#pragma checksum "C:\Users\James\Desktop\CD\C#\MVC\TheWall\Views\Home\Wall.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27682ea65033f174d90d0361646e9daf1707f359"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Wall), @"mvc.1.0.view", @"/Views/Home/Wall.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Wall.cshtml", typeof(AspNetCore.Views_Home_Wall))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\James\Desktop\CD\C#\MVC\TheWall\Views\_ViewImports.cshtml"
using TheWall;

#line default
#line hidden
#line 2 "C:\Users\James\Desktop\CD\C#\MVC\TheWall\Views\_ViewImports.cshtml"
using TheWall.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27682ea65033f174d90d0361646e9daf1707f359", @"/Views/Home/Wall.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7e71ffde7a728a68b8b3cc854b53961bfe31ff0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Wall : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PostMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 64, true);
            WriteLiteral("<div id=\"header\">\r\n    <h4>CodingDojo Wall</h4>\r\n    <p>Welcome ");
            EndContext();
            BeginContext(65, 27, false);
#line 3 "C:\Users\James\Desktop\CD\C#\MVC\TheWall\Views\Home\Wall.cshtml"
          Write(ViewBag.ThisUser.First_Name);

#line default
#line hidden
            EndContext();
            BeginContext(92, 73, true);
            WriteLiteral("</p>\r\n    <a href=\"/logout\">Log Off</a>\r\n</div>\r\n<div id=\"content\">\r\n    ");
            EndContext();
            BeginContext(165, 238, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "246e502c0be2426a8b9ac75758b43f30", async() => {
                BeginContext(232, 164, true);
                WriteLiteral("\r\n        <h6>Post a Message</h6>\r\n        <textarea id=\"msgText\" name=\"msgText\"></textarea>\r\n        <input id=\"msgBtn\" type=\"submit\" value=\"Post a message\">\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(403, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 12 "C:\Users\James\Desktop\CD\C#\MVC\TheWall\Views\Home\Wall.cshtml"
     foreach (var m in ViewBag.AllMessages)
    {

#line default
#line hidden
            BeginContext(457, 27, true);
            WriteLiteral("        <p class=\"msgHead\">");
            EndContext();
            BeginContext(485, 21, false);
#line 14 "C:\Users\James\Desktop\CD\C#\MVC\TheWall\Views\Home\Wall.cshtml"
                      Write(m.MsgMaker.First_Name);

#line default
#line hidden
            EndContext();
            BeginContext(506, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(508, 20, false);
#line 14 "C:\Users\James\Desktop\CD\C#\MVC\TheWall\Views\Home\Wall.cshtml"
                                             Write(m.MsgMaker.Last_Name);

#line default
#line hidden
            EndContext();
            BeginContext(528, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(532, 36, false);
#line 14 "C:\Users\James\Desktop\CD\C#\MVC\TheWall\Views\Home\Wall.cshtml"
                                                                     Write(m.CreatedAt.ToString("MMMM d, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(568, 33, true);
            WriteLiteral("</p>\r\n        <p class=\"msgBody\">");
            EndContext();
            BeginContext(602, 13, false);
#line 15 "C:\Users\James\Desktop\CD\C#\MVC\TheWall\Views\Home\Wall.cshtml"
                      Write(m.MessageText);

#line default
#line hidden
            EndContext();
            BeginContext(615, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 16 "C:\Users\James\Desktop\CD\C#\MVC\TheWall\Views\Home\Wall.cshtml"
         foreach (var c in m.RelatedComments)
        {

#line default
#line hidden
            BeginContext(679, 32, true);
            WriteLiteral("            <p class=\"cmntHead\">");
            EndContext();
            BeginContext(712, 22, false);
#line 18 "C:\Users\James\Desktop\CD\C#\MVC\TheWall\Views\Home\Wall.cshtml"
                           Write(c.CmntMaker.First_Name);

#line default
#line hidden
            EndContext();
            BeginContext(734, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(736, 21, false);
#line 18 "C:\Users\James\Desktop\CD\C#\MVC\TheWall\Views\Home\Wall.cshtml"
                                                   Write(c.CmntMaker.Last_Name);

#line default
#line hidden
            EndContext();
            BeginContext(757, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(761, 11, false);
#line 18 "C:\Users\James\Desktop\CD\C#\MVC\TheWall\Views\Home\Wall.cshtml"
                                                                            Write(c.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(772, 38, true);
            WriteLiteral("</p>\r\n            <p class=\"cmntBody\">");
            EndContext();
            BeginContext(811, 13, false);
#line 19 "C:\Users\James\Desktop\CD\C#\MVC\TheWall\Views\Home\Wall.cshtml"
                           Write(c.CommentText);

#line default
#line hidden
            EndContext();
            BeginContext(824, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 20 "C:\Users\James\Desktop\CD\C#\MVC\TheWall\Views\Home\Wall.cshtml"
        }

#line default
#line hidden
            BeginContext(841, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(849, 265, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6f4de82d2044ed6a14f8ffc65c25c36", async() => {
                BeginContext(904, 203, true);
                WriteLiteral("\r\n            <h6 id=\"cmntHead\">Post a Comment</h6>\r\n            <textarea class=\"cmntText\" name=\"cmntText\"></textarea>\r\n            <input class=\"cmntBtn\" type=\"submit\" value=\"Post a comment\">\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 863, "/postcomment/", 863, 13, true);
#line 21 "C:\Users\James\Desktop\CD\C#\MVC\TheWall\Views\Home\Wall.cshtml"
AddHtmlAttributeValue("", 876, m.MessageId, 876, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1114, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 26 "C:\Users\James\Desktop\CD\C#\MVC\TheWall\Views\Home\Wall.cshtml"
    }

#line default
#line hidden
            BeginContext(1123, 6, true);
            WriteLiteral("</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
