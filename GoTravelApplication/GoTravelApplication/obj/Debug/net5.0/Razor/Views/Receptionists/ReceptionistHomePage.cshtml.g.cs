#pragma checksum "C:\Users\Abdul\Documents\GitHub\GoTravelApplication\GoTravelApplication\GoTravelApplication\Views\Receptionists\ReceptionistHomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be0aff0f989864e9c09acd3a4366a348ef4a57ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receptionists_ReceptionistHomePage), @"mvc.1.0.view", @"/Views/Receptionists/ReceptionistHomePage.cshtml")]
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
#line 1 "C:\Users\Abdul\Documents\GitHub\GoTravelApplication\GoTravelApplication\GoTravelApplication\Views\_ViewImports.cshtml"
using GoTravelApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdul\Documents\GitHub\GoTravelApplication\GoTravelApplication\GoTravelApplication\Views\_ViewImports.cshtml"
using GoTravelApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be0aff0f989864e9c09acd3a4366a348ef4a57ff", @"/Views/Receptionists/ReceptionistHomePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e273dc96806dda8e1a43cbeb56809e2fddeaa70", @"/Views/_ViewImports.cshtml")]
    public class Views_Receptionists_ReceptionistHomePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GoTravelApplication.Model.Receptionist>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookingDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align: center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h1>Receptionist Home Page</h1><br />\r\n<h4 style=\"text-align: center; margin: auto; color: rebeccapurple; text-size-adjust: 12px\">\r\n    Welcome ");
#nullable restore
#line 5 "C:\Users\Abdul\Documents\GitHub\GoTravelApplication\GoTravelApplication\GoTravelApplication\Views\Receptionists\ReceptionistHomePage.cshtml"
       Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h4>\r\n<br />\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Abdul\Documents\GitHub\GoTravelApplication\GoTravelApplication\GoTravelApplication\Views\Receptionists\ReceptionistHomePage.cshtml"
  
    var Msg = "";
    if (ViewData["msg"] != null)
        if (ViewData["msg"].ToString() != "Fine")
            Msg = ViewData["msg"].ToString();
    if (Msg != "")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5 style=\"color:red;\">");
#nullable restore
#line 16 "C:\Users\Abdul\Documents\GitHub\GoTravelApplication\GoTravelApplication\GoTravelApplication\Views\Receptionists\ReceptionistHomePage.cshtml"
                      Write(Msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5><br>\r\n");
#nullable restore
#line 17 "C:\Users\Abdul\Documents\GitHub\GoTravelApplication\GoTravelApplication\GoTravelApplication\Views\Receptionists\ReceptionistHomePage.cshtml"
    }

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be0aff0f989864e9c09acd3a4366a348ef4a57ff5961", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 568, "\"", 597, 1);
#nullable restore
#line 20 "C:\Users\Abdul\Documents\GitHub\GoTravelApplication\GoTravelApplication\GoTravelApplication\Views\Receptionists\ReceptionistHomePage.cshtml"
WriteAttributeValue("", 576, Model.ReceptionistId, 576, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" />\r\n    <input type=\"number\" min=\"0\" name=\"bookId\" required=\"required\"/><br /><br />\r\n\r\n    <div class=\"form-group\" style=\"text-align: center\">\r\n        <input type=\"submit\" value=\"Search Booking Id\" />\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GoTravelApplication.Model.Receptionist> Html { get; private set; }
    }
}
#pragma warning restore 1591
