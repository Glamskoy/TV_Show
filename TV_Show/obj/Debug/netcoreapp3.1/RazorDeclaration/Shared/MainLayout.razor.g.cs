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
#line 4 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Shared\MainLayout.razor"
using MongoDB.Driver;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "D:\Projects\TV_Show\TV_Show.git\TV_Show\Shared\MainLayout.razor"
 
    public string CurrentUserLogin { get; set; }
    public string CurrentUserPassword { get; set; }

    public string UserLogin { get; set; }
    public string UserPassword { get; set; }



    public bool IsUserLogged { get; set; }

    bool userIsAuthorised = true;

    protected override async Task OnInitializedAsync()
    {
        //await storage.SetItemAsync<bool>("IsUserLogged", false);
        IsUserLogged = await storage.GetItemAsync<bool>("IsUserLogged");

    }

    async Task SignUp()
    {
        var connectionString = "mongodb://localhost";
        var client = new MongoClient(connectionString);
        var db = client.GetDatabase("TV_Shows");
        var collection = db.GetCollection<User>("Users");

        if (CurrentUserLogin != null && CurrentUserPassword != null)
        {
            if (collection.Find(x => x.CurrentUserLogin == CurrentUserLogin &&
                    x.CurrentUserPassword == CurrentUserPassword).CountDocuments() == 0)
            {
                await storage.SetItemAsync<bool>("CurrentUser", true);
                await storage.SetItemAsync<bool>("IsUserLogged", true);
                await storage.SetItemAsync<string>("UserLogin", CurrentUserLogin);
                await storage.SetItemAsync<string>("UserPassword", CurrentUserPassword);
                User.AddUserToDb(new User(CurrentUserLogin, CurrentUserPassword));
                manager.NavigateTo("/", true);
                userIsAuthorised = true;
            }
            else
            {
                userIsAuthorised = false;
                await storage.SetItemAsync<bool>("IsUserLogged", false);
                CurrentUserLogin = "";
                CurrentUserPassword = "";
                //await storage.RemoveItemAsync("UserLogin");
                //await storage.RemoveItemAsync("UserPassword");
            }
        }
    }

    async Task SignIn()
    {
        var connectionString = "mongodb://localhost";
        var client = new MongoClient(connectionString);
        var db = client.GetDatabase("TV_Shows");
        var collection = db.GetCollection<User>("Users");

        if(CurrentUserLogin != null && CurrentUserPassword != null)
        {
            if (collection.Find(x => x.CurrentUserLogin == CurrentUserLogin &&
                    x.CurrentUserPassword == CurrentUserPassword).CountDocuments() > 0)
            {
                User user = collection.Find(x => x.CurrentUserLogin == CurrentUserLogin &&
                x.CurrentUserPassword == CurrentUserPassword).First();
                await storage.SetItemAsync<User>("CurrentUser", user);
                await storage.SetItemAsync<bool>("IsUserLogged", true);
                await storage.SetItemAsync<string>("UserLogin", CurrentUserLogin);
                await storage.SetItemAsync<string>("UserPassword", CurrentUserPassword);
                manager.NavigateTo("/", true);
                userIsAuthorised = true;
            }
            else
            {
                userIsAuthorised = false;
                await storage.SetItemAsync<bool>("IsUserLogged", false);
                CurrentUserLogin = "";
                CurrentUserPassword = "";
                //await storage.RemoveItemAsync("UserLogin");
                //await storage.RemoveItemAsync("UserPassword");
            }
        }

    }

    async Task LogOut()
    {
        await storage.SetItemAsync<bool>("IsUserLogged", false);
        userIsAuthorised = false;
        manager.NavigateTo("/", true);
        //await storage.RemoveItemAsync("UserLogin");
        //await storage.RemoveItemAsync("UserPassword");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager manager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService storage { get; set; }
    }
}
#pragma warning restore 1591
