#pragma checksum "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf093aa32a7b71f8017a51c881509eb8deef2d43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 2 "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\_ViewImports.cshtml"
using ChrisApp.Models;

#line default
#line hidden
#line 3 "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\_ViewImports.cshtml"
using ChrisApp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf093aa32a7b71f8017a51c881509eb8deef2d43", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"396dcfb1cb7c71336d9ba190dda5dd4eaa67b9c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 26, true);
            WriteLiteral("\r\n<h2 class=\"text-center\">");
            EndContext();
            BeginContext(50, 11, false);
#line 3 "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\Home\Index.cshtml"
                   Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(61, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
#line 5 "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\Home\Index.cshtml"
 foreach (var slime in Model.Slimes)
{

#line default
#line hidden
            BeginContext(111, 96, true);
            WriteLiteral("    <div class=\"col-sm-3 col-lg-3 col-md-3\">\r\n        <div class=\"thumbnail\" >\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 207, "\"", 237, 1);
#line 9 "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 213, slime.ImageThumbnailUrl, 213, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(238, 76, true);
            WriteLiteral(" alt=\"\">\r\n        <div class=\"caption\">\r\n            <h4 class=\"pull-right\">");
            EndContext();
            BeginContext(315, 25, false);
#line 11 "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\Home\Index.cshtml"
                              Write(slime.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(340, 42, true);
            WriteLiteral("</h4>\r\n        \r\n        <h4>\r\n           ");
            EndContext();
            BeginContext(382, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf093aa32a7b71f8017a51c881509eb8deef2d435348", async() => {
                BeginContext(454, 10, false);
#line 14 "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\Home\Index.cshtml"
                                                                             Write(slime.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 14 "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\Home\Index.cshtml"
                                                           WriteLiteral(slime.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(468, 28, true);
            WriteLiteral("\r\n        </h4>\r\n        <p>");
            EndContext();
            BeginContext(497, 22, false);
#line 16 "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\Home\Index.cshtml"
      Write(slime.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(519, 36, true);
            WriteLiteral("</p>\r\n    </div>\r\n  </div>\r\n</div>\r\n");
            EndContext();
#line 20 "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
