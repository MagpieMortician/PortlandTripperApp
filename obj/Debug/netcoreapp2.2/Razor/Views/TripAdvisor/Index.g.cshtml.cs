#pragma checksum "/Users/Guest/Desktop/PortlandTripperApp/Views/TripAdvisor/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23acc5f862be2b12dc16c2969ef099a93516b9b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TripAdvisor_Index), @"mvc.1.0.view", @"/Views/TripAdvisor/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TripAdvisor/Index.cshtml", typeof(AspNetCore.Views_TripAdvisor_Index))]
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
#line 1 "/Users/Guest/Desktop/PortlandTripperApp/Views/TripAdvisor/Index.cshtml"
using PortlandTripper.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23acc5f862be2b12dc16c2969ef099a93516b9b0", @"/Views/TripAdvisor/Index.cshtml")]
    public class Views_TripAdvisor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 5, true);
            WriteLiteral("<ul>\n");
            EndContext();
#line 3 "/Users/Guest/Desktop/PortlandTripperApp/Views/TripAdvisor/Index.cshtml"
 foreach (TripAdvisor tripAdvisor in Model)
{

#line default
#line hidden
            BeginContext(81, 14, true);
            WriteLiteral("    <li>City: ");
            EndContext();
            BeginContext(96, 16, false);
#line 5 "/Users/Guest/Desktop/PortlandTripperApp/Views/TripAdvisor/Index.cshtml"
         Write(tripAdvisor.Name);

#line default
#line hidden
            EndContext();
            BeginContext(112, 29, true);
            WriteLiteral("</li>  \n    <li>Time of day: ");
            EndContext();
            BeginContext(142, 21, false);
#line 6 "/Users/Guest/Desktop/PortlandTripperApp/Views/TripAdvisor/Index.cshtml"
                Write(tripAdvisor.TimeOfDay);

#line default
#line hidden
            EndContext();
            BeginContext(163, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 7 "/Users/Guest/Desktop/PortlandTripperApp/Views/TripAdvisor/Index.cshtml"
}

#line default
#line hidden
            BeginContext(171, 5, true);
            WriteLiteral("</ul>");
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
