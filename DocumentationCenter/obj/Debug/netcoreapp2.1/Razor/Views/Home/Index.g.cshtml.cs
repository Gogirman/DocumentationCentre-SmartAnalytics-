#pragma checksum "C:\Users\Шипик\source\repos\DocumentationCenter\DocumentationCenter\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b33c4bd095fc403cbf83d5064b8d0650cc57df17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Шипик\source\repos\DocumentationCenter\DocumentationCenter\Views\_ViewImports.cshtml"
using DocumentationCenter;

#line default
#line hidden
#line 2 "C:\Users\Шипик\source\repos\DocumentationCenter\DocumentationCenter\Views\_ViewImports.cshtml"
using DocumentationCenter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b33c4bd095fc403cbf83d5064b8d0650cc57df17", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fa4e6ccebf1c6b7e74e424ae0a766ed793c8161", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DocumentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddFile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddFolder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Шипик\source\repos\DocumentationCenter\DocumentationCenter\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Documentation Centre";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(105, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(139, 655, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1136d4b2f1bb4e4bb7bf8e65c4c3824e", async() => {
                BeginContext(232, 555, true);
                WriteLiteral(@"
    <p>
        <label>Аннотация</label>
        <input name=""Annotation"" class=""form-control"" />
    </p>
    <p>
        <label>Документ</label>
        <input name=""FileDocument"" type=""file"" class=""form-control"" accept=""application/vnd.openxmlformats-officedocument.spreadsheetml.sheet,application/vnd.ms-excel"" size=""5"" />
    </p>
    <p>
        <input type=""submit"" value=""Добавить файл"" class=""form-control"" size=""5"" />
    </p>
    <p>
        <input id=""filePath"" name=""MasterGuid"" class=""form-control"" type=""hidden"" />
    </p>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(794, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(831, 454, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "716638803e0d43a0a2b2ec552877792f", async() => {
                BeginContext(926, 352, true);
                WriteLiteral(@"
    <p>
        <label>Имя</label>
        <input name=""Name"" class=""form-control"" size=""5"" />
    </p>
    <p>
        <label>Аннотация</label>
        <input name=""Annotation"" class=""form-control"" size=""5"" />
    </p>

    <p>
        <input id=""addFolder"" type=""submit"" value=""Добавить папку"" class=""form-control"" size=""5"" />
    </p>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1285, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1308, 41, true);
            WriteLiteral("<label class=\"annotation\" >\r\n\r\n</label>\r\n");
            EndContext();
            BeginContext(1370, 64, true);
            WriteLiteral("<ul class=\"list-group btn-group-toggle\" data-toggle=\"buttons\">\r\n");
            EndContext();
#line 46 "C:\Users\Шипик\source\repos\DocumentationCenter\DocumentationCenter\Views\Home\Index.cshtml"
     foreach (var file1 in Model.Files.Where(f => f.ParentId == null))
    {
        

#line default
#line hidden
            BeginContext(1522, 22, false);
#line 48 "C:\Users\Шипик\source\repos\DocumentationCenter\DocumentationCenter\Views\Home\Index.cshtml"
   Write(Html.CreateList(file1));

#line default
#line hidden
            EndContext();
#line 48 "C:\Users\Шипик\source\repos\DocumentationCenter\DocumentationCenter\Views\Home\Index.cshtml"
                               
    }

#line default
#line hidden
            BeginContext(1553, 13, true);
            WriteLiteral("</ul>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1583, 16, true);
                WriteLiteral("\r\n    <script>\r\n");
                EndContext();
                BeginContext(1635, 221, true);
                WriteLiteral("            function Delete() {\r\n                $(\'button.deleteFile\').on(\'click\', function () {\r\n                    if ($(this).attr(\'parametre\')) {\r\n                        $.ajax({\r\n                            url: \'");
                EndContext();
                BeginContext(1857, 28, false);
#line 61 "C:\Users\Шипик\source\repos\DocumentationCenter\DocumentationCenter\Views\Home\Index.cshtml"
                             Write(Url.Action("Delete", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(1885, 375, true);
                WriteLiteral(@"',
                            data: { parametre: $(this).attr('parametre') },
                            method: ""POST"",
                            success: function (id) {

                                $('#' + id).remove();
                            }
                        });
                    }
                });
        };
        $(Delete());
");
                EndContext();
                BeginContext(2309, 236, true);
                WriteLiteral("        $(function () {\r\n            var clicks = 0;\r\n            $(document).on(\'click\', function (e) {\r\n                if (!$(\'.form-control\').is(e.target))\r\n                    $(\'#filePath\').val(\'\');\r\n            });\r\n        });\r\n");
                EndContext();
                BeginContext(2581, 227, true);
                WriteLiteral("        $(function () {\r\n            var clicks = 0;\r\n            $(\'a.list-group-item\').on(\'click\', function () {\r\n                if ($(this).attr(\'primarykey\')) {\r\n                    $.ajax({\r\n                        url: \'");
                EndContext();
                BeginContext(2809, 28, false);
#line 87 "C:\Users\Шипик\source\repos\DocumentationCenter\DocumentationCenter\Views\Home\Index.cshtml"
                         Write(Url.Action("Select", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(2837, 400, true);
                WriteLiteral(@"',
                        data: { primarykey: $(this).attr('primarykey') },
                        method: ""POST"",
                        success: function (file) {
                            $('#filePath').val(file.id);
                            $('.annotation').text(file.annotation);
                        }
                    });
                }
            });
        });
");
                EndContext();
                BeginContext(3278, 554, true);
                WriteLiteral(@"        $(function () {
            $('a.list-group-item').on('dblclick', function () {
                if ($(this).hasClass('opened')) {
                    $(this).removeClass('opened');
                    var parent = $(this).parent();
                    parent.children('ul').remove();
                    console.log(parent);
                }
                else {
                    $(this).addClass('opened')
                    if ($(this).attr('primarykey')) {
                        $.ajax({
                            url: '");
                EndContext();
                BeginContext(3833, 31, false);
#line 111 "C:\Users\Шипик\source\repos\DocumentationCenter\DocumentationCenter\Views\Home\Index.cshtml"
                             Write(Url.Action("GetFolder", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(3864, 1926, true);
                WriteLiteral(@"',
                            data: { primarykey: $(this).attr('primarykey') },
                            method: ""POST"",
                            success: function (files) {
                                var s = '<ul>';
                                if (!$(this).empty())
                                {
                                    for (var i = 0; i < files.length; i++) {
                                        $(""#"" + files[i].parentId).remove();
                                    }
                                }
                                else {
                                    for (var i = 0; i < files.length; i++) {
                                        s += '<li id=""' + files[i].id + '"">';
                                        s += '<a class=""list-group-item secondLevel asd"" primarykey=""' + files[i].id + '"">'
                                        s += '<button class=""deleteFile"" parametre=""' + files[i].id + '"">'
                                        ");
                WriteLiteral(@"s += '<img class=""elementPhoto"" src=""http://s1.iconbird.com/ico/2013/9/452/w448h5121380477116trash.png"">'
                                        s += '</button>'
                                        s += '<img class=""elementPhoto"" src=""' + files[i].baseIcon + '"">'
                                        s += '<p class=""elementText"">' + files[i].name + '</p>'
                                        s += '</a>';
                                        s += '</li>';
                                    }
                                    s += '</ul>';
                                    $(""#"" + files[0].parentId).append(s);
                                    Delete();
                                    Download();
                            }
                            }
                        });
                    }
                }
            });
        });
");
                EndContext();
                BeginContext(5838, 194, true);
                WriteLiteral("        function Download() {\r\n            $(\'.asd\').on(\'dblclick\', function () {\r\n                if ($(this).attr(\'primarykey\')) {\r\n                    $.ajax({\r\n                        url: \'");
                EndContext();
                BeginContext(6033, 30, false);
#line 150 "C:\Users\Шипик\source\repos\DocumentationCenter\DocumentationCenter\Views\Home\Index.cshtml"
                         Write(Url.Action("Download", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(6063, 777, true);
                WriteLiteral(@"',
                        data: { primarykey: $(this).attr('primarykey') },
                        method: ""POST"",
                        success:
                            function (file) {
                                var blob = new Blob([file.fileDocument], { type: ""application/"" + file.format});
                                var link = document.createElement('a');
                                link.href = window.URL.createObjectURL(blob);
                                var fileName = file.name;
                                link.download = fileName;
                                link.click();
                            }
                    });
                }
            });
        };
        $(Download());
    </script>

");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DocumentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
