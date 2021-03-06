#pragma checksum "C:\Users\Steven\Downloads\Web Development Technologies\SampleTest\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2871ad6542c4b3f2b769d826a93408300fce2b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Index), @"mvc.1.0.view", @"/Views/Course/Index.cshtml")]
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
#line 1 "C:\Users\Steven\Downloads\Web Development Technologies\SampleTest\Views\_ViewImports.cshtml"
using SampleTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Steven\Downloads\Web Development Technologies\SampleTest\Views\_ViewImports.cshtml"
using SampleTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2871ad6542c4b3f2b769d826a93408300fce2b5", @"/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"887dfc661e87731a49c26b07f0b97821826b4347", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Course>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Steven\Downloads\Web Development Technologies\SampleTest\Views\Course\Index.cshtml"
  
    ViewData["Title"] = "View All Courses";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>View All Courses</h1>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 10 "C:\Users\Steven\Downloads\Web Development Technologies\SampleTest\Views\Course\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CourseID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\Steven\Downloads\Web Development Technologies\SampleTest\Views\Course\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Steven\Downloads\Web Development Technologies\SampleTest\Views\Course\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Credits));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 21 "C:\Users\Steven\Downloads\Web Development Technologies\SampleTest\Views\Course\Index.cshtml"
         if (Model.Any())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Steven\Downloads\Web Development Technologies\SampleTest\Views\Course\Index.cshtml"
             foreach (var course in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\Steven\Downloads\Web Development Technologies\SampleTest\Views\Course\Index.cshtml"
                   Write(course.CourseID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\Steven\Downloads\Web Development Technologies\SampleTest\Views\Course\Index.cshtml"
                   Write(course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\Steven\Downloads\Web Development Technologies\SampleTest\Views\Course\Index.cshtml"
                   Write(course.Credits);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 30 "C:\Users\Steven\Downloads\Web Development Technologies\SampleTest\Views\Course\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Steven\Downloads\Web Development Technologies\SampleTest\Views\Course\Index.cshtml"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>No Courses Were Found.</td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Steven\Downloads\Web Development Technologies\SampleTest\Views\Course\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
