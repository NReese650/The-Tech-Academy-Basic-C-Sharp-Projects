#pragma checksum "C:\Users\nickr\OneDrive\Tech Academy\The Tech Academy Basic C-Sharp Projects\The-Tech-Academy-Basic-C-Sharp-Projects\CSharpChallengeSubmission\Pages\Time.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa305ac55aaac71b2690e07e28fdc9b3e927de24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ChallengeSubmission.Pages.Pages_Time), @"mvc.1.0.razor-page", @"/Pages/Time.cshtml")]
namespace ChallengeSubmission.Pages
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
#line 1 "C:\Users\nickr\OneDrive\Tech Academy\The Tech Academy Basic C-Sharp Projects\The-Tech-Academy-Basic-C-Sharp-Projects\CSharpChallengeSubmission\Pages\_ViewImports.cshtml"
using ChallengeSubmission;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa305ac55aaac71b2690e07e28fdc9b3e927de24", @"/Pages/Time.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3aebe13d89973ebdcba9e63fe3ad967214a01283", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Time : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div>\r\n    Current Time: ");
#nullable restore
#line 8 "C:\Users\nickr\OneDrive\Tech Academy\The Tech Academy Basic C-Sharp Projects\The-Tech-Academy-Basic-C-Sharp-Projects\CSharpChallengeSubmission\Pages\Time.cshtml"
             Write(Model.CurrentTime.CurrentTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChallengeSubmission.Pages.TimePageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ChallengeSubmission.Pages.TimePageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ChallengeSubmission.Pages.TimePageModel>)PageContext?.ViewData;
        public ChallengeSubmission.Pages.TimePageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
