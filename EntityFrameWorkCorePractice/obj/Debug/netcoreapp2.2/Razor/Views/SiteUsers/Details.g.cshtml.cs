#pragma checksum "C:\Users\Jafrul Hasan Taj\source\repos\EntityFrameWorkCorePractice\EntityFrameWorkCorePractice\Views\SiteUsers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f4ecec84d6ab2374afd9c141dca63da92955d86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SiteUsers_Details), @"mvc.1.0.view", @"/Views/SiteUsers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SiteUsers/Details.cshtml", typeof(AspNetCore.Views_SiteUsers_Details))]
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
#line 1 "C:\Users\Jafrul Hasan Taj\source\repos\EntityFrameWorkCorePractice\EntityFrameWorkCorePractice\Views\_ViewImports.cshtml"
using EntityFrameWorkCorePractice;

#line default
#line hidden
#line 2 "C:\Users\Jafrul Hasan Taj\source\repos\EntityFrameWorkCorePractice\EntityFrameWorkCorePractice\Views\_ViewImports.cshtml"
using EntityFrameWorkCorePractice.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f4ecec84d6ab2374afd9c141dca63da92955d86", @"/Views/SiteUsers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3096de8e941f5566471edf8363de3b5e1f7fbfe4", @"/Views/_ViewImports.cshtml")]
    public class Views_SiteUsers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityFrameWorkCorePractice.Models.Data.SiteUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Jafrul Hasan Taj\source\repos\EntityFrameWorkCorePractice\EntityFrameWorkCorePractice\Views\SiteUsers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(102, 129, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>SiteUser</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(232, 40, false);
#line 14 "C:\Users\Jafrul Hasan Taj\source\repos\EntityFrameWorkCorePractice\EntityFrameWorkCorePractice\Views\SiteUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(272, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(334, 36, false);
#line 17 "C:\Users\Jafrul Hasan Taj\source\repos\EntityFrameWorkCorePractice\EntityFrameWorkCorePractice\Views\SiteUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(370, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(431, 44, false);
#line 20 "C:\Users\Jafrul Hasan Taj\source\repos\EntityFrameWorkCorePractice\EntityFrameWorkCorePractice\Views\SiteUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(475, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(537, 40, false);
#line 23 "C:\Users\Jafrul Hasan Taj\source\repos\EntityFrameWorkCorePractice\EntityFrameWorkCorePractice\Views\SiteUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(577, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(638, 44, false);
#line 26 "C:\Users\Jafrul Hasan Taj\source\repos\EntityFrameWorkCorePractice\EntityFrameWorkCorePractice\Views\SiteUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(682, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(744, 40, false);
#line 29 "C:\Users\Jafrul Hasan Taj\source\repos\EntityFrameWorkCorePractice\EntityFrameWorkCorePractice\Views\SiteUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(784, 28, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n");
            EndContext();
#line 32 "C:\Users\Jafrul Hasan Taj\source\repos\EntityFrameWorkCorePractice\EntityFrameWorkCorePractice\Views\SiteUsers\Details.cshtml"
     if (Model.Courses != null)
    {

#line default
#line hidden
            BeginContext(852, 124, true);
            WriteLiteral("        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(977, 43, false);
#line 38 "C:\Users\Jafrul Hasan Taj\source\repos\EntityFrameWorkCorePractice\EntityFrameWorkCorePractice\Views\SiteUsers\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Courses));

#line default
#line hidden
            EndContext();
            BeginContext(1020, 128, true);
            WriteLiteral("\r\n                    </th>\r\n\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 45 "C:\Users\Jafrul Hasan Taj\source\repos\EntityFrameWorkCorePractice\EntityFrameWorkCorePractice\Views\SiteUsers\Details.cshtml"
                 foreach (var item in Model.Courses)
                {

#line default
#line hidden
            BeginContext(1221, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1306, 39, false);
#line 49 "C:\Users\Jafrul Hasan Taj\source\repos\EntityFrameWorkCorePractice\EntityFrameWorkCorePractice\Views\SiteUsers\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1345, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 52 "C:\Users\Jafrul Hasan Taj\source\repos\EntityFrameWorkCorePractice\EntityFrameWorkCorePractice\Views\SiteUsers\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(1424, 40, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            EndContext();
#line 55 "C:\Users\Jafrul Hasan Taj\source\repos\EntityFrameWorkCorePractice\EntityFrameWorkCorePractice\Views\SiteUsers\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(1471, 30, true);
            WriteLiteral("\r\n\r\n</div>\r\n<div>\r\n     \r\n    ");
            EndContext();
            BeginContext(1501, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f4ecec84d6ab2374afd9c141dca63da92955d869489", async() => {
                BeginContext(1523, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1539, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityFrameWorkCorePractice.Models.Data.SiteUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
