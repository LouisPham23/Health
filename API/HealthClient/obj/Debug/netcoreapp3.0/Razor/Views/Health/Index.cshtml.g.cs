#pragma checksum "C:\Users\Louis\Desktop\Projects\Health\API\HealthClient\Views\Health\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d00639fe201691d6e31c94c687bf0d51bc86608"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Health_Index), @"mvc.1.0.view", @"/Views/Health/Index.cshtml")]
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
#line 1 "C:\Users\Louis\Desktop\Projects\Health\API\HealthClient\Views\_ViewImports.cshtml"
using HealthClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Louis\Desktop\Projects\Health\API\HealthClient\Views\_ViewImports.cshtml"
using HealthClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d00639fe201691d6e31c94c687bf0d51bc86608", @"/Views/Health/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff4a4cb5abbd672ebe7d831f1a620b2d79888eff", @"/Views/_ViewImports.cshtml")]
    public class Views_Health_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Louis\Desktop\Projects\Health\API\HealthClient\Views\Health\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Cors Request</h3>\r\n<button id=\"btnGetPatients\">Get Patients</button>\r\n<pre id=\"preOutput\"></pre>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
    <script>
          $(function () {
            var getPatients = function () {
              var url = ""https://localhost:5001/api/patients/"";
              $.get(url).always(showResponse);
              return false;
            };

            var showResponse = function (object) {
              $(""#preOutput"").text(JSON.stringify(object, null, 4));
            };

            $(""#btnGetPatients"").click(getPatients);
          });
    </script>
");
            }
            );
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