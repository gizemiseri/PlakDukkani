#pragma checksum "C:\Users\gizem.iseri\Desktop\PlakDukkani\PlakDukkani.UI.MVC\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce9154038148ea1163516338a30d218afa87278a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce9154038148ea1163516338a30d218afa87278a", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d56660a6bc46ea6371146a3a0e4bd13c11dd8bc3", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cart>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\gizem.iseri\Desktop\PlakDukkani\PlakDukkani.UI.MVC\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- ##### Hero Area Start ##### -->
<section class=""hero-area"">
    <div class=""hero-slides owl-carousel"">

        <!-- Single Hero Slide -->
        <div class=""single-hero-slide d-flex align-items-center justify-content-center"">
            <!-- Slide Img -->
            <div class=""slide-img bg-img"" style=""background-image: url(../../img/bg-img/bg-2.jpg);""></div>
            <!-- Slide Content -->
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""hero-slides-content text-center"">
                            <table class=""table table-dark"">
                                <thead>
                                    <tr>
                                        <th>Title</th>
                                        <th>Price</th>
                                        <th>Quantity</th>
                                        <th>Discount</th>
                                        <th>Sub");
            WriteLiteral("Total</th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\gizem.iseri\Desktop\PlakDukkani\PlakDukkani.UI.MVC\Views\Cart\Index.cshtml"
                                     foreach (var item in Model.GetCartItems)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 34 "C:\Users\gizem.iseri\Desktop\PlakDukkani\PlakDukkani.UI.MVC\Views\Cart\Index.cshtml"
                                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 35 "C:\Users\gizem.iseri\Desktop\PlakDukkani\PlakDukkani.UI.MVC\Views\Cart\Index.cshtml"
                                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td><input type=\"number\"");
            BeginWriteAttribute("value", " value=\"", 1582, "\"", 1604, 1);
#nullable restore
#line 36 "C:\Users\gizem.iseri\Desktop\PlakDukkani\PlakDukkani.UI.MVC\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1590, item.Quantity, 1590, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" min=\"0\" /></td>\r\n                                            <td>");
#nullable restore
#line 37 "C:\Users\gizem.iseri\Desktop\PlakDukkani\PlakDukkani.UI.MVC\Views\Cart\Index.cshtml"
                                           Write(item.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 39 "C:\Users\gizem.iseri\Desktop\PlakDukkani\PlakDukkani.UI.MVC\Views\Cart\Index.cshtml"
                                           Write(item.SubTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\gizem.iseri\Desktop\PlakDukkani\PlakDukkani.UI.MVC\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- ##### Hero Area End ##### -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
