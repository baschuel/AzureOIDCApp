#pragma checksum "D:\AzureOIDCApp\AzureAuthToken\Views\Home\Tokens.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bee5f7dfe2008d3b64cdb8df8d146917013be44f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Tokens), @"mvc.1.0.view", @"/Views/Home/Tokens.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Tokens.cshtml", typeof(AspNetCore.Views_Home_Tokens))]
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
#line 1 "D:\AzureOIDCApp\AzureAuthToken\Views\_ViewImports.cshtml"
using AzureAuthToken;

#line default
#line hidden
#line 2 "D:\AzureOIDCApp\AzureAuthToken\Views\_ViewImports.cshtml"
using AzureAuthToken.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee5f7dfe2008d3b64cdb8df8d146917013be44f", @"/Views/Home/Tokens.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b2b1d91f606c61ee992b9fcbee379755950596f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Tokens : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\AzureOIDCApp\AzureAuthToken\Views\Home\Tokens.cshtml"
  
    ViewData["Title"] = "Tokens";

#line default
#line hidden
            BeginContext(44, 9, true);
            WriteLiteral("\r\n<div>\r\n");
            EndContext();
#line 7 "D:\AzureOIDCApp\AzureAuthToken\Views\Home\Tokens.cshtml"
     if (User.Identity.IsAuthenticated)
        {
            foreach(var identity in User.Identities)
            {


#line default
#line hidden
            BeginContext(176, 20, true);
            WriteLiteral("                <h3>");
            EndContext();
            BeginContext(197, 13, false);
#line 12 "D:\AzureOIDCApp\AzureAuthToken\Views\Home\Tokens.cshtml"
               Write(identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(210, 29, true);
            WriteLiteral("</h3>\r\n                <ul>\r\n");
            EndContext();
#line 14 "D:\AzureOIDCApp\AzureAuthToken\Views\Home\Tokens.cshtml"
                     foreach(var claim in identity.Claims)
                    {

#line default
#line hidden
            BeginContext(322, 28, true);
            WriteLiteral("                        <li>");
            EndContext();
            BeginContext(351, 10, false);
#line 16 "D:\AzureOIDCApp\AzureAuthToken\Views\Home\Tokens.cshtml"
                       Write(claim.Type);

#line default
#line hidden
            EndContext();
            BeginContext(361, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(365, 11, false);
#line 16 "D:\AzureOIDCApp\AzureAuthToken\Views\Home\Tokens.cshtml"
                                     Write(claim.Value);

#line default
#line hidden
            EndContext();
            BeginContext(376, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 17 "D:\AzureOIDCApp\AzureAuthToken\Views\Home\Tokens.cshtml"
                    }

#line default
#line hidden
            BeginContext(406, 23, true);
            WriteLiteral("                </ul>\r\n");
            EndContext();
#line 19 "D:\AzureOIDCApp\AzureAuthToken\Views\Home\Tokens.cshtml"
            }
        }
        else
        {

#line default
#line hidden
            BeginContext(480, 42, true);
            WriteLiteral("            <div>You are anonymous</div>\r\n");
            EndContext();
#line 24 "D:\AzureOIDCApp\AzureAuthToken\Views\Home\Tokens.cshtml"
        }

#line default
#line hidden
            BeginContext(533, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
