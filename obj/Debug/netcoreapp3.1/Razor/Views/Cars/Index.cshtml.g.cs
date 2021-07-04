#pragma checksum "C:\Users\Nkosana\source\repos\MovieApiV2Web1\Views\Cars\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3919f2e7ccace253964a60c29cc1448ec767fc83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Index), @"mvc.1.0.view", @"/Views/Cars/Index.cshtml")]
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
#line 1 "C:\Users\Nkosana\source\repos\MovieApiV2Web1\Views\_ViewImports.cshtml"
using MovieApiV2Web1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nkosana\source\repos\MovieApiV2Web1\Views\_ViewImports.cshtml"
using MovieApiV2Web1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3919f2e7ccace253964a60c29cc1448ec767fc83", @"/Views/Cars/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc4768a615df7338089819088ea68857cc6b1144", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieApiV.Model.Car>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Nkosana\source\repos\MovieApiV2Web1\Views\Cars\Index.cshtml"
  
    ViewData["Title"] = "Car Inventory";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <link rel=\"stylesheet\" type=\"text/css\" href=\"//cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css\" />\r\n");
            WriteLiteral(@"
<ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
    <li class=""nav-item"">
        <a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#home"" role=""tab"" aria-controls=""home"" aria-selected=""true"">Car</a>
    </li>
    <li class=""nav-item"">
        <a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#profile"" role=""tab"" aria-controls=""profile"" aria-selected=""false"">Parts</a>
    </li>
");
            WriteLiteral(@"</ul>
<p></p>
<div class=""tab-content"" id=""myTabContent"">

    <div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">
        <table class=""table table-striped col-md-12"" id=""tbl"">
            <thead>
                <tr>
                    <th>");
#nullable restore
#line 25 "C:\Users\Nkosana\source\repos\MovieApiV2Web1\Views\Cars\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FirstOrDefault().Make));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 26 "C:\Users\Nkosana\source\repos\MovieApiV2Web1\Views\Cars\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FirstOrDefault().Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 27 "C:\Users\Nkosana\source\repos\MovieApiV2Web1\Views\Cars\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FirstOrDefault().Mileage));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 28 "C:\Users\Nkosana\source\repos\MovieApiV2Web1\Views\Cars\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FirstOrDefault().Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 29 "C:\Users\Nkosana\source\repos\MovieApiV2Web1\Views\Cars\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FirstOrDefault().Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\Nkosana\source\repos\MovieApiV2Web1\Views\Cars\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>   ");
#nullable restore
#line 37 "C:\Users\Nkosana\source\repos\MovieApiV2Web1\Views\Cars\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.Make));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>   ");
#nullable restore
#line 38 "C:\Users\Nkosana\source\repos\MovieApiV2Web1\Views\Cars\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>   ");
#nullable restore
#line 39 "C:\Users\Nkosana\source\repos\MovieApiV2Web1\Views\Cars\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.Mileage));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>   ");
#nullable restore
#line 40 "C:\Users\Nkosana\source\repos\MovieApiV2Web1\Views\Cars\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>   ");
#nullable restore
#line 41 "C:\Users\Nkosana\source\repos\MovieApiV2Web1\Views\Cars\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>

                        <td>
                            <div class=""dropdown"">
                                <button class=""btn btn-secondary btn-sm  dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" data-display=""static"" aria-haspopup=""true"" aria-expanded=""false"">
                                    Action
                                </button>
                                <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""dropdownMenuButton"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3919f2e7ccace253964a60c29cc1448ec767fc839371", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3919f2e7ccace253964a60c29cc1448ec767fc8310643", async() => {
                WriteLiteral("Detail");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3919f2e7ccace253964a60c29cc1448ec767fc8311918", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 56 "C:\Users\Nkosana\source\repos\MovieApiV2Web1\Views\Cars\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>

    <div class=""tab-pane fade"" id=""profile"" role=""tabpanel"" aria-labelledby=""profile-tab"">...</div>
    <div class=""tab-pane fade"" id=""contact"" role=""tabpanel"" aria-labelledby=""contact-tab"">...</div>
</div>
");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"" charset=""utf8"" src=""//cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js""></script>

    <script type=""text/javascript"">
        $(document).ready(function () {
            $('#tbl').DataTable({
                order:
                    [
                        ['1', 'desc']
                    ]
            });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MovieApiV.Model.Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591
