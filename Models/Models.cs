using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheWall.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users {get;set;}
        public DbSet<Message> Messages {get;set;}
        public DbSet<Comment> Comments {get;set;}
    }

    public class User
    {
        [Key]
        public int UserId {get;set;}
        [Required]
        [Display(Name = "First Name")]
        public string First_Name {get;set;}
        [Required]
        [Display(Name = "Last Name")]
        public string Last_Name {get;set;}
        [Required]
        [EmailAddress]
        public string Email {get;set;}
        [Required]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        [DataType(DataType.Password)]
        public string Password {get;set;}
        public List<Message> PostedMessages {get;set;}
        public List<Comment> PostedComments {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }

    public class LoginUser
    {
        [Required]
        [EmailAddress]
        public string Email {get;set;}

        [Required]
        [DataType(DataType.Password)]
        public string Password {get;set;}
    }

    public class IndexViewModel
    {
        public LoginUser LogUser {get;set;}
        public User RegUser {get;set;}
    }

    public class Message
    {
        [Key]
        public int MessageId {get;set;}
        public int UserId {get;set;}
        public string MessageText {get;set;}
        public User MsgMaker {get;set;}
        public List<Comment> RelatedComments {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }

    public class Comment
    {
        [Key]
        public int CommentId {get;set;}
        public int MessageId {get;set;}
        public int UserId {get;set;}
        public string CommentText {get;set;}
        public Message Message {get;set;}
        public User CmntMaker {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}