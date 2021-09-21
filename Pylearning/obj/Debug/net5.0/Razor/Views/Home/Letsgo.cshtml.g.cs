#pragma checksum "/home/lucas/Project_Csharp/Pylearning/Views/Home/Letsgo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce31e37a4a7c98480b10e181f48a948b7b72bb55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Letsgo), @"mvc.1.0.view", @"/Views/Home/Letsgo.cshtml")]
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
#line 1 "/home/lucas/Project_Csharp/Pylearning/Views/_ViewImports.cshtml"
using Pylearning;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/lucas/Project_Csharp/Pylearning/Views/_ViewImports.cshtml"
using Pylearning.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce31e37a4a7c98480b10e181f48a948b7b72bb55", @"/Views/Home/Letsgo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f872bb1313668c665f1d7b3333f768cd1e2e862", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Letsgo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("tblFruits"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/lucas/Project_Csharp/Pylearning/Views/Home/Letsgo.cshtml"
  
    ViewData["Title"] = "Let's Go";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "/home/lucas/Project_Csharp/Pylearning/Views/Home/Letsgo.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<p>What is Python?
Python is a popular programming language. It was created by Guido van Rossum, and released in 1991.

It is used for:

web development (server-side),
software development,
mathematics,
system scripting.
What can Python do?
Python can be used on a server to create web applications.
Python can be used alongside software to create workflows.
Python can connect to database systems. It can also read and modify files.
Python can be used to handle big data and perform complex mathematics.
Python can be used for rapid prototyping, or for production-ready software development.
Why Python?
Python works on different platforms (Windows, Mac, Linux, Raspberry Pi, etc).
Python has a simple syntax similar to the English language.
Python has syntax that allows developers to write programs with fewer lines than some other programming languages.
Python runs on an interpreter system, meaning that code can be executed as soon as it is written. This means that prototyping can be very ");
            WriteLiteral(@"quick.
Python can be treated in a procedural way, an object-oriented way or a functional way.
Good to know
The most recent major version of Python is Python 3, which we shall be using in this tutorial. However, Python 2, although not being updated with anything other than security updates, is still quite popular.
In this tutorial Python will be written in a text editor. It is possible to write Python in an Integrated Development Environment, such as Thonny, Pycharm, Netbeans or Eclipse which are particularly useful when managing larger collections of Python files.
Python Syntax compared to other programming languages
Python was designed for readability, and has some similarities to the English language with influence from mathematics.
Python uses new lines to complete a command, as opposed to other programming languages which often use semicolons or parentheses.
Python relies on indentation, using whitespace, to define scope; such as the scope of loops, functions and classes. Other programming languag");
            WriteLiteral("es often use curly-brackets for this purpose.</p>\r\n\r\n<h4>O que faz o print() no Python?</h4>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce31e37a4a7c98480b10e181f48a948b7b72bb556040", async() => {
                WriteLiteral(@"
    
    <input type=""checkbox"" id = 'answer_1' value = '1' onclick = ""Disabled_answer1()""> A) Recebe um valor. <br/>
    <input type=""checkbox"" id = 'answer_2' value = '2' onclick = ""Disabled_answer2()""> B) Mostra algo na tela.<br/>
    <input type=""checkbox"" id = 'answer_3' value = '3' onclick = ""Disabled_answer3()""> C) Muda a cor. <br/>
    <input type=""checkbox"" id = 'answer_4' value = '4' onclick = ""Disabled_answer4()""> D) Nada. <br/>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<button onclick=""send_response()"">Click me</button>

<p id=""demo""></p>

<script>
    function Disabled_answer1()
    {
        if ((document.getElementById(""answer_1"").checked == true) && (document.getElementById(""answer_4"").checked == false) && (document.getElementById(""answer_2"").checked == false) && (document.getElementById(""answer_3"").checked == false))
        {
            document.getElementById(""answer_3"").disabled = true; 
            document.getElementById(""answer_2"").disabled = true;
            document.getElementById(""answer_4"").disabled = true;
        }
        else
        {
            document.getElementById(""answer_2"").disabled = false;
            document.getElementById(""answer_3"").disabled = false;
            document.getElementById(""answer_4"").disabled = false;
        }
        
    }

    function Disabled_answer2()
    {
        if ((document.getElementById(""answer_2"").checked == true) && (document.getElementById(""answer_4"").checked == false) && (documen");
            WriteLiteral(@"t.getElementById(""answer_1"").checked == false) && (document.getElementById(""answer_3"").checked == false))
        {
            document.getElementById(""answer_3"").disabled = true; 
            document.getElementById(""answer_1"").disabled = true;
            document.getElementById(""answer_4"").disabled = true;
        }
        else
        {
            document.getElementById(""answer_1"").disabled = false;
            document.getElementById(""answer_3"").disabled = false;
            document.getElementById(""answer_4"").disabled = false;
        }
    }
    function Disabled_answer3()
    {
        if ((document.getElementById(""answer_3"").checked == true) && (document.getElementById(""answer_4"").checked == false) && (document.getElementById(""answer_1"").checked == false) && (document.getElementById(""answer_2"").checked == false))
        {
            document.getElementById(""answer_2"").disabled = true; 
            document.getElementById(""answer_1"").disabled = true;
            document.getEl");
            WriteLiteral(@"ementById(""answer_4"").disabled = true;
        }
        else
        {
            document.getElementById(""answer_4"").disabled = false;
            document.getElementById(""answer_1"").disabled = false;
            document.getElementById(""answer_2"").disabled = false;
        }
    }
    function Disabled_answer4()
    {
        if ((document.getElementById(""answer_3"").checked == false) && (document.getElementById(""answer_4"").checked == true) && (document.getElementById(""answer_1"").checked == false) && (document.getElementById(""answer_2"").checked == false))
        {
            document.getElementById(""answer_2"").disabled = true; 
            document.getElementById(""answer_1"").disabled = true;
            document.getElementById(""answer_3"").disabled = true;
        }
        else
        {
            document.getElementById(""answer_4"").disabled = false;
            document.getElementById(""answer_1"").disabled = false;
            document.getElementById(""answer_3"").disabled = false;
");
            WriteLiteral(@"        }
    }

    function send_response()
    {
        
        var answer_1 = document.getElementById(""answer_1"");
        var answer_2 = document.getElementById(""answer_2"");
        var answer_3 = document.getElementById(""answer_3"");
        var answer_4 = document.getElementById(""answer_4"");
        if (answer_1.checked == true)
        {
            window.alert(answer_1.value);
        }
        else if (answer_2.checked == true)
        {
            window.alert(answer_2.value);
        }
        else if (answer_3.checked == true)
        {
            window.alert(answer_3.value);
        }
        else
        {
            window.alert(answer_4.value);
        }
    }
</script>");
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
