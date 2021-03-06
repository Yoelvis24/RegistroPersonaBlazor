// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RegistroBlazor.Pages.Registros
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\yoelvis\source\repos\Yoelvis24\RegistroDetalleBlazor\RegistroBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yoelvis\source\repos\Yoelvis24\RegistroDetalleBlazor\RegistroBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yoelvis\source\repos\Yoelvis24\RegistroDetalleBlazor\RegistroBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\yoelvis\source\repos\Yoelvis24\RegistroDetalleBlazor\RegistroBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\yoelvis\source\repos\Yoelvis24\RegistroDetalleBlazor\RegistroBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\yoelvis\source\repos\Yoelvis24\RegistroDetalleBlazor\RegistroBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\yoelvis\source\repos\Yoelvis24\RegistroDetalleBlazor\RegistroBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\yoelvis\source\repos\Yoelvis24\RegistroDetalleBlazor\RegistroBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\yoelvis\source\repos\Yoelvis24\RegistroDetalleBlazor\RegistroBlazor\_Imports.razor"
using RegistroBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\yoelvis\source\repos\Yoelvis24\RegistroDetalleBlazor\RegistroBlazor\_Imports.razor"
using RegistroBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yoelvis\source\repos\Yoelvis24\RegistroDetalleBlazor\RegistroBlazor\Pages\Registros\RMoras.razor"
using BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\yoelvis\source\repos\Yoelvis24\RegistroDetalleBlazor\RegistroBlazor\Pages\Registros\RMoras.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\yoelvis\source\repos\Yoelvis24\RegistroDetalleBlazor\RegistroBlazor\Pages\Registros\RMoras.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\yoelvis\source\repos\Yoelvis24\RegistroDetalleBlazor\RegistroBlazor\Pages\Registros\RMoras.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Moras")]
    public partial class RMoras : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 131 "C:\Users\yoelvis\source\repos\Yoelvis24\RegistroDetalleBlazor\RegistroBlazor\Pages\Registros\RMoras.razor"
       
    [Parameter]
    public int MoraId { get; set; }

    public Moras Mora { get; set; }

    public MorasDetalle MoraDetalle { get; set; }

    public double MontoPendiente { get; set; }

    public double MontoMora { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        Nuevo();
        Buscar();
    }

    public void OnPrestamoChanged(ChangeEventArgs e)
    {
        if (Convert.ToInt32(e.Value) != 0)
        {
            MoraDetalle.PrestamoId = Convert.ToInt32(e.Value);

            MontoPendiente = PrestamosBLL.Buscar(MoraDetalle.PrestamoId).Balance;
        }
    }

    public void Nuevo()
    {
        Mora = new Moras();
        MoraDetalle = new MorasDetalle();
        MontoPendiente = 0;
        MontoMora = 0;
        MoraId = 0;
    }

    public void Buscar()
    {
        if (Mora.MoraId > 0)
        {
            var encontrado = MorasBLL.Buscar(Mora.MoraId);
            if (encontrado != null)
            {
                this.Mora = encontrado;
                var count = Mora.MorasDetalle.Count;
                Console.Write(count);
            }
            else
            {
                toast.ShowWarning("No Encontrado");
            }
        }
    }

    public void Agregar()
    {
        var balance = PrestamosBLL.Buscar(MoraDetalle.PrestamoId).Balance;

        MoraDetalle.Valor = MontoMora > (balance * 0.25) ? balance * 0.25 : MontoMora;

        Mora.MorasDetalle.Add(MoraDetalle);
        MoraDetalle = new MorasDetalle();
        MontoMora = 0;
        Mora.Total = 0;
        foreach (MorasDetalle detalle in Mora.MorasDetalle)
        {
            Mora.Total += detalle.Valor;
        }
    }

    public void Remover(MorasDetalle Detalle)
    {
        Mora.MorasDetalle.Remove(Detalle);
        Mora.Total = 0;
        foreach (MorasDetalle detalle in Mora.MorasDetalle)
        {
            Mora.Total += detalle.Valor;
        }
    }

    public void Guardar()
    {
        bool guardo;

        guardo = MorasBLL.Guardar(Mora);

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

        elimino = MorasBLL.Eliminar(Mora.MoraId);

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
#pragma warning restore 1591
