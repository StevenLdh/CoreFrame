#pragma checksum "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_DatabaseLink\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1f3a709c8cf99c77a84f2d1e4d511bfc9656602"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Base_SysManage_Views_Base_DatabaseLink_Form), @"mvc.1.0.view", @"/Areas/Base_SysManage/Views/Base_DatabaseLink/Form.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Base_SysManage/Views/Base_DatabaseLink/Form.cshtml", typeof(AspNetCore.Areas_Base_SysManage_Views_Base_DatabaseLink_Form))]
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
#line 1 "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_DatabaseLink\Form.cshtml"
using Coldairarrow.Entity.Base_SysManage;

#line default
#line hidden
#line 2 "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_DatabaseLink\Form.cshtml"
using Coldairarrow.Util;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1f3a709c8cf99c77a84f2d1e4d511bfc9656602", @"/Areas/Base_SysManage/Views/Base_DatabaseLink/Form.cshtml")]
    public class Areas_Base_SysManage_Views_Base_DatabaseLink_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_DatabaseLink\Form.cshtml"
  
    Layout = "~/Views/Shared/_Layout_List.cshtml";

    var obj = (Base_DatabaseLink)Model;
    var objStr = Html.Raw(obj.ToJson());

#line default
#line hidden
            BeginContext(208, 365, true);
            WriteLiteral(@"
<form id=""dataForm"" enctype=""multipart/form-data"" class=""easyui-form"" method=""post"" data-options=""novalidate:true"">
    <table class=""table_base"">
        <colgroup>
            <col style=""width:80px;"" />
        </colgroup>
        <tbody>
            
            <tr>
                <th>连接名</th>
                <td>
                    <input name=""LinkName""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 573, "\"", 594, 1);
#line 21 "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_DatabaseLink\Form.cshtml"
WriteAttributeValue("", 581, obj.LinkName, 581, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(595, 224, true);
            WriteLiteral(" class=\"easyui-textbox\" data-options=\"width:\'200px\',required:true\">\n                </td>\n            </tr>\n            <tr>\n                <th>连接字符串</th>\n                <td>\n                    <input name=\"ConnectionStr\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 819, "\"", 845, 1);
#line 27 "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_DatabaseLink\Form.cshtml"
WriteAttributeValue("", 827, obj.ConnectionStr, 827, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(846, 274, true);
            WriteLiteral(@" class=""easyui-textbox"" data-options=""width:'200px',required:true"">
                </td>
            </tr>
            <tr>
                <th>数据库类型</th>
                <td>
                    <select name=""DbType"" class=""easyui-combobox"" data-options=""width:200,value:'");
            EndContext();
            BeginContext(1121, 10, false);
#line 33 "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_DatabaseLink\Form.cshtml"
                                                                                            Write(obj.DbType);

#line default
#line hidden
            EndContext();
            BeginContext(1131, 461, true);
            WriteLiteral(@"',required:true"">
                        <option value=""SqlServer"">SqlServer</option>
                        <option value=""MySql"">MySql</option>
                        <option value=""Oracle"">Oracle</option>
                        <option value=""PostgreSql"">PostgreSql</option>
                    </select>
                </td>
            </tr>
            <tr>
                <th>排序编号</th>
                <td>
                    <input name=""SortNum""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1592, "\"", 1612, 1);
#line 44 "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_DatabaseLink\Form.cshtml"
WriteAttributeValue("", 1600, obj.SortNum, 1600, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1613, 148, true);
            WriteLiteral(" class=\"easyui-textbox\" data-options=\"width:\'200px\',required:false\">\n                </td>\n            </tr>\n        </tbody>\n    </table>\n</form>\n\n");
            EndContext();
            DefineSection("foottoolbar", async() => {
                BeginContext(1782, 110, true);
                WriteLiteral("\n    <a id=\"saveForm\" href=\"javascript:;\" class=\"easyui-linkbutton\" data-options=\"iconCls:\'icon-save\'\">保存</a>\n");
                EndContext();
            }
            );
            BeginContext(1894, 29, true);
            WriteLiteral("\n<script>\n    var rootUrl = \'");
            EndContext();
            BeginContext(1924, 17, false);
#line 56 "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_DatabaseLink\Form.cshtml"
              Write(Url.Content("~/"));

#line default
#line hidden
            EndContext();
            BeginContext(1941, 23, true);
            WriteLiteral("\';\n    var theEntity = ");
            EndContext();
            BeginContext(1965, 6, false);
#line 57 "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_DatabaseLink\Form.cshtml"
               Write(objStr);

#line default
#line hidden
            EndContext();
            BeginContext(1971, 751, true);
            WriteLiteral(@";

    $(function () {
        $('#saveForm').click(function () {
            if (!$('#dataForm').form('enableValidation').form('validate'))
                return;

            var formValues = $('#dataForm').getValues();
            $.extend(theEntity, formValues);
            $.postJSON(rootUrl + 'Base_SysManage/Base_DatabaseLink/SaveData', theEntity, function (resJson) {
                if (resJson.Success) {
                    parent.dialogMsg('保存成功!');
                    parent.dialogClose('form');
                    parent.$('#dataTable').datagrid('clearChecked').datagrid('reload');
                }
                else {
                    dialogError(resJson.Msg);
                }
            });
        });
    });
</script>
");
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
