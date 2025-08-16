using Ejercicio2;

var doc = new DocumentoPDF();
var ctx = new ContextoDatos();

var reporte = ReportePDFBuilder
    .ParaCliente("Grupo 6")
    .DelPeriodo(DateTime.Now.AddMonths(-1), DateTime.Now)
    .ConPortada("logo.png")
    .AgregarSeccion(new SeccionMovimientos())
    .AgregarSeccionSi(true, () => new SeccionGraficos { Tipo = TipoGrafico.Lineas})
    .WithIf(DateTime.Now.DayOfWeek == DayOfWeek.Monday, b => 
        b.AgregarSeccion(new SeccionPieAsesor { Contacto = "correo@test.com" }))
    .Build();

reporte.Render(doc, ctx);
