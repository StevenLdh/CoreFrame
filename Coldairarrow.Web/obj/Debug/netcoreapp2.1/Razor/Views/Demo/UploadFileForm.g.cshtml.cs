#pragma checksum "D:\projectspace\Coldairarrow\src\Coldairarrow.Web\Views\Demo\UploadFileForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe971323e42cbd5d25c288d19712ae5e469cef67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_UploadFileForm), @"mvc.1.0.view", @"/Views/Demo/UploadFileForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Demo/UploadFileForm.cshtml", typeof(AspNetCore.Views_Demo_UploadFileForm))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe971323e42cbd5d25c288d19712ae5e469cef67", @"/Views/Demo/UploadFileForm.cshtml")]
    public class Views_Demo_UploadFileForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\projectspace\Coldairarrow\src\Coldairarrow.Web\Views\Demo\UploadFileForm.cshtml"
  
    Layout = "~/Views/Shared/_Layout_List.cshtml";

#line default
#line hidden
            DefineSection("toolbar", async() => {
                BeginContext(73, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(182, 691, true);
            WriteLiteral(@"<form id=""dataForm"" enctype=""multipart/form-data"" class=""easyui-form"" method=""post"" data-options=""novalidate:true"">
    <table class=""table_base"">
        <colgroup>
            <col style=""width:80px;"" />
        </colgroup>
        <tbody>
            <tr>
                <th>文件</th>
                <td>
                    <input style=""display:none"" id=""file"" type=""file"" accept=""*"">
                    <input id=""file-display"" class=""easyui-textbox"" data-options=""width:'200px',required:true"">
                    <label for=""file"" class=""easyui-linkbutton"" data-options=""iconCls:'icon-add'"">选择文件</label>
                </td>
            </tr>
        </tbody>
    </table>
</form>
");
            EndContext();
            DefineSection("foottoolbar", async() => {
                BeginContext(894, 110, true);
                WriteLiteral("\n    <a id=\"saveForm\" href=\"javascript:;\" class=\"easyui-linkbutton\" data-options=\"iconCls:\'icon-save\'\">上传</a>\n");
                EndContext();
            }
            );
            BeginContext(1006, 1129, true);
            WriteLiteral(@"<script>
    $(function () {
        document.getElementById('file').onchange = function () {
            $('#file').getFileBase64(function (base64, fileName) {
                $('#file-display').textbox('setValue', fileName);
            });
        };

        $('#saveForm').click(function () {
            if (!$('#dataForm').form('enableValidation').form('validate'))
                return;

            var formValues = $('#dataForm').getValues();
            loading();
            $('#file').getFileBase64(function (base64, fileName) {
                $.postJSON('/Demo/UploadFile', { fileName: fileName, fileBase64: base64 }, function (resJson) {
                    loading(false);

                    if (resJson.Success) {
                        parent.dialogMsg('上传成功!');
                        parent.$('#dataTable').datagrid('clearChecked').datagrid('reload');
                        parent.dialogClose('UploadFileForm');
                    }
                    else {
                        dialogErr");
            WriteLiteral("or(resJson.Msg);\n                    }\n                });\n            });\n        });\n    });\n</script>\n");
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
