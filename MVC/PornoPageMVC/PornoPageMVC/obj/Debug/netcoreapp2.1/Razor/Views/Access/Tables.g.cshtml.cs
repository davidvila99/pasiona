#pragma checksum "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Access\Tables.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c197320952bb3a77b4d3c944f4be7dcbea2b200"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Access_Tables), @"mvc.1.0.view", @"/Views/Access/Tables.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Access/Tables.cshtml", typeof(AspNetCore.Views_Access_Tables))]
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
#line 1 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\_ViewImports.cshtml"
using PornoPageMVC;

#line default
#line hidden
#line 2 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\_ViewImports.cshtml"
using PornoPageMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c197320952bb3a77b4d3c944f4be7dcbea2b200", @"/Views/Access/Tables.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6c126268a7b591d30d7decc8c4324f4b0235050", @"/Views/_ViewImports.cshtml")]
    public class Views_Access_Tables : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Access\Tables.cshtml"
  
    ViewData["Title"] = "RandomTable";

#line default
#line hidden
            BeginContext(49, 54, true);
            WriteLiteral("\r\n<h2>Table de valores Random:</h2>\r\n<br />\r\n<table>\r\n");
            EndContext();
#line 9 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Access\Tables.cshtml"
     for (int i = 0; i < ViewBag.Size; i++)
    {

#line default
#line hidden
            BeginContext(155, 14, true);
            WriteLiteral("        <tr>\r\n");
            EndContext();
#line 12 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Access\Tables.cshtml"
             for (int j = 0; j < ViewBag.Size; j++)
            {

#line default
#line hidden
            BeginContext(237, 45, true);
            WriteLiteral("                <td>\r\n                    <p>");
            EndContext();
            BeginContext(283, 19, false);
#line 15 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Access\Tables.cshtml"
                  Write(ViewBag.Table[i, j]);

#line default
#line hidden
            EndContext();
            BeginContext(302, 29, true);
            WriteLiteral("</p>\r\n                </td>\r\n");
            EndContext();
#line 17 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Access\Tables.cshtml"
            }

#line default
#line hidden
            BeginContext(346, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 19 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Access\Tables.cshtml"
    }

#line default
#line hidden
            BeginContext(368, 68, true);
            WriteLiteral("</table>\r\n\r\n\r\n<h2>Table de valores diagonal:</h2>\r\n<br />\r\n<table>\r\n");
            EndContext();
#line 26 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Access\Tables.cshtml"
     for (int i = 0; i < ViewBag.Size; i++)
    {


#line default
#line hidden
            BeginContext(490, 14, true);
            WriteLiteral("        <tr>\r\n");
            EndContext();
#line 30 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Access\Tables.cshtml"
             for (int j = 0; j < ViewBag.Size; j++)
            {

#line default
#line hidden
            BeginContext(572, 45, true);
            WriteLiteral("                <td>\r\n                    <p>");
            EndContext();
            BeginContext(618, 19, false);
#line 33 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Access\Tables.cshtml"
                  Write(ViewBag.Table[i, j]);

#line default
#line hidden
            EndContext();
            BeginContext(637, 29, true);
            WriteLiteral("</p>\r\n                </td>\r\n");
            EndContext();
#line 35 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Access\Tables.cshtml"
            }

#line default
#line hidden
            BeginContext(681, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 37 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Access\Tables.cshtml"
    }

#line default
#line hidden
            BeginContext(703, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(742, 8, true);
            WriteLiteral("</table>");
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