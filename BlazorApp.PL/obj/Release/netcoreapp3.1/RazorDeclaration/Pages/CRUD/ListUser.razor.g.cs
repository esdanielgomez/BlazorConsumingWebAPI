#pragma checksum "C:\Users\Daniel\source\repos\BlazorApp\BlazorApp.PL\Pages\CRUD\ListUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5485dc9fd0d11469c1d2c474b1e9ffd0a5225da9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.PL.Pages.CRUD
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Daniel\source\repos\BlazorApp\BlazorApp.PL\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Daniel\source\repos\BlazorApp\BlazorApp.PL\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Daniel\source\repos\BlazorApp\BlazorApp.PL\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Daniel\source\repos\BlazorApp\BlazorApp.PL\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Daniel\source\repos\BlazorApp\BlazorApp.PL\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Daniel\source\repos\BlazorApp\BlazorApp.PL\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Daniel\source\repos\BlazorApp\BlazorApp.PL\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Daniel\source\repos\BlazorApp\BlazorApp.PL\_Imports.razor"
using BlazorApp.PL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Daniel\source\repos\BlazorApp\BlazorApp.PL\_Imports.razor"
using BlazorApp.PL.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Daniel\source\repos\BlazorApp\BlazorApp.PL\Pages\CRUD\ListUser.razor"
using BlazorApp.BL.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Daniel\source\repos\BlazorApp\BlazorApp.PL\Pages\CRUD\ListUser.razor"
using BlazorApp.BL.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listusers")]
    public partial class ListUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\Daniel\source\repos\BlazorApp\BlazorApp.PL\Pages\CRUD\ListUser.razor"
       

    public List<UserListModel> Users { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Users = await userService.GetAllUsersAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService userService { get; set; }
    }
}
#pragma warning restore 1591
