#pragma checksum "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21b187ec8ecf59090aecba2a3e6a5ce03afb30cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\Loyd.Mabulana\source\repos\test\Views\_ViewImports.cshtml"
using MovieApiV2Web1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Loyd.Mabulana\source\repos\test\Views\_ViewImports.cshtml"
using MovieApiV2Web1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21b187ec8ecf59090aecba2a3e6a5ce03afb30cc", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc4768a615df7338089819088ea68857cc6b1144", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<(List<MovieApiV.Model.Bookings>, List<MovieApiV.Model.StockBal>)>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Parts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Parts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StockEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Car Inventory";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <link rel=\"stylesheet\" type=\"text/css\" href=\"//cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css\" />\r\n");
            WriteLiteral("\r\n<h2 class=\"alert alert-primary text-center\" role=\"alert\">\r\n    <i class=\"fas fa-user-circle\"></i>Admin Panel\r\n</h2>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21b187ec8ecf59090aecba2a3e6a5ce03afb30cc6689", async() => {
                WriteLiteral("New Part ");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21b187ec8ecf59090aecba2a3e6a5ce03afb30cc8136", async() => {
                WriteLiteral("New Car ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21b187ec8ecf59090aecba2a3e6a5ce03afb30cc9586", async() => {
                WriteLiteral("View Parts ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21b187ec8ecf59090aecba2a3e6a5ce03afb30cc10829", async() => {
                WriteLiteral("View Cars ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<p></p>

<ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
    <li class=""nav-item"">
        <a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#home"" role=""tab"" aria-controls=""home"" aria-selected=""true"">Bookings</a>
    </li>
    <li class=""nav-item"">
        <a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#profile"" role=""tab"" aria-controls=""profile"" aria-selected=""false"">
            Finance
        </a>
    </li>
</ul>

<p></p>


<div class=""tab-content"" id=""myTabContent"">

    <div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">
        <table class=""table table-striped col-md-12"" id=""tbl"">
            <thead>
                <tr>
                    <th>");
#nullable restore
#line 41 "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Item1.FirstOrDefault().TestingCarName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 42 "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Item1.FirstOrDefault().CustName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 43 "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Item1.FirstOrDefault().Revdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 44 "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Item1.FirstOrDefault().hasCome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 49 "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml"
                 foreach (var item in Model.Item1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>   ");
#nullable restore
#line 52 "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.TestingCarName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>   ");
#nullable restore
#line 53 "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.CustName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>   ");
#nullable restore
#line 54 "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.Revdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>   ");
#nullable restore
#line 55 "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.hasCome));

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21b187ec8ecf59090aecba2a3e6a5ce03afb30cc16233", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml"
                                                           WriteLiteral(item.CustomerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21b187ec8ecf59090aecba2a3e6a5ce03afb30cc18518", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml"
                                                             WriteLiteral(item.CustomerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 71 "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>

    <div class=""tab-pane fade"" id=""profile"" role=""tabpanel"" aria-labelledby=""profile-tab"">
        <table class=""table table-striped col-md-12"" id=""tbl2"">
            <thead>
                <tr>
                    <th>");
#nullable restore
#line 80 "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Item2.FirstOrDefault().StockId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 81 "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Item2.FirstOrDefault().PaymentType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 82 "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Item2.FirstOrDefault().CarModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 83 "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Item2.FirstOrDefault().Approve));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 88 "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml"
                 foreach (var item in Model.Item2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>   ");
#nullable restore
#line 91 "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.StockId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>   ");
#nullable restore
#line 92 "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.PaymentType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>   ");
#nullable restore
#line 93 "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.CarModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>   ");
#nullable restore
#line 94 "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.Approve));

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21b187ec8ecf59090aecba2a3e6a5ce03afb30cc24739", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml"
                                                                WriteLiteral(item.StockId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 110 "C:\Users\Loyd.Mabulana\source\repos\test\Views\Admin\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"" charset=""utf8"" src=""//cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js""></script>

    <script type=""text/javascript"">
        $(document).ready(function () {
            $('#tbl, #tbl2').DataTable({
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<(List<MovieApiV.Model.Bookings>, List<MovieApiV.Model.StockBal>)> Html { get; private set; }
    }
}
#pragma warning restore 1591
