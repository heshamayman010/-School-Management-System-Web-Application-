#pragma checksum "D:\csharp_projects\mvc projects\The_second_project\The_second_project\Views\Shared\_MYlayout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "448ecab74d6be44877f5b8a417f50abfe2fe2f628ded063a05db3b299c6c89c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MYlayout), @"mvc.1.0.view", @"/Views/Shared/_MYlayout.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\csharp_projects\mvc projects\The_second_project\The_second_project\Views\_ViewImports.cshtml"
using The_second_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\csharp_projects\mvc projects\The_second_project\The_second_project\Views\_ViewImports.cshtml"
using The_second_project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"448ecab74d6be44877f5b8a417f50abfe2fe2f628ded063a05db3b299c6c89c9", @"/Views/Shared/_MYlayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"cf39b0f46c03b876788cde4126694103bb9b9a96284d4f1c97e09050d46c880f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__MYlayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-signup"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-sb-form-api-token", new global::Microsoft.AspNetCore.Html.HtmlString("API_TOKEN"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "448ecab74d6be44877f5b8a417f50abfe2fe2f628ded063a05db3b299c6c89c96185", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 195, "\"", 205, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 234, "\"", 244, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
    <title>Grayscale - Start Bootstrap Theme</title>
    <link rel=""icon"" type=""image/x-icon"" href=""/assets/favicon.ico"" />
    <!-- Font Awesome icons (free version)-->
    <script src=""https://use.fontawesome.com/releases/v6.3.0/js/all.js"" crossorigin=""anonymous""></script>
    <!-- Google fonts-->
    <link href=""https://fonts.googleapis.com/css?family=Varela+Round"" rel=""stylesheet"" />
    <link href=""https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i"" rel=""stylesheet"" />
    <!-- Core theme CSS (includes Bootstrap)-->
    <link href=""/css/styles.css"" rel=""stylesheet"" />
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "448ecab74d6be44877f5b8a417f50abfe2fe2f628ded063a05db3b299c6c89c98359", async() => {
                WriteLiteral(@"
    <!-- Navigation-->
    <nav class=""navbar navbar-expand-lg navbar-light fixed-top"" id=""mainNav"">
        <div class=""container px-4 px-lg-5"">
            <a class=""navbar-brand"" href=""#page-top"">Start Bootstrap</a>
            <button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                Menu
                <i class=""fas fa-bars""></i>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
                <ul class=""navbar-nav ms-auto"">
                    <li class=""nav-item""><a class=""nav-link"" href=""#about"">About</a></li>
                    <li class=""nav-item""><a class=""nav-link"" href=""#projects"">Projects</a></li>
                    <li class=""nav-item""><a class=""nav-link"" href=""#signup"">Contact</a></li>
                </ul>
            </div>
        </div>
    </nav>
    <!");
                WriteLiteral(@"-- Masthead-->
    <header class=""masthead"">
        <div class=""container px-4 px-lg-5 d-flex h-100 align-items-center justify-content-center"">
            <div class=""d-flex justify-content-center"">
                <div class=""text-center"">
                    <h1 class=""mx-auto my-0 text-uppercase"">Grayscale</h1>
                    <h2 class=""text-white-50 mx-auto mt-2 mb-5"">A free, responsive, one page Bootstrap theme created by Start Bootstrap.</h2>
                    <a class=""btn btn-primary"" href=""#about"">Get Started</a>
                </div>
            </div>
        </div>
    </header>
    <!-- About-->
    <section class=""about-section text-center"" id=""about"">
        <div class=""container px-4 px-lg-5"">
            <div class=""row gx-4 gx-lg-5 justify-content-center"">
                <div class=""col-lg-8"">
                    <h2 class=""text-white mb-4"">Built with Bootstrap 5</h2>
                    <p class=""text-white-50"">
                        Grayscale is a free Boot");
                WriteLiteral(@"strap theme created by Start Bootstrap. It can be yours right now, simply download the template on
                        <a href=""https://startbootstrap.com/theme/grayscale/"">the preview page.</a>
                        The theme is open source, and you can use it for any purpose, personal or commercial.
                    </p>
                </div>
            </div>
            <img class=""img-fluid"" src=""/assets/img/ipad.png"" alt=""..."" />
        </div>
    </section>
    <!-- Projects-->
    <div>

        ");
#nullable restore
#line 67 "D:\csharp_projects\mvc projects\The_second_project\The_second_project\Views\Shared\_MYlayout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@" ;

    </div>

    <!-- Signup-->
    <section class=""signup-section"" id=""signup"">
        <div class=""container px-4 px-lg-5"">
            <div class=""row gx-4 gx-lg-5"">
                <div class=""col-md-10 col-lg-8 mx-auto text-center"">
                    <i class=""far fa-paper-plane fa-2x mb-2 text-white""></i>
                    <h2 class=""text-white mb-5"">Subscribe to receive updates!</h2>
                    <!-- * * * * * * * * * * * * * * *-->
                    <!-- * * SB Forms Contact Form * *-->
                    <!-- * * * * * * * * * * * * * * *-->
                    <!-- This form is pre-integrated with SB Forms.-->
                    <!-- To make this form functional, sign up at-->
                    <!-- https://startbootstrap.com/solution/contact-forms-->
                    <!-- to get an API token!-->
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "448ecab74d6be44877f5b8a417f50abfe2fe2f628ded063a05db3b299c6c89c912515", async() => {
                    WriteLiteral(@"
                        <!-- Email address input-->
                        <div class=""row input-group-newsletter"">
                            <div class=""col""><input class=""form-control"" id=""emailAddress"" type=""email"" placeholder=""Enter email address..."" aria-label=""Enter email address..."" data-sb-validations=""required,email"" /></div>
                            <div class=""col-auto""><button class=""btn btn-primary disabled"" id=""submitButton"" type=""submit"">Notify Me!</button></div>
                        </div>
                        <div class=""invalid-feedback mt-2"" data-sb-feedback=""emailAddress:required"">An email is required.</div>
                        <div class=""invalid-feedback mt-2"" data-sb-feedback=""emailAddress:email"">Email is not valid.</div>
                        <!-- Submit success message-->
                        <!---->
                        <!-- This is what your users will see when the form-->
                        <!-- has successfully submitted-->
               ");
                    WriteLiteral(@"         <div class=""d-none"" id=""submitSuccessMessage"">
                            <div class=""text-center mb-3 mt-2 text-white"">
                                <div class=""fw-bolder"">Form submission successful!</div>
                                To activate this form, sign up at
                                <br />
                                <a href=""https://startbootstrap.com/solution/contact-forms"">https://startbootstrap.com/solution/contact-forms</a>
                            </div>
                        </div>
                        <!-- Submit error message-->
                        <!---->
                        <!-- This is what your users will see when there is-->
                        <!-- an error submitting the form-->
                        <div class=""d-none"" id=""submitErrorMessage""><div class=""text-center text-danger mb-3 mt-2"">Error sending message!</div></div>
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
            </div>
        </div>
    </section>
    <!-- Contact-->
    <section class=""contact-section bg-black"">
        <div class=""container px-4 px-lg-5"">
            <div class=""row gx-4 gx-lg-5"">
                <div class=""col-md-4 mb-3 mb-md-0"">
                    <div class=""card py-4 h-100"">
                        <div class=""card-body text-center"">
                            <i class=""fas fa-map-marked-alt text-primary mb-2""></i>
                            <h4 class=""text-uppercase m-0"">Address</h4>
                            <hr class=""my-4 mx-auto"" />
                            <div class=""small text-black-50"">4923 Market Street, Orlando FL</div>
                        </div>
                    </div>
                </div>
                <div class=""col-md-4 mb-3 mb-md-0"">
                    <div class=""card py-4 h-100"">
                        <div class=""card-body text-center"">
                            <i class=""fas fa-envelope text-");
                WriteLiteral(@"primary mb-2""></i>
                            <h4 class=""text-uppercase m-0"">Email</h4>
                            <hr class=""my-4 mx-auto"" />
                            <div class=""small text-black-50""><a href=""#!"">hello@yourdomain.com</a></div>
                        </div>
                    </div>
                </div>
                <div class=""col-md-4 mb-3 mb-md-0"">
                    <div class=""card py-4 h-100"">
                        <div class=""card-body text-center"">
                            <i class=""fas fa-mobile-alt text-primary mb-2""></i>
                            <h4 class=""text-uppercase m-0"">Phone</h4>
                            <hr class=""my-4 mx-auto"" />
                            <div class=""small text-black-50"">+1 (555) 902-8832</div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""social d-flex justify-content-center"">
                <a class=""mx-2"" href=""#!""><i class=""fab fa");
                WriteLiteral(@"-twitter""></i></a>
                <a class=""mx-2"" href=""#!""><i class=""fab fa-facebook-f""></i></a>
                <a class=""mx-2"" href=""#!""><i class=""fab fa-github""></i></a>
            </div>
        </div>
    </section>
    <!-- Footer-->
    <footer class=""footer bg-black small text-center text-white-50""><div class=""container px-4 px-lg-5"">Copyright &copy; Your Website 2023</div></footer>
    <!-- Bootstrap core JS-->
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js""></script>
    <!-- Core theme JS-->
    <script src=""/js/scripts.js""></script>
    <!-- * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *-->
    <!-- * *                               SB Forms JS                               * *-->
    <!-- * * Activate your form at https://startbootstrap.com/solution/contact-forms * *-->
    <!-- * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *-->
    <script src=""https://cdn.startboots");
                WriteLiteral("trap.com/sb-forms-latest.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>
<script>

    <script src=""~/lib/jquery/dist/jquery.min.js"" ></script>
<script src=""https://cdn.jsdelivr.net/jquery.validation/1.16.0/jquery.validate.min.js""></script>
<script src=""https://cdn.jsdelivr.net/jquery.validation.unobtrusive/3.2.12/jquery.validate.unobtrusive.min.js""></script>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "448ecab74d6be44877f5b8a417f50abfe2fe2f628ded063a05db3b299c6c89c920549", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "448ecab74d6be44877f5b8a417f50abfe2fe2f628ded063a05db3b299c6c89c921613", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 177 "D:\csharp_projects\mvc projects\The_second_project\The_second_project\Views\Shared\_MYlayout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n</script>\r\n<div>\r\n\r\n    ");
#nullable restore
#line 184 "D:\csharp_projects\mvc projects\The_second_project\The_second_project\Views\Shared\_MYlayout.cshtml"
Write(await RenderSectionAsync("scripts", required: false));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591