#pragma checksum "C:\NetCoreOauthGithub\NetCoreOauthGithub\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f214433a11ec516a6629b320336180f1bd7e623b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NetCoreOauthGithub.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace NetCoreOauthGithub.Pages
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
#line 1 "C:\NetCoreOauthGithub\NetCoreOauthGithub\Pages\_ViewImports.cshtml"
using NetCoreOauthGithub;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f214433a11ec516a6629b320336180f1bd7e623b", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f3dfbaa35cc689dd3343de56df414f5e5fc14df", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Auth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 3 "C:\NetCoreOauthGithub\NetCoreOauthGithub\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 8 "C:\NetCoreOauthGithub\NetCoreOauthGithub\Pages\Index.cshtml"
     if (!User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f214433a11ec516a6629b320336180f1bd7e623b4256", async() => {
                WriteLiteral("Log In with GitHub");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\NetCoreOauthGithub\NetCoreOauthGithub\Pages\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div id=""accordion"" class=""container-fluid"">
            <div class=""card"">
                <div class=""card-header"" id=""headingOne"">
                    <h5 class=""mb-0"">
                        <button class=""btn btn-link"" data-toggle=""collapse"" data-target=""#collapse-repos"" aria-expanded=""true"" aria-controls=""collapse-repos"">
                            Repos
                        </button>
                    </h5>
                </div>

                <div id=""collapse-repos"" class=""collapse show"" aria-labelledby=""headingOne"" data-parent=""#accordion"">
                    <div class=""card-body"">
                        <ul>
");
#nullable restore
#line 27 "C:\NetCoreOauthGithub\NetCoreOauthGithub\Pages\Index.cshtml"
                             foreach (var repo in Model.Repositories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1074, "\"", 1094, 1);
#nullable restore
#line 29 "C:\NetCoreOauthGithub\NetCoreOauthGithub\Pages\Index.cshtml"
WriteAttributeValue("", 1081, repo.HtmlUrl, 1081, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "C:\NetCoreOauthGithub\NetCoreOauthGithub\Pages\Index.cshtml"
                                                       Write(repo.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 30 "C:\NetCoreOauthGithub\NetCoreOauthGithub\Pages\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
            </div>
            <div class=""card"">
                <div class=""card-header"" id=""headingTwo"">
                    <h5 class=""mb-0"">
                        <button class=""btn btn-link collapsed"" data-toggle=""collapse"" data-target=""#collapse-starred"" aria-expanded=""false"" aria-controls=""collapse-starred"">
                            Starred Repositories
                        </button>
                    </h5>
                </div>
                <div id=""collapse-starred"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordion"">
                    <div class=""card-body"">
                        <ul>
");
#nullable restore
#line 46 "C:\NetCoreOauthGithub\NetCoreOauthGithub\Pages\Index.cshtml"
                             foreach (var repo in Model.StarredRepos)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2027, "\"", 2047, 1);
#nullable restore
#line 48 "C:\NetCoreOauthGithub\NetCoreOauthGithub\Pages\Index.cshtml"
WriteAttributeValue("", 2034, repo.HtmlUrl, 2034, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 48 "C:\NetCoreOauthGithub\NetCoreOauthGithub\Pages\Index.cshtml"
                                                       Write(repo.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 49 "C:\NetCoreOauthGithub\NetCoreOauthGithub\Pages\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
            </div>
            <div class=""card"">
                <div class=""card-header"" id=""headingThree"">
                    <h5 class=""mb-0"">
                        <button class=""btn btn-link collapsed"" data-toggle=""collapse"" data-target=""#collapse-followers"" aria-expanded=""false"" aria-controls=""collapse-followers"">
                            Followers
                        </button>
                    </h5>
                </div>
                <div id=""collapse-followers"" class=""collapse"" aria-labelledby=""headingThree"" data-parent=""#accordion"">
                    <div class=""card-body"">
                        <ul>
");
#nullable restore
#line 65 "C:\NetCoreOauthGithub\NetCoreOauthGithub\Pages\Index.cshtml"
                             foreach (var follower in Model.Followers)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2980, "\"", 3004, 1);
#nullable restore
#line 67 "C:\NetCoreOauthGithub\NetCoreOauthGithub\Pages\Index.cshtml"
WriteAttributeValue("", 2987, follower.HtmlUrl, 2987, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 67 "C:\NetCoreOauthGithub\NetCoreOauthGithub\Pages\Index.cshtml"
                                                           Write(follower.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 68 "C:\NetCoreOauthGithub\NetCoreOauthGithub\Pages\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
            </div>
            <div class=""card"">
                <div class=""card-header"" id=""headingFour"">
                    <h5 class=""mb-0"">
                        <button class=""btn btn-link collapsed"" data-toggle=""collapse"" data-target=""#collapse-following"" aria-expanded=""false"" aria-controls=""collapse-following"">
                            Following
                        </button>
                    </h5>
                </div>
                <div id=""collapse-following"" class=""collapse"" aria-labelledby=""headingFour"" data-parent=""#accordion"">
                    <div class=""card-body"">
                        <ul>
");
#nullable restore
#line 84 "C:\NetCoreOauthGithub\NetCoreOauthGithub\Pages\Index.cshtml"
                             foreach (var follower in Model.Followers)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 3936, "\"", 3960, 1);
#nullable restore
#line 86 "C:\NetCoreOauthGithub\NetCoreOauthGithub\Pages\Index.cshtml"
WriteAttributeValue("", 3943, follower.HtmlUrl, 3943, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 86 "C:\NetCoreOauthGithub\NetCoreOauthGithub\Pages\Index.cshtml"
                                                           Write(follower.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 87 "C:\NetCoreOauthGithub\NetCoreOauthGithub\Pages\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 93 "C:\NetCoreOauthGithub\NetCoreOauthGithub\Pages\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
