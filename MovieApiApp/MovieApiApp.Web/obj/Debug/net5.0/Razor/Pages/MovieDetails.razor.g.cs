#pragma checksum "C:\Users\Aleksandar\source\repos\MovieApiApp.Models\MovieApiApp.Web\Pages\MovieDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "720d4b0ab6eb595e671f511d73bb21b34aea4319"
// <auto-generated/>
#pragma warning disable 1591
namespace MovieApiApp.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Aleksandar\source\repos\MovieApiApp.Models\MovieApiApp.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aleksandar\source\repos\MovieApiApp.Models\MovieApiApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Aleksandar\source\repos\MovieApiApp.Models\MovieApiApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Aleksandar\source\repos\MovieApiApp.Models\MovieApiApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Aleksandar\source\repos\MovieApiApp.Models\MovieApiApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Aleksandar\source\repos\MovieApiApp.Models\MovieApiApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Aleksandar\source\repos\MovieApiApp.Models\MovieApiApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Aleksandar\source\repos\MovieApiApp.Models\MovieApiApp.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Aleksandar\source\repos\MovieApiApp.Models\MovieApiApp.Web\_Imports.razor"
using MovieApiApp.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Aleksandar\source\repos\MovieApiApp.Models\MovieApiApp.Web\_Imports.razor"
using MovieApiApp.Web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/moviedetails/{id}")]
    public partial class MovieDetails : MovieDetailsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>MovieDetails</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card");
            __builder.AddAttribute(3, "style", "width: 18rem;");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.OpenElement(6, "h5");
            __builder.AddAttribute(7, "class", "card-title");
            __builder.AddContent(8, 
#nullable restore
#line 8 "C:\Users\Aleksandar\source\repos\MovieApiApp.Models\MovieApiApp.Web\Pages\MovieDetails.razor"
                                Movie.original_title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "p");
            __builder.AddAttribute(11, "class", "card-text");
            __builder.AddContent(12, 
#nullable restore
#line 9 "C:\Users\Aleksandar\source\repos\MovieApiApp.Models\MovieApiApp.Web\Pages\MovieDetails.razor"
                              Movie.overview

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.AddMarkupContent(14, "<a href=\"/\">Back</a>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591