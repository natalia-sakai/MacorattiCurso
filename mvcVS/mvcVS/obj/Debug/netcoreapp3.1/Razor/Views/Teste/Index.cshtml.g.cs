#pragma checksum "C:\Users\User\Documents\Natalia\mvcVS\mvcVS\Views\Teste\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65caa561bd989294aa6fad23377149553fa8884d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teste_Index), @"mvc.1.0.view", @"/Views/Teste/Index.cshtml")]
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
#line 1 "C:\Users\User\Documents\Natalia\mvcVS\mvcVS\Views\_ViewImports.cshtml"
using mvcVS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\Natalia\mvcVS\mvcVS\Views\_ViewImports.cshtml"
using mvcVS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65caa561bd989294aa6fad23377149553fa8884d", @"/Views/Teste/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b893aa70ccc0b4062ce9bd4e36548a6bbe1e9b56", @"/Views/_ViewImports.cshtml")]
    public class Views_Teste_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Documents\Natalia\mvcVS\mvcVS\Views\Teste\Index.cshtml"
                                                 
    var endereco = ViewData["Endereco"] as Endereco;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 10 "C:\Users\User\Documents\Natalia\mvcVS\mvcVS\Views\Teste\Index.cshtml"
Write(ViewBag.Saudacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h2>");
#nullable restore
#line 11 "C:\Users\User\Documents\Natalia\mvcVS\mvcVS\Views\Teste\Index.cshtml"
Write(ViewData["DataInicio"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<hr>\r\n");
            WriteLiteral("    ");
#nullable restore
#line 14 "C:\Users\User\Documents\Natalia\mvcVS\mvcVS\Views\Teste\Index.cshtml"
Write(ViewBag.Endereco.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n    ");
#nullable restore
#line 15 "C:\Users\User\Documents\Natalia\mvcVS\mvcVS\Views\Teste\Index.cshtml"
Write(ViewBag.Endereco.Rua);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n    ");
#nullable restore
#line 16 "C:\Users\User\Documents\Natalia\mvcVS\mvcVS\Views\Teste\Index.cshtml"
Write(ViewBag.Endereco.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 16 "C:\Users\User\Documents\Natalia\mvcVS\mvcVS\Views\Teste\Index.cshtml"
                         Write(ViewBag.Endereco.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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