#pragma checksum "C:\Users\yoelvis\source\repos\RegistroBlazor\Pages\Registros\RPrestamos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "053e9c1014a0465bf0125a4a2d2dee14d52f8052"
// <auto-generated/>
#pragma warning disable 1591
namespace RegistroBlazor.Pages.Registros
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\yoelvis\source\repos\RegistroBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yoelvis\source\repos\RegistroBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yoelvis\source\repos\RegistroBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\yoelvis\source\repos\RegistroBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\yoelvis\source\repos\RegistroBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\yoelvis\source\repos\RegistroBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\yoelvis\source\repos\RegistroBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\yoelvis\source\repos\RegistroBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\yoelvis\source\repos\RegistroBlazor\_Imports.razor"
using RegistroBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\yoelvis\source\repos\RegistroBlazor\_Imports.razor"
using RegistroBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yoelvis\source\repos\RegistroBlazor\Pages\Registros\RPrestamos.razor"
using BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\yoelvis\source\repos\RegistroBlazor\Pages\Registros\RPrestamos.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\yoelvis\source\repos\RegistroBlazor\Pages\Registros\RPrestamos.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\yoelvis\source\repos\RegistroBlazor\Pages\Registros\RPrestamos.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Prestamos")]
    public partial class RPrestamos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\yoelvis\source\repos\RegistroBlazor\Pages\Registros\RPrestamos.razor"
                 Prestamo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\yoelvis\source\repos\RegistroBlazor\Pages\Registros\RPrestamos.razor"
                                          Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n\r\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "card");
                __builder2.AddAttribute(8, "style", "align-self:self-start");
                __builder2.AddMarkupContent(9, "<div class=\"card-header\"><h3>Registro de Personas</h3>\r\n            <style type=\"text/css\">\r\n                label {\r\n                    width: 200px;\r\n                    display: inline-block;\r\n                }\r\n            </style></div>\r\n\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "card-body");
                __builder2.AddAttribute(12, "style", "align-self:self-start");
                __builder2.OpenElement(13, "form");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-row align-items-lg-start");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "col");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-inline");
                __builder2.AddMarkupContent(20, "<label><strong>Id</strong></label>\r\n                            ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "input-group");
                __Blazor.RegistroBlazor.Pages.Registros.RPrestamos.TypeInference.CreateInputNumber_0(__builder2, 23, 24, "form-control col-4", 25, 
#nullable restore
#line 33 "C:\Users\yoelvis\source\repos\RegistroBlazor\Pages\Registros\RPrestamos.razor"
                                                          Prestamo.PrestamoId

#line default
#line hidden
#nullable disable
                , 26, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Prestamo.PrestamoId = __value, Prestamo.PrestamoId)), 27, () => Prestamo.PrestamoId);
                __builder2.AddMarkupContent(28, "\r\n                                ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "input-group-append");
                __builder2.OpenElement(31, "button");
                __builder2.AddAttribute(32, "type", "button");
                __builder2.AddAttribute(33, "class", "btn btn-toolbar input-group-text");
                __builder2.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\yoelvis\source\repos\RegistroBlazor\Pages\Registros\RPrestamos.razor"
                                                                                                             Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(35, "<span class=\"oi oi-magnifying-glass mr-2\"></span>Buscar");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n\r\n                <br>\r\n\r\n                ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-row align-items-lg-start");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "col");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-inline");
                __builder2.AddMarkupContent(43, "<label><strong>Persona</strong></label>\r\n                            ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "input-group");
                __Blazor.RegistroBlazor.Pages.Registros.RPrestamos.TypeInference.CreateInputSelect_1(__builder2, 46, 47, "form-control col-4", 48, 
#nullable restore
#line 50 "C:\Users\yoelvis\source\repos\RegistroBlazor\Pages\Registros\RPrestamos.razor"
                                                          Prestamo.PersonaId

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Prestamo.PersonaId = __value, Prestamo.PersonaId)), 50, () => Prestamo.PersonaId, 51, (__builder3) => {
                    __builder3.AddMarkupContent(52, "<option value=\"0\">Selecciona una persona</option>");
#nullable restore
#line 53 "C:\Users\yoelvis\source\repos\RegistroBlazor\Pages\Registros\RPrestamos.razor"
                                     foreach (var persona in PersonasBLL.GetList(per => true))
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(53, "option");
                    __builder3.AddAttribute(54, "value", 
#nullable restore
#line 55 "C:\Users\yoelvis\source\repos\RegistroBlazor\Pages\Registros\RPrestamos.razor"
                                                        persona.PersonaId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(55, 
#nullable restore
#line 55 "C:\Users\yoelvis\source\repos\RegistroBlazor\Pages\Registros\RPrestamos.razor"
                                                                            persona.Cedula

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(56, " >>> ");
                    __builder3.AddContent(57, 
#nullable restore
#line 55 "C:\Users\yoelvis\source\repos\RegistroBlazor\Pages\Registros\RPrestamos.razor"
                                                                                                persona.Nombres

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 56 "C:\Users\yoelvis\source\repos\RegistroBlazor\Pages\Registros\RPrestamos.razor"
                                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n\r\n                <br>\r\n\r\n                ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "form-row align-items-lg-start");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "col");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-inline");
                __builder2.AddMarkupContent(65, "<label><strong>Concepto</strong></label>\r\n                            ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "input-group");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(68);
                __builder2.AddAttribute(69, "class", "form-control");
                __builder2.AddAttribute(70, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 71 "C:\Users\yoelvis\source\repos\RegistroBlazor\Pages\Registros\RPrestamos.razor"
                                                            Prestamo.Concepto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Prestamo.Concepto = __value, Prestamo.Concepto))));
                __builder2.AddAttribute(72, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Prestamo.Concepto));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n\r\n                <br>\r\n\r\n                ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "form-row align-items-lg-start");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "col");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "form-inline");
                __builder2.AddMarkupContent(80, "<label><strong>Monto</strong></label>\r\n                            ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "input-group");
                __Blazor.RegistroBlazor.Pages.Registros.RPrestamos.TypeInference.CreateInputNumber_2(__builder2, 83, 84, "form-control", 85, 
#nullable restore
#line 85 "C:\Users\yoelvis\source\repos\RegistroBlazor\Pages\Registros\RPrestamos.razor"
                                                          Prestamo.Monto

#line default
#line hidden
#nullable disable
                , 86, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Prestamo.Monto = __value, Prestamo.Monto)), 87, () => Prestamo.Monto);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n\r\n                <br>\r\n\r\n                ");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "form-row align-items-lg-start");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "col");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "form-inline");
                __builder2.AddMarkupContent(95, "<label><strong>Balance</strong></label>\r\n                            ");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "input-group");
                __Blazor.RegistroBlazor.Pages.Registros.RPrestamos.TypeInference.CreateInputNumber_3(__builder2, 98, 99, true, 100, "form-control", 101, 
#nullable restore
#line 99 "C:\Users\yoelvis\source\repos\RegistroBlazor\Pages\Registros\RPrestamos.razor"
                                                                   Prestamo.Balance

#line default
#line hidden
#nullable disable
                , 102, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Prestamo.Balance = __value, Prestamo.Balance)), 103, () => Prestamo.Balance);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n\r\n                <br>\r\n\r\n                ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "form-row align-items-lg-start");
                __builder2.OpenElement(107, "div");
                __builder2.AddAttribute(108, "class", "col");
                __builder2.OpenElement(109, "div");
                __builder2.AddAttribute(110, "class", "form-inline");
                __builder2.AddMarkupContent(111, "<label><strong>Fecha</strong></label>\r\n                            ");
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "input-group");
                __Blazor.RegistroBlazor.Pages.Registros.RPrestamos.TypeInference.CreateInputDate_4(__builder2, 114, 115, "form-control", 116, 
#nullable restore
#line 113 "C:\Users\yoelvis\source\repos\RegistroBlazor\Pages\Registros\RPrestamos.razor"
                                                        Prestamo.Fecha

#line default
#line hidden
#nullable disable
                , 117, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Prestamo.Fecha = __value, Prestamo.Fecha)), 118, () => Prestamo.Fecha);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n\r\n                <br>\r\n\r\n                ");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "card-footer");
                __builder2.AddAttribute(122, "style", "align-self:self-start");
                __builder2.OpenElement(123, "div");
                __builder2.AddAttribute(124, "class", "form-group text-center");
                __builder2.AddAttribute(125, "display:");
                __builder2.AddAttribute(126, "inline-block");
                __builder2.OpenElement(127, "button");
                __builder2.AddAttribute(128, "type", "button");
                __builder2.AddAttribute(129, "class", "btn btn-outline-primary");
                __builder2.AddAttribute(130, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 123 "C:\Users\yoelvis\source\repos\RegistroBlazor\Pages\Registros\RPrestamos.razor"
                                                                                        Nuevo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(131, "<span class=\"oi oi-file mr-2\"></span>Nuevo");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n                        &nbsp;&nbsp;\r\n                        ");
                __builder2.OpenElement(133, "button");
                __builder2.AddAttribute(134, "type", "button");
                __builder2.AddAttribute(135, "class", "btn btn-outline-primary");
                __builder2.AddAttribute(136, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 125 "C:\Users\yoelvis\source\repos\RegistroBlazor\Pages\Registros\RPrestamos.razor"
                                                                                        Guardar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(137, "<span class=\"oi oi-account-login mr-2\"></span>Guardar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\r\n                        &nbsp;&nbsp;\r\n                        ");
                __builder2.OpenElement(139, "button");
                __builder2.AddAttribute(140, "type", "button");
                __builder2.AddAttribute(141, "class", "btn btn-outline-primary");
                __builder2.AddAttribute(142, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 127 "C:\Users\yoelvis\source\repos\RegistroBlazor\Pages\Registros\RPrestamos.razor"
                                                                                        Eliminar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(143, "<span class=\"oi oi-trash mr-2\"></span>Eliminar");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 137 "C:\Users\yoelvis\source\repos\RegistroBlazor\Pages\Registros\RPrestamos.razor"
       
    [Parameter]
    public int PrestamoId { get; set; }

    private Prestamos Prestamo { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        Nuevo();
        Buscar();
    }

    public void Nuevo()
    {
        Prestamo = new Prestamos();
    }
    
    public void Buscar()
    {
        if (Prestamo.PrestamoId > 0)
        {
            var encontrado = PrestamosBLL.Buscar(Prestamo.PrestamoId);

            if (encontrado != null)
                this.Prestamo = encontrado;
            else
            {
                toast.ShowWarning("No Encontrado");
            }
        }
    }

    public void Guardar()
    {
        bool guardo;

        guardo = PrestamosBLL.Guardar(Prestamo);

        if (guardo)
        {
            Nuevo();
            toast.ShowSuccess("Guardado correctamente");
        }
        else
        {
            toast.ShowError("No se pudo guardar.");
        }
    }

    public void Eliminar()
    {
        bool elimino;

        elimino = PrestamosBLL.Eliminar(Prestamo.PrestamoId);

        if (elimino)
        {
            Nuevo();
            toast.ShowSuccess("Eliminado correctamente");
        }
        else
        {
            toast.ShowError("No se pudo eliminar.");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
    }
}
namespace __Blazor.RegistroBlazor.Pages.Registros.RPrestamos
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "readonly", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
