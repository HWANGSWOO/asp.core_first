#pragma checksum "C:\Users\edvan\source\repos\App\App\Views\Home\_TeacherTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "720ab46ebcd9e8255e806d82c61c6c4750ed6875"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__TeacherTable), @"mvc.1.0.view", @"/Views/Home/_TeacherTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_TeacherTable.cshtml", typeof(AspNetCore.Views_Home__TeacherTable))]
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
#line 1 "C:\Users\edvan\source\repos\App\App\Views\_ViewImports.cshtml"
using App;

#line default
#line hidden
#line 2 "C:\Users\edvan\source\repos\App\App\Views\_ViewImports.cshtml"
using App.Models;

#line default
#line hidden
#line 4 "C:\Users\edvan\source\repos\App\App\Views\_ViewImports.cshtml"
using App.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"720ab46ebcd9e8255e806d82c61c6c4750ed6875", @"/Views/Home/_TeacherTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a603609366d93e76bd1ce3c992b3b12edadf97c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__TeacherTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentTeacherViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(34, 176, true);
            WriteLiteral("\r\n\r\n<h3>Our Teachers</h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Class</th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 15 "C:\Users\edvan\source\repos\App\App\Views\Home\_TeacherTable.cshtml"
         foreach (var teacher in Model.Teachers)
        {

#line default
#line hidden
            BeginContext(271, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(302, 12, false);
#line 18 "C:\Users\edvan\source\repos\App\App\Views\Home\_TeacherTable.cshtml"
           Write(teacher.Name);

#line default
#line hidden
            EndContext();
            BeginContext(314, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(338, 13, false);
#line 19 "C:\Users\edvan\source\repos\App\App\Views\Home\_TeacherTable.cshtml"
           Write(teacher.Class);

#line default
#line hidden
            EndContext();
            BeginContext(351, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 21 "C:\Users\edvan\source\repos\App\App\Views\Home\_TeacherTable.cshtml"
        }

#line default
#line hidden
            BeginContext(384, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentTeacherViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591