#pragma checksum "D:\WorkSpace\BITM9_ASPNETCore\Projects\App08_Routing\App08_Routing\Views\Data\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36f6feab9476f7bfeeb0ac8f07adf311d93fa3b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Data_Show), @"mvc.1.0.view", @"/Views/Data/Show.cshtml")]
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
#nullable restore
#line 1 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App08_Routing\App08_Routing\Views\_ViewImports.cshtml"
using App08_Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App08_Routing\App08_Routing\Views\_ViewImports.cshtml"
using App08_Routing.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36f6feab9476f7bfeeb0ac8f07adf311d93fa3b9", @"/Views/Data/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4223615cbcca2b7c7baf3d422b96b09593b4792", @"/Views/_ViewImports.cshtml")]
    public class Views_Data_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App08_Routing\App08_Routing\Views\Data\Show.cshtml"
  
    ViewData["Title"] = "Show";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2 class=\"alert alert-info\">Show</h2>\r\n<h2 class=\"alert alert-success\">Date of Birth : ");
#nullable restore
#line 8 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App08_Routing\App08_Routing\Views\Data\Show.cshtml"
                                           Write(ViewBag.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2 class=\"alert alert-info\">Birth Day : ");
#nullable restore
#line 9 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App08_Routing\App08_Routing\Views\Data\Show.cshtml"
                                    Write(ViewBag.day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
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
