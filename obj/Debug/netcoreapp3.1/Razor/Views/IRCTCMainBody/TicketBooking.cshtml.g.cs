#pragma checksum "C:\Users\win10\Desktop\Assessment_IRCTC_Revervation\Views\IRCTCMainBody\TicketBooking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecbfba7c40fb060da2ce91aaad6786408cdd3b16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IRCTCMainBody_TicketBooking), @"mvc.1.0.view", @"/Views/IRCTCMainBody/TicketBooking.cshtml")]
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
#line 1 "C:\Users\win10\Desktop\Assessment_IRCTC_Revervation\Views\_ViewImports.cshtml"
using Assessment_IRCTC_Revervation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\win10\Desktop\Assessment_IRCTC_Revervation\Views\_ViewImports.cshtml"
using Assessment_IRCTC_Revervation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecbfba7c40fb060da2ce91aaad6786408cdd3b16", @"/Views/IRCTCMainBody/TicketBooking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dcde4ba811cbd09e4d8eae3834d4c6554ee3ff1", @"/Views/_ViewImports.cshtml")]
    public class Views_IRCTCMainBody_TicketBooking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/StyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Image/irctc-logo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Your Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ticketBookingForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\win10\Desktop\Assessment_IRCTC_Revervation\Views\IRCTCMainBody\TicketBooking.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecbfba7c40fb060da2ce91aaad6786408cdd3b166113", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"">
    <title>Train Ticket Booking</title>
    <script src=""https://code.jquery.com/jquery-3.5.1.min.js""></script>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ecbfba7c40fb060da2ce91aaad6786408cdd3b166961", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecbfba7c40fb060da2ce91aaad6786408cdd3b168843", async() => {
                WriteLiteral("\r\n    <nav class=\"navbar navbar-expand-lg\" id=\"dashboardnav\">\r\n        <a class=\"navbar-brand\" href=\"#\" style=\"margin-left:5%;\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ecbfba7c40fb060da2ce91aaad6786408cdd3b169255", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </a>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>
        <div class=""collapse navbar-collapse"" id=""navbarNav"">
            <ul class=""navbar-nav ml-auto"">
                <li class=""nav-item"">
                    <a class=""nav-link"" id=""dashnavlink""");
                BeginWriteAttribute("href", " href=\"", 1392, "\"", 1439, 1);
#nullable restore
#line 28 "C:\Users\win10\Desktop\Assessment_IRCTC_Revervation\Views\IRCTCMainBody\TicketBooking.cshtml"
WriteAttributeValue("", 1399, Url.Action("TrainList","IRCTCMainBody"), 1399, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><b>Train Master</b></a>\r\n                </li>\r\n                <li class=\"nav-item\">\r\n                    <a class=\"nav-link\" id=\"dashnavlink\"");
                BeginWriteAttribute("href", " href=\"", 1584, "\"", 1635, 1);
#nullable restore
#line 31 "C:\Users\win10\Desktop\Assessment_IRCTC_Revervation\Views\IRCTCMainBody\TicketBooking.cshtml"
WriteAttributeValue("", 1591, Url.Action("TicketBooking","IRCTCMainBody"), 1591, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><b>Ticket Booking</b></a>\r\n                </li>\r\n                <li class=\"nav-item\">\r\n                    <a class=\"nav-link\" id=\"dashnavlink\"");
                BeginWriteAttribute("href", " href=\"", 1782, "\"", 1817, 1);
#nullable restore
#line 34 "C:\Users\win10\Desktop\Assessment_IRCTC_Revervation\Views\IRCTCMainBody\TicketBooking.cshtml"
WriteAttributeValue("", 1789, Url.Action("Login","Login"), 1789, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><b>Logout</b></a>
                </li>
            </ul>
        </div>
    </nav>
    <div class=""container mt-5"">
        <div class=""row justify-content-center"">
            <div class=""col-md-6"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h4 class=""mb-0"">Ticket Booking</h4>
                    </div>
                    <div class=""card-body"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecbfba7c40fb060da2ce91aaad6786408cdd3b1613037", async() => {
                    WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <label for=\"trainName\"><b>Select Train Name</b></label>\r\n                                ");
#nullable restore
#line 50 "C:\Users\win10\Desktop\Assessment_IRCTC_Revervation\Views\IRCTCMainBody\TicketBooking.cshtml"
                           Write(Html.DropDownList("train", ViewBag.train as SelectList, "Select", new { @class = "form-select", id = "ddltrain" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                            </div>
                           
                            <div class=""form-group"">
                                <label for=""txtTrainNumber""><b>Train Number</b></label>
                                <input type=""text"" class=""form-control"" id=""txtTrainNumber"" >
                            </div>

                            <div class=""form-group"">
                                <label for=""emailId""><b>Email Address</b></label>
                                ");
#nullable restore
#line 60 "C:\Users\win10\Desktop\Assessment_IRCTC_Revervation\Views\IRCTCMainBody\TicketBooking.cshtml"
                           Write(Html.DropDownList("train", ViewBag.mail as SelectList, "Select", new { @class = "form-select", id = "ddlmail" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                            </div>
                            <div class=""form-group"">
                                <label for=""departureDate""><b>Departure Date</b></label>
                                <input type=""date"" class=""form-control"" id=""departureDate"" name=""departureDate"" required>
                            </div>
                            <div class=""form-group"">
                                <label for=""ticketFare""><b>Ticket Fare</b></label>
                                <input type=""number"" class=""form-control"" id=""ticketFare"" name=""ticketFare"" placeholder=""Enter ticket fare"" required>
                            </div>
                            <button type=""submit"" class=""btn btn-primary"">Book Ticket</button>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>

<script>
    $(document).ready(function () {
        $(""#ddltrain"").change(function () {
            var Id = $(""#ddltrain"").val();

            $.ajax({
                url: '/IRCTCMainBody/GetTrainNumbers',
                type: 'GET',
                data: { Id: Id },
                success: function (data) {
                    console.log(data);                   
                    if (data.length > 0) {
                        debugger;                       
                        $(""#txtTrainNumber"").val(data[0].trainNumber);
                    } else {
                      
                        $(""#txtTrainNumber"").val("""");
                    }
                },
                error: function () {
                    alert(""Error fetching train numbers."");
                }
            });
        });
    });

</script>
<script>    
    $(""#ticketBookingForm"").submit(function (event) {        
        event.preventDefault();
        var formData ");
            WriteLiteral(@"= {
            trainName: $(""#ddltrain"").val(),
            trainNumber: $(""#txtTrainNumber"").val(),
            emailId: $(""#ddlmail"").val(),
            departureDate: $(""#departureDate"").val(),
            ticketFare: $(""#ticketFare"").val()
        };

       
        $.ajax({
            url: '/IRCTCMainBody/SaveTicket',
            type: 'POST',
            data: formData,
        
            success: function (res) {
               
                if (res.status) {
                    alert(res.message);
                } else {
                    alert(""Error: "" + res.message);
                }
                window.location.href = ""/IRCTCMainBody/TicketList"";
            },
            error: function () {
                alert(""Error submitting the form."");
            }
        });
    });
 
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
