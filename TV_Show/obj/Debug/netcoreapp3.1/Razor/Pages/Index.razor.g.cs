#pragma checksum "D:\Projects\TV_Show\TV_Show.git\TV_Show\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c00447028c5a246179e7090da72bbb4acc38f955"
// <auto-generated/>
#pragma warning disable 1591
namespace TV_Show.Pages
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
#nullable restore
#line 2 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Pages\Index.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Pages\Index.razor"
using MongoDB.Driver;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Pages\Index.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row\" style=\"margin-left: auto; margin-right: auto;\">\r\n    <div class=\"col text-center\">\r\n        <h1>Рекомендации</h1>\r\n    </div>\r\n</div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddAttribute(3, "style", "margin-left: auto; margin-right: auto; position: relative;");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "id", "recommendationCarousel");
            __builder.AddAttribute(7, "class", "carousel slide");
            __builder.AddAttribute(8, "data-ride", "carousel");
            __builder.AddAttribute(9, "style", "height: inherit;");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "ol");
            __builder.AddAttribute(12, "class", "carousel-indicators");
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "li");
            __builder.AddAttribute(15, "data-target", "#recommendationCarousel");
            __builder.AddAttribute(16, "data-slide-to", "0");
            __builder.AddAttribute(17, "class", 
#nullable restore
#line 15 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Pages\Index.razor"
                                                                                currentSlide

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "li");
            __builder.AddAttribute(20, "data-target", "#recommendationCarousel");
            __builder.AddAttribute(21, "data-slide-to", "1");
            __builder.AddAttribute(22, "class", 
#nullable restore
#line 16 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Pages\Index.razor"
                                                                                secondSlide

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "li");
            __builder.AddAttribute(25, "data-target", "#recommendationCarousel");
            __builder.AddAttribute(26, "data-slide-to", "2");
            __builder.AddAttribute(27, "class", 
#nullable restore
#line 17 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Pages\Index.razor"
                                                                                thirdSlide

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "carousel-inner");
            __builder.AddAttribute(32, "style", "height: inherit;");
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "carousel-item" + " " + (
#nullable restore
#line 20 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Pages\Index.razor"
                                       firstSlide

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "style", "height: inherit;");
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.AddMarkupContent(38, "<a href=\"/GameofThrones\" style=\"height: inherit\">\r\n                    <img class=\"d-block w-100\" src=\"/got.jpg\" alt=\"Game of Thrones\" style=\"height: inherit;\">\r\n                </a>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "carousel-item" + " " + (
#nullable restore
#line 25 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Pages\Index.razor"
                                       secondSlide

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "style", "height: inherit; width: inherit;");
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.AddMarkupContent(44, "<a href=\"/Supernatural\" style=\"height: inherit; width: inherit;\">\r\n                    <img class=\"d-block w-100\" src=\"/spn.jpg\" alt=\"Supernatural\" style=\"height: inherit; width: inherit;\">\r\n                </a>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "carousel-item" + " " + (
#nullable restore
#line 30 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Pages\Index.razor"
                                       thirdSlide

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "style", "height: inherit;");
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.AddMarkupContent(50, "<a href=\"/TheBigBangTheory\" style=\"height:inherit\">\r\n                    <img class=\"d-block w-100\" src=\"/tbbt.jpg\" alt=\"The Big Bang Theory\" style=\"height:inherit;\">\r\n                </a>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.OpenElement(53, "a");
            __builder.AddAttribute(54, "class", "carousel-control-prev");
            __builder.AddAttribute(55, "href", "");
            __builder.AddAttribute(56, "role", "button");
            __builder.AddAttribute(57, "data-slide", "prev");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Pages\Index.razor"
                                                                                           ()=>Manually(true)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(59, "\r\n            <span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span>\r\n            ");
            __builder.AddMarkupContent(60, "<span class=\"sr-only\">Previous</span>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.OpenElement(62, "a");
            __builder.AddAttribute(63, "class", "carousel-control-next");
            __builder.AddAttribute(64, "href", "");
            __builder.AddAttribute(65, "role", "button");
            __builder.AddAttribute(66, "data-slide", "next");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Pages\Index.razor"
                                                                                           ()=>Manually(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(68, "\r\n            <span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span>\r\n            ");
            __builder.AddMarkupContent(69, "<span class=\"sr-only\">Next</span>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n\r\n");
            __builder.OpenComponent<TV_Show.Shared.SerialListTable>(73);
            __builder.AddAttribute(74, "Serials", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<TV_Show.Models.Serials>>(
#nullable restore
#line 47 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Pages\Index.razor"
                          serials

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Pages\Index.razor"
       

    List<Serials> serials = new List<Serials>();

    string firstSlide = "active";
    string secondSlide = "";
    string thirdSlide = "";

    int currentPosition = 0;
    int currentSlide = 0;

    CancellationTokenSource cts;
    CancellationToken ct;

    protected override async Task OnInitializedAsync()
    {
        cts = new CancellationTokenSource();
        ct = cts.Token;
        Walkthrough(ct);

        StreamReader r = new StreamReader(Path.GetFullPath("serials.txt"));
        string s = null;
        while ((s = r.ReadLine()) != null)
        {
            Serials x = new Serials();
            x.SerialName = s;
            x.SerialNameEng = r.ReadLine();
            x.ReleaseDate = r.ReadLine();
            x.FinishDate = r.ReadLine();
            x.SeriesTime = int.Parse(r.ReadLine());
            x.Seasons = int.Parse(r.ReadLine());
            x.About = r.ReadLine();
            serials.Add(x);
        }
        r.Close();
    }

    public async Task Walkthrough(CancellationToken ct)
    {
        while (!ct.IsCancellationRequested)
        {
            await Task.Delay(3000, ct);
            currentPosition++;
            ChangeSlide();
            await InvokeAsync(() => this.StateHasChanged());
        }
    }

    public void Manually(bool backwards)
    {
        cts.Cancel();

        if (backwards)
            currentPosition--;
        else
            currentPosition++;

        ChangeSlide();
    }

    private void ChangeSlide()
    {
        currentSlide = Math.Abs(currentPosition % 3);

        switch (currentSlide)
        {
            case 0:
                firstSlide = "active";
                secondSlide = "";
                thirdSlide = "";
                break;
            case 1:
                firstSlide = "";
                secondSlide = "active";
                thirdSlide = "";
                break;
            case 2:
                firstSlide = "";
                secondSlide = "";
                thirdSlide = "active";
                break;
            default:
                break;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
