#pragma checksum "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Fragments\ExternalLinksComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e2ea5cc6ef2122d84a65812cdec9d2bdebb0ff4"
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
#line 1 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\_Imports.razor"
using TestBlazorhart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\_Imports.razor"
using TestBlazorhart.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\_Imports.razor"
using ChartJs.Blazor.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\_Imports.razor"
using ChartJs.Blazor.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\_Imports.razor"
using ChartJs.Blazor.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\_Imports.razor"
using ChartJs.Blazor.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\_Imports.razor"
using ChartJs.Blazor.Common.Handlers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\_Imports.razor"
using ChartJs.Blazor.Common.Time;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\_Imports.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\_Imports.razor"
using ChartJs.Blazor.Interop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Fragments\ExternalLinksComponent.razor"
using TestBlazorhart.Data;

#line default
#line hidden
#nullable disable
    public partial class ExternalLinksComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>External links</h3>\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row justify-content-center");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-12");
            __builder.OpenElement(7, "table");
#nullable restore
#line 13 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Fragments\ExternalLinksComponent.razor"
                 if (noOfRows != 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Fragments\ExternalLinksComponent.razor"
                     for (int i = 0; i < noOfRows; i++)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "tr");
#nullable restore
#line 18 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Fragments\ExternalLinksComponent.razor"
                             for (int j = 0; j < 4; j++)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "td");
            __builder.OpenElement(10, "a");
            __builder.AddAttribute(11, "href", 
#nullable restore
#line 20 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Fragments\ExternalLinksComponent.razor"
                                              strings[i * 4 + j]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, 
#nullable restore
#line 20 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Fragments\ExternalLinksComponent.razor"
                                                                   strings[i * 4 + j]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Fragments\ExternalLinksComponent.razor"
                                                                                              //maybe do 3 columns
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Fragments\ExternalLinksComponent.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Fragments\ExternalLinksComponent.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "container");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "row");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-md-12");
            __builder.AddMarkupContent(20, "<label>Select date: </label>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(21);
            __builder.AddAttribute(22, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 34 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Fragments\ExternalLinksComponent.razor"
                              _Date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __Blazor.TestBlazorhart.Pages.Fragments.ExternalLinksComponent.TypeInference.CreateInputDate_0(__builder2, 24, 25, "form-control", 26, 
#nullable restore
#line 35 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Fragments\ExternalLinksComponent.razor"
                                        _Date.dateTime

#line default
#line hidden
#nullable disable
                , 27, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _Date.dateTime = __value, _Date.dateTime)), 28, () => _Date.dateTime);
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "row");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col-md-12");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Fragments\ExternalLinksComponent.razor"
                              GetData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(36, "onclick", true);
            __builder.AddContent(37, "Get data");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
            __builder.AddMarkupContent(39, @"<style>

    table {
        margin: auto;
        width: 50% !important;
    }
    td {
        max-width: 300px;
    }
    table, th, td {
        border: 1px solid black;
        border-collapse: collapse;
    }

    h3 {
        text-align: center
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Fragments\ExternalLinksComponent.razor"
       
    [Parameter] public int index { get; set; } // index of the link
    public string message = "";
    string[] strings = new string[10];
    int noOfRows;// round ceiling

    TimeSelected _Date { get; set; } = new TimeSelected();


    public async Task GetData()
    {
        var newTime = new DateTime(_Date.dateTime.Year, _Date.dateTime.Month, _Date.dateTime.Day, 0, 0, 0);
        await ResultService.GetLinksFromUrl(index, newTime);
        strings = ResultService.resultsFromCraler.ToArray();
        noOfRows = (int)Math.Ceiling((decimal)(strings.Length / 4));
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
namespace __Blazor.TestBlazorhart.Pages.Fragments.ExternalLinksComponent
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
