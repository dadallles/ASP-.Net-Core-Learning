#pragma checksum "C:\Users\Dawid\Documents\GIT\Aplikacje_WWW_S\SchoolRegister\SchoolRegister.Web\Views\Group\DetachStudentFromGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b0529bfc6c9f57f39a27799d3cbd9359d78dd9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Group_DetachStudentFromGroup), @"mvc.1.0.view", @"/Views/Group/DetachStudentFromGroup.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Group/DetachStudentFromGroup.cshtml", typeof(AspNetCore.Views_Group_DetachStudentFromGroup))]
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
#line 1 "C:\Users\Dawid\Documents\GIT\Aplikacje_WWW_S\SchoolRegister\SchoolRegister.Web\Views\_ViewImports.cshtml"
using SchoolRegister.Web;

#line default
#line hidden
#line 2 "C:\Users\Dawid\Documents\GIT\Aplikacje_WWW_S\SchoolRegister\SchoolRegister.Web\Views\_ViewImports.cshtml"
using SchoolRegister.Web.Models;

#line default
#line hidden
#line 1 "C:\Users\Dawid\Documents\GIT\Aplikacje_WWW_S\SchoolRegister\SchoolRegister.Web\Views\Group\DetachStudentFromGroup.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b0529bfc6c9f57f39a27799d3cbd9359d78dd9e", @"/Views/Group/DetachStudentFromGroup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d0783724ed864fe6452b5b898b23f5c64f72546", @"/Views/_ViewImports.cshtml")]
    public class Views_Group_DetachStudentFromGroup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SchoolRegister.ViewModels.DTOs.AttachDetachStudentToGroupDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewStudents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetachStudentFromGroup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Dawid\Documents\GIT\Aplikacje_WWW_S\SchoolRegister\SchoolRegister.Web\Views\Group\DetachStudentFromGroup.cshtml"
  
    ViewData["Title"] = Localizer["DetachStudentFromGroup"];

#line default
#line hidden
            BeginContext(212, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(218, 35, false);
#line 8 "C:\Users\Dawid\Documents\GIT\Aplikacje_WWW_S\SchoolRegister\SchoolRegister.Web\Views\Group\DetachStudentFromGroup.cshtml"
Write(Localizer["DetachStudentFromGroup"]);

#line default
#line hidden
            EndContext();
            BeginContext(253, 11, true);
            WriteLiteral("</h2>\n\n<h3>");
            EndContext();
            BeginContext(265, 42, false);
#line 10 "C:\Users\Dawid\Documents\GIT\Aplikacje_WWW_S\SchoolRegister\SchoolRegister.Web\Views\Group\DetachStudentFromGroup.cshtml"
Write(Localizer["DetachStudentFromGroupConfirm"]);

#line default
#line hidden
            EndContext();
            BeginContext(307, 79, true);
            WriteLiteral("</h3>\n<div>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(387, 20, false);
#line 15 "C:\Users\Dawid\Documents\GIT\Aplikacje_WWW_S\SchoolRegister\SchoolRegister.Web\Views\Group\DetachStudentFromGroup.cshtml"
       Write(Localizer["Student"]);

#line default
#line hidden
            EndContext();
            BeginContext(407, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(448, 19, false);
#line 18 "C:\Users\Dawid\Documents\GIT\Aplikacje_WWW_S\SchoolRegister\SchoolRegister.Web\Views\Group\DetachStudentFromGroup.cshtml"
       Write(ViewBag.studentName);

#line default
#line hidden
            EndContext();
            BeginContext(467, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(508, 18, false);
#line 21 "C:\Users\Dawid\Documents\GIT\Aplikacje_WWW_S\SchoolRegister\SchoolRegister.Web\Views\Group\DetachStudentFromGroup.cshtml"
       Write(Localizer["Group"]);

#line default
#line hidden
            EndContext();
            BeginContext(526, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(567, 17, false);
#line 24 "C:\Users\Dawid\Documents\GIT\Aplikacje_WWW_S\SchoolRegister\SchoolRegister.Web\Views\Group\DetachStudentFromGroup.cshtml"
       Write(ViewBag.groupName);

#line default
#line hidden
            EndContext();
            BeginContext(584, 30, true);
            WriteLiteral("\n        </dd>\n    </dl>\n\n    ");
            EndContext();
            BeginContext(614, 386, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9aef35964534e198cf48fbd922156f6", async() => {
                BeginContext(656, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(665, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7166c3891418496f89b0a7a9499459c0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 29 "C:\Users\Dawid\Documents\GIT\Aplikacje_WWW_S\SchoolRegister\SchoolRegister.Web\Views\Group\DetachStudentFromGroup.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.GroupId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 29 "C:\Users\Dawid\Documents\GIT\Aplikacje_WWW_S\SchoolRegister\SchoolRegister.Web\Views\Group\DetachStudentFromGroup.cshtml"
                                          WriteLiteral(ViewBag.GroupId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(731, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(740, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ad12368310cc4402b15722f2a44cb821", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 30 "C:\Users\Dawid\Documents\GIT\Aplikacje_WWW_S\SchoolRegister\SchoolRegister.Web\Views\Group\DetachStudentFromGroup.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StudentId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 30 "C:\Users\Dawid\Documents\GIT\Aplikacje_WWW_S\SchoolRegister\SchoolRegister.Web\Views\Group\DetachStudentFromGroup.cshtml"
                                            WriteLiteral(ViewBag.StudentId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(810, 29, true);
                WriteLiteral("\n        <input type=\"submit\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 839, "\"", 867, 1);
#line 31 "C:\Users\Dawid\Documents\GIT\Aplikacje_WWW_S\SchoolRegister\SchoolRegister.Web\Views\Group\DetachStudentFromGroup.cshtml"
WriteAttributeValue("", 847, Localizer["Delete"], 847, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(868, 38, true);
                WriteLiteral(" class=\"btn btn-default\" /> |\n        ");
                EndContext();
                BeginContext(906, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6e3aedb8cdc4f0c8b9a2a1adc911140", async() => {
                    BeginContext(961, 23, false);
#line 32 "C:\Users\Dawid\Documents\GIT\Aplikacje_WWW_S\SchoolRegister\SchoolRegister.Web\Views\Group\DetachStudentFromGroup.cshtml"
                                                         Write(Localizer["BackToList"]);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(988, 5, true);
                WriteLiteral("\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1000, 8, true);
            WriteLiteral("\n</div>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SchoolRegister.ViewModels.DTOs.AttachDetachStudentToGroupDto> Html { get; private set; }
    }
}
#pragma warning restore 1591