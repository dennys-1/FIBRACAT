#pragma checksum "C:\Users\FLORES\Desktop\PROGRAMACION\CARLOS\FABRICAT\Views\Transaction\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bacc42883345f35f41cd0064269e943f5e804f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction_Index), @"mvc.1.0.view", @"/Views/Transaction/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Transaction/Index.cshtml", typeof(AspNetCore.Views_Transaction_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bacc42883345f35f41cd0064269e943f5e804f6", @"/Views/Transaction/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f576ac4a31474272c484b2351e42f5e8acc6e2f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Asp.netCoreMVCCRUD.Models.TransactionModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\FLORES\Desktop\PROGRAMACION\CARLOS\FABRICAT\Views\Transaction\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 26, true);
            WriteLiteral("\n\n<div id=\"view-all\">\n    ");
            EndContext();
            BeginContext(129, 42, false);
#line 9 "C:\Users\FLORES\Desktop\PROGRAMACION\CARLOS\FABRICAT\Views\Transaction\Index.cshtml"
Write(await Html.PartialAsync("_ViewAll", Model));

#line default
#line hidden
            EndContext();
            BeginContext(171, 531, true);
            WriteLiteral(@"
</div>

<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""form-modal"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title""></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">

            </div>
        </div>
    </div>
</div>


");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(719, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 30 "C:\Users\FLORES\Desktop\PROGRAMACION\CARLOS\FABRICAT\Views\Transaction\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Asp.netCoreMVCCRUD.Models.TransactionModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591