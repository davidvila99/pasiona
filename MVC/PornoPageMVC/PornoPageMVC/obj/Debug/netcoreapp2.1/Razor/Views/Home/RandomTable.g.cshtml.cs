#pragma checksum "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Home\RandomTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dae9c816503fd9006d9b9cdac021c2417f8fb42c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RandomTable), @"mvc.1.0.view", @"/Views/Home/RandomTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/RandomTable.cshtml", typeof(AspNetCore.Views_Home_RandomTable))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dae9c816503fd9006d9b9cdac021c2417f8fb42c", @"/Views/Home/RandomTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6c126268a7b591d30d7decc8c4324f4b0235050", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RandomTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Home\RandomTable.cshtml"
  
    ViewData["Title"] = "RandomTable";

#line default
#line hidden
            BeginContext(49, 66, true);
            WriteLiteral("\r\n    <h2>Table de valores Random:</h2>\r\n    <br />\r\n    <table>\r\n");
            EndContext();
#line 9 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Home\RandomTable.cshtml"
         for (int i = 0; i < ViewBag.Size; i++)
        {

#line default
#line hidden
            BeginContext(175, 18, true);
            WriteLiteral("            <tr>\r\n");
            EndContext();
#line 12 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Home\RandomTable.cshtml"
                 for (int j = 0; j < ViewBag.Size; j++)
                {

#line default
#line hidden
            BeginContext(269, 53, true);
            WriteLiteral("                    <td>\r\n                        <p>");
            EndContext();
            BeginContext(323, 19, false);
#line 15 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Home\RandomTable.cshtml"
                      Write(ViewBag.Table[i, j]);

#line default
#line hidden
            EndContext();
            BeginContext(342, 33, true);
            WriteLiteral("</p>\r\n                    </td>\r\n");
            EndContext();
#line 17 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Home\RandomTable.cshtml"
                }

#line default
#line hidden
            BeginContext(394, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 19 "C:\Users\David\Desktop\Pasiona Stuff\PornoPageMVC\PornoPageMVC\Views\Home\RandomTable.cshtml"
        }

#line default
#line hidden
            BeginContext(424, 16, true);
            WriteLiteral("    </table>\r\n\r\n");
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