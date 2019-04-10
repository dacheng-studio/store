#pragma checksum "E:\workspace\store\store\Views\Shared\Paging.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b91cc1d1a08bf88408d42a87d4cce29904fd68dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Paging), @"mvc.1.0.view", @"/Views/Shared/Paging.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Paging.cshtml", typeof(AspNetCore.Views_Shared_Paging))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b91cc1d1a08bf88408d42a87d4cce29904fd68dd", @"/Views/Shared/Paging.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"566700498a609f6e2f7139cc0b245fed22787aa0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Paging : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 237, true);
            WriteLiteral("\r\n<ul class=\"pagination paging\"></ul>\r\n\r\n<script>\r\n\r\n    //分页相关 - Begin\r\n    $(function () {\r\n        //来自url\r\n        var page = $_Request[\"p\"];\r\n        if (!page)\r\n            page = 1;\r\n\r\n        //来自ViewBag\r\n        var totalRows = ");
            EndContext();
            BeginContext(239, 41, false);
#line 14 "E:\workspace\store\store\Views\Shared\Paging.cshtml"
                    Write(ViewBag.total == null ? 1 : ViewBag.total);

#line default
#line hidden
            EndContext();
            BeginContext(281, 26, true);
            WriteLiteral(";\r\n        var pageSize = ");
            EndContext();
            BeginContext(309, 48, false);
#line 15 "E:\workspace\store\store\Views\Shared\Paging.cshtml"
                   Write(ViewBag.pageSize == null ? 10 : ViewBag.pageSize);

#line default
#line hidden
            EndContext();
            BeginContext(358, 1408, true);
            WriteLiteral(@";

        //计算总页数
        //alert(totalRows % pageSize);
        var pageCount = Math.floor(totalRows % pageSize == 0 ? totalRows / pageSize : totalRows / pageSize + 1);

        //计算起始页数
        var pageStart = page <= 5 ? 1 : page - 5;
        pageStart = pageStart <= 1 ? 1 : pageStart;

        //计算结束页数
        var pageEnd = (page <= 5 ? 10 : parseInt(page) + 5);
        pageEnd = (pageEnd >= pageCount ? pageCount : pageEnd);


        var HTML = """";

        if (page > 1) {
            HTML += ""<li><a href='"" + urlEdit(location.href, ""p"", 1) + ""'><i class='fa fa-step-backward'></a></i></li>"";
            HTML += ""<li><a href='"" + urlEdit(location.href, ""p"", page - 1) + ""'><i class='fa fa-play fa-rotate-180'></i></a></li>"";
        }
        for (var i = pageStart; i <= pageEnd; i++) {
            HTML += ""<li class="" + (i == page ? ""active"" : """") + ""><a href='"" + urlEdit(location.href, ""p"", i) + ""'>"" + i + ""</a></li>"";
        }

        if (page < pageCount) {
            HTML ");
            WriteLiteral(@"+= ""<li><a href='"" + urlEdit(location.href, ""p"", ++page) + ""'><i class='fa fa-play'></i></a></li>"";
            HTML += ""<li><a href='"" + urlEdit(location.href, ""p"", pageCount) + ""'> <i class='fa fa-step-forward'></i></a></li>"";
	 }

        HTML += ""<li><a>共 "" + totalRows + "" 条,"" + pageCount + "" 页</a></li>"";

        $("".paging"").html(HTML);

    });//分页相关 - End
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
