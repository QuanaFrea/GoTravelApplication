#pragma checksum "C:\Users\user\Documents\GitHub\GoTravelApplication\GoTravelApplication\GoTravelApplication\Views\CustomerBookings\AdminDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7218f68358650e79e93329a0539b45810ab54dfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerBookings_AdminDelete), @"mvc.1.0.view", @"/Views/CustomerBookings/AdminDelete.cshtml")]
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
#line 1 "C:\Users\user\Documents\GitHub\GoTravelApplication\GoTravelApplication\GoTravelApplication\Views\_ViewImports.cshtml"
using GoTravelApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Documents\GitHub\GoTravelApplication\GoTravelApplication\GoTravelApplication\Views\_ViewImports.cshtml"
using GoTravelApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7218f68358650e79e93329a0539b45810ab54dfd", @"/Views/CustomerBookings/AdminDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e273dc96806dda8e1a43cbeb56809e2fddeaa70", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CustomerBookings_AdminDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GoTravelApplication.Model.CustomerBooking>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminDeleteConfirmed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\Documents\GitHub\GoTravelApplication\GoTravelApplication\GoTravelApplication\Views\CustomerBookings\AdminDelete.cshtml"
  
    ViewData["Title"] = "AdminDelete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>AdminDelete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>CustomerBooking</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\user\Documents\GitHub\GoTravelApplication\GoTravelApplication\GoTravelApplication\Views\CustomerBookings\AdminDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.PurchaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\user\Documents\GitHub\GoTravelApplication\GoTravelApplication\GoTravelApplication\Views\CustomerBookings\AdminDelete.cshtml"
       Write(Html.DisplayFor(model => model.PurchaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\user\Documents\GitHub\GoTravelApplication\GoTravelApplication\GoTravelApplication\Views\CustomerBookings\AdminDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\user\Documents\GitHub\GoTravelApplication\GoTravelApplication\GoTravelApplication\Views\CustomerBookings\AdminDelete.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\user\Documents\GitHub\GoTravelApplication\GoTravelApplication\GoTravelApplication\Views\CustomerBookings\AdminDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.Booking));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\user\Documents\GitHub\GoTravelApplication\GoTravelApplication\GoTravelApplication\Views\CustomerBookings\AdminDelete.cshtml"
       Write(Html.DisplayFor(model => model.Booking.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\user\Documents\GitHub\GoTravelApplication\GoTravelApplication\GoTravelApplication\Views\CustomerBookings\AdminDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\user\Documents\GitHub\GoTravelApplication\GoTravelApplication\GoTravelApplication\Views\CustomerBookings\AdminDelete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7218f68358650e79e93329a0539b45810ab54dfd7958", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1182, "\"", 1216, 1);
#nullable restore
#line 41 "C:\Users\user\Documents\GitHub\GoTravelApplication\GoTravelApplication\GoTravelApplication\Views\CustomerBookings\AdminDelete.cshtml"
WriteAttributeValue("", 1190, ViewData["loggedAdminId"], 1190, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" />\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1260, "\"", 1292, 1);
#nullable restore
#line 42 "C:\Users\user\Documents\GitHub\GoTravelApplication\GoTravelApplication\GoTravelApplication\Views\CustomerBookings\AdminDelete.cshtml"
WriteAttributeValue("", 1268, Model.CustomerBookingId, 1268, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"bookingId\" />\r\n        <input type=\"submit\" value=\"Cancel Booking\" class=\"btn btn-danger\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7218f68358650e79e93329a0539b45810ab54dfd10479", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1495, "\"", 1529, 1);
#nullable restore
#line 47 "C:\Users\user\Documents\GitHub\GoTravelApplication\GoTravelApplication\GoTravelApplication\Views\CustomerBookings\AdminDelete.cshtml"
WriteAttributeValue("", 1503, ViewData["loggedAdminId"], 1503, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" />\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1573, "\"", 1605, 1);
#nullable restore
#line 48 "C:\Users\user\Documents\GitHub\GoTravelApplication\GoTravelApplication\GoTravelApplication\Views\CustomerBookings\AdminDelete.cshtml"
WriteAttributeValue("", 1581, Model.CustomerBookingId, 1581, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"bookingId\" />\r\n        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Back to Details\" class=\"btn btn-secondary\" />\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GoTravelApplication.Model.CustomerBooking> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
