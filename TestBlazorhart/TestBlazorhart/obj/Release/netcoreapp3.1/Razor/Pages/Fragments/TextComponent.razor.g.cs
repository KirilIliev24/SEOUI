#pragma checksum "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\Fragments\TextComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d07456e1589f1e267573141103853eacebeb3c3d"
// <auto-generated/>
#pragma warning disable 1591
namespace TestBlazorhart.Pages.Fragments
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\_Imports.razor"
using TestBlazorhart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\_Imports.razor"
using TestBlazorhart.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\_Imports.razor"
using ChartJs.Blazor.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\_Imports.razor"
using ChartJs.Blazor.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\_Imports.razor"
using ChartJs.Blazor.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\_Imports.razor"
using ChartJs.Blazor.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\_Imports.razor"
using ChartJs.Blazor.Common.Handlers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\_Imports.razor"
using ChartJs.Blazor.Common.Time;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\_Imports.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\_Imports.razor"
using ChartJs.Blazor.Interop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\Fragments\TextComponent.razor"
using TestBlazorhart.Data;

#line default
#line hidden
#nullable disable
    public partial class TextComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "<h3>TextComponent</h3>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
#nullable restore
#line 11 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\Fragments\TextComponent.razor"
         if (!meaningfulText.Equals(""))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-12 textBox");
            __builder.OpenElement(7, "p");
            __builder.AddContent(8, 
#nullable restore
#line 14 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\Fragments\TextComponent.razor"
                    meaningfulText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\Fragments\TextComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-md-12");
            __builder.AddMarkupContent(14, "<label>Select date: </label>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(15);
            __builder.AddAttribute(16, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 21 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\Fragments\TextComponent.razor"
                              _Date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __Blazor.TestBlazorhart.Pages.Fragments.TextComponent.TypeInference.CreateInputDate_0(__builder2, 18, 19, "form-control", 20, 
#nullable restore
#line 22 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\Fragments\TextComponent.razor"
                                        _Date.dateTime

#line default
#line hidden
#nullable disable
                , 21, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _Date.dateTime = __value, _Date.dateTime)), 22, () => _Date.dateTime);
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "row");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col-md-12");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\Fragments\TextComponent.razor"
                              GetData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(30, "onclick", true);
            __builder.AddContent(31, "Get data");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(33, @"<style>
    p {
        width: inherit;
        max-height: 200px;
        overflow: auto;
    }

    div.text {
        border: solid;
        border-width: 1.5px;
        border-color: black;
    }

    .textBox {
        border: solid;
        border-width: 1px;
        border-color: darkgray;
    }

</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\Fragments\TextComponent.razor"
       
    [Parameter] public int index { get; set; } // index of the link
    public string meaningfulText = "";

    TimeSelected _Date { get; set; } = new TimeSelected();


    public async Task GetData()
    {
        var newTime = new DateTime(_Date.dateTime.Year, _Date.dateTime.Month, _Date.dateTime.Day, 0, 0, 0);

        meaningfulText = await ResultService.GetMeaningfulText(index, newTime);

    }

    public class TimeSelected
    {
        public DateTime dateTime { get; set; } = DateTime.Now;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ResultService ResultService { get; set; }
    }
}
namespace __Blazor.TestBlazorhart.Pages.Fragments.TextComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
