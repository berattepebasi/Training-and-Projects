#pragma checksum "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afb9f1073d0cce52b117914b4711b362a5f121d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Uyelers_Index), @"mvc.1.0.view", @"/Views/Uyelers/Index.cshtml")]
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
#line 1 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\_ViewImports.cshtml"
using Kutuphane_MVC_EF;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\_ViewImports.cshtml"
using Kutuphane_MVC_EF.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afb9f1073d0cce52b117914b4711b362a5f121d7", @"/Views/Uyelers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d318b6bfef958db898af5341a289608a16646a81", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Uyelers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Kutuphane_MVC_EF.Models.Uyeler>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afb9f1073d0cce52b117914b4711b362a5f121d74831", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AdSoyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cinsiyet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DogumTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Tel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Mail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UyelikTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UyelikTipi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TcNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Meslek));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EgitimDurumu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CezaDurumu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 53 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AdSoyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cinsiyet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DogumTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UyelikTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UyelikTipi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TcNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Meslek));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EgitimDurumu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 86 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CezaDurumu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afb9f1073d0cce52b117914b4711b362a5f121d714239", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afb9f1073d0cce52b117914b4711b362a5f121d716442", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afb9f1073d0cce52b117914b4711b362a5f121d718651", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 94 "C:\Users\berat\OneDrive\Masaüstü\Git\kagan git\Projeler\Kutuphane_MVC_EF\Kutuphane_MVC_EF\Views\Uyelers\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Kutuphane_MVC_EF.Models.Uyeler>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591