#pragma checksum "D:\Ankitkumar-Singh\Asp-Core-Mvc\ASP Core Assignment 3-4\MvcFirstApp\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d083878c3624ecab618352da57e869da6ca888e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/Index.cshtml", typeof(AspNetCore.Views_Movie_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d083878c3624ecab618352da57e869da6ca888e6", @"/Views/Movie/Index.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcFirstApp.Models.Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded mx-auto d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/1705400.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Movie Icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/1594221.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Ankitkumar-Singh\Asp-Core-Mvc\ASP Core Assignment 3-4\MvcFirstApp\Views\Movie\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(100, 30, true);
            WriteLiteral("\r\n<div class=\"row my-3\">\r\n    ");
            EndContext();
            BeginContext(130, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d083878c3624ecab618352da57e869da6ca888e64792", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(213, 76, true);
            WriteLiteral("\r\n</div>\r\n<div class=\"row my-2\">\r\n    <div class=\"col-8 offset-2\">\r\n        ");
            EndContext();
            BeginContext(290, 105, false);
#line 11 "D:\Ankitkumar-Singh\Asp-Core-Mvc\ASP Core Assignment 3-4\MvcFirstApp\Views\Movie\Index.cshtml"
   Write(Html.ActionLink("Add Movie Details", "Save", "Movie", null, new { @class = "btn btn-block btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(395, 74, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row justify-content-md-center my-3\">\r\n");
            EndContext();
#line 16 "D:\Ankitkumar-Singh\Asp-Core-Mvc\ASP Core Assignment 3-4\MvcFirstApp\Views\Movie\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(510, 68, true);
            WriteLiteral("        <div class=\"card col-md-3 my-2 mx-2 offset-1\">\r\n            ");
            EndContext();
            BeginContext(578, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d083878c3624ecab618352da57e869da6ca888e67073", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(650, 141, true);
            WriteLiteral("\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title text-center font-weight-bold text-danger\">\r\n                    ");
            EndContext();
            BeginContext(792, 40, false);
#line 22 "D:\Ankitkumar-Singh\Asp-Core-Mvc\ASP Core Assignment 3-4\MvcFirstApp\Views\Movie\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(832, 127, true);
            WriteLiteral("\r\n                </h4>\r\n                <p class=\"card-text text-primary font-weight-bold\">\r\n                    Movie Star:  ");
            EndContext();
            BeginContext(960, 44, false);
#line 25 "D:\Ankitkumar-Singh\Asp-Core-Mvc\ASP Core Assignment 3-4\MvcFirstApp\Views\Movie\Index.cshtml"
                            Write(Html.DisplayFor(modelItem => item.MovieStar));

#line default
#line hidden
            EndContext();
            BeginContext(1004, 125, true);
            WriteLiteral("\r\n                </p>\r\n                <p class=\"card-text text-warning font-weight-bold\">\r\n                    Movie type: ");
            EndContext();
            BeginContext(1130, 44, false);
#line 28 "D:\Ankitkumar-Singh\Asp-Core-Mvc\ASP Core Assignment 3-4\MvcFirstApp\Views\Movie\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MovieType));

#line default
#line hidden
            EndContext();
            BeginContext(1174, 40, true);
            WriteLiteral("\r\n                </p>\r\n                ");
            EndContext();
            BeginContext(1215, 99, false);
#line 30 "D:\Ankitkumar-Singh\Asp-Core-Mvc\ASP Core Assignment 3-4\MvcFirstApp\Views\Movie\Index.cshtml"
           Write(Html.ActionLink("View", "Details", new { id = item.Id }, new { @class = "btn btn-sm btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(1314, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1333, 102, false);
#line 31 "D:\Ankitkumar-Singh\Asp-Core-Mvc\ASP Core Assignment 3-4\MvcFirstApp\Views\Movie\Index.cshtml"
           Write(Html.ActionLink("Edit Movie", "Save", new { id = item.Id }, new { @class = "btn btn-sm btn-warning" }));

#line default
#line hidden
            EndContext();
            BeginContext(1435, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1454, 99, false);
#line 32 "D:\Ankitkumar-Singh\Asp-Core-Mvc\ASP Core Assignment 3-4\MvcFirstApp\Views\Movie\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }, new { @class = "btn btn-sm btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1553, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 35 "D:\Ankitkumar-Singh\Asp-Core-Mvc\ASP Core Assignment 3-4\MvcFirstApp\Views\Movie\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1598, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MvcFirstApp.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
