#pragma checksum "D:\ProMvcCore98\Session14\Session14.Models\Session14.Models\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79cd85b51eb52457b2eb2632608127defa2487fb"
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
#line 1 "D:\ProMvcCore98\Session14\Session14.Models\Session14.Models\Views\_ViewImports.cshtml"
using Session14.Models.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79cd85b51eb52457b2eb2632608127defa2487fb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b70610af31d3d9eebc0f575b809c4dd2a900511", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\ProMvcCore98\Session14\Session14.Models\Session14.Models\Views\Home\Index.cshtml"
   Layout = "_Layout"; 

#line default
#line hidden
            BeginContext(41, 157, true);
            WriteLiteral("<div class=\"bg-primary m-1 p-1 text-white\"><h2>Person</h2></div>\r\n<table class=\"table table-sm table-bordered table-striped\">\r\n    <tr><th>PersonId:</th><td>");
            EndContext();
            BeginContext(199, 14, false);
#line 5 "D:\ProMvcCore98\Session14\Session14.Models\Session14.Models\Views\Home\Index.cshtml"
                         Write(Model.PersonId);

#line default
#line hidden
            EndContext();
            BeginContext(213, 44, true);
            WriteLiteral("</td></tr>\r\n    <tr><th>First Name:</th><td>");
            EndContext();
            BeginContext(258, 15, false);
#line 6 "D:\ProMvcCore98\Session14\Session14.Models\Session14.Models\Views\Home\Index.cshtml"
                           Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(273, 43, true);
            WriteLiteral("</td></tr>\r\n    <tr><th>Last Name:</th><td>");
            EndContext();
            BeginContext(317, 14, false);
#line 7 "D:\ProMvcCore98\Session14\Session14.Models\Session14.Models\Views\Home\Index.cshtml"
                          Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(331, 38, true);
            WriteLiteral("</td></tr>\r\n    <tr><th>Role:</th><td>");
            EndContext();
            BeginContext(370, 10, false);
#line 8 "D:\ProMvcCore98\Session14\Session14.Models\Session14.Models\Views\Home\Index.cshtml"
                     Write(Model.Role);

#line default
#line hidden
            EndContext();
            BeginContext(380, 20, true);
            WriteLiteral("</td></tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
