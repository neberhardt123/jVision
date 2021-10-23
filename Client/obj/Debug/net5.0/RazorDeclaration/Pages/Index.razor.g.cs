// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace jVision.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using jVision.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using jVision.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\natha\source\repos\jVision\Client\Pages\Index.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\natha\source\repos\jVision\Client\Pages\Index.razor"
using jVision.Shared.Models;

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
#line 16 "C:\Users\natha\source\repos\jVision\Client\Pages\Index.razor"
       
    [Inject] public HttpClient Http { get; set; }

    private IList<BoxDTO> boxes = new List<BoxDTO>();
    private IList<ServiceDTO> services = new List<ServiceDTO>();
    private string error;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            string requestUri = "Box";
            boxes = await Http.GetFromJsonAsync<IList<BoxDTO>>(requestUri);
        } catch (Exception)
        {
            error = "Error Encountered";
        };
    }

    private async Task AddBox()
    {
        Console.WriteLine("anyuthing");
        ServiceDTO newService = new ServiceDTO
        {
            Port = 22
        };
        services.Add(newService);
        BoxDTO newBox = new BoxDTO
        {
            Ip = "192.168.1.1",
            Hostname = "Hostname",
            State = false,
            Comments = "none",
            Active = false,
            Pwned = false,
            Unrelated = false,
            Comeback = false,
            Os = "Windows",
            Cidr = "/24",
            Services = services
        };
        boxes.Add(newBox);
        var response = await Http.PostAsJsonAsync("Box", boxes);
        Console.WriteLine(response);

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
