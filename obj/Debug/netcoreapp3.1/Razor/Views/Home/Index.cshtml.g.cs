#pragma checksum "C:\Users\esmit\Google Drive\Dojo_Assignments\Csharp\3_asp_net_core\Passcode\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7449ca4273cfafc235b577f3dffd9311b43d8ac6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\esmit\Google Drive\Dojo_Assignments\Csharp\3_asp_net_core\Passcode\Views\_ViewImports.cshtml"
using Passcode;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esmit\Google Drive\Dojo_Assignments\Csharp\3_asp_net_core\Passcode\Views\_ViewImports.cshtml"
using Passcode.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7449ca4273cfafc235b577f3dffd9311b43d8ac6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40a72012c55048ca6fdfa163b1e87e2c83470655", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\esmit\Google Drive\Dojo_Assignments\Csharp\3_asp_net_core\Passcode\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Passcode";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"d-flex justify-content-center\" style=\"margin-top : 30%; \">\r\n    <h1>Random passcode (passcode# ");
#nullable restore
#line 7 "C:\Users\esmit\Google Drive\Dojo_Assignments\Csharp\3_asp_net_core\Passcode\Views\Home\Index.cshtml"
                              Write(ViewBag.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h1>\r\n</div class=\"d-flex justify-content-center\">\r\n<hr>\r\n<div class=\"text-center\">\r\n    <div>\r\n        <p>");
#nullable restore
#line 12 "C:\Users\esmit\Google Drive\Dojo_Assignments\Csharp\3_asp_net_core\Passcode\Views\Home\Index.cshtml"
      Write(ViewBag.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <br>\r\n    <a type=\"submit\" href=\"increment\" class=\"btn btn-dark\">Generate</a>\r\n    <a type=\"submit\" href=\"endsession\" class=\"btn btn-dark\">Reset</a>\r\n</div>\r\n");
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
