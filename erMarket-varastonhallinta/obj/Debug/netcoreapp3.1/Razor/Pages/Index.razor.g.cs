#pragma checksum "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b91a027afc0e343990227be645fd0746f37d206"
// <auto-generated/>
#pragma warning disable 1591
namespace erMarket_varastonhallinta.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using erMarket_varastonhallinta;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using erMarket_varastonhallinta.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using erMarket_varastonhallinta_DataLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"css/style.css\" rel=\"stylesheet\">\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, @"<div class=""row p-2"">
        <div class=""col-sm text-nowrap"">
            <div class=""text-left"" id=""company"">erMarket</div>
        </div>
        <div class=""col-md-auto"">
            <div class=""text-nowrap"" id=""title"">Varastonhallinta</div>
        </div>
        <div class=""col-md d-flex d-inline align-self-center justify-content-md-end text-nowrap"">
            <div class=""d-flex d-inline"">
                <img class=""flags"" src=""finnish.png"" alt=""FI"">
                <div>&emsp;</div>
                <img class=""flags"" src=""english.png"" alt=""EN"">
                <div>&emsp;</div>
                <img id=""pagecolor"" src=""darkmode.png"" alt=""Light/Dark"">
            </div>
        </div>
    </div>

    ");
            __builder.AddMarkupContent(5, "<div class=\"row pt-4\">\r\n        <div class=\"col text-center\">\r\n            Valitse myymälä, minkä tietoja haluat katsella tai muuttaa.\r\n        </div>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row d-flex justify-content-center");
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 31 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
         if (stores != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
             foreach (Store s in stores)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "                ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-auto py-3");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "class", "stores btn-primary");
            __builder.AddAttribute(16, "value", 
#nullable restore
#line 36 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                                                                             s.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                                                                                             (() => SelectedStore(s.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, 
#nullable restore
#line 36 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                                                                                                                           s.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 38 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "        ");
            __builder.AddMarkupContent(22, "<div class=\"col-auto py-3\">\r\n            <button type=\"button\" class=\"stores btn-info\">Muutosloki</button>\r\n        </div>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n");
#nullable restore
#line 45 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
     if (displayedInfo != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "        ");
            __builder.OpenElement(25, "h5");
            __builder.AddContent(26, 
#nullable restore
#line 47 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
             displayedInfo.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "row py-2 text-nowrap");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.AddMarkupContent(31, "<div class=\"col-sm-3\">Osoite:</div>\r\n            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col-sm");
            __builder.AddContent(34, 
#nullable restore
#line 50 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                                 displayedInfo.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "row py-2 text-nowrap");
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.AddMarkupContent(40, "<div class=\"col-sm-3\">Esimies:</div>\r\n            ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "col-sm");
            __builder.AddContent(43, 
#nullable restore
#line 54 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                                 displayedInfo.Supervisor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "row py-2 text-nowrap");
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.AddMarkupContent(49, "<div class=\"col-sm-3\">Puhelin:</div>\r\n            ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "col-sm");
            __builder.AddContent(52, 
#nullable restore
#line 58 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                                 displayedInfo.Phone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "row py-2 text-nowrap");
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.AddMarkupContent(58, "<div class=\"col-sm-3\">Sähköposti:</div>\r\n            ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col-sm");
            __builder.AddContent(61, 
#nullable restore
#line 62 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                                 displayedInfo.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
            __builder.AddContent(64, "        ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "row d-flex justify-content-center");
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "col-auto py-3");
            __builder.AddMarkupContent(70, "\r\n                ");
            __builder.OpenElement(71, "button");
            __builder.AddAttribute(72, "type", "button");
            __builder.AddAttribute(73, "class", "useractions btn-secondary");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                                                                                  (() => ChangeAction(0))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(75, "Tarkemmat tiedot");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n            ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "col-auto py-3");
            __builder.AddMarkupContent(80, "\r\n                ");
            __builder.OpenElement(81, "button");
            __builder.AddAttribute(82, "type", "button");
            __builder.AddAttribute(83, "class", "useractions btn-secondary");
            __builder.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                                                                                  (() => ChangeAction(1))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(85, "Selaa tuotteita");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n            ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "col-auto py-3");
            __builder.AddMarkupContent(90, "\r\n                ");
            __builder.OpenElement(91, "button");
            __builder.AddAttribute(92, "type", "button");
            __builder.AddAttribute(93, "class", "useractions btn-secondary");
            __builder.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                                                                                  (() => ChangeAction(2))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(95, "Lisää uusi tuote");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n");
#nullable restore
#line 76 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"

        // Additional Info.
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
         if (action == 0)
        {

        }

        // Browse products.
        else if (action == 1)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(99, "            ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "table-responsive");
            __builder.AddMarkupContent(102, "\r\n                ");
            __builder.OpenElement(103, "table");
            __builder.AddAttribute(104, "class", "table");
            __builder.AddMarkupContent(105, "\r\n                    ");
            __builder.AddMarkupContent(106, @"<thead>
                        <tr>
                            <th scope=""col"">Tuotteen nimi</th>
                            <th scope=""col"">Hinta</th>
                            <th scope=""col"">Määrä varastossa</th>
                            <th scope=""col"">Määrä muuttunut</th>
                            <th scope=""col"">Tuoteryhmät</th>
                        </tr>
                    </thead>
                    ");
            __builder.OpenElement(107, "tbody");
            __builder.AddMarkupContent(108, "\r\n");
#nullable restore
#line 98 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                         foreach (Product product in displayedInfo.Products)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(109, "                            ");
            __builder.OpenElement(110, "tr");
            __builder.AddMarkupContent(111, "\r\n                                ");
            __builder.OpenElement(112, "td");
            __builder.AddContent(113, 
#nullable restore
#line 101 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                                     product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                                ");
            __builder.OpenElement(115, "td");
            __builder.AddContent(116, 
#nullable restore
#line 102 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                                     product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                                ");
            __builder.OpenElement(118, "td");
            __builder.AddContent(119, 
#nullable restore
#line 103 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                                     product.InStock

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n                                ");
            __builder.OpenElement(121, "td");
            __builder.AddContent(122, 
#nullable restore
#line 104 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                                     product.QuantityChanged.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                                ");
            __builder.OpenElement(124, "td");
            __builder.AddMarkupContent(125, "\r\n                                    ");
            __builder.OpenElement(126, "select");
            __builder.AddAttribute(127, "class", "form-control-sm");
            __builder.AddMarkupContent(128, "\r\n");
#nullable restore
#line 107 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                                         foreach (ProductCategory category in product.Groups)
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(129, "                                            ");
            __builder.OpenElement(130, "option");
            __builder.AddContent(131, 
#nullable restore
#line 109 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                                                     category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n");
#nullable restore
#line 110 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(133, "                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n");
#nullable restore
#line 114 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(137, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n");
#nullable restore
#line 118 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
        }

        // Add new product.
        else if (action == 2)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(141, "            ");
            __builder.AddMarkupContent(142, "<h5>Lisää uusi tuote</h5>\r\n            ");
            __builder.OpenElement(143, "form");
            __builder.AddMarkupContent(144, "\r\n                ");
            __builder.AddMarkupContent(145, @"<div class=""row"">
                    <div class=""col-md-6 py-2"">
                        <label for=""productName"">Tuotteen nimi</label>
                        <input type=""text"" id=""productName"" class=""form-control"">
                    </div>
                    <div class=""col-md-6 py-2"">
                        <label for=""price"">Tuotteen hinta</label>
                        <input type=""text"" id=""price"" class=""form-control"">
                    </div>
                    <div class=""col-md-6 py-2"">
                        <label for=""amount"">Lisättävä kappalemäärä</label>
                        <input type=""text"" id=""amount"" class=""form-control"">
                    </div>
                </div>
                ");
            __builder.AddMarkupContent(146, "<div>Valitse tuoterymät</div>\r\n                ");
            __builder.OpenElement(147, "div");
            __builder.AddAttribute(148, "class", "row text-nowrap");
            __builder.AddMarkupContent(149, "\r\n");
#nullable restore
#line 141 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                     foreach (ProductCategory category in categories)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(150, "                        ");
            __builder.OpenElement(151, "div");
            __builder.AddAttribute(152, "class", "col-sm-6 py-2");
            __builder.AddMarkupContent(153, "\r\n                            ");
            __builder.OpenElement(154, "input");
            __builder.AddAttribute(155, "type", "checkbox");
            __builder.AddAttribute(156, "id", 
#nullable restore
#line 144 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                                                        category.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(157, "name", 
#nullable restore
#line 144 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                                                                            category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n                            ");
            __builder.OpenElement(159, "label");
            __builder.AddAttribute(160, "for", 
#nullable restore
#line 145 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                                         category.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(161, 
#nullable restore
#line 145 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                                                       category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n");
#nullable restore
#line 147 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(164, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n                <input type=\"button\" class=\"btn-primary\" value=\"Lisää tuote\">\r\n                <div class=\"py-3\"></div>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n");
#nullable restore
#line 152 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
        }

        // Error case. Only for testing.
        else
        {
            throw new Exception();
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 158 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(167, "\r\n\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 166 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
 
    static List<ProductCategory> categories = AllCategories.GetProductCategories();
    List<Store> stores = AllStores.GetStores(categories);
    Store displayedInfo = null;
    int action = 0;

    private void SelectedStore(int id)
    {
        foreach (Store s in stores)
        {
            if (s.Id == id)
            {
                displayedInfo = s;
                break;
            }
        }
    }

    private void ChangeAction(int selected)
    {
        action = selected;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
