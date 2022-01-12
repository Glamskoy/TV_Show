// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Pages\Index.razor"
       
    GoT test;

    List<Serials> serials = new List<Serials>();

    [Parameter] public GoT GoT { get; set; }

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
            x.Seasons = int.Parse(r.ReadLine());
            x.Year = int.Parse(r.ReadLine());
            serials.Add(x);
        }
        r.Close();



        //var connectionString = "mongodb://localhost";
        //var client = new MongoClient(connectionString);
        //var db = client.GetDatabase("TV_Shows");
        //var collection = db.GetCollection<Serials>("Serials").AsQueryable();
        //foreach (var item in collection)
        //{
        //    Serials ser = new Serials(item.SerialName, item.Seasons, item.Year);
        //    serials.Add(ser);
        //}

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

    private void FromBlazorToDBToUser()
    {
        var connectionString = "mongodb://localhost";
        var client = new MongoClient(connectionString);
        var db = client.GetDatabase("TV_Shows");
        var collection = db.GetCollection<GoT>("GameofThrones");
        test = collection.Find(x => x.SeriesName == "Winter is Coming").FirstOrDefault();
        //foreach (var item in collection)
        //{
        //    User.AddUserSerialsToDb(new User(item.SerialName, item.SerialSeason, item.SeriesNumber, item.SeriesName));
        //}
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
