#pragma checksum "F:\C#5\LAB_NOP\Assignment\Assignment\Assignment\Views\Users\GetUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "551edddf52cb4bce33113076a49a16091c6500fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_GetUsers), @"mvc.1.0.view", @"/Views/Users/GetUsers.cshtml")]
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
#line 1 "F:\C#5\LAB_NOP\Assignment\Assignment\Assignment\Views\_ViewImports.cshtml"
using Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\C#5\LAB_NOP\Assignment\Assignment\Assignment\Views\_ViewImports.cshtml"
using Assignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"551edddf52cb4bce33113076a49a16091c6500fb", @"/Views/Users/GetUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12290ae8b54fdba546f13d1190a2a2d1619f6758", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_GetUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<asmC5.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\C#5\LAB_NOP\Assignment\Assignment\Assignment\Views\Users\GetUsers.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\C#5\LAB_NOP\Assignment\Assignment\Assignment\Views\Users\GetUsers.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>DANH SÁCH USERS</h1>\r\n");
#nullable restore
#line 11 "F:\C#5\LAB_NOP\Assignment\Assignment\Assignment\Views\Users\GetUsers.cshtml"
  using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        User full name : ");
#nullable restore
#line 14 "F:\C#5\LAB_NOP\Assignment\Assignment\Assignment\Views\Users\GetUsers.cshtml"
                    Write(Html.TextBox("SearchString"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <input type=\"submit\" value=\"Tìm kiếm\" />\r\n    </p>\r\n");
#nullable restore
#line 16 "F:\C#5\LAB_NOP\Assignment\Assignment\Assignment\Views\Users\GetUsers.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "551edddf52cb4bce33113076a49a16091c6500fb5511", async() => {
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
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
               NAME
            </th>
            <th>
                EMAIL
            </th>
           
            <th>
                SEX
            </th>
            <th>
                DATE OF BIRTH
            </th>
            <th>
                PHONE
            </th>
            <th>
                ADDRESS
            </th>
           
            <th>
                ISDELETE
            </th>
            
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 52 "F:\C#5\LAB_NOP\Assignment\Assignment\Assignment\Views\Users\GetUsers.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "F:\C#5\LAB_NOP\Assignment\Assignment\Assignment\Views\Users\GetUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "F:\C#5\LAB_NOP\Assignment\Assignment\Assignment\Views\Users\GetUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n           \r\n            <td>\r\n                ");
#nullable restore
#line 62 "F:\C#5\LAB_NOP\Assignment\Assignment\Assignment\Views\Users\GetUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserGender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "F:\C#5\LAB_NOP\Assignment\Assignment\Assignment\Views\Users\GetUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserBirtday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "F:\C#5\LAB_NOP\Assignment\Assignment\Assignment\Views\Users\GetUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "F:\C#5\LAB_NOP\Assignment\Assignment\Assignment\Views\Users\GetUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n          \r\n            <td>\r\n                ");
#nullable restore
#line 75 "F:\C#5\LAB_NOP\Assignment\Assignment\Assignment\Views\Users\GetUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsDelete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 78 "F:\C#5\LAB_NOP\Assignment\Assignment\Assignment\Views\Users\GetUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Roles.RoleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n             <button style=\"width:80px\" type=\"button\" class=\"btn btn-outline-info\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "551edddf52cb4bce33113076a49a16091c6500fb10160", async() => {
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
#line 81 "F:\C#5\LAB_NOP\Assignment\Assignment\Assignment\Views\Users\GetUsers.cshtml"
                                                                                                               WriteLiteral(item.UserId);

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
            WriteLiteral("</button>\r\n                <button style=\"width:80px\"  type=\"button\" class=\"btn btn-outline-warning\">  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "551edddf52cb4bce33113076a49a16091c6500fb12487", async() => {
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
#line 82 "F:\C#5\LAB_NOP\Assignment\Assignment\Assignment\Views\Users\GetUsers.cshtml"
                                                                                                                      WriteLiteral(item.UserId);

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
            WriteLiteral(" </button>\r\n              \r\n");
#nullable restore
#line 84 "F:\C#5\LAB_NOP\Assignment\Assignment\Assignment\Views\Users\GetUsers.cshtml"
                     if (item.RoleID == 1)
                    {
                        
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "F:\C#5\LAB_NOP\Assignment\Assignment\Assignment\Views\Users\GetUsers.cshtml"
                     if(item.RoleID==2){

#line default
#line hidden
#nullable disable
            WriteLiteral("                         <button style=\"width:80px\"  type=\"button\" class=\"btn btn-outline-danger\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "551edddf52cb4bce33113076a49a16091c6500fb15352", async() => {
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
#line 89 "F:\C#5\LAB_NOP\Assignment\Assignment\Assignment\Views\Users\GetUsers.cshtml"
                                                                                                                           WriteLiteral(item.UserId);

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
            WriteLiteral("</button>\r\n");
#nullable restore
#line 90 "F:\C#5\LAB_NOP\Assignment\Assignment\Assignment\Views\Users\GetUsers.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n               \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 95 "F:\C#5\LAB_NOP\Assignment\Assignment\Assignment\Views\Users\GetUsers.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<asmC5.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591