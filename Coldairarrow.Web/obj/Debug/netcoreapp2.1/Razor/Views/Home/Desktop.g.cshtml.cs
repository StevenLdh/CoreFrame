#pragma checksum "D:\projectspace\Coldairarrow\src\Coldairarrow.Web\Views\Home\Desktop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0475960f1b7cd674fb8822e16eec5fdfccb0523a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Desktop), @"mvc.1.0.view", @"/Views/Home/Desktop.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Desktop.cshtml", typeof(AspNetCore.Views_Home_Desktop))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0475960f1b7cd674fb8822e16eec5fdfccb0523a", @"/Views/Home/Desktop.cshtml")]
    public class Views_Home_Desktop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 24, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n\n");
            EndContext();
            BeginContext(24, 226, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c93e86cc107453c9e7b89f2a8f4a512", async() => {
                BeginContext(30, 74, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <title></title>\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 104, "\"", 162, 1);
#line 7 "D:\projectspace\Coldairarrow\src\Coldairarrow.Web\Views\Home\Desktop.cshtml"
WriteAttributeValue("", 111, Url.Scrpit("~/Scripts/vendor/layui/css/layui.css"), 111, 51, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(163, 30, true);
                WriteLiteral(" />\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 193, "\"", 238, 1);
#line 8 "D:\projectspace\Coldairarrow\src\Coldairarrow.Web\Views\Home\Desktop.cshtml"
WriteAttributeValue("", 200, Url.Scrpit("~/Skin/home/desktop.css"), 200, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(239, 4, true);
                WriteLiteral(" />\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(250, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(252, 7452, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a88100c169f4ee6b2d7ba1e9100f420", async() => {
                BeginContext(258, 7439, true);
                WriteLiteral(@"
    <div class=""admin-main"">
        <blockquote class=""layui-elem-quote"">
            <p>本框架旨在极大的提高开发效率</p>
            <p>
                使用技术栈：<br />
                后端：采用.NET Core平台，ASP.NET Core，C#语言（使用反射等高级技术），Entity Framework Core（数据库ORM框架）。<br />
                使用数据仓储模式，抽象化数据库操作(CRUD等)、支持事务处理以及分布式事务处理（跨库）<br />
                禁用系统Session,使用自定义Session，提高系统性能<br />
                集成多种工具类库以及操作拓展<br />
                数据库：SqlServer（框架使用简单工厂，工厂方法，抽象工厂，可轻松更换数据库）,Redis作为分布式缓存<br />
                前端：HTML5,JS,JQuery,Easyui（主要前端框架），其中集成多种JS插件，力求方便项目开发。
                <br />
                <br />
                具体技术实施：<br />
                项目采用前后端完全分离模式，并采用严格分层模式，极大的增加聚合度，降低耦合度，<br />
                提高代码的健壮性，可维护性。<br />
                前后端通过数据接口操作数据，统一使用JSON作为数据格式，并使用默认接口签名算法保证接口的安全性。
                <br />
                <br />
                功能架构部分详解：<br />
                快速开发：此功能为框架的核心，通过选择数据库中的表，就能自动生成对应的实体层、业务逻辑层、控制器、视图，以及对应的配置，即无需编写代码即可生成基本的CRUD操作。<br />
                接口密钥管理：管理接口的密钥，若开启接口签名");
                WriteLiteral(@"的规则，则前端需要通过给接口签名才能够正常访问后台接口。<br />
                权限管理：提供健全的权限管理功能，支持给系统用户、系统角色和对外接口AppId分配权限
                <br />
                <br />
                相关技术文档:<br />
                Easyui:<a href=""http://www.jeasyui.net/"" target=""_blank"">http://www.jeasyui.net/</a>
            </p>
            <br />
        </blockquote>
        <fieldset class=""layui-elem-field"">
            <legend>更新日志</legend>
            <div class=""layui-field-box"">
                <fieldset class=""layui-elem-field layui-field-title"">
                    <legend>2018-01-08</legend>
                    <div class=""layui-field-box"">
                        <p>
                            框架移植整合到Easyui
                        </p>
                    </div>
                </fieldset>
                <fieldset class=""layui-elem-field layui-field-title"">
                    <legend>2017-11-16</legend>
                    <div class=""layui-field-box"">
                        <p>
                            添加数据库分布式事务支持
               ");
                WriteLiteral(@"         </p>
                    </div>
                </fieldset>
                <fieldset class=""layui-elem-field layui-field-title"">
                    <legend>2017-11-15</legend>
                    <div class=""layui-field-box"">
                        <p>
                            数据库事务优化
                        </p>
                    </div>
                </fieldset>
                <fieldset class=""layui-elem-field layui-field-title"">
                    <legend>2017-11-13</legend>
                    <div class=""layui-field-box"">
                        <p>
                            数据库操作优化
                        </p>
                    </div>
                </fieldset>
                <fieldset class=""layui-elem-field layui-field-title"">
                    <legend>2017-11-12</legend>
                    <div class=""layui-field-box"">
                        <p>
                            实体生成，添加对PostgreSql的支持
                        </p>
                    </div>
                </fie");
                WriteLiteral(@"ldset>
                <fieldset class=""layui-elem-field layui-field-title"">
                    <legend>2017-11-08</legend>
                    <div class=""layui-field-box"">
                        <p>
                            数据仓储更新优化
                        </p>
                    </div>
                </fieldset>
                <fieldset class=""layui-elem-field layui-field-title"">
                    <legend>2017-11-08</legend>
                    <div class=""layui-field-box"">
                        <p>
                            初步整体完成~~
                        </p>
                    </div>
                </fieldset>
                <fieldset class=""layui-elem-field layui-field-title"">
                    <legend>2017-11-06</legend>
                    <div class=""layui-field-box"">
                        <p>
                            1:添加验证插件<br />
                            2:加载动画
                        </p>
                    </div>
                </fieldset>
                <fieldset");
                WriteLiteral(@" class=""layui-elem-field layui-field-title"">
                    <legend>2017-11-04</legend>
                    <div class=""layui-field-box"">
                        <p>
                            禁用自带Session，使用自定义Session，提高并发性能
                        </p>
                    </div>
                </fieldset>
                <fieldset class=""layui-elem-field layui-field-title"">
                    <legend>2017-10-31</legend>
                    <div class=""layui-field-box"">
                        <p>
                            完成用户管理，权限管理
                        </p>
                    </div>
                </fieldset>
                <fieldset class=""layui-elem-field layui-field-title"">
                    <legend>2017-10-23</legend>
                    <div class=""layui-field-box"">
                        <p>
                            Wcf优化，不再需要添加服务引用，可以直接使用接口创建客户端
                        </p>
                    </div>
                </fieldset>
                <fieldset class=""layui-elem-field ");
                WriteLiteral(@"layui-field-title"">
                    <legend>2017-10-17</legend>
                    <div class=""layui-field-box"">
                        <p>
                            代码生成（完成部分）
                        </p>
                    </div>
                </fieldset>
                <fieldset class=""layui-elem-field layui-field-title"">
                    <legend>2017-10-14</legend>
                    <div class=""layui-field-box"">
                        <p>
                            1:更新完善签名<br />
                            2:SocketUdp框架初步完成
                        </p>
                    </div>
                </fieldset>
                <fieldset class=""layui-elem-field layui-field-title"">
                    <legend>2017-10-11</legend>
                    <div class=""layui-field-box"">
                        <p>
                            1:添加密钥管理<br />
                            2:更新Socket框架
                        </p>
                    </div>
                </fieldset>
                <field");
                WriteLiteral(@"set class=""layui-elem-field layui-field-title"">
                    <legend>2017-10-07</legend>
                    <div class=""layui-field-box"">
                        <p>
                            完成实体生成功能
                        </p>
                    </div>
                </fieldset>
                <fieldset class=""layui-elem-field layui-field-title"">
                    <legend>2017-10-05</legend>
                    <div class=""layui-field-box"">
                        <p>
                            完成数据库连接管理
                        </p>
                    </div>
                </fieldset>
                <fieldset class=""layui-elem-field layui-field-title"">
                    <legend>2017-10-03</legend>
                    <div class=""layui-field-box"">
                        <p>
                            完成系统功能模块
                        </p>
                    </div>
                </fieldset>
                <fieldset class=""layui-elem-field layui-field-title"">
                    <leg");
                WriteLiteral(@"end>2017-10-02</legend>
                    <div class=""layui-field-box"">
                        <p>
                            系统功能管理
                        </p>
                    </div>
                </fieldset>
            </div>
        </fieldset>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7704, 8, true);
            WriteLiteral("\n</html>");
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
