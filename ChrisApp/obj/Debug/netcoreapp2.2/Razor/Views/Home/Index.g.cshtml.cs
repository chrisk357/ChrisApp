#pragma checksum "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5d087e3a99075fc1ead2412dbaaee6d9f41132a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5d087e3a99075fc1ead2412dbaaee6d9f41132a", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChrisApp.ViewModels.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 6, true);
            WriteLiteral("\r\n<h2>");
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
            BeginContext(111, 95, true);
            WriteLiteral("    <div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n        <div class=\"thumbnail\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 206, "\"", 236, 1);
#line 9 "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 212, slime.ImageThumbnailUrl, 212, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(237, 76, true);
            WriteLiteral(" alt=\"\">\r\n        <div class=\"caption\">\r\n            <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(314, 25, false);
#line 11 "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\Home\Index.cshtml"
                              Write(slime.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(339, 29, true);
            WriteLiteral("</h3>\r\n        \r\n        <h3>");
            EndContext();
            BeginContext(369, 10, false);
#line 13 "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\Home\Index.cshtml"
       Write(slime.Name);

#line default
#line hidden
            EndContext();
            BeginContext(379, 18, true);
            WriteLiteral("</h3>\r\n        <p>");
            EndContext();
            BeginContext(398, 22, false);
#line 14 "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\Home\Index.cshtml"
      Write(slime.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(420, 36, true);
            WriteLiteral("</p>\r\n    </div>\r\n  </div>\r\n</div>\r\n");
            EndContext();
#line 18 "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChrisApp.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591