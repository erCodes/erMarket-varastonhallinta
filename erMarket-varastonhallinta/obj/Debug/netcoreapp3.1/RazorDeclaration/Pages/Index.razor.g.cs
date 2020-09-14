#pragma checksum "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75924613ccb88544043e4a3eb493967030e1712e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using erMarket_varastonhallinta;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using erMarket_varastonhallinta.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 165 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
 
    static List<ProductCategory> categories = AllCategories.GetProductCategories();
    List<Store> stores = AllStores.GetStores(categories);
    Store displayedInfo = null;
    int action = 0;

    string newProductName;
    string newProductQuantity;
    List<ProductCategory> newProductCategories = new List<ProductCategory>();

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

    private void CheckboxClicked(ProductCategory category, object checkedCategory)
    {
        if ((bool)checkedCategory)
        {
            if (!newProductCategories.Contains(category))
            {
                newProductCategories.Add(category);
            }
        }

        else
        {
            if (newProductCategories.Contains(category))
            {
                newProductCategories.Remove(category);
            }
        }
    }

    private async Task AddNewProduct()
    {
        HttpClient Http = new HttpClient();
        NewProductToDb productToDb = new NewProductToDb {
            Store = displayedInfo.Id,
            Name = newProductName,
            InStock = newProductQuantity,
            Groups = newProductCategories,
            QuantityChanged = DateTime.Now
        };

        string json = JsonSerializer.Serialize(productToDb);
        var response = await Http.PostAsJsonAsync("http://localhost:54859/api/newproduct", json);
        NewProductToDb data = await response.Content.ReadAsAsync<NewProductToDb>();

        if (response.IsSuccessStatusCode)
        {

        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
