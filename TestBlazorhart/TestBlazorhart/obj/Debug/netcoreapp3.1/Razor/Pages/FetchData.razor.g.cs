#pragma checksum "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05064a87cbe5cf22aa4c60c3e0f078aa5d6920de"
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
#nullable restore
#line 17 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                 if (chooseDate == true)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "label");
            __builder.AddContent(9, "Choose a keyword: ");
            __builder.AddContent(10, 
#nullable restore
#line 19 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                              keyword

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    <br>\r\n                    ");
            __builder.OpenElement(12, "select");
            __builder.AddAttribute(13, "id", "fullWight");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                                  keyword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => keyword = __value, keyword));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(16, "option");
            __builder.AddAttribute(17, "value", true);
            __builder.AddAttribute(18, "disabled", true);
            __builder.AddAttribute(19, "selected", true);
            __builder.AddContent(20, "--Choose--");
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                         if (keywords.Count != 0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                             foreach (string s in keywords)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "option");
            __builder.AddAttribute(22, "value", 
#nullable restore
#line 27 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                                s

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, 
#nullable restore
#line 27 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                                    s

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                             
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "disabled", true);
            __builder.AddContent(26, "Waiting for keywords...");
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "label");
            __builder.AddContent(28, "Choose a keyword: ");
            __builder.AddContent(29, 
#nullable restore
#line 38 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                              keyword

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    <br>\r\n                    ");
            __builder.OpenElement(31, "select");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                   keyword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => keyword = __value, keyword));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "value", true);
            __builder.AddAttribute(36, "disabled", true);
            __builder.AddAttribute(37, "selected", true);
            __builder.AddContent(38, "--Choose--");
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                         if (keywords.Count != 0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                             foreach (string s in keywords)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "option");
            __builder.AddAttribute(40, "value", 
#nullable restore
#line 46 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                                s

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(41, 
#nullable restore
#line 46 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                                    s

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                             
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(42, "option");
            __builder.AddAttribute(43, "disabled", true);
            __builder.AddContent(44, "Waiting for keywords...");
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "class", "links myButton");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                                             GetLinks

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(49, "Get all links");
            __builder.CloseElement();
#nullable restore
#line 55 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "col-md-6");
            __builder.AddMarkupContent(53, "<label>Add a keyword</label>\r\n                <br>\r\n                ");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "type", "text");
            __builder.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 60 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                          addKeyword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => addKeyword = __value, addKeyword));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "button");
            __builder.AddAttribute(60, "class", "myButton");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                                   AddKeyWord

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(62, "Add keyword");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 65 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
     if (chooseDate)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "container-fluid");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "row");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "col-md-2");
            __builder.AddMarkupContent(69, "<label>Start date: </label>\r\n                    <br>\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(70);
            __builder.AddAttribute(71, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 72 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                      _startDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __Blazor.TestBlazorhart.Pages.FetchData.TypeInference.CreateInputDate_0(__builder2, 73, 74, "datePicker form-control", 75, 
#nullable restore
#line 73 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                                _startDate.dateTime

#line default
#line hidden
#nullable disable
                , 76, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _startDate.dateTime = __value, _startDate.dateTime)), 77, () => _startDate.dateTime);
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "col-md-2");
            __builder.AddMarkupContent(81, "<label>End date: </label>\r\n                    <br>\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(82);
            __builder.AddAttribute(83, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 79 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                      _endDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __Blazor.TestBlazorhart.Pages.FetchData.TypeInference.CreateInputDate_1(__builder2, 85, 86, "form-control", 87, 
#nullable restore
#line 80 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                                _endDate.dateTime

#line default
#line hidden
#nullable disable
                , 88, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _endDate.dateTime = __value, _endDate.dateTime)), 89, () => _endDate.dateTime);
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 85 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "container-fluid");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "row");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "col-md-6");
#nullable restore
#line 90 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                 if (chooseDate == false)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(96, "button");
            __builder.AddAttribute(97, "class", "myButton");
            __builder.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 92 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                                       showDatePicker

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(99, "Pick date range<i class=\"arrow down\"></i>");
            __builder.CloseElement();
#nullable restore
#line 93 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(100, "button");
            __builder.AddAttribute(101, "class", "myButton");
            __builder.AddAttribute(102, "id", "datePickButton");
            __builder.AddAttribute(103, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                                                           showDatePicker

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(104, "Pick date range<i class=\"arrow up\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                    ");
            __builder.OpenElement(106, "button");
            __builder.AddAttribute(107, "class", "myButton");
            __builder.AddAttribute(108, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 97 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                                       GetLinks

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(109, "Get links");
            __builder.CloseElement();
#nullable restore
#line 98 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n\r\n\r\n    ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "container-fluid");
#nullable restore
#line 105 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
         if (loading == true)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(113, "<div class=\"row\"><div class=\"col-md-12 spinDiv\"><div class=\"spinner-border\"></div></div></div>");
#nullable restore
#line 112 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
             foreach (var result in results)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "row");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "col-md-12 resultComp");
            __builder.OpenComponent<TestBlazorhart.Pages.Fragments.ResultComponent>(118);
            __builder.AddAttribute(119, "result", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TestBlazorhart.Data.Result>(
#nullable restore
#line 119 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
                                                                                 result

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 122 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(121, "<style>\r\n    body {\r\n        background-color: transparent; \r\n    }\r\n\r\n   \r\n\r\n    input {\r\n        margin-top: 5px;\r\n        width: 50%;\r\n        height: 30px;\r\n        border-radius: 28px;\r\n    }\r\n\r\n    select {\r\n        margin-top: 5px;\r\n        width: 50%;\r\n        height: 30px;\r\n        border-radius: 28px;\r\n    }\r\n\r\n        select#fullWight {\r\n            margin-top: 5px;\r\n            width: 75%;\r\n            height: 30px;\r\n        }\r\n\r\n    option {\r\n        border-radius: 28px;\r\n    }\r\n\r\n    .myButton {\r\n        width: auto;\r\n        min-width: 25%;\r\n        height: 30px;\r\n        margin-top: 5px;\r\n        box-shadow: 3px 4px 7px 0px #718a6a;\r\n        background: linear-gradient(90deg , #586be8 5%, #5aa1e0 100%);\r\n        background-color: #586be8;\r\n        border-radius: 28px;\r\n        border: 1px solid #4e86cc;\r\n        display: inline-block;\r\n        cursor: pointer;\r\n        color: #ffffff;\r\n        font-family: Arial;\r\n        font-size: 17px;\r\n        text-decoration: none;\r\n        text-shadow: 0px 0px 0px #2f6627;\r\n    }\r\n\r\n        .myButton:hover {\r\n            background-color: #2c79bd;\r\n        }\r\n\r\n    h1 {\r\n        text-align: center;\r\n    }\r\n\r\n    label {\r\n        font-size: large;\r\n        margin-top: 5px;\r\n        margin-bottom: -15px;\r\n    }\r\n\r\n    button.links {\r\n        margin-left: 5px;\r\n    }\r\n\r\n    .arrow {\r\n        border: solid white;\r\n        border-width: 0 3px 3px 0;\r\n        display: inline-block;\r\n        padding: 3px;\r\n        margin-left: 10px;\r\n    }\r\n\r\n    .up {\r\n        transform: rotate(-135deg);\r\n        -webkit-transform: rotate(-135deg);\r\n    }\r\n\r\n    .down {\r\n        transform: rotate(45deg);\r\n        -webkit-transform: rotate(45deg);\r\n    }\r\n\r\n    .spinDiv {\r\n        display: flex;\r\n        justify-content: center;\r\n    }\r\n\r\n    .resultComp {\r\n        margin-top: 10px;\r\n        margin-bottom: 10px;\r\n    }\r\n\r\n    .form-control {\r\n        border-radius: 28px;\r\n    }\r\n\r\n    #datePickButton {\r\n        margin-right: 10px;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 131 "C:\Users\Administrator\Kiril\repos\SEOUI\TestBlazorhart\TestBlazorhart\Pages\FetchData.razor"
       
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
