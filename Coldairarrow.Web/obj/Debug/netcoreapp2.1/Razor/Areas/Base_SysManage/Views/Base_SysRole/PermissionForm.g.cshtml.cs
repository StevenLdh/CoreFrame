#pragma checksum "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_SysRole\PermissionForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74a733ec1fd606b5477f3a2abf0d7fcc1b756512"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Base_SysManage_Views_Base_SysRole_PermissionForm), @"mvc.1.0.view", @"/Areas/Base_SysManage/Views/Base_SysRole/PermissionForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Base_SysManage/Views/Base_SysRole/PermissionForm.cshtml", typeof(AspNetCore.Areas_Base_SysManage_Views_Base_SysRole_PermissionForm))]
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
#line 1 "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_SysRole\PermissionForm.cshtml"
using Coldairarrow.Business.Base_SysManage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74a733ec1fd606b5477f3a2abf0d7fcc1b756512", @"/Areas/Base_SysManage/Views/Base_SysRole/PermissionForm.cshtml")]
    public class Areas_Base_SysManage_Views_Base_SysRole_PermissionForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_SysRole\PermissionForm.cshtml"
  
    Layout = "~/Views/Shared/_Layout_List.cshtml";

    var permissions = PermissionManage.GetRolePermissionModules((string)ViewData["roleId"]);

#line default
#line hidden
            BeginContext(196, 391, true);
            WriteLiteral(@"<div class=""easyui-panel"" data-options=""fit:true,footer:'#ft_role_permission'"">
    <table id=""db_role_permission"" class=""table_base table_grid"" style=""width:100%;border-width:0;"">
        <thead>
            <tr>
                <th style=""width:100px;"">模块</th>
                <th>权限项</th>
                <th style=""width:80px;"">操作</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 18 "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_SysRole\PermissionForm.cshtml"
             foreach (var aModule in permissions)
            {

#line default
#line hidden
            BeginContext(651, 33, true);
            WriteLiteral("                <tr data-module=\"");
            EndContext();
            BeginContext(685, 13, false);
#line 20 "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_SysRole\PermissionForm.cshtml"
                            Write(aModule.Value);

#line default
#line hidden
            EndContext();
            BeginContext(698, 27, true);
            WriteLiteral("\">\n                    <td>");
            EndContext();
            BeginContext(726, 12, false);
#line 21 "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_SysRole\PermissionForm.cshtml"
                   Write(aModule.Name);

#line default
#line hidden
            EndContext();
            BeginContext(738, 64, true);
            WriteLiteral("</td>\n                    <td class=\"pretty-checkbox-mutiline\">\n");
            EndContext();
#line 23 "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_SysRole\PermissionForm.cshtml"
                         foreach (var item in aModule.Items)
                        {

#line default
#line hidden
            BeginContext(889, 114, true);
            WriteLiteral("                            <label class=\"pretty-checkbox\">\n                                <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1003, "\"", 1022, 1);
#line 26 "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_SysRole\PermissionForm.cshtml"
WriteAttributeValue("", 1011, item.Value, 1011, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1023, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1026, 43, false);
#line 26 "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_SysRole\PermissionForm.cshtml"
                                                                       Write(item.IsChecked ? "checked=\"checked\"" : "");

#line default
#line hidden
            EndContext();
            BeginContext(1070, 62, true);
            WriteLiteral(" />\n                                <i></i><span class=\"text\">");
            EndContext();
            BeginContext(1133, 9, false);
#line 27 "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_SysRole\PermissionForm.cshtml"
                                                     Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1142, 45, true);
            WriteLiteral("</span>\n                            </label>\n");
            EndContext();
#line 29 "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_SysRole\PermissionForm.cshtml"
                        }

#line default
#line hidden
            BeginContext(1213, 347, true);
            WriteLiteral(@"                    </td>
                    <td>
                        <a href=""javascript:void(0);"" class=""operate"" onclick=""role_permission_checkall.call(this)"">全选</a>
                        <a href=""javascript:void(0);"" class=""operate"" onclick=""role_permission_uncheckall.call(this)"">全消</a>
                    </td>
                </tr>
");
            EndContext();
#line 36 "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_SysRole\PermissionForm.cshtml"
            }

#line default
#line hidden
            BeginContext(1574, 262, true);
            WriteLiteral(@"        </tbody>
    </table>
</div>
<div id=""ft_role_permission"" style=""text-align:right;padding:5px;"">
    <a href=""javascript:;"" class=""easyui-linkbutton"" data-options=""iconCls:'icon-save'"" onclick=""savePermission()"">保存</a>
</div>
<script>
    var rootUrl = '");
            EndContext();
            BeginContext(1837, 17, false);
#line 44 "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_SysRole\PermissionForm.cshtml"
              Write(Url.Content("~/"));

#line default
#line hidden
            EndContext();
            BeginContext(1854, 1152, true);
            WriteLiteral(@"';
    var roleId = request('roleId');

    function role_permission_checkall() {
        $(this).closest('tr').find('input:checkbox').prop(""checked"", true);
    }
    function role_permission_uncheckall() {
        $(this).closest('tr').find('input:checkbox').prop(""checked"", false);
    }

    function savePermission() {
        var permissions = [];
        $(""#db_role_permission>tbody>tr"").each(function () {
            var moduleValue = $(this).data(""module"");
            var checked = $(this).find(""input:checked"");
            if (checked.length) {
                checked.each(function () {
                    var itemValue = this.value;

                    permissions.push(moduleValue + '.' + itemValue);
                });
            }
        });

        $.postJSON(rootUrl + 'Base_SysManage/Base_SysRole/SavePermission', {
            roleId: roleId,
            permissions: JSON.stringify(permissions)
        }, function (resJson) {
            if (resJson.Success) {
                parent.dialogMs");
            WriteLiteral("g(\'保存成功!\');\n            }\n            else {\n                dialogError(resJson.Msg);\n            }\n        });\n    }\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
