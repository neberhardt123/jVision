#pragma checksum "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "614d96190b556cb11c9cd5f8bee1bdd2b0dcce20"
// <auto-generated/>
#pragma warning disable 1591
namespace jVision.Client.Shared
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
#line 32 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
using jVision.Client.Shared.HtmlColors;

#line default
#line hidden
#nullable disable
    public partial class CollapsePanel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "collapsePanel");
            __builder.AddAttribute(2, "tabindex", "200");
            __builder.AddAttribute(3, "disabled", 
#nullable restore
#line 1 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
                                                                      Disabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddMultipleAttributes(4, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 1 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
                                                                                            AllOtherAttributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "b-jyww2i6ojk");
            __builder.AddElementReferenceCapture(6, (__value) => {
#nullable restore
#line 1 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
           _inputRef = __value;

#line default
#line hidden
#nullable disable
            }
            );
#nullable restore
#line 2 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
     if (Collapsed)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "id", 
#nullable restore
#line 4 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
                   $"collapse_{_componentId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "class", "collapseHeader" + " collapsed" + " " + (
#nullable restore
#line 4 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
                                                                                  Animate ? "animate" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
                                                                                                                       ExpandCollapse

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "b-jyww2i6ojk");
            __builder.AddContent(12, 
#nullable restore
#line 5 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
              CommonHeader ?? CollapsedHeaderContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 7 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "id", 
#nullable restore
#line 10 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
                   $"collapse_{_componentId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "class", "collapseHeader" + " expanded" + " " + (
#nullable restore
#line 10 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
                                                                                 Animate ? "animate" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
                                                                                                                      ExpandCollapse

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "b-jyww2i6ojk");
            __builder.AddContent(18, 
#nullable restore
#line 11 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
              CommonHeader ?? ExpandedHeaderContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "collapseContent" + " " + (
#nullable restore
#line 14 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
                                  Animate ? "animate" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "style", "opacity:" + " " + (
#nullable restore
#line 15 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
                           Collapsed ? "0" : "1"

#line default
#line hidden
#nullable disable
            ) + ";" + " max-height:" + " " + (
#nullable restore
#line 15 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
                                                                GetContentHeight()

#line default
#line hidden
#nullable disable
            ) + ";" + " overflow:" + " " + (
#nullable restore
#line 15 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
                                                                                                ShowContentOverflow ? "auto" : "hidden"

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddAttribute(22, "b-jyww2i6ojk");
            __builder.AddContent(23, 
#nullable restore
#line 16 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
         Content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n");
            __builder.OpenElement(25, "style");
            __builder.AddAttribute(26, "b-jyww2i6ojk");
            __builder.AddMarkupContent(27, "\r\n\t.collapseHeader[id=");
            __builder.AddContent(28, 
#nullable restore
#line 21 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
                         $"collapse_{_componentId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(29, "].expanded {\r\n\t\tbackground-color: ");
            __builder.AddContent(30, 
#nullable restore
#line 22 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
                            $"rgb({ExpandedColor})"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(31, ";\r\n\t}\r\n\t.collapseHeader[id=");
            __builder.AddContent(32, 
#nullable restore
#line 24 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
                         $"collapse_{_componentId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(33, "].collapsed {\r\n\t\tbackground-color: ");
            __builder.AddContent(34, 
#nullable restore
#line 25 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
                            $"rgb({CollapsedColor})"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(35, ";\r\n\t}\r\n\t.collapseHeader[id=");
            __builder.AddContent(36, 
#nullable restore
#line 27 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
                         $"collapse_{_componentId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(37, "]:hover {\r\n\t\tbackground-color: ");
            __builder.AddContent(38, 
#nullable restore
#line 28 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
                            $"rgb({HoverColor})"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(39, ";\r\n\t}\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\natha\source\repos\jVision\Client\Shared\CollapsePanel.razor"
       
    [CascadingParameter] private Accordion Parent { get; set; }
    protected override void OnInitialized()
    {
        Parent?.AddCollapsePanel(this);
    }

    private string _componentId = Guid.NewGuid().ToString("n");
    private ElementReference _inputRef;
    /// <summary>
    /// Exposes a Blazor <see cref="ElementReference"/> of the wrapped around HTML element. It can be used e.g. for JS interop, etc.
    /// </summary>
    public ElementReference InnerElementReference => _inputRef;

    /// <summary>
    /// Common header for Collapse control it will be shown for any collapsed state. It overrides ExpandedHeaderContent, CollapsedHeaderContent.
    /// </summary>
    [Parameter] public RenderFragment CommonHeader { get; set; }
    /// <summary>
    /// Special header for Collapse control it is shown when item Expanded.
    /// </summary>
    [Parameter] public RenderFragment ExpandedHeaderContent { get; set; }
    /// <summary>
    /// Special header for Collapse control it is shown when item Collapsed.
    /// </summary>
    [Parameter] public RenderFragment CollapsedHeaderContent { get; set; }

    /// <summary>
    /// HTML Content of the collapse panel.
    /// </summary>
    [Parameter] public RenderFragment Content { get; set; }

    private string _expandedColor = "211,211,211";//lightGray
    /// <summary>
    /// Sets the `style` of the `background-color` when tab is Active. Use HTML specified: **Color Names**, **RGB**, **HEX** or with **HSL** values.
    /// </summary>
    [Parameter]
    public string ExpandedColor
    {
        get => _expandedColor;
        set => _expandedColor = new HtmlColor(value)?.RgbColor.ToRgbString();
    }
    private string _collapsedColor = "211,211,211";//lightGray
    /// <summary>
    /// Sets the `style` of the `background-color` when tab is not the Active tab. Use HTML specified: **Color Names**, **RGB**, **HEX** or with **HSL** values.
    /// </summary>
    [Parameter]
    public string CollapsedColor
    {
        get => _collapsedColor;
        set => _collapsedColor = new HtmlColor(value)?.RgbColor.ToRgbString();
    }
    private string _hoverColor = "245, 245, 245";//WhiteSmoke
    /// <summary>
    /// Sets the `style` of the `background-color` when button is hovered over with mouse. Use HTML specified: **Color Names**, **RGB**, **HEX** or with **HSL** values.
    /// </summary>
    [Parameter]
    public string HoverColor
    {
        get => _hoverColor;
        set => _hoverColor = new HtmlColor(value)?.RgbColor.ToRgbString();
    }

    /// <summary>
    /// Sets the height of Content panel in `px`. 0 is auto.
    /// </summary>
    [Parameter] public int ContentHeight { get; set; } = 200;

    /// <summary>
    /// Determines whether all the rendered HTML elements should be disabled or not.
    /// </summary>
    [Parameter] public bool Disabled { get; set; } = false;

    private bool _collapsed = false;
    /// <summary>
    /// Can be set if panel should be collapsed `true` or expanded `false`.
    /// </summary>
    [Parameter]
    public bool Collapsed
    {
        get => _collapsed;
        set
        {
            if (value != _collapsed)
            {
                _collapsed = value;
                InvokeAsync(async () =>
                {
                    await CollapseEvent();
                });
            }
        }
    }

    /// <summary>
    /// Determines to apply CSS animation and transition on Collapse state changes or not.
    /// Note: in case of `auto` height some animation won't work.
    /// </summary>
    [Parameter] public bool Animate { get; set; } = true;

    /// <summary>
    /// Determines whether content overflow is visible (scrollable) or not (hidden).
    /// </summary>
    [Parameter] public bool ShowContentOverflow { get; set; } = false;

    /// <summary>
    /// Callback function called when panel collapsed or expanded. Collapsed state is the callback parameter.
    /// </summary>
    [Parameter] public EventCallback<bool> OnCollapseChanged { get; set; }

    /// <summary>
    /// Blazor capture for any unmatched HTML attributes.
    /// </summary>
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> AllOtherAttributes { get; set; }

    private async Task ExpandCollapse()
    {
        _collapsed = !Collapsed;

        await CollapseEvent();
    }
    private async Task CollapseEvent()
    {
        Parent?.ActivateCollapsePanel(_collapsed ? null : this);

        if (OnCollapseChanged.HasDelegate)
        {
            await OnCollapseChanged.InvokeAsync(_collapsed);
        }
    }

    private string GetContentHeight()
    {
        if (Collapsed)
            return "0px;";

        return ContentHeight <= 0 ? "auto;" : $"{ContentHeight}px;";
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591