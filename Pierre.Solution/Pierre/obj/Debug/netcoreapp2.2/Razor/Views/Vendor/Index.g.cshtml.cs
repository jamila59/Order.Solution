#pragma checksum "/Users/Guest/Desktop/Pierre.Solution/Pierre.Solution/Pierre/Views/Vendor/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f83be1ce0de71c63601ade7ea8aab0c215288779"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendor_Index), @"mvc.1.0.view", @"/Views/Vendor/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendor/Index.cshtml", typeof(AspNetCore.Views_Vendor_Index))]
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
#line 1 "/Users/Guest/Desktop/Pierre.Solution/Pierre.Solution/Pierre/Views/Vendor/Index.cshtml"
using Pierre.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f83be1ce0de71c63601ade7ea8aab0c215288779", @"/Views/Vendor/Index.cshtml")]
    public class Views_Vendor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 35, true);
            WriteLiteral("\n<h1>Vendor and Order Tracker</h1>\n");
            EndContext();
#line 4 "/Users/Guest/Desktop/Pierre.Solution/Pierre.Solution/Pierre/Views/Vendor/Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(82, 45, true);
            WriteLiteral("    <p>There are no Vendors in the list.</p>\n");
            EndContext();
#line 7 "/Users/Guest/Desktop/Pierre.Solution/Pierre.Solution/Pierre/Views/Vendor/Index.cshtml"
}

#line default
#line hidden
            BeginContext(129, 5, true);
            WriteLiteral("<ul>\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/Pierre.Solution/Pierre.Solution/Pierre/Views/Vendor/Index.cshtml"
 foreach (Vendor vendor in Model)
{

#line default
#line hidden
            BeginContext(170, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(179, 18, false);
#line 11 "/Users/Guest/Desktop/Pierre.Solution/Pierre.Solution/Pierre/Views/Vendor/Index.cshtml"
   Write(vendor.Description);

#line default
#line hidden
            EndContext();
            BeginContext(197, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 12 "/Users/Guest/Desktop/Pierre.Solution/Pierre.Solution/Pierre/Views/Vendor/Index.cshtml"
}

#line default
#line hidden
            BeginContext(205, 53, true);
            WriteLiteral("</ul>\n\n<a href=\'/vendors/new\'>Add a new vendor.</a>\n\n");
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