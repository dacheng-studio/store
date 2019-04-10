#pragma checksum "E:\workspace\store\store\Views\Order\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "582fe63a28ff1f606c191da88c72558183900fcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_List), @"mvc.1.0.view", @"/Views/Order/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/List.cshtml", typeof(AspNetCore.Views_Order_List))]
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
#line 1 "E:\workspace\store\store\Views\_ViewImports.cshtml"
using store;

#line default
#line hidden
#line 2 "E:\workspace\store\store\Views\_ViewImports.cshtml"
using store.Models;

#line default
#line hidden
#line 1 "E:\workspace\store\store\Views\Order\List.cshtml"
using Model.Entity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"582fe63a28ff1f606c191da88c72558183900fcb", @"/Views/Order/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"566700498a609f6e2f7139cc0b245fed22787aa0", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/Paging.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 392, true);
            WriteLiteral(@"<style>
    .table tbody tr td {
        vertical-align: middle;
    }
</style>

<div class=""panel"">


    <table class=""table table-striped"">
        <tr>
            <td>编号</td>
            <td>用户名</td>
            <td>商品名</td>
            <td>数量</td>
            <td>寄往地址</td>
            <td>收件人</td>
            <td>收件人联系方式</td>
            <td>操作</td>
        </tr>
");
            EndContext();
#line 22 "E:\workspace\store\store\Views\Order\List.cshtml"
         foreach (T_Order order in ViewBag.list)
        {

#line default
#line hidden
            BeginContext(474, 46, true);
            WriteLiteral("        <tr>\r\n            <td class=\"td-text\">");
            EndContext();
            BeginContext(521, 8, false);
#line 25 "E:\workspace\store\store\Views\Order\List.cshtml"
                           Write(order.id);

#line default
#line hidden
            EndContext();
            BeginContext(529, 39, true);
            WriteLiteral("</td>\r\n            <td class=\"td-text\">");
            EndContext();
            BeginContext(569, 21, false);
#line 26 "E:\workspace\store\store\Views\Order\List.cshtml"
                           Write(order.userEntity.name);

#line default
#line hidden
            EndContext();
            BeginContext(590, 39, true);
            WriteLiteral("</td>\r\n            <td class=\"td-text\">");
            EndContext();
            BeginContext(630, 22, false);
#line 27 "E:\workspace\store\store\Views\Order\List.cshtml"
                           Write(order.goodsEntity.name);

#line default
#line hidden
            EndContext();
            BeginContext(652, 39, true);
            WriteLiteral("</td>\r\n            <td class=\"td-text\">");
            EndContext();
            BeginContext(692, 14, false);
#line 28 "E:\workspace\store\store\Views\Order\List.cshtml"
                           Write(order.quantity);

#line default
#line hidden
            EndContext();
            BeginContext(706, 39, true);
            WriteLiteral("</td>\r\n            <td class=\"td-text\">");
            EndContext();
            BeginContext(746, 21, false);
#line 29 "E:\workspace\store\store\Views\Order\List.cshtml"
                           Write(order.addrEntity.addr);

#line default
#line hidden
            EndContext();
            BeginContext(767, 39, true);
            WriteLiteral("</td>\r\n            <td class=\"td-text\">");
            EndContext();
            BeginContext(807, 21, false);
#line 30 "E:\workspace\store\store\Views\Order\List.cshtml"
                           Write(order.addrEntity.name);

#line default
#line hidden
            EndContext();
            BeginContext(828, 39, true);
            WriteLiteral("</td>\r\n            <td class=\"td-text\">");
            EndContext();
            BeginContext(868, 23, false);
#line 31 "E:\workspace\store\store\Views\Order\List.cshtml"
                           Write(order.addrEntity.mobile);

#line default
#line hidden
            EndContext();
            BeginContext(891, 79, true);
            WriteLiteral("</td>\r\n            <td>\r\n                <button class=\"btn btn-default btn-sm\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 970, "\"", 995, 3);
            WriteAttributeValue("", 980, "edit(", 980, 5, true);
#line 33 "E:\workspace\store\store\Views\Order\List.cshtml"
WriteAttributeValue("", 985, order.id, 985, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 994, ")", 994, 1, true);
            EndWriteAttribute();
            BeginContext(996, 115, true);
            WriteLiteral(">查看</button>\r\n                <button class=\"btn btn-danger btn-sm\">删除</button>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 37 "E:\workspace\store\store\Views\Order\List.cshtml"
        }

#line default
#line hidden
            BeginContext(1122, 43, true);
            WriteLiteral("    </table>\r\n\r\n    <!--引入分页Layout-->\r\n    ");
            EndContext();
            BeginContext(1165, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a5274bf0665497b9aded20cb62f55a7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1212, 462, true);
            WriteLiteral(@"
</div>



<script>
    function edit(id) {
        location.href = ""../store/edit?goodsId="" + id;
    }

    function del(id) {
        $.ajax({
            url: 'delGoods',
            data: {
                goodsId: id
            },
            method: 'post',
            success: function (json) {
                alert(json);
                setTimeout(window.location.reload(), 2000);
            }
        });
    }


</script>");
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
