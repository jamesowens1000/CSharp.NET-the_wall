using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using TheWall.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace TheWall.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("register")]
        public IActionResult TryRegister(IndexViewModel modelData)
        {
            User regUser = modelData.RegUser;
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == regUser.Email))
                {
                    ModelState.AddModelError("RegUser.Email", "Email already in use!");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    regUser.Password = Hasher.HashPassword(regUser, regUser.Password);
                    dbContext.Add(regUser);
                    dbContext.SaveChanges();
                    User currUser = dbContext.Users.FirstOrDefault(u => u.Email == regUser.Email);
                    HttpContext.Session.SetInt32("userId", regUser.UserId);
                    return RedirectToAction("Wall");
                }
            }
            return View("Index", modelData);
        }

        [HttpPost("login")]
        public IActionResult TryLogin(IndexViewModel modelData)
        {
            LoginUser logUser = modelData.LogUser;
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == logUser.Email);

                if (userInDb == null)
                {
                    ModelState.AddModelError("LogUser.Email", "Invalid Email/Password");
                }
                else
                {
                    var hasher = new PasswordHasher<LoginUser>();
                    var result = hasher.VerifyHashedPassword(logUser, userInDb.Password, logUser.Password);

                    if (result == 0)
                    {
                        ModelState.AddModelError("LogUser.Email", "Invalid Email/Password");
                    }
                    else
                    {
                        HttpContext.Session.SetInt32("userId", userInDb.UserId);
                        return RedirectToAction("Wall");
                    }
                }
            }
            return View("Index", modelData);
        }

        [HttpGet("Wall")]
        public IActionResult Wall()
        {
            if (HttpContext.Session.GetInt32("userId") == null)
            {
                return RedirectToAction("Index");
            }

            User thisUser = dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("userId"));
            ViewBag.ThisUser = thisUser;

            IEnumerable<Message> EveryMessage = dbContext.Messages
                .Include(u => u.MsgMaker)
                .Include(rc => rc.RelatedComments)
                .ThenInclude(c => c.CmntMaker)
                .ToList().OrderByDescending(m => m.CreatedAt);
            ViewBag.AllMessages = EveryMessage;

            return View("Wall");
        }

        [HttpPost("postmessage")]
        public IActionResult PostMessage()
        {
            Message newMsg = new Message();
            newMsg.UserId = (int)HttpContext.Session.GetInt32("userId");
            newMsg.MessageText = Request.Form["msgText"];
            dbContext.Add(newMsg);
            dbContext.SaveChanges();
            return RedirectToAction("Wall");
        }

        [HttpPost("postcomment/{msgId}")]
        public IActionResult PostComment(int msgId)
        {
            Comment newCmnt = new Comment();
            newCmnt.UserId = (int)HttpContext.Session.GetInt32("userId");
            newCmnt.MessageId = msgId;
            newCmnt.CommentText = Request.Form["cmntText"];
            dbContext.Add(newCmnt);
            dbContext.SaveChanges();
            return RedirectToAction("Wall");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}