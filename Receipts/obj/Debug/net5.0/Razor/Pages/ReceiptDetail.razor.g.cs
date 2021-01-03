#pragma checksum "/workspaces/Cooking-Recipe/Receipts/Pages/ReceiptDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3109f9162fa88a9a8203c7d9d2e85bdb1a6eeee8"
// <auto-generated/>
#pragma warning disable 1591
namespace Receipts.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Threading.Tasks;
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
#line 3 "/workspaces/Cooking-Recipe/Receipts/Pages/ReceiptDetail.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/workspaces/Cooking-Recipe/Receipts/Pages/ReceiptDetail.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/workspaces/Cooking-Recipe/Receipts/Pages/ReceiptDetail.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/workspaces/Cooking-Recipe/Receipts/Pages/ReceiptDetail.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/recipe/{id}")]
    public partial class ReceiptDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    h1 {text-align: center;}\r\n    img {align-self: center;}\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "h1");
            __builder.AddContent(2, 
#nullable restore
#line 15 "/workspaces/Cooking-Recipe/Receipts/Pages/ReceiptDetail.razor"
     receipt.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 16 "/workspaces/Cooking-Recipe/Receipts/Pages/ReceiptDetail.razor"
 if(!string.IsNullOrEmpty(receipt.ImageUrl))
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "img");
            __builder.AddAttribute(4, "src", 
#nullable restore
#line 18 "/workspaces/Cooking-Recipe/Receipts/Pages/ReceiptDetail.razor"
              receipt.ImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "alt", "Italian Trulli");
            __builder.AddAttribute(6, "style", "width:500px;");
            __builder.CloseElement();
#nullable restore
#line 19 "/workspaces/Cooking-Recipe/Receipts/Pages/ReceiptDetail.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<br><br>\r\n\r\n");
            __builder.AddMarkupContent(8, "<h4>Descrição</h4>\r\n");
            __builder.OpenElement(9, "p");
            __builder.AddContent(10, 
#nullable restore
#line 23 "/workspaces/Cooking-Recipe/Receipts/Pages/ReceiptDetail.razor"
    receipt.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.AddMarkupContent(12, "<h4>Ingredientes</h4>\r\n");
            __builder.OpenElement(13, "table");
            __builder.AddAttribute(14, "class", "table");
            __builder.AddMarkupContent(15, "<thead><tr><th>Quantidade</th>\r\n            <th>Ingrediente</th></tr></thead>\r\n            ");
            __builder.OpenElement(16, "tbody");
#nullable restore
#line 33 "/workspaces/Cooking-Recipe/Receipts/Pages/ReceiptDetail.razor"
                 foreach(var ingredient in receipt.Ingredients)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "tr");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 36 "/workspaces/Cooking-Recipe/Receipts/Pages/ReceiptDetail.razor"
                             ingredient.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 37 "/workspaces/Cooking-Recipe/Receipts/Pages/ReceiptDetail.razor"
                             ingredient.Ingredient

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "/workspaces/Cooking-Recipe/Receipts/Pages/ReceiptDetail.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n");
            __builder.AddMarkupContent(24, "<h4>Passos</h4>");
#nullable restore
#line 44 "/workspaces/Cooking-Recipe/Receipts/Pages/ReceiptDetail.razor"
 foreach(var step in receipt.Steps)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "p");
            __builder.AddContent(26, " - ");
            __builder.AddContent(27, 
#nullable restore
#line 46 "/workspaces/Cooking-Recipe/Receipts/Pages/ReceiptDetail.razor"
           step.Step

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 47 "/workspaces/Cooking-Recipe/Receipts/Pages/ReceiptDetail.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "/workspaces/Cooking-Recipe/Receipts/Pages/ReceiptDetail.razor"
       
    [Parameter]
    public string Id { get; set; }
    private Receipt receipt = new Receipt();
    private List<StepRecipe> steps = new List<StepRecipe>();
    private List<IngredientRecipe> ingredients = new List<IngredientRecipe>();

    protected override async Task OnInitializedAsync()
    {
        receipt = await _receiptRepository.FirstOrDefault(x => x.Id ==Guid.Parse(Id));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.Repositories.Interface.IAsyncRepository<Receipt> _receiptRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.Services.ReceiptService _receiptService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.DataBase.DataContext _context { get; set; }
    }
}
#pragma warning restore 1591
