#pragma checksum "/Users/takahashikazuhiro/Desktop/work/vagrant/asp_net_core_test/SampleMVCApp/SampleMVCApp/Views/Hello/_table.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38f09db4e04bf45994be4b9687be0ee30d58640b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hello__table), @"mvc.1.0.view", @"/Views/Hello/_table.cshtml")]
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
#line 1 "/Users/takahashikazuhiro/Desktop/work/vagrant/asp_net_core_test/SampleMVCApp/SampleMVCApp/Views/_ViewImports.cshtml"
using SampleMVCApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/takahashikazuhiro/Desktop/work/vagrant/asp_net_core_test/SampleMVCApp/SampleMVCApp/Views/_ViewImports.cshtml"
using SampleMVCApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38f09db4e04bf45994be4b9687be0ee30d58640b", @"/Views/Hello/_table.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8634379219d6a5f30fbe0da2c23774f4343c00f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Hello__table : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/Users/takahashikazuhiro/Desktop/work/vagrant/asp_net_core_test/SampleMVCApp/SampleMVCApp/Views/Hello/_table.cshtml"
  
	string[] header = (string[])ViewData["header"];
	string[][] data = (string[][])ViewData["data"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\n\t<tr>\n");
#nullable restore
#line 10 "/Users/takahashikazuhiro/Desktop/work/vagrant/asp_net_core_test/SampleMVCApp/SampleMVCApp/Views/Hello/_table.cshtml"
     foreach(string item in header)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<th>");
#nullable restore
#line 12 "/Users/takahashikazuhiro/Desktop/work/vagrant/asp_net_core_test/SampleMVCApp/SampleMVCApp/Views/Hello/_table.cshtml"
       Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n");
#nullable restore
#line 13 "/Users/takahashikazuhiro/Desktop/work/vagrant/asp_net_core_test/SampleMVCApp/SampleMVCApp/Views/Hello/_table.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</tr>\n\n");
#nullable restore
#line 16 "/Users/takahashikazuhiro/Desktop/work/vagrant/asp_net_core_test/SampleMVCApp/SampleMVCApp/Views/Hello/_table.cshtml"
     foreach(var row in data)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<tr>\n");
#nullable restore
#line 19 "/Users/takahashikazuhiro/Desktop/work/vagrant/asp_net_core_test/SampleMVCApp/SampleMVCApp/Views/Hello/_table.cshtml"
         foreach(var item in row)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<td>");
#nullable restore
#line 21 "/Users/takahashikazuhiro/Desktop/work/vagrant/asp_net_core_test/SampleMVCApp/SampleMVCApp/Views/Hello/_table.cshtml"
           Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 22 "/Users/takahashikazuhiro/Desktop/work/vagrant/asp_net_core_test/SampleMVCApp/SampleMVCApp/Views/Hello/_table.cshtml"
	    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</tr>\n");
#nullable restore
#line 24 "/Users/takahashikazuhiro/Desktop/work/vagrant/asp_net_core_test/SampleMVCApp/SampleMVCApp/Views/Hello/_table.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n");
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