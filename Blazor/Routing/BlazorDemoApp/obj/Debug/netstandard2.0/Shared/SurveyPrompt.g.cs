#pragma checksum "D:\CoreApp\BlazorTestApp\TestApp\BlazorDemoApp\Shared\SurveyPrompt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fb5fa8e5062a672fcd81ea9ee2037d0bc88c80d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDemoApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using BlazorDemoApp;
    using BlazorDemoApp.Shared;
    public class SurveyPrompt : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "alert alert-survey");
            builder.AddAttribute(2, "role", "alert");
            builder.AddContent(3, "\n    ");
            builder.OpenElement(4, "span");
            builder.AddAttribute(5, "class", "glyphicon glyphicon-ok-circle");
            builder.AddAttribute(6, "aria-hidden", "true");
            builder.CloseElement();
            builder.AddContent(7, "\n    ");
            builder.OpenElement(8, "strong");
            builder.AddContent(9, Title);
            builder.CloseElement();
            builder.AddContent(10, "\n\n    Please take our\n    ");
            builder.OpenElement(11, "a");
            builder.AddAttribute(12, "target", "_blank");
            builder.AddAttribute(13, "class", "alert-link");
            builder.AddAttribute(14, "href", "https://go.microsoft.com/fwlink/?linkid=871783");
            builder.AddContent(15, "\n        brief survey\n    ");
            builder.CloseElement();
            builder.AddContent(16, "\n    and tell us what you think.\n");
            builder.CloseElement();
            builder.AddContent(17, "\n\n");
        }
        #pragma warning restore 1998
#line 13 "D:\CoreApp\BlazorTestApp\TestApp\BlazorDemoApp\Shared\SurveyPrompt.cshtml"
 
    // This is to demonstrate how a parent component can supply parameters
    public string Title { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
