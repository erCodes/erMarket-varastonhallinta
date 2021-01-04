#pragma checksum "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "703614ed71ec96fbc3f018f42fbfff9a1f0f7631"
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
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using erMarket_varastonhallinta;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
using erMarket_varastonhallinta.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\_Imports.razor"
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
#line 173 "D:\Sekalaiset tiedostot\erMarket-varastonhallinta\erMarket-varastonhallinta\Pages\Index.razor"
 
    static List<ProductCategory> categories = new List<ProductCategory>();
    List<Store> stores = new List<Store>();
    Store displayedInfo = null;
    int action = 0;
    int newValue = 0;

    string newProductName;
    string newProductQuantity;
    List<ProductCategory> newProductCategories = new List<ProductCategory>();

    protected override async Task OnInitializedAsync()
    {
        await GetAllStores();
        await GetAllCategories();
    }

    private async Task GetAllStores()
    {
        HttpClient Http = new HttpClient();
        var response = await Http.GetAsync("http://localhost:54859/api/getstorenames");

        if (response.StatusCode == HttpStatusCode.OK)
        {
            stores = await response.Content.ReadAsAsync<List<Store>>();
        }

        else if (response.StatusCode == HttpStatusCode.NoContent)
        {
            // If there are no stores.
        }

        // Error case. Only for testing.
        else
        {
            throw new Exception();
        }
    }

    private async Task GetAllCategories()
    {
        HttpClient Http = new HttpClient();
        var response = await Http.GetAsync("http://localhost:54859/api/getallcategories");

        if (response.StatusCode == HttpStatusCode.OK)
        {
            categories = await response.Content.ReadAsAsync<List<ProductCategory>>();
        }

        else if (response.StatusCode == HttpStatusCode.NoContent)
        {

        }

        // Error case. Only for testing.
        else
        {
            throw new Exception();
        }
    }

    private async Task SelectedStore(int id)
    {
        foreach (Store s in stores)
        {
            if (s.Id == id)
            {
                displayedInfo = s;
                break;
            }
        }

        await GetSelectedStoresData();
    }

    private async Task GetSelectedStoresData()
    {
        HttpClient Http = new HttpClient();
        string json = JsonSerializer.Serialize(displayedInfo.Id);
        var response = await Http.GetAsync("http://localhost:54859/api/getstoresdata?storeid=" + displayedInfo.Id);
        Store data = await response.Content.ReadAsAsync<Store>();
        displayedInfo = data;
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

            else
            {
                throw new Exception();
            }
        }
    }

    private async Task AddNewProduct()
    {
        HttpClient Http = new HttpClient();
        NewProductToDb productToDb = new NewProductToDb
        {
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
            await GetSelectedStoresData();
        }
    }

    private async Task TakeNewValue(string store, int productId)
    {
        string elementsId = store + "+" + productId.ToString();

        string value = await JS.InvokeAsync<string>("TakeNewValue", elementsId);

        if (int.TryParse(value, out int num))
        {
            await ChangeProductsQuantity(productId, num);
        }

    }

    private async Task ChangeProductsQuantity(int productsId, int newQuantity)
    {
        HttpClient Http = new HttpClient();

        ProductToBeChanged productToBeChanged = new ProductToBeChanged
        {
            StoresId = displayedInfo.Id,
            ProductsId = productsId,
            NewQuantity = newQuantity,
            QuantityChanged = DateTime.Now
        };

        string json = JsonSerializer.Serialize(productToBeChanged);
        var response = await Http.PutAsJsonAsync("http://localhost:54859/api/changeproductquantity", json);

        if (response.IsSuccessStatusCode)
        {

        }
    }

    private async Task RemoveProduct(int storesId, int productsId)
    {
        HttpClient Http = new HttpClient();

        var response = await Http.DeleteAsync($"http://localhost:54859/api/removeproduct/?id={storesId}&ide={productsId}");

        if (response.IsSuccessStatusCode)
        {

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
