#pragma checksum "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Home\DiagonalTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f306058c1416826e21a666b3060e751117b306b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DiagonalTable), @"mvc.1.0.view", @"/Views/Home/DiagonalTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DiagonalTable.cshtml", typeof(AspNetCore.Views_Home_DiagonalTable))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f306058c1416826e21a666b3060e751117b306b", @"/Views/Home/DiagonalTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6c126268a7b591d30d7decc8c4324f4b0235050", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DiagonalTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Home\DiagonalTable.cshtml"
  
    ViewData["Title"] = "DiagonalTable";

#line default
#line hidden
            BeginContext(51, 56, true);
            WriteLiteral("\r\n<h2>Table de valores diagonal:</h2>\r\n<br />\r\n<table>\r\n");
            EndContext();
#line 9 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Home\DiagonalTable.cshtml"
     for (int i = 0; i < ViewBag.Size; i++)
        {
            

#line default
#line hidden
            BeginContext(177, 18, true);
            WriteLiteral("            <tr>\r\n");
            EndContext();
#line 13 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Home\DiagonalTable.cshtml"
                 for (int j = 0; j < ViewBag.Size; j++)
                {

#line default
#line hidden
            BeginContext(271, 53, true);
            WriteLiteral("                    <td>\r\n                        <p>");
            EndContext();
            BeginContext(325, 19, false);
#line 16 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Home\DiagonalTable.cshtml"
                      Write(ViewBag.Table[i, j]);

#line default
#line hidden
            EndContext();
            BeginContext(344, 33, true);
            WriteLiteral("</p>\r\n                    </td>\r\n");
            EndContext();
#line 18 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Home\DiagonalTable.cshtml"
                }

#line default
#line hidden
            BeginContext(396, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 20 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Home\DiagonalTable.cshtml"
        }

#line default
#line hidden
            BeginContext(426, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(465, 8, true);
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
