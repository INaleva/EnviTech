#pragma checksum "C:\Users\ilia\source\repos\EnviTech\envitech\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8c3052fcf49264c7584db5e4a97b5b563a6ab03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(envitech.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace envitech.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ilia\source\repos\EnviTech\envitech\Pages\_ViewImports.cshtml"
using envitech;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8c3052fcf49264c7584db5e4a97b5b563a6ab03", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cf773e33c6518c3da28378e5417ccce7554e22f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ilia\source\repos\EnviTech\envitech\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--As this assigment requires me to build a dynamic UI from the Json file, I'll build it and populate the data through foreach loops.-->

<div class=""container text-center"">
    <h1 class=""display-4"">EnviTech json menu</h1>
    <div class=""row"">
        <!--Main buttons, At this Json file there are only 3, but could be more.-->
");
#nullable restore
#line 13 "C:\Users\ilia\source\repos\EnviTech\envitech\Pages\Index.cshtml"
         foreach (var monitorType in Model.jsonData.MonitorType)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""dropdown p-1 btn-group btn-group-justified col-lg-4 col-md-4 col-sm-12"">
                <button class=""btn-secondary form-control dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    ");
#nullable restore
#line 17 "C:\Users\ilia\source\repos\EnviTech\envitech\Pages\Index.cshtml"
               Write(monitorType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n                <div class=\"dropdown-menu dropdown-menu-left w-100 dropright\" aria-labelledby=\"dropdownMenuButton\">\r\n                    <!--Each monitor type has different amount of monitors-->\r\n");
#nullable restore
#line 21 "C:\Users\ilia\source\repos\EnviTech\envitech\Pages\Index.cshtml"
                     foreach (var monitor in Model.jsonData.Monitor)
                    {
                        if (monitorType.LegentId == monitor.MonitorTypeId)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button class=\"btn-secondary  form-control dropdown-toggle\" type=\"button\" id=\"dropdownInnerMenuButton\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n                                ");
#nullable restore
#line 26 "C:\Users\ilia\source\repos\EnviTech\envitech\Pages\Index.cshtml"
                           Write(monitor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </button>
                            <div class=""dropdown-menu  w-100"" aria-labelledby=""dropdownInnerMenuButton"">
                                <div class=""pl-4""><b>AQI [level]</b></div>
                                <!--Access to the legend, tags data and color.-->
");
#nullable restore
#line 31 "C:\Users\ilia\source\repos\EnviTech\envitech\Pages\Index.cshtml"
                                 foreach (var legend in Model.jsonData.Legends)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\ilia\source\repos\EnviTech\envitech\Pages\Index.cshtml"
                                     foreach (var tags in legend.Tags)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"legend pb-2 row pl-4\">\r\n                                            <div class=\"rectangle\"");
            BeginWriteAttribute("style", " style=\"", 2143, "\"", 2173, 2);
            WriteAttributeValue("", 2151, "background:", 2151, 11, true);
#nullable restore
#line 36 "C:\Users\ilia\source\repos\EnviTech\envitech\Pages\Index.cshtml"
WriteAttributeValue("", 2162, tags.Color, 2162, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                            <div class=\" pl-2\">");
#nullable restore
#line 37 "C:\Users\ilia\source\repos\EnviTech\envitech\Pages\Index.cshtml"
                                                          Write(tags.Label);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                        </div>\r\n");
#nullable restore
#line 39 "C:\Users\ilia\source\repos\EnviTech\envitech\Pages\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\ilia\source\repos\EnviTech\envitech\Pages\Index.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n");
#nullable restore
#line 42 "C:\Users\ilia\source\repos\EnviTech\envitech\Pages\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n");
#nullable restore
#line 46 "C:\Users\ilia\source\repos\EnviTech\envitech\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
