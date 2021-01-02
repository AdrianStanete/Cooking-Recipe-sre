#pragma checksum "/workspaces/Cooking-Recipe/Receipts/Pages/ListRecipies.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d0196c6b8ca33707eb8500445f0819123d70c46"
// <auto-generated/>
#pragma warning disable 1591
namespace Receipts.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/workspaces/Cooking-Recipe/Receipts/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/workspaces/Cooking-Recipe/Receipts/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/workspaces/Cooking-Recipe/Receipts/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/workspaces/Cooking-Recipe/Receipts/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/workspaces/Cooking-Recipe/Receipts/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/workspaces/Cooking-Recipe/Receipts/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/workspaces/Cooking-Recipe/Receipts/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/workspaces/Cooking-Recipe/Receipts/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/workspaces/Cooking-Recipe/Receipts/_Imports.razor"
using Receipts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/workspaces/Cooking-Recipe/Receipts/_Imports.razor"
using Receipts.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/workspaces/Cooking-Recipe/Receipts/Pages/ListRecipies.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listrecipes")]
    public partial class ListRecipies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>");
#nullable restore
#line 10 "/workspaces/Cooking-Recipe/Receipts/Pages/ListRecipies.razor"
 if (receipts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "/workspaces/Cooking-Recipe/Receipts/Pages/ListRecipies.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Id</th>\r\n                <th>Name</th>\r\n                <th>CreatedDate</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 25 "/workspaces/Cooking-Recipe/Receipts/Pages/ListRecipies.razor"
             foreach (var receipt in receipts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 28 "/workspaces/Cooking-Recipe/Receipts/Pages/ListRecipies.razor"
                         receipt.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 29 "/workspaces/Cooking-Recipe/Receipts/Pages/ListRecipies.razor"
                         receipt.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 30 "/workspaces/Cooking-Recipe/Receipts/Pages/ListRecipies.razor"
                         receipt.CreatedDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "/workspaces/Cooking-Recipe/Receipts/Pages/ListRecipies.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "/workspaces/Cooking-Recipe/Receipts/Pages/ListRecipies.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "/workspaces/Cooking-Recipe/Receipts/Pages/ListRecipies.razor"
       
    private List<Receipt> receipts = new List<Receipt>();

    protected override async Task OnInitializedAsync()
    {
        receipts = await _receiptService.ListAll();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.Services.ReceiptService _receiptService { get; set; }
    }
}
#pragma warning restore 1591
