#pragma checksum "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_User\ChangePwdForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c441e217c87b4b1a459896dc883b064006ab54a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Base_SysManage_Views_Base_User_ChangePwdForm), @"mvc.1.0.view", @"/Areas/Base_SysManage/Views/Base_User/ChangePwdForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Base_SysManage/Views/Base_User/ChangePwdForm.cshtml", typeof(AspNetCore.Areas_Base_SysManage_Views_Base_User_ChangePwdForm))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c441e217c87b4b1a459896dc883b064006ab54a", @"/Areas/Base_SysManage/Views/Base_User/ChangePwdForm.cshtml")]
    public class Areas_Base_SysManage_Views_Base_User_ChangePwdForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_User\ChangePwdForm.cshtml"
  
    Layout = "~/Views/Shared/_Layout_List.cshtml";

#line default
#line hidden
            BeginContext(56, 720, true);
            WriteLiteral(@"
<form id=""dataForm"" enctype=""multipart/form-data"" class=""easyui-form"" method=""post"" data-options=""novalidate:true"">
    <table class=""table_base"">
        <colgroup>
            <col style=""width:80px;"" />
        </colgroup>
        <tbody>
            <tr>
                <th>原密码</th>
                <td>
                    <input name=""oldPwd"" class=""easyui-passwordbox"" data-options=""width:'200px',required:true"">
                </td>
            </tr>
            <tr>
                <th>新密码</th>
                <td>
                    <input name=""newPwd"" class=""easyui-passwordbox"" data-options=""width:'200px',required:true"">
                </td>
            </tr>
        </tbody>
    </table>
</form>

");
            EndContext();
            DefineSection("foottoolbar", async() => {
                BeginContext(797, 110, true);
                WriteLiteral("\n    <a id=\"saveForm\" href=\"javascript:;\" class=\"easyui-linkbutton\" data-options=\"iconCls:\'icon-save\'\">保存</a>\n");
                EndContext();
            }
            );
            BeginContext(909, 29, true);
            WriteLiteral("\n<script>\n    var rootUrl = \'");
            EndContext();
            BeginContext(939, 17, false);
#line 32 "D:\projectspace\CoreFrame\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_User\ChangePwdForm.cshtml"
              Write(Url.Content("~/"));

#line default
#line hidden
            EndContext();
            BeginContext(956, 621, true);
            WriteLiteral(@"';
    $(function () {
        $('#saveForm').click(function () {
            if (!$('#dataForm').form('enableValidation').form('validate'))
                return;

            var formValues = $('#dataForm').getValues();
            $.postJSON(rootUrl + 'Base_SysManage/Base_User/ChangePwd', formValues, function (resJson) {
                if (resJson.Success) {
                    parent.dialogMsg('修改成功!');
                    parent.dialogClose('changePwdForm');
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
