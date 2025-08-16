using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2;

public class ReportePDFBuilder
{
    private string _cliente;
    private Periodo _periodo;
    private readonly List<ISeccionReporte> _secciones = new();
    private bool _portadaAgregada;
    public ReportePDFBuilder(string cliente) => _cliente = cliente;
    public static ReportePDFBuilder ParaCliente(string cliente) 
        => new(cliente);

    public ReportePDFBuilder DelPeriodo(DateTime desde, DateTime hasta)
    { 
        _periodo = new Periodo() { Desde = desde, Hasta = hasta };
        return this;
    }
    public ReportePDFBuilder ConPortada(string logoPath)
    {
        if (!_portadaAgregada)
        {
            _secciones.Add(new SeccionPortada() { Cliente = _cliente, LogoPath = logoPath});
            _portadaAgregada = true;
        }
        return this;
    }

    public ReportePDFBuilder AgregarSeccion(ISeccionReporte seccion)
    {
        _secciones.Add(seccion);
        return this;
    }

    public ReportePDFBuilder AgregarSeccionSi(bool cond, Func<ISeccionReporte> factory)
    {
        if(cond) _secciones.Add(factory());        
        return this;
    }

    public ReportePDFBuilder WithIf(bool cond, Action<ReportePDFBuilder> step)
    {
        if (cond) step(this);
        return this;
    }

    public ReportePDF Build() 
        => new(_cliente, _periodo, _secciones);
}
