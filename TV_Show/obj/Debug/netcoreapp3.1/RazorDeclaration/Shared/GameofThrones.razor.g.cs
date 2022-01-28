// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 5 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Shared\GameofThrones.razor"
using MongoDB.Driver;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Shared\GameofThrones.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GameofThrones")]
    public partial class GameofThrones : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 531 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Shared\GameofThrones.razor"
       
    public string UserLogin { get; set; }
    public string UserPassword { get; set; }

    public bool IsUserLogged { get; set; }

    public bool UserWatch { get; set; }
    public bool UserWillWatch { get; set; }
    public bool UserStopWatch { get; set; }
    public bool UserDoesntWatch { get; set; }

    public int CurrentUserRating { get; set; }
    int currentUserRating;
    int rating = 0;
    public double AllUsersRating { get; set; }
    double allUsersRating = 0;
    public int UserCount { get; set; }
    int userCount = 0;

    public int GoTSeriesCount { get; set; }
    int goTSeriesCount = 0;
    public int GoTTimeCount { get; set; }
    int goTTimeCount = 0;

    [Parameter] public GoT GoT { get; set; }
    List<GoT> got = new List<GoT>();

    string date;
    string information;
    int seasons;
    int seriesTime = 57;

    protected override async Task OnInitializedAsync()
    {
        StreamReader rr = new StreamReader(Path.GetFullPath("got.txt"));
        string ss = null;
        while ((ss = rr.ReadLine()) != null)
        {
            GoT x = new GoT();
            x.SerialName = ss;
            x.SerialNameEng = rr.ReadLine();
            x.SerialSeason = int.Parse(rr.ReadLine());
            x.SeriesNumber = int.Parse(rr.ReadLine());
            x.SeriesName = rr.ReadLine();
            got.Add(x);
            goTSeriesCount++;
        }
        rr.Close();

        UserLogin = await storage.GetItemAsync<string>("UserLogin");
        UserPassword = await storage.GetItemAsync<string>("UserPassword");
        IsUserLogged = await storage.GetItemAsync<bool>("IsUserLogged");

        var connectionStringGoT = "mongodb://localhost";
        var clientGoT = new MongoClient(connectionStringGoT);
        var dbGoT = clientGoT.GetDatabase("TV_Shows");
        var collectionGoT = dbGoT.GetCollection<GoT>("GameofThrones");
        if (collectionGoT.Find(x => x.SerialNameEng == "Game of Thrones").CountDocuments() == 0)
            FromBlazorToDBToSerial();

        goTTimeCount = 57 * goTSeriesCount;

        await storage.SetItemAsync<int>("GoTSeriesCount", goTSeriesCount);
        await storage.SetItemAsync<int>("GoTTimeCount", goTTimeCount);

        UserWatch = await storage.GetItemAsync<bool>("UserWatch");
        UserWillWatch = await storage.GetItemAsync<bool>("UserWillWatch");
        UserStopWatch = await storage.GetItemAsync<bool>("UserStopWatch");
        UserDoesntWatch = await storage.GetItemAsync<bool>("UserDoesntWatch");

        var connectionStringSerials = "mongodb://localhost";
        var clientSerials = new MongoClient(connectionStringSerials);
        var dbSerials = clientSerials.GetDatabase("TV_Shows");
        var collectionSerials = dbSerials.GetCollection<Serials>("Serials");
        if (collectionSerials.Find(x => x.SerialNameEng == "Game of Thrones").CountDocuments() > 0)
        {
            Serials ser = new Serials();
            ser.ReleaseDate = collectionSerials.Find(x => x.SerialNameEng == "Game of Thrones").FirstOrDefault().ReleaseDate;
            ser.FinishDate = collectionSerials.Find(x => x.SerialNameEng == "Game of Thrones").FirstOrDefault().FinishDate;
            ser.Seasons = collectionSerials.Find(x => x.SerialNameEng == "Game of Thrones").FirstOrDefault().Seasons;
            ser.About = collectionSerials.Find(x => x.SerialNameEng == "Game of Thrones").FirstOrDefault().About;
            date = ser.ReleaseDate + " - " + ser.FinishDate;
            seasons = ser.Seasons;
            information = ser.About;
        }

        var connectionStringUserRating = "mongodb://localhost";
        var clientUserRating = new MongoClient(connectionStringUserRating);
        var dbUserRating = clientUserRating.GetDatabase("TV_Show");
        var collectionUserRating = dbUserRating.GetCollection<UserRating>("UserRating");
        if (collectionUserRating.Find(x => x.SerialNameEng == "Game of Thrones").CountDocuments() > 0)
        {
            UserRating ur = new UserRating();
            ur.SingleUserRating = collectionUserRating.Find(x => x.SerialNameEng == "Game of Thrones").FirstOrDefault().SingleUserRating;
            currentUserRating = ur.SingleUserRating;
        }

        CurrentUserRating = await storage.GetItemAsync<int>("CurrentUserRating");

        var connectionStringUserSeries = "mongodb://localhost";
        var clientUserSeries = new MongoClient(connectionStringUserSeries);
        var dbUserSeries = clientUserSeries.GetDatabase("TV_Shows");
        var collectionUserSeries = dbUserSeries.GetCollection<UserSeries>("UserSeries");
        if (collectionUserSeries.Find(x => x.SerialNameEng == "Game of Thrones").CountDocuments() > 0)
        {
            if (CurrentUserRating != 0)
            {
                userCount++;
                allUsersRating += currentUserRating;
                await storage.SetItemAsync<double>("AllUsersRating", allUsersRating / userCount + allUsersRating % userCount);
                await storage.SetItemAsync<int>("UserCount", userCount);
                AllUsersRating = await storage.GetItemAsync<double>("AllUsersRating");
                UserCount = await storage.GetItemAsync<int>("UserCount");
            }
        }
    }

    private void FromBlazorToDBToSerial()
    {
        foreach (var item in got)
        {
            GoT.AddSeriesGoTToDb(new GoT(item.SerialName, item.SerialNameEng, item.SerialSeason, item.SeriesNumber,
                item.SeriesName));
        }
    }

    async Task UserIsWatchingAsync()
    {
        await storage.SetItemAsync<bool>("UserWatch", true);
        await storage.SetItemAsync<bool>("UserWillWatch", false);
        await storage.SetItemAsync<bool>("UserStopWatch", false);
        await storage.SetItemAsync<bool>("UserDoesntWatch", false);

        UserWatch = await storage.GetItemAsync<bool>("UserWatch");
        UserWillWatch = await storage.GetItemAsync<bool>("UserWillWatch");
        UserStopWatch = await storage.GetItemAsync<bool>("UserStopWatch");
        UserDoesntWatch = await storage.GetItemAsync<bool>("UserDoesntWatch");
    }

    async Task UserWillWatchingAsync()
    {
        await storage.SetItemAsync<bool>("UserWatch", false);
        await storage.SetItemAsync<bool>("UserWillWatch", true);
        await storage.SetItemAsync<bool>("UserStopWatch", false);
        await storage.SetItemAsync<bool>("UserDoesntWatch", false);

        UserWatch = await storage.GetItemAsync<bool>("UserWatch");
        UserWillWatch = await storage.GetItemAsync<bool>("UserWillWatch");
        UserStopWatch = await storage.GetItemAsync<bool>("UserStopWatch");
        UserDoesntWatch = await storage.GetItemAsync<bool>("UserDoesntWatch");
    }

    async Task UserStopWatchingAsync()
    {
        await storage.SetItemAsync<bool>("UserWatch", false);
        await storage.SetItemAsync<bool>("UserWillWatch", false);
        await storage.SetItemAsync<bool>("UserStopWatch", true);
        await storage.SetItemAsync<bool>("UserDoesntWatch", false);

        UserWatch = await storage.GetItemAsync<bool>("UserWatch");
        UserWillWatch = await storage.GetItemAsync<bool>("UserWillWatch");
        UserStopWatch = await storage.GetItemAsync<bool>("UserStopWatch");
        UserDoesntWatch = await storage.GetItemAsync<bool>("UserDoesntWatch");
    }

    async Task UserDontWatchingAsync()
    {
        await storage.SetItemAsync<bool>("UserWatch", false);
        await storage.SetItemAsync<bool>("UserWillWatch", false);
        await storage.SetItemAsync<bool>("UserStopWatch", false);
        await storage.SetItemAsync<bool>("UserDoesntWatch", true);

        UserWatch = await storage.GetItemAsync<bool>("UserWatch");
        UserWillWatch = await storage.GetItemAsync<bool>("UserWillWatch");
        UserStopWatch = await storage.GetItemAsync<bool>("UserStopWatch");
        UserDoesntWatch = await storage.GetItemAsync<bool>("UserDoesntWatch");
    }

    async Task Rating(int rating)
    {
        await storage.SetItemAsync<int>("CurrentUserRating", rating);

        CurrentUserRating = await storage.GetItemAsync<int>("CurrentUserRating");

        var connectionStringUserRating = "mongodb://localhost";
        var clientUserRating = new MongoClient(connectionStringUserRating);
        var dbUserRating = clientUserRating.GetDatabase("TV_Shows");
        var collectionUserRating = dbUserRating.GetCollection<UserRating>("UserRating");
        if (collectionUserRating.Find(x => x.UserRatingLogin == UserLogin &&
                x.UserRatingPassword == UserPassword && x.SerialNameEng == "Game of Thrones").CountDocuments() == 0)
        {
            UserRating.AddUserRatingToDb(new UserRating(UserLogin, UserPassword, "Game of Thrones", CurrentUserRating));
        }
        else
        {
            if (collectionUserRating.Find(x => x.SingleUserRating != CurrentUserRating).CountDocuments() > 0)
            {
                collectionUserRating.DeleteOne(x => x.UserRatingLogin == UserLogin &&
                x.UserRatingPassword == UserPassword && x.SerialNameEng == "Game of Thrones" &&
                x.SingleUserRating != CurrentUserRating);

                UserRating.AddUserRatingToDb(new UserRating(UserLogin, UserPassword, "Game of Thrones", CurrentUserRating));
            }
        }
    }

    private void Rating5()
    {
        rating = 5;
        Rating(rating);
    }

    private void Rating4()
    {
        rating = 4;
        Rating(rating);
    }

    private void Rating3()
    {
        rating = 3;
        Rating(rating);
    }

    private void Rating2()
    {
        rating = 2;
        Rating(rating);
    }

    private void Rating1()
    {
        rating = 1;
        Rating(rating);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager manager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService storage { get; set; }
    }
}
#pragma warning restore 1591
