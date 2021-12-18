#pragma checksum "D:\Projects\TV_Show\TV_Show.git\TV_Show\Shared\SerialListTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4da88b26763777218a065d3f13d9de59c0739c85"
// <auto-generated/>
#pragma warning disable 1591
namespace TV_Show.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\TV_Show\TV_Show.git\TV_Show\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\TV_Show\TV_Show.git\TV_Show\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\TV_Show\TV_Show.git\TV_Show\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\TV_Show\TV_Show.git\TV_Show\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\TV_Show\TV_Show.git\TV_Show\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\TV_Show\TV_Show.git\TV_Show\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\TV_Show\TV_Show.git\TV_Show\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\TV_Show\TV_Show.git\TV_Show\_Imports.razor"
using TV_Show;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\TV_Show\TV_Show.git\TV_Show\_Imports.razor"
using TV_Show.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\TV_Show\TV_Show.git\TV_Show\_Imports.razor"
using TV_Show.Models;

#line default
#line hidden
#nullable disable
    public partial class SerialListTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "table-responsive");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddAttribute(5, "table-striped", true);
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "thead");
            __builder.AddAttribute(8, "class", "thead-light");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<th>Serial Name</th>\r\n                ");
            __builder.AddMarkupContent(13, "<th>Count of Seasons</th>\r\n                ");
            __builder.AddMarkupContent(14, "<th>Year</th>\r\n                ");
            __builder.OpenElement(15, "th");
            __builder.AddContent(16, "Add Serial To Your Checklist ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "checkbox");
            __builder.AddAttribute(19, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Shared\SerialListTable.razor"
                                                                               displayButtons

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => displayButtons = __value, displayButtons));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "tbody");
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 12 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Shared\SerialListTable.razor"
             if (Serials == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "                ");
            __builder.AddMarkupContent(27, "<tr>LOADING DATA...</tr>\r\n");
#nullable restore
#line 15 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Shared\SerialListTable.razor"
            }
            else if (Serials.Count == 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "                ");
            __builder.AddMarkupContent(29, "<tr>No items in array</tr>\r\n");
#nullable restore
#line 19 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Shared\SerialListTable.razor"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Shared\SerialListTable.razor"
                 foreach (var item in Serials)
                {
                    

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "                    ");
            __builder.OpenComponent<TV_Show.Shared.AllSerials>(31);
            __builder.AddAttribute(32, "Serials", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TV_Show.Models.Serials>(
#nullable restore
#line 29 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Shared\SerialListTable.razor"
                                         item

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "IsTable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Shared\SerialListTable.razor"
                                                        true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "DisplayButtons", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Shared\SerialListTable.razor"
                                                                              displayButtons

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 30 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Shared\SerialListTable.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Shared\SerialListTable.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Shared\SerialListTable.razor"
       
    [Parameter] public List<Serials> Serials { get; set; }

    bool displayButtons = false;


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
