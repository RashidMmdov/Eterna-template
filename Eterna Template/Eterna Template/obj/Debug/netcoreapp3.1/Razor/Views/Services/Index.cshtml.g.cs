#pragma checksum "C:\Users\resid\Desktop\Final Temp\Eterna Template\Eterna Template\Views\Services\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a325a31add416efe7c27e570e50d6e0e5991151e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Index), @"mvc.1.0.view", @"/Views/Services/Index.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\resid\Desktop\Final Temp\Eterna Template\Eterna Template\Views\Services\Index.cshtml"
using Eterna_Template.HomeViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\resid\Desktop\Final Temp\Eterna Template\Eterna Template\Views\Services\Index.cshtml"
using Eterna_Template.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a325a31add416efe7c27e570e50d6e0e5991151e", @"/Views/Services/Index.cshtml")]
    #nullable restore
    public class Views_Services_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<main>\r\n\r\n        <div class=\"container\">\r\n            <div class=\"row justify-content-between\">\r\n                \r\n");
#nullable restore
#line 10 "C:\Users\resid\Desktop\Final Temp\Eterna Template\Eterna Template\Views\Services\Index.cshtml"
                 foreach (BigCard item in Model.bigCards)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   <div class=\"col-lg-4 col-md-6\">\r\n                    <div class=\"card\">\r\n                        <div class=\"icon\">\r\n                            <i");
            BeginWriteAttribute("class", " class=\"", 461, "\"", 479, 1);
#nullable restore
#line 15 "C:\Users\resid\Desktop\Final Temp\Eterna Template\Eterna Template\Views\Services\Index.cshtml"
WriteAttributeValue("", 469, item.Icon, 469, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                        </div>\r\n                        <div class=\"about\">\r\n                            <strong><a");
            BeginWriteAttribute("href", " href=\"", 602, "\"", 609, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "C:\Users\resid\Desktop\Final Temp\Eterna Template\Eterna Template\Views\Services\Index.cshtml"
                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></strong>\r\n                            <p>");
#nullable restore
#line 19 "C:\Users\resid\Desktop\Final Temp\Eterna Template\Eterna Template\Views\Services\Index.cshtml"
                          Write(item.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 23 "C:\Users\resid\Desktop\Final Temp\Eterna Template\Eterna Template\Views\Services\Index.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>

        <section class=""skils"">
            <div class=""container "">
                <div class=""about"">
                    <h2>Our Skills</h2>
                    <h2 class=""line""></h2>
                    <p>Magnam dolores commodi suscipit. Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit
                        sint consectetur velit. Quisquam quos quisquam cupiditate. Et nemo qui impedit suscipit alias
                        ea. Quia fugiat sit in iste officiis commodi quidem hic quas.
                    </p>
                </div>

                <div class=""BarAndImage"">
                    <div class=""row"">
                        <div class=""imagers col-lg-6"">

                            <img src=""https://bootstrapmade.com/demo/templates/Eterna/assets/img/skills-img.jpg""
                                alt=""Team Working rr"">

                        </div>
                        <div class="" title col-lg-6"">

           ");
            WriteLiteral(@"                 <h3>Voluptatem dignissimos provident quasi corporis voluptates</h3>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt
                                direna past reda</p>

");
#nullable restore
#line 115 "C:\Users\resid\Desktop\Final Temp\Eterna Template\Eterna Template\Views\Services\Index.cshtml"
                                 foreach (ProgressBar item in Model.progressBars)
                               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   <div class=\"name d-flex justify-content-between\">\r\n                                <span class=\"language\">");
#nullable restore
#line 118 "C:\Users\resid\Desktop\Final Temp\Eterna Template\Eterna Template\Views\Services\Index.cshtml"
                                                  Write(item.LanguageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"percent\">");
#nullable restore
#line 119 "C:\Users\resid\Desktop\Final Temp\Eterna Template\Eterna Template\Views\Services\Index.cshtml"
                                                 Write(item.Percend);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"progress\">\r\n                                <div");
            BeginWriteAttribute("class", " class=\"", 5321, "\"", 5353, 2);
            WriteAttributeValue("", 5329, "progress-bar", 5329, 12, true);
#nullable restore
#line 122 "C:\Users\resid\Desktop\Final Temp\Eterna Template\Eterna Template\Views\Services\Index.cshtml"
WriteAttributeValue(" ", 5341, item.Color, 5342, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"progressbar\"");
            BeginWriteAttribute("style", " style=\"", 5373, "\"", 5401, 2);
            WriteAttributeValue("", 5381, "width:", 5381, 6, true);
#nullable restore
#line 122 "C:\Users\resid\Desktop\Final Temp\Eterna Template\Eterna Template\Views\Services\Index.cshtml"
WriteAttributeValue(" ", 5387, item.Percend, 5388, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                    aria-valuenow=\"100\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                            </div>\r\n");
#nullable restore
#line 125 "C:\Users\resid\Desktop\Final Temp\Eterna Template\Eterna Template\Views\Services\Index.cshtml"
                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </section>\r\n\r\n    </main>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
