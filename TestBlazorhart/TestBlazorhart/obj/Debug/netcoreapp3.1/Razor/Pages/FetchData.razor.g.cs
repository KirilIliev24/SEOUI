#pragma checksum "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9def431586806bc5cb849cfc8ef479e14296bd4"
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
#line 3 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
using TestBlazorhart.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
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
            __builder.AddMarkupContent(3, "<div class=\"row\"><div class=\"col-md-12\"><h1>Search result page</h1></div></div>\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-6");
            __builder.AddMarkupContent(8, "<label>Choose a keyword</label>\r\n                <br>\r\n                ");
            __builder.OpenElement(9, "select");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
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
#line 20 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                     if (keywords.Count != 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                         foreach (string s in keywords)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "option");
            __builder.AddAttribute(18, "value", 
#nullable restore
#line 24 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                            s

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(19, 
#nullable restore
#line 24 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                                s

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                         
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
#line 30 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n                ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                  GetLinks

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Get links");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-md-6");
            __builder.AddMarkupContent(30, "<label>Add a keyword</label>\r\n                <br>\r\n                ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "text");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                          addKeyword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => addKeyword = __value, addKeyword));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                  AddKeyWord

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "Add keyword");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
     if (chooseDate)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "container-fluid");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "row");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col-md-3");
            __builder.AddMarkupContent(45, "<label>Start date: </label>\r\n                    <br>\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(46);
            __builder.AddAttribute(47, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 52 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                      _startDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __Blazor.TestBlazorhart.Pages.FetchData.TypeInference.CreateInputDate_0(__builder2, 49, 50, "form-control", 51, 
#nullable restore
#line 53 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                                _startDate.dateTime

#line default
#line hidden
#nullable disable
                , 52, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _startDate.dateTime = __value, _startDate.dateTime)), 53, () => _startDate.dateTime);
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "col-md-3");
            __builder.AddMarkupContent(57, "<label>End date: </label>\r\n                    <br>\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(58);
            __builder.AddAttribute(59, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 59 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                      _endDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __Blazor.TestBlazorhart.Pages.FetchData.TypeInference.CreateInputDate_1(__builder2, 61, 62, "form-control", 63, 
#nullable restore
#line 60 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                                _endDate.dateTime

#line default
#line hidden
#nullable disable
                , 64, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _endDate.dateTime = __value, _endDate.dateTime)), 65, () => _endDate.dateTime);
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 65 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "container-fluid");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "row");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "col-md-6");
            __builder.AddAttribute(72, "id", "datePickButton");
#nullable restore
#line 69 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                 if (chooseDate == false)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(73, "button");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                      showDatePicker

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(75, "Pick date range<i class=\"arrow down\"></i>");
            __builder.CloseElement();
#nullable restore
#line 72 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(76, "button");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                      showDatePicker

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(78, "Pick date range<i class=\"arrow up\"></i>");
            __builder.CloseElement();
#nullable restore
#line 76 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n\r\n\r\n    ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "container-fluid");
#nullable restore
#line 83 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
         if (loading == true)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(82, "<div class=\"row\"><div class=\"col-md-12 spinDiv\"><div class=\"spinner-border\"></div></div></div>");
#nullable restore
#line 90 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
             foreach (var result in results)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "row");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "col-md-12");
            __builder.OpenComponent<TestBlazorhart.Pages.Fragments.ResultComponent>(87);
            __builder.AddAttribute(88, "result", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TestBlazorhart.Data.Result>(
#nullable restore
#line 97 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                                                                 result

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 100 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(90, @"<style>
    body {
        background-color: #ebf4ff;
    }

    input {
        margin-top: 5px;
        width: 50%;
        height: 30px;
    }

    select {
        margin-top: 5px;
        width: 50%;
        height: 30px;
    }

    button {
        width: auto;
        min-width: 25%;
        height: 30px;
        background-color: #07428a;
        color: white;
        margin-top: 5px;
    }

    h1 {
        text-align: center;
    }

    label {
        font-size: large;
    }

    div.col-md-6 {
        display: block;
    }

    #datePickButton {
        width: inherit !important;
    }

    .arrow {
        border: solid white;
        border-width: 0 3px 3px 0;
        display: inline-block;
        padding: 3px;
        margin-left: 10px;
    }

    .up {
        transform: rotate(-135deg);
        -webkit-transform: rotate(-135deg);
    }

    .down {
        transform: rotate(45deg);
        -webkit-transform: rotate(45deg);
    }

    /*.spinDiv {
        display: flex;
        justify-content: center;
    }*/

    .spinner-border {
        display: flex;
        justify-content: center;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 109 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
       
    private Result[] results;
    private List<string> keywords = new List<string>();
    private string addKeyword;
    private string keyword = "";
    private bool chooseDate { get; set; } = false;
    private bool loading { get; set; } = false;

    TimeSelected _startDate { get; set; } = new TimeSelected();
    TimeSelected _endDate { get; set; } = new TimeSelected();

    private async Task AddKeyWord()
    {
        await ResultService.AddKeyord(addKeyword);
        await ResultService.GetAllKeyords();
        keywords = ResultService.keywords;
    }

    private async Task GetLinks()
    {
        loading = true;
        if (chooseDate == false)
        {
            _startDate.dateTime = new DateTime(2000, 1, 1);
            _endDate.dateTime = DateTime.Now;

            await ResultService.GetResultAsync(keyword, _startDate.dateTime, _endDate.dateTime);
            loading = false;
            results = ResultService.results.ToArray();

            _startDate.dateTime = DateTime.Now;
        }
        else
        {
            await ResultService.GetResultAsync(keyword, _startDate.dateTime, _endDate.dateTime);
            loading = false;
            results = ResultService.results.ToArray();
        }
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

    public void showDatePicker()
    {
        chooseDate = !chooseDate;
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
namespace __Blazor.TestBlazorhart.Pages.FetchData
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
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
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
