#pragma checksum "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "584c79440277a0d1e6e8809f47f12a62eac0cecb"
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
#line 17 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\_Imports.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Index.razor"
using ChartJs.Blazor.LineChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Index.razor"
using ChartJs.Blazor.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Index.razor"
using ChartJs.Blazor.Common.Time;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Index.razor"
using ChartJs.Blazor.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Index.razor"
using ChartJs.Blazor.Interop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Index.razor"
using TestBlazorhart.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Rankings/{index:int}")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Rankings</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-6");
            __builder.OpenComponent<ChartJs.Blazor.Chart>(7);
            __builder.AddAttribute(8, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.Common.ConfigBase>(
#nullable restore
#line 23 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Index.razor"
                           _lineConfig

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-md-6");
#nullable restore
#line 26 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Index.razor"
             if (linkPositions.Count != 0)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<TestBlazorhart.Pages.Fragments.CssChartComponent>(12);
            __builder.AddAttribute(13, "linkCss", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<TestBlazorhart.Data.DateAndPosition>>(
#nullable restore
#line 28 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Index.razor"
                                                                           linkPositions

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 29 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-md-6");
#nullable restore
#line 34 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Index.razor"
             if (linkPositions.Count != 0)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<TestBlazorhart.Pages.Fragments.JsChartComponent>(19);
            __builder.AddAttribute(20, "linkJs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<TestBlazorhart.Data.DateAndPosition>>(
#nullable restore
#line 36 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Index.razor"
                                                                         linkPositions

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 37 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-md-6");
#nullable restore
#line 40 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Index.razor"
             if (linkPositions.Count != 0)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<TestBlazorhart.Pages.Fragments.WordCountComponent>(24);
            __builder.AddAttribute(25, "linkWords", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<TestBlazorhart.Data.DateAndPosition>>(
#nullable restore
#line 42 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Index.razor"
                                                                              linkPositions

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 43 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n\r\n\r\n");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "container");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "row");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col-md-6");
            __builder.AddMarkupContent(33, "<label>Start date: </label>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(34);
            __builder.AddAttribute(35, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 54 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Index.razor"
                              _startDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __Blazor.TestBlazorhart.Pages.Index.TypeInference.CreateInputDate_0(__builder2, 37, 38, "form-control", 39, 
#nullable restore
#line 55 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Index.razor"
                                        _startDate.dateTime

#line default
#line hidden
#nullable disable
                , 40, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _startDate.dateTime = __value, _startDate.dateTime)), 41, () => _startDate.dateTime);
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col-md-6");
            __builder.AddMarkupContent(45, "<label>End date: </label>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(46);
            __builder.AddAttribute(47, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 60 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Index.razor"
                              _endDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __Blazor.TestBlazorhart.Pages.Index.TypeInference.CreateInputDate_1(__builder2, 49, 50, "form-control", 51, 
#nullable restore
#line 61 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Index.razor"
                                        _endDate.dateTime

#line default
#line hidden
#nullable disable
                , 52, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _endDate.dateTime = __value, _endDate.dateTime)), 53, () => _endDate.dateTime);
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "row");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "col-md-12");
            __builder.OpenElement(59, "button");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Index.razor"
                              GetDateRange

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(61, "Get data");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n\r\n    ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "row");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "col-md-12");
            __builder.OpenComponent<TestBlazorhart.Pages.Fragments.ExternalLinksComponent>(67);
            __builder.AddAttribute(68, "index", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 73 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Index.razor"
                                                                          index

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n\r\n\r\n\r\n    ");
            __builder.AddMarkupContent(70, @"<style>
        button {
            border-radius: 8px;
            border: 2px solid #000000;
            background-color: limegreen;
            margin-top: 10px;
            width: 100%;
        }

            button:hover {
                box-shadow: 0 12px 16px 0 rgba(0,0,0,0.24), 0 17px 50px 0 rgba(0,0,0,0.19);
            }
    </style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\Administrator\source\repos\TestBlazorhart\TestBlazorhart\Pages\Index.razor"
 
        [Parameter] public int index { get; set; }
        private List<DateAndPosition> linkPositions = new List<DateAndPosition>();

        TimeSelected _startDate { get; set; } = new TimeSelected();
        TimeSelected _endDate { get; set; } = new TimeSelected();

        private LineConfig _lineConfig;

        private LineDataset<TimePoint> _lineDataSetPositions;
        private string id = "";

        protected override async Task OnInitializedAsync()
        {
            await initialiseChart();

            await ResultService.GetLinkPositions(index, null, null);
            if (ResultService.linkPositions != null)
            {
                linkPositions = ResultService.linkPositions;
            }

            _lineDataSetPositions = new LineDataset<TimePoint>()
            {
                BackgroundColor = ColorUtil.FromDrawingColor(System.Drawing.Color.White),
                BorderColor = ColorUtil.FromDrawingColor(System.Drawing.Color.Red),
                Label = "Position",
                Fill = false,
                BorderWidth = 2,
                PointRadius = 2,
                PointBorderWidth = 2,
                SteppedLine = SteppedLine.False,
                LineTension = 0
            };


            _lineDataSetPositions.AddRange(linkPositions
                .Select(p => new TimePoint(p.Date, p.Position)));


            _lineConfig.Data.Datasets.Add(_lineDataSetPositions);

        }

        public async Task GetDateRange()
        {
            var startTime = new DateTime(_startDate.dateTime.Year, _startDate.dateTime.Month, _startDate.dateTime.Day, 0, 0, 0);
            var endTime = new DateTime(_endDate.dateTime.Year, _endDate.dateTime.Month, _endDate.dateTime.Day, 23, 59, 59);

            var dataset = _lineConfig.Data.Datasets;

            _lineConfig.Data.Datasets.Remove(_lineDataSetPositions);
            //await _lineChart.Update();

            await ResultService.GetLinkPositions(index, startTime, endTime);
            if (ResultService.linkPositions != null)
            {
                linkPositions = ResultService.linkPositions;
            }
            //await _lineChart.Update();

            _lineDataSetPositions = new LineDataset<TimePoint>()
            {
                BackgroundColor = ColorUtil.FromDrawingColor(System.Drawing.Color.White),
                BorderColor = ColorUtil.FromDrawingColor(System.Drawing.Color.Red),
                Label = "Position",
                Fill = false,
                BorderWidth = 2,
                PointRadius = 2,
                PointBorderWidth = 2,
                SteppedLine = SteppedLine.False,
                LineTension = 0
            };

            _lineDataSetPositions.AddRange(linkPositions
            .Select(p => new TimePoint(p.Date, p.Position)));

            _lineConfig.Data.Datasets.Add(_lineDataSetPositions);
        }

        private async Task initialiseChart()
        {
            _lineConfig = new LineConfig
            {
                Options = new LineOptions
                {
                    Responsive = true,
                    Title = new OptionsTitle
                    {
                        Display = true,
                        Text = "Website rank"
                    },
                    Legend = new Legend
                    {
                        Display = false
                    },
                    Tooltips = new Tooltips
                    {
                        Mode = InteractionMode.Nearest,
                        Intersect = false
                    },
                    Scales = new Scales
                    {
                        YAxes = new List<CartesianAxis>
{
                        new LinearCartesianAxis
                        {
                            Ticks = new LinearCartesianTicks
                            {
                                Reverse = true,
                                Min = 1
                            },
                            ScaleLabel = new ScaleLabel
                            {
                                LabelString = "Position"
                            }
                        }
                    },
                        XAxes = new List<CartesianAxis>
{
                        new TimeAxis
                        {
                            Distribution = TimeDistribution.Linear,
                            Ticks = new TimeTicks
                            {
                                Source = TickSource.Data
                            },
                            Time = new TimeOptions
                            {
                                Unit = TimeMeasurement.Day,
                                Round = TimeMeasurement.Hour,
                                TooltipFormat = "MM.DD.YYYY",
                                //DisplayFormats = TimeDisplayFormats.DE_CH
                            },
                            ScaleLabel = new ScaleLabel
                            {
                                LabelString = "Date"
                            }
                        }
                    }
                    },
                    Hover = new Hover
                    {
                        Intersect = true,
                        Mode = InteractionMode.Y
                    }
                }
            };

            id = await Task.Run(() => _lineConfig.CanvasId);

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
namespace __Blazor.TestBlazorhart.Pages.Index
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
