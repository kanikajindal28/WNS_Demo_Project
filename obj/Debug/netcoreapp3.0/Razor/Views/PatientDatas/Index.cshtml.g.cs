#pragma checksum "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "786120ba0df6f006c3f2018b6bde2351aaa9f1b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PatientDatas_Index), @"mvc.1.0.view", @"/Views/PatientDatas/Index.cshtml")]
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
#line 1 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\_ViewImports.cshtml"
using WNS_DEMOPROJECT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\_ViewImports.cshtml"
using WNS_DEMOPROJECT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"786120ba0df6f006c3f2018b6bde2351aaa9f1b8", @"/Views/PatientDatas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dbca962d7c34ebb8f387972f21efd03d0bb8a09", @"/Views/_ViewImports.cshtml")]
    public class Views_PatientDatas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WNS_DEMOPROJECT.Models.PatientData>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Index</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "786120ba0df6f006c3f2018b6bde2351aaa9f1b84594", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 16 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.assumptions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 19 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.data));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 22 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 28 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 32 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.assumptions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 35 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.data));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 38 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "786120ba0df6f006c3f2018b6bde2351aaa9f1b88087", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml"
                                           WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "786120ba0df6f006c3f2018b6bde2351aaa9f1b810259", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml"
                                              WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "786120ba0df6f006c3f2018b6bde2351aaa9f1b812438", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml"
                                             WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 46 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<button type=""submit"" id=""btn1"" class=""btn btn-primary"" onclick=""getRowTotal()"">STotal</button>
<button type=""submit"" id=""btn2"" class=""btn btn-primary""  onclick=""submitdata()"">Submit Data</button>
<table id=""tabler"" class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"">Assumption</th>
");
#nullable restore
#line 55 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml"
             for (var i = 2016; i < 2025; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th scope=\"col\">");
#nullable restore
#line 57 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml"
                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n");
#nullable restore
#line 58 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th scope=\"col\">Total</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 63 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml"
         foreach (var record in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n");
#nullable restore
#line 66 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml"
               
                var assump = record.assumptions;
                var year = record.year;
                decimal datas=0;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th scope=\"row\"> ");
#nullable restore
#line 71 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml"
                        Write(assump);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n");
#nullable restore
#line 72 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml"
             for (var i = 2016; i < 2025; i++)
            {
                if (i == year)
                    datas = record.data;
          

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td><input class=\"myclass\"");
            BeginWriteAttribute("year", " year=\"", 2225, "\"", 2234, 1);
#nullable restore
#line 77 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml"
WriteAttributeValue("", 2232, i, 2232, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("assumps", " assumps=\"", 2235, "\"", 2252, 1);
#nullable restore
#line 77 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml"
WriteAttributeValue("", 2245, assump, 2245, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2253, "\"", 2267, 1);
#nullable restore
#line 77 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml"
WriteAttributeValue("", 2261, datas, 2261, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:60px\" /></td>\n");
#nullable restore
#line 78 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml"
                datas = 0;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n            <td>\n                <p id=\"myp\"> </p>\n            </td>\n        </tr>\n");
#nullable restore
#line 87 "D:\AspNet\Patient-Data-Management-Syystem-master\Views\PatientDatas\Index.cshtml"
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <tr id=""mytr"">
            <td> Total</td>
        </tr>

    </tbody>

</table>
<script>
    jQuery('document').ready(function () {
        getRowTotal();



    });

    function getRowTotal() {
        $table1 = jQuery('#tabler')
        $table1.find('tbody tr').each(function () {
            var sum = 0;
            jQuery(this).find('input').each(function () {
                if( !isNaN(this.value))
                sum = sum + parseFloat(this.value);

            });
            // $table1.find('p').value = sum;

            $(""#myp"", this).html(sum);
        });


        //column total

        var result = [];

        $table1 = jQuery('#tabler');
        $table1.find('tbody tr').each(function (index, ele) {

            var rowInputs = ele.querySelectorAll('input');
//console.log(rowInputs);
            var row = [];
            rowInputs.forEach((cell) => {
                row.push(cell.value);
            });

            result.push(row);
        });
        let r = [];
      //  console.l");
            WriteLiteral(@"og(result);
        result.forEach(row => {
            var s = 0;
            
            row.forEach((cell, index) => {
             //   console.log(""index""+index);
             //   console.log(""cell value = ""+cell);
             
                if (!r[index]) {
                r[index] = parseFloat(cell);
               //     console.log(""r index =""+ r[index]);
                }
                else if (!isNaN(cell)) r[index] += parseFloat(cell);
            })
        })
        var mytr = document.querySelector('#mytr');
        mytr.innerHTML = '<td>Total</td>';
        r.forEach((value) => {
            mytr.innerHTML += `<td>${value}</td>`;
        })

    }

    function submitdata() {      
        var result = [];

        $table1 = jQuery('#tabler')
        $table1.find('tbody tr').each(function (index, ele) {
            var rowInputs = ele.querySelectorAll('input');
            var row = [];
            
            rowInputs.forEach((cell) => {
                if (cell.hasAttributes()) {
 ");
            WriteLiteral(@"                   var attrs = cell.attributes;
                    let i = 1;
                    var dataa = cell.value;
                    var yearr = attrs[i].value;
                    i++;
                    var assumptionss = attrs[i].value;
                    var obj = {
                        data: dataa,
                        year: yearr,
                        assumptions: assumptionss
                    };
                    row.push(obj);
                }
            });
           // console.log(row);
            result.push(row);
            
        });
        console.log(result);
        var data = JSON.stringify(result);
        //    console.log(data);
      $.ajax({
          type: 'POST',
          url: '/PatientDatas/Save',
          data: JSON.stringify(result),
           traditional: true,
          contentType: 'application/json',
          dataType: ""json"",
          success: function (response, data) {
           alert(response.someValue);
           },
          error: ");
            WriteLiteral("function (err) {\n              console.log(data);\n    }\n});\n\n\n        \n    }\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WNS_DEMOPROJECT.Models.PatientData>> Html { get; private set; }
    }
}
#pragma warning restore 1591
