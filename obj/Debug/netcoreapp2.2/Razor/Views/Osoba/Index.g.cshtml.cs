#pragma checksum "C:\Users\bogda\source\repos\WebShopNow\WebShopNow\Views\Osoba\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f69fcae1b158138fef6e23ccd4bff473ad08b6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Osoba_Index), @"mvc.1.0.view", @"/Views/Osoba/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Osoba/Index.cshtml", typeof(AspNetCore.Views_Osoba_Index))]
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
#line 1 "C:\Users\bogda\source\repos\WebShopNow\WebShopNow\Views\_ViewImports.cshtml"
using WebShop;

#line default
#line hidden
#line 2 "C:\Users\bogda\source\repos\WebShopNow\WebShopNow\Views\_ViewImports.cshtml"
using WebShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f69fcae1b158138fef6e23ccd4bff473ad08b6d", @"/Views/Osoba/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf6e511299f0cda60cf4de484793b6cb35bd75b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Osoba_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebShop.Models.Osoba>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\bogda\source\repos\WebShopNow\WebShopNow\Views\Osoba\Index.cshtml"
  
    ViewData["Title"] = "Porudzbina";

#line default
#line hidden
            BeginContext(90, 39, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(129, 491, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f69fcae1b158138fef6e23ccd4bff473ad08b6d4879", async() => {
                BeginContext(135, 210, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\r\n    <title>Primljena porudzbina</title>\r\n    ");
                EndContext();
                BeginContext(345, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0f69fcae1b158138fef6e23ccd4bff473ad08b6d5488", async() => {
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
                EndContext();
                BeginContext(418, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(424, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0f69fcae1b158138fef6e23ccd4bff473ad08b6d6821", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(471, 142, true);
                WriteLiteral("\r\n    <style>\r\n        #spanh1 {\r\n            color: red;           \r\n        } \r\n        body{ background-color:deepskyblue;}\r\n    </style>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(620, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(622, 3199, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f69fcae1b158138fef6e23ccd4bff473ad08b6d9104", async() => {
                BeginContext(628, 1188, true);
                WriteLiteral(@"
    <div>
        <center>
            <h1>Vasa Porudzbina je</h1>
        </center>
    </div>
    <div>
        <center>
            <h1 id=""h""><span id=""spanh1"">PRIMLJENA</span>!</h1>
        </center>
    </div>
    <div>
        <center>
            <h3>Vasa porudzbina</h3>
        </center>
    </div>
    <div class=""container"">
        <div class=""row"" style=""display:flex;flex-direction:column; justify-self:center;align-items:center; position:center;text-align:center; "">
            <center>
                <div>
                    <div id=""table1"">
                         
                        <table class=""table table-bordered"" style="" background-color:greenyellow;"">
                            <thead>
                                <tr>
                                    <th>Naziv artikla:</th>
                                    <th>Kolicina:</th>
                                    <th>Cena:</th>
                                </tr>
                           ");
                WriteLiteral(" </thead>\r\n                            <tbody>\r\n                                <tr>\r\n                                    \r\n                                    <td>");
                EndContext();
                BeginContext(1817, 15, false);
#line 57 "C:\Users\bogda\source\repos\WebShopNow\WebShopNow\Views\Osoba\Index.cshtml"
                                   Write(Global.proizvod);

#line default
#line hidden
                EndContext();
                BeginContext(1832, 47, true);
                WriteLiteral("</td>\r\n                                    <td>");
                EndContext();
                BeginContext(1880, 15, false);
#line 58 "C:\Users\bogda\source\repos\WebShopNow\WebShopNow\Views\Osoba\Index.cshtml"
                                   Write(Global.kolicina);

#line default
#line hidden
                EndContext();
                BeginContext(1895, 1919, true);
                WriteLiteral(@"</td>
                                    <td>0.00 <br>RSD</td>
                                </tr>
                                <tr>
                                    <td style=""text-align: left "" colspan=""2""><b> Postarina:</b></td>
                                    <td>0.00 <br> RSD </td>
                                </tr>
                                <tr>
                                    <td style=""text-align: left "" colspan=""2""> <b>Ukupno:</b></td>
                                    <td class=""table-primary"">0.00 <br> RSD</td>
                                </tr>
                            </tbody>
                        </table>

                    </div>
                </div>
            </center>
        </div>
        <div style=""text-align: center"">
            <div>
                <p>

                    Hvala vam sto ste izabrali Facebook Shop ZMAJ za vas shoping. Vasa porudzbina je primljena. Placanje je prilikom preuzimanja(sigurna kupovina).

   ");
                WriteLiteral(@"             </p>

            </div>
            <div>
                <p>

                    Dostavu vrsi kurirska sluzba ROYAL EXPRESS.

                </p>
                <p>

                    Isporuka ce biti kroz 4-7 radnih dana.

                </p>

            </div>
            <div>
                <p>

                    Ukoliko ne dobijete vasu posiljku ni nakon 7 dana, javite nam se da mozemo proveriti sta se dogobilo.

                </p>

            </div>
            <div>
                <p>

                    OBAVEZNO OSTAVITE PRAVI BROJ MOBILNOG TELEFONA, KAKO BI VAS MOGLA KONTAKTIRATI KURIRSKA SLUZBA.

                </p>

            </div>
            <a href='javascript:history.go(-2)' style=""color:greenyellow ;border:solid"">klikni ovde da bi se vratio na stranicu sa proizvodima</a>
        </div>

    </div>
");
                EndContext();
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
            EndContext();
            BeginContext(3821, 21, true);
            WriteLiteral("\r\n\r\n</html>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebShop.Models.Osoba>> Html { get; private set; }
    }
}
#pragma warning restore 1591
