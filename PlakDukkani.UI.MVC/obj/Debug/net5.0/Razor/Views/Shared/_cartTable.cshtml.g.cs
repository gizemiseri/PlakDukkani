#pragma checksum "C:\Users\gizem.iseri\Desktop\PlakDukkani\PlakDukkani.UI.MVC\Views\Shared\_cartTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b67125e29f4f327873bfd5ea2a50f62bab97c1a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__cartTable), @"mvc.1.0.view", @"/Views/Shared/_cartTable.cshtml")]
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
#line 2 "C:\Users\gizem.iseri\Desktop\PlakDukkani\PlakDukkani.UI.MVC\Views\_ViewImports.cshtml"
using PlakDukkani.ViewModel.AlbumViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gizem.iseri\Desktop\PlakDukkani\PlakDukkani.UI.MVC\Views\_ViewImports.cshtml"
using PlakDukkani.ViewModel.UserViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gizem.iseri\Desktop\PlakDukkani\PlakDukkani.UI.MVC\Views\_ViewImports.cshtml"
using PlakDukkani.ViewModel.CartViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b67125e29f4f327873bfd5ea2a50f62bab97c1a0", @"/Views/Shared/_cartTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d56660a6bc46ea6371146a3a0e4bd13c11dd8bc3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__cartTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cart>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\gizem.iseri\Desktop\PlakDukkani\PlakDukkani.UI.MVC\Views\Shared\_cartTable.cshtml"
 foreach (var item in Model.GetCartItems)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 6 "C:\Users\gizem.iseri\Desktop\PlakDukkani\PlakDukkani.UI.MVC\Views\Shared\_cartTable.cshtml"
       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 7 "C:\Users\gizem.iseri\Desktop\PlakDukkani\PlakDukkani.UI.MVC\Views\Shared\_cartTable.cshtml"
       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><input");
            BeginWriteAttribute("onchange", " onchange=\"", 149, "\"", 192, 4);
            WriteAttributeValue("", 160, "CartUpdate(", 160, 11, true);
#nullable restore
#line 8 "C:\Users\gizem.iseri\Desktop\PlakDukkani\PlakDukkani.UI.MVC\Views\Shared\_cartTable.cshtml"
WriteAttributeValue("", 171, item.ID, 171, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 179, ",", 179, 1, true);
            WriteAttributeValue(" ", 180, "this.value)", 181, 12, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"number\"");
            BeginWriteAttribute("value", " value=\"", 207, "\"", 229, 1);
#nullable restore
#line 8 "C:\Users\gizem.iseri\Desktop\PlakDukkani\PlakDukkani.UI.MVC\Views\Shared\_cartTable.cshtml"
WriteAttributeValue("", 215, item.Quantity, 215, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" min=\"0\" /></td>\r\n        <td>");
#nullable restore
#line 9 "C:\Users\gizem.iseri\Desktop\PlakDukkani\PlakDukkani.UI.MVC\Views\Shared\_cartTable.cshtml"
       Write(item.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n            ");
#nullable restore
#line 11 "C:\Users\gizem.iseri\Desktop\PlakDukkani\PlakDukkani.UI.MVC\Views\Shared\_cartTable.cshtml"
       Write(item.SubTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 14 "C:\Users\gizem.iseri\Desktop\PlakDukkani\PlakDukkani.UI.MVC\Views\Shared\_cartTable.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591