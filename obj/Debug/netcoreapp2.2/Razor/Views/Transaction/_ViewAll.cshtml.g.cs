#pragma checksum "C:\Users\FLORES\Desktop\PROGRAMACION\CARLOS\FABRICAT\Views\Transaction\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aae4ba43b2953bdd2ccd8a8fdb9630376352821e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction__ViewAll), @"mvc.1.0.view", @"/Views/Transaction/_ViewAll.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Transaction/_ViewAll.cshtml", typeof(AspNetCore.Views_Transaction__ViewAll))]
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
#line 2 "C:\Users\FLORES\Desktop\PROGRAMACION\CARLOS\FABRICAT\Views\_ViewImports.cshtml"
using Asp.netCoreMVCCRUD;

#line default
#line hidden
#line 3 "C:\Users\FLORES\Desktop\PROGRAMACION\CARLOS\FABRICAT\Views\_ViewImports.cshtml"
using Asp.netCoreMVCCRUD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aae4ba43b2953bdd2ccd8a8fdb9630376352821e", @"/Views/Transaction/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f576ac4a31474272c484b2351e42f5e8acc6e2f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Asp.netCoreMVCCRUD.Models.TransactionModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger ml-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'¿ESTAS SEGURO?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(63, 234, true);
            WriteLiteral("\n    <div class=\"row\">\n\n\n\n        <h1 class=\"text-center\"></i> REGISTRO VENTAS</h1>\n\n\n        <table class=\"table table-sm\">\n            <thead class=\"thead-dark\">\n                <tr>\n                    <th>\n                        ");
            EndContext();
            BeginContext(298, 42, false);
#line 14 "C:\Users\FLORES\Desktop\PROGRAMACION\CARLOS\FABRICAT\Views\Transaction\_ViewAll.cshtml"
                   Write(Html.DisplayNameFor(model => model.CORREO));

#line default
#line hidden
            EndContext();
            BeginContext(340, 76, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(417, 44, false);
#line 17 "C:\Users\FLORES\Desktop\PROGRAMACION\CARLOS\FABRICAT\Views\Transaction\_ViewAll.cshtml"
                   Write(Html.DisplayNameFor(model => model.TELEFONO));

#line default
#line hidden
            EndContext();
            BeginContext(461, 77, true);
            WriteLiteral("\n                    </th>\n                     <th>\n                        ");
            EndContext();
            BeginContext(539, 39, false);
#line 20 "C:\Users\FLORES\Desktop\PROGRAMACION\CARLOS\FABRICAT\Views\Transaction\_ViewAll.cshtml"
                   Write(Html.DisplayNameFor(model => model.DNI));

#line default
#line hidden
            EndContext();
            BeginContext(578, 77, true);
            WriteLiteral("\n                    </th>\n                     <th>\n                        ");
            EndContext();
            BeginContext(656, 45, false);
#line 23 "C:\Users\FLORES\Desktop\PROGRAMACION\CARLOS\FABRICAT\Views\Transaction\_ViewAll.cshtml"
                   Write(Html.DisplayNameFor(model => model.DIRECCION));

#line default
#line hidden
            EndContext();
            BeginContext(701, 77, true);
            WriteLiteral("\n                    </th>\n                     <th>\n                        ");
            EndContext();
            BeginContext(779, 45, false);
#line 26 "C:\Users\FLORES\Desktop\PROGRAMACION\CARLOS\FABRICAT\Views\Transaction\_ViewAll.cshtml"
                   Write(Html.DisplayNameFor(model => model.VELOCIDAD));

#line default
#line hidden
            EndContext();
            BeginContext(824, 76, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(901, 40, false);
#line 29 "C:\Users\FLORES\Desktop\PROGRAMACION\CARLOS\FABRICAT\Views\Transaction\_ViewAll.cshtml"
                   Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(941, 98, true);
            WriteLiteral("\n                    </th>\n                   \n                    <th>\n                        <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1039, "\"", 1147, 4);
            WriteAttributeValue("", 1049, "showInPopup(\'", 1049, 13, true);
#line 33 "C:\Users\FLORES\Desktop\PROGRAMACION\CARLOS\FABRICAT\Views\Transaction\_ViewAll.cshtml"
WriteAttributeValue("", 1062, Url.Action("AddOrEdit","Transaction",null,Context.Request.Scheme), 1062, 66, false);

#line default
#line hidden
            WriteAttributeValue("", 1128, "\',\'Nuevo", 1128, 8, true);
            WriteAttributeValue(" ", 1136, "Registro\')", 1137, 11, true);
            EndWriteAttribute();
            BeginContext(1148, 169, true);
            WriteLiteral(" class=\"btn btn-outline-success\"><i class=\"far fa-plus-square\"></i> Agregar</a>\n                    </th>\n                </tr>\n            </thead>\n            <tbody>\n");
            EndContext();
#line 38 "C:\Users\FLORES\Desktop\PROGRAMACION\CARLOS\FABRICAT\Views\Transaction\_ViewAll.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1380, 82, true);
            WriteLiteral("                    <tr>\n                        <td>\n                            ");
            EndContext();
            BeginContext(1463, 41, false);
#line 42 "C:\Users\FLORES\Desktop\PROGRAMACION\CARLOS\FABRICAT\Views\Transaction\_ViewAll.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CORREO));

#line default
#line hidden
            EndContext();
            BeginContext(1504, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(1593, 43, false);
#line 45 "C:\Users\FLORES\Desktop\PROGRAMACION\CARLOS\FABRICAT\Views\Transaction\_ViewAll.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TELEFONO));

#line default
#line hidden
            EndContext();
            BeginContext(1636, 89, true);
            WriteLiteral("\n                        </td>\n                         <td>\n                            ");
            EndContext();
            BeginContext(1726, 38, false);
#line 48 "C:\Users\FLORES\Desktop\PROGRAMACION\CARLOS\FABRICAT\Views\Transaction\_ViewAll.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DNI));

#line default
#line hidden
            EndContext();
            BeginContext(1764, 89, true);
            WriteLiteral("\n                        </td>\n                         <td>\n                            ");
            EndContext();
            BeginContext(1854, 44, false);
#line 51 "C:\Users\FLORES\Desktop\PROGRAMACION\CARLOS\FABRICAT\Views\Transaction\_ViewAll.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DIRECCION));

#line default
#line hidden
            EndContext();
            BeginContext(1898, 89, true);
            WriteLiteral("\n                        </td>\n                         <td>\n                            ");
            EndContext();
            BeginContext(1988, 44, false);
#line 54 "C:\Users\FLORES\Desktop\PROGRAMACION\CARLOS\FABRICAT\Views\Transaction\_ViewAll.cshtml"
                       Write(Html.DisplayFor(modelItem => item.VELOCIDAD));

#line default
#line hidden
            EndContext();
            BeginContext(2032, 113, true);
            WriteLiteral("\n                        </td>\n                        \n                        <td>\n                            ");
            EndContext();
            BeginContext(2146, 39, false);
#line 58 "C:\Users\FLORES\Desktop\PROGRAMACION\CARLOS\FABRICAT\Views\Transaction\_ViewAll.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2185, 153, true);
            WriteLiteral("\n                        </td>\n                        \n                        <td>\n                            <div>\n                                <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2338, "\"", 2464, 4);
            WriteAttributeValue("", 2348, "showInPopup(\'", 2348, 13, true);
#line 63 "C:\Users\FLORES\Desktop\PROGRAMACION\CARLOS\FABRICAT\Views\Transaction\_ViewAll.cshtml"
WriteAttributeValue("", 2361, Url.Action("AddOrEdit","Transaction",new {id=item.CID},Context.Request.Scheme), 2361, 79, false);

#line default
#line hidden
            WriteAttributeValue("", 2440, "\',\'Actualizar", 2440, 13, true);
            WriteAttributeValue(" ", 2453, "Registro\')", 2454, 11, true);
            EndWriteAttribute();
            BeginContext(2465, 81, true);
            WriteLiteral(" class=\"\"><i class=\"fas fa-pencil-alt\"></i> </a>\n                                ");
            EndContext();
            BeginContext(2546, 157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aae4ba43b2953bdd2ccd8a8fdb9630376352821e12257", async() => {
                BeginContext(2662, 37, true);
                WriteLiteral("<i class=\"fa fa-trash-alt fa-lg\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\FLORES\Desktop\PROGRAMACION\CARLOS\FABRICAT\Views\Transaction\_ViewAll.cshtml"
                                                         WriteLiteral(item.CID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2703, 92, true);
            WriteLiteral("\n                            </div>\n                        </td>\n                    </tr>\n");
            EndContext();
#line 68 "C:\Users\FLORES\Desktop\PROGRAMACION\CARLOS\FABRICAT\Views\Transaction\_ViewAll.cshtml"
                }

#line default
#line hidden
            BeginContext(2813, 48, true);
            WriteLiteral("            </tbody>\n        </table>\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Asp.netCoreMVCCRUD.Models.TransactionModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
