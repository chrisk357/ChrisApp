#pragma checksum "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcfe047312bdd67519cdb1e3f58279d7129c8008"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcfe047312bdd67519cdb1e3f58279d7129c8008", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"574f0fb91f5f2fc72c309e82d3d68ca2eec55a4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(30, 11, false);
#line 3 "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\Home\Index.cshtml"
Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(41, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
#line 5 "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\Home\Index.cshtml"
 foreach (var slime in Model.Slimes)
{

#line default
#line hidden
            BeginContext(91, 96, true);
            WriteLiteral("    <div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n        <div class=\"thumbnail\" >\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 187, "\"", 217, 1);
#line 9 "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 193, slime.ImageThumbnailUrl, 193, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(218, 76, true);
            WriteLiteral(" alt=\"\">\r\n        <div class=\"caption\">\r\n            <h4 class=\"pull-right\">");
            EndContext();
            BeginContext(295, 25, false);
#line 11 "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\Home\Index.cshtml"
                              Write(slime.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(320, 87, true);
            WriteLiteral("</h4>\r\n        \r\n        <h4>\r\n           <a asp-controller=\"Home\" asp-action=\"Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 407, "\"", 431, 1);
#line 14 "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 422, slime.Id, 422, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(432, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(434, 10, false);
#line 14 "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\Home\Index.cshtml"
                                                                             Write(slime.Name);

#line default
#line hidden
            EndContext();
            BeginContext(444, 32, true);
            WriteLiteral("</a>\r\n        </h4>\r\n        <p>");
            EndContext();
            BeginContext(477, 22, false);
#line 16 "C:\Users\chris\source\repos\ChrisApp\ChrisApp\Views\Home\Index.cshtml"
      Write(slime.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(499, 36, true);
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
