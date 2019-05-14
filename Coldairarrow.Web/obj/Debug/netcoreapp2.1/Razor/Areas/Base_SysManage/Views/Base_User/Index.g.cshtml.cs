#pragma checksum "D:\projectspace\Coldairarrow\src\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b733e889590b131fd8ca98a162137957f78e5405"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Base_SysManage_Views_Base_User_Index), @"mvc.1.0.view", @"/Areas/Base_SysManage/Views/Base_User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Base_SysManage/Views/Base_User/Index.cshtml", typeof(AspNetCore.Areas_Base_SysManage_Views_Base_User_Index))]
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
#line 1 "D:\projectspace\Coldairarrow\src\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_User\Index.cshtml"
using Coldairarrow.Business.Base_SysManage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b733e889590b131fd8ca98a162137957f78e5405", @"/Areas/Base_SysManage/Views/Base_User/Index.cshtml")]
    public class Areas_Base_SysManage_Views_Base_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "D:\projectspace\Coldairarrow\src\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_User\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout_List.cshtml";

    var manage = PermissionManage.OperatorHasPermissionValue("sysuser.manage");
    var manageSysPermission = PermissionManage.OperatorHasPermissionValue("sysuser.manageSysPermission");

#line default
#line hidden
            BeginContext(289, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("toolbar", async() => {
                BeginContext(307, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 11 "D:\projectspace\Coldairarrow\src\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_User\Index.cshtml"
     if (manage)
    {

#line default
#line hidden
                BeginContext(331, 269, true);
                WriteLiteral(@"        <a id=""add"" class=""easyui-linkbutton"" data-options=""iconCls:'icon-add'"">添加</a>
        <a id=""edit"" class=""easyui-linkbutton"" data-options=""iconCls:'icon-edit'"">修改</a>
        <a id=""delete"" class=""easyui-linkbutton"" data-options=""iconCls:'icon-remove'"">删除</a>
");
                EndContext();
#line 16 "D:\projectspace\Coldairarrow\src\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_User\Index.cshtml"
    }

#line default
#line hidden
            }
            );
            BeginContext(608, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("search", async() => {
                BeginContext(625, 688, true);
                WriteLiteral(@"
    <div class=""search_wrapper"">
        <div class=""search_item"">
            <label class=""search_label"">查询类别</label>
            <select name=""condition"" class=""easyui-combobox"" data-options=""width:100"">
                <option value="""">请选择</option>

                <option value=""UserName"">用户名</option>
                <option value=""RealName"">真实姓名</option>
            </select>
            <input name=""keyword"" class=""easyui-textbox"" style=""width:150px"" />
        </div>
        <div class=""search_submit"">
            <a href=""javascript:;"" class=""easyui-linkbutton"" data-options=""iconCls:'icon-search'"" onclick=""searchGrid(this,'#dataTable')"">查询</a>
        </div>
    </div>
");
                EndContext();
            }
            );
            BeginContext(1315, 58, true);
            WriteLiteral("<div id=\"dataTable\">\n\n</div>\n\n<script>\n    var rootUrl = \'");
            EndContext();
            BeginContext(1374, 17, false);
#line 41 "D:\projectspace\Coldairarrow\src\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_User\Index.cshtml"
              Write(Url.Content("~/"));

#line default
#line hidden
            EndContext();
            BeginContext(1391, 32, true);
            WriteLiteral("\';\n    var manageSysPermission =");
            EndContext();
            BeginContext(1424, 40, false);
#line 42 "D:\projectspace\Coldairarrow\src\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_User\Index.cshtml"
                        Write(manageSysPermission.ToString().ToLower());

#line default
#line hidden
            EndContext();
            BeginContext(1464, 4208, true);
            WriteLiteral(@";

    function initTable() {
        $('#dataTable').datagrid({
            url: rootUrl + 'Base_SysManage/Base_User/GetDataList',
            method: 'POST',
            //queryParams: { 'id': id },
            idField: 'Id',
            fit: true,
            fitColumns: true,
            singleSelect: false,
            selectOnCheck: false,
            checkOnSelect: false,
            //rownumbers: true,
            pagination: true,
            pageSize: 30,
            //nowrap: false,
            pageList: [10, 20, 30, 50, 100, 150, 200],
            //showFooter: true,
            columns: [[
                { title: 'ck', field: 'ck', checkbox: true },
                { title: '用户名', field: 'UserName', width: 200 },
                { title: '真实姓名', field: 'RealName', width: 200 },
                {
                    title: '性别', field: 'Sex', width: 200, formatter: function (value, row) {
                        var mapping = {
                            '1': '男',
                            '0'");
            WriteLiteral(@": '女'
                        };

                        return mapping[value];
                    }
                },
                {
                    title: '出生日期', field: 'Birthday', width: 200, formatter: function (value) {
                        return toDateString(value, 'yyyy-MM-dd');
                    }
                },
                { title: '所属角色', field: 'RoleNameList', width: 600 },
                {
                    title: '操作', field: '_', width: 200, fixed: true, formatter: function (value, row) {
                        var html = '';
                        if (manageSysPermission && row['UserId'] != 'Admin') {
                            html += '<a href=""javascript:;"" onclick=""setPermission(\'{0}\',\'{1}\')"">设置权限</a>'.format(row['UserId'], row['RealName']);
                        }

                        return html;
                    }
                }
            ]],
            onBeforeSelect: function () {
                return false;
            }
        });
 ");
            WriteLiteral(@"   }

    $(function () {
        initTable();

        //添加数据
        $('#add').click(function () {
            dialogOpen({
                id: 'form',
                title: '添加数据',
                width: 500,
                height: 445,
                url: rootUrl + 'Base_SysManage/Base_User/Form',
            });
        });

        //修改数据
        $('#edit').click(function () {
            var selected = $(""#dataTable"").datagrid(""getChecked"");
            if (!selected || !selected.length) {
                dialogError('请选择要修改的记录!');
                return;
            }
            var id = selected[0].Id;

            dialogOpen({
                id: 'form',
                title: '修改数据',
                width: 500,
                height: 445,
                url: rootUrl + 'Base_SysManage/Base_User/Form?id=' + id,
            });
        });

        //删除数据
        $('#delete').click(function () {
            var checked = $(""#dataTable"").datagrid(""getChecked"");
            if (!checked || !checke");
            WriteLiteral(@"d.length) {
                dialogError('请选择要删除的记录!');
                return;
            }
            var ids = $.map(checked, function (item) {
                return item['Id'];
            });

            dialogComfirm('确认删除吗？', function () {
                $.postJSON(rootUrl + 'Base_SysManage/Base_User/DeleteData', { ids: JSON.stringify(ids) }, function (resJson) {
                    if (resJson.Success) {
                        $('#dataTable').datagrid('clearSelections').datagrid('clearChecked');
                        $('#dataTable').datagrid('reload');
                        dialogMsg('删除成功!');
                    }
                    else {
                        dialogError(resJson.Msg);
                    }
                });
            });
        });
    });

    //设置权限
    function setPermission(userId, realName) {
        dialogOpen({
            id: 'permissionForm',
            title: '设置用户【{0}】权限'.format(realName),
            width: '80%',
            height: '80%',
           ");
            WriteLiteral(" url: rootUrl + \'Base_SysManage/Base_User/PermissionForm?userId={0}\'.format(userId),\n        });\n    }\n</script>");
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
