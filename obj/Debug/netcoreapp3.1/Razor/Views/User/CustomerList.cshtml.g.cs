#pragma checksum "D:\Marolix\Projects\SCASA\Project\SCASA\Views\User\CustomerList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a41a2f64240027ef512629368cc20c7e3608aab0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_CustomerList), @"mvc.1.0.view", @"/Views/User/CustomerList.cshtml")]
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
#line 1 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\_ViewImports.cshtml"
using SCASA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\_ViewImports.cshtml"
using SCASA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a41a2f64240027ef512629368cc20c7e3608aab0", @"/Views/User/CustomerList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f59c02fdbf6895e021479e28253e13dd514c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_User_CustomerList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SCASA.Models.ModelClasses.CustomerDisplayModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/EmpireHome/Dashboard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/CustomerData"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Addresses"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\User\CustomerList.cshtml"
      
    int rCnt = 1;
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""content-wrapper"">
        <!-- Content Header (Page header) -->
        <section class=""content-header"">
            <div class=""row"">
                <div class=""col-md-11"">
                    <div class=""header-icon"">

                        <i class=""fa fa-dashboard""></i>
                    </div>
                    <div class=""header-title"">
                        <h1>Customers</h1>
                        <small>Customers List</small>
                    </div>
                </div>
                <div class=""btn-group float-right"" role=""group"">
                    <div class=""buttonexport"" id=""buttonlist"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a41a2f64240027ef512629368cc20c7e3608aab05773", async() => {
                WriteLiteral("\r\n                            <i class=\"fa fa-reply mr-2\"></i> Back\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </section>
        <!-- Main content -->
        <section class=""content"">
            <div class=""row"">
                <div class=""col-lg-12 pinpin"">
                    <div class=""card"" data-sortable=""true"">
                        <div class=""card-header"">
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""card-title custom_title"">
                                        <h4>Customers</h4>
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""btn-group float-right"" role=""group"">
                                        <div class=""buttonexport"" id=""buttonlist"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a41a2f64240027ef512629368cc20c7e3608aab07992", async() => {
                WriteLiteral("\r\n                                                <i class=\"fa fa-plus\"></i> Add New\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""card-body"">
                            <!-- Plugin content:powerpoint,txt,pdf,png,word,xl -->
                            <!-- Plugin content:powerpoint,txt,pdf,png,word,xl -->
                            <div class=""table-responsive"">
                                <table id=""mydatatable"" class=""table table-bordered table-striped table-hover"">
                                    <thead class=""back_table_color"">
                                        <tr class=""info"">
                                            <th>S No</th>
                                            <th>Name</th>
                                            <th>Mobile Number</th>
                                            <th>Email</th>
                                            <th>WhatsApp ");
            WriteLiteral(@"Number</th>
                                            <th>Quotations</th><th>Orders</th><th>To be Dispatched</th><th>Dispatched</th>
                                            <th>Ledger Id</th>
                                            <th>Actions</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 73 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\User\CustomerList.cshtml"
                                         foreach (var u in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 76 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\User\CustomerList.cshtml"
                                            Write(rCnt ++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 77 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\User\CustomerList.cshtml"
                                           Write(u.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 78 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\User\CustomerList.cshtml"
                                           Write(u.MobileNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 79 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\User\CustomerList.cshtml"
                                           Write(u.EmailId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 80 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\User\CustomerList.cshtml"
                                           Write(u.WhatsAppNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                           <td>");
#nullable restore
#line 81 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\User\CustomerList.cshtml"
                                          Write(u.TotalQuotations);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 82 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\User\CustomerList.cshtml"
                                           Write(u.TotalOrders);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 83 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\User\CustomerList.cshtml"
                                           Write(u.ReadyToDispatch);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 84 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\User\CustomerList.cshtml"
                                           Write(u.DespatchedOrders);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>\r\n");
#nullable restore
#line 86 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\User\CustomerList.cshtml"
                                                 if (u.FinanceHeadId == null)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a href=\"javascript:void(0);\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4686, "\"", 4713, 3);
            WriteAttributeValue("", 4696, "AddLedger(", 4696, 10, true);
#nullable restore
#line 88 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\User\CustomerList.cshtml"
WriteAttributeValue("", 4706, u.Cid, 4706, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4712, ")", 4712, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Create</a>\r\n");
#nullable restore
#line 89 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\User\CustomerList.cshtml"
                                                }
                                                else
                                                {
                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\User\CustomerList.cshtml"
                                               Write(u.FinanceHeadId);

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\User\CustomerList.cshtml"
                                                                    

                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a41a2f64240027ef512629368cc20c7e3608aab015872", async() => {
                WriteLiteral(@"
                                                    <button type=""button"" class=""btn btn-add btn-sm"">
                                                        <i class=""fa fa-pencil""></i>
                                                    </button>
                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5166, "~/User/CustomerData?id=", 5166, 23, true);
#nullable restore
#line 98 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\User\CustomerList.cshtml"
AddHtmlAttributeValue("", 5189, u.Cid, 5189, 6, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a41a2f64240027ef512629368cc20c7e3608aab017832", async() => {
                WriteLiteral(@"
                                                    <button type=""button"" class=""btn btn-success btn-sm"">
                                                        <i class=""fa fa-address-card""></i>
                                                    </button>
                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5575, "~/User/GetAddress?id=", 5575, 21, true);
#nullable restore
#line 103 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\User\CustomerList.cshtml"
AddHtmlAttributeValue("", 5596, u.Cid, 5596, 6, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                <a href=\"javascript:void(0);\" title=\"Delete\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6032, "\"", 6060, 3);
            WriteAttributeValue("", 6042, "ShowDelete(", 6042, 11, true);
#nullable restore
#line 108 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\User\CustomerList.cshtml"
WriteAttributeValue("", 6053, u.Cid, 6053, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6059, ")", 6059, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <button type=""button"" class=""btn btn-danger btn-sm"" data-toggle=""modal"">
                                                        <i class=""fa fa-trash-o""></i>
                                                    </button>
                                                </a>
                                            </td>
                                        </tr>
");
#nullable restore
#line 115 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\User\CustomerList.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- /.content -->
    </div>
    <script>

        function AddLedger(id) {
            swal(""Are you sure? create ledger ?"", {
                buttons: {
                    yes: {
                        text: ""Yes"",
                        value: ""yes""
                    },
                    no: {
                        text: ""No"",
                        value: ""no""
                    }
                }
            }).then((value) => {
                if (value === ""yes"") {
                    $.ajax({
                        url: GlobalUrl + ""User/AddLedger?cid="" + id,
                        type: 'post',
                        data: '{}',
                        success: function (result) {
                            to");
            WriteLiteral(@"astr[""success""](""Successuflly created!"");
                            window.location.href = window.location.href;
                        }
                    });
                }
                else {
                    toastr[""error""](""Create cancelled!"")
                }
                return false;
            });
        }
        function ShowDelete(id) {
            swal(""Are you sure?"", {
                buttons: {
                    yes: {
                        text: ""Yes"",
                        value: ""yes""
                    },
                    no: {
                        text: ""No"",
                        value: ""no""
                    }
                }
            }).then((value) => {
                if (value === ""yes"") {
                    $.ajax({
                        url: GlobalUrl + ""User/DeleteCustomer?id="" + id,
                        type: 'post',
                        data: '{}',
                        success: function (result) ");
            WriteLiteral(@"{
                            toastr[""success""](""Successuflly deleted!"");
                            window.location.href = window.location.href;
                        }
                    });
                }
                else {
                    toastr[""error""](""Delete cancelled!"")
                }
                return false;
            });


        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SCASA.Models.ModelClasses.CustomerDisplayModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591