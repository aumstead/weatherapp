#pragma checksum "C:\Users\Andrew\Projects\CSI-Task\CSI-WeatherApp\CSI-WeatherApp\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9d869cf9cac758dce7cddb3fc9982e1a74e5f38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "C:\Users\Andrew\Projects\CSI-Task\CSI-WeatherApp\CSI-WeatherApp\Views\_ViewImports.cshtml"
using CSI_WeatherApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Andrew\Projects\CSI-Task\CSI-WeatherApp\CSI-WeatherApp\Views\_ViewImports.cshtml"
using CSI_WeatherApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9d869cf9cac758dce7cddb3fc9982e1a74e5f38", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"148a4b7ece74857de9881fb1a56358d479b6b85c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 class=\"text-danger\">Error</h1>\r\n\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Andrew\Projects\CSI-Task\CSI-WeatherApp\CSI-WeatherApp\Views\Shared\Error.cshtml"
 if (!string.IsNullOrWhiteSpace(Model.Message))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 12 "C:\Users\Andrew\Projects\CSI-Task\CSI-WeatherApp\CSI-WeatherApp\Views\Shared\Error.cshtml"
   Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 13 "C:\Users\Andrew\Projects\CSI-Task\CSI-WeatherApp\CSI-WeatherApp\Views\Shared\Error.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Oops, there was an error somewhere</h3>\r\n");
#nullable restore
#line 17 "C:\Users\Andrew\Projects\CSI-Task\CSI-WeatherApp\CSI-WeatherApp\Views\Shared\Error.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591