#pragma checksum "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d84aae4379d988b6cfcd46bad5ebc1994c8be64e"
// <auto-generated/>
#pragma warning disable 1591
namespace TestBlazorhart.Pages
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
#line 3 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
using TestBlazorhart.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
using TestBlazorhart.Pages.Fragments;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "body");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.AddMarkupContent(3, "<div class=\"row\"><div class=\"col-md-12\"><p><h1>Search result page</h1></p></div></div>\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-6");
            __builder.AddMarkupContent(8, "<h3>Choose a keyword</h3>\r\n                ");
            __builder.OpenElement(9, "select");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                               keyword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => keyword = __value, keyword));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(12, "option");
            __builder.AddAttribute(13, "value", true);
            __builder.AddAttribute(14, "disabled", true);
            __builder.AddAttribute(15, "selected", true);
            __builder.AddContent(16, "--Choose--");
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                     if (keywords.Count != 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                         foreach (string s in keywords)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "option");
            __builder.AddAttribute(18, "value", 
#nullable restore
#line 23 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                            s

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(19, 
#nullable restore
#line 23 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                                s

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "disabled", true);
            __builder.AddContent(22, "Waiting for keywords...");
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                <br>\r\n                ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "class", "btn btn-primary");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                                          GetLinks

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Get links");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-md-6");
            __builder.AddMarkupContent(31, "<h3>Add a keyword</h3>\r\n                ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "text");
            __builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                          addKeyword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => addKeyword = __value, addKeyword));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                <br>\r\n                ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "btn btn-primary");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                                          AddKeyWord

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Add keyword");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
     if (results != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
         foreach (var result in results)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<TestBlazorhart.Pages.Fragments.ResultComponent>(41);
            __builder.AddAttribute(42, "result", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TestBlazorhart.Data.Result>(
#nullable restore
#line 47 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                                                     result

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 48 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(43, "<i>Loading...</i>");
#nullable restore
#line 53 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(45, @"<style>
    body {
        background-color: #8ac1e3;
    }

    input {
        justify-content: center;
        width: inherit;
        height: 30px;
        margin-bottom: 5px;
    }

    button {
        width: inherit;
    }

    select {
        width: inherit;
        height: 30px;
        margin-bottom: 5px;
    }
    h1 {
        text-align: center;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
       
    private Result[] results;
    private List<string> keywords = new List<string>();
    private string addKeyword;
    private string keyword = "";

    private async Task AddKeyWord()
    {
        await ResultService.AddKeyord(addKeyword);
        await ResultService.GetAllKeyords();
        keywords = ResultService.keywords;
    }

    private async Task GetLinks()
    {
        await ResultService.GetResultAsync(keyword);
        results = ResultService.results.ToArray();
    }


    protected override async Task OnInitializedAsync()
    {
        if (ResultService.results != null)
        {
            results = ResultService.results.ToArray();
        }
        try
        {
            await ResultService.GetAllKeyords();
            keywords = ResultService.keywords;
        }
        catch (Exception e)
        {

            Console.WriteLine(e.StackTrace);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ResultService ResultService { get; set; }
    }
}
#pragma warning restore 1591
