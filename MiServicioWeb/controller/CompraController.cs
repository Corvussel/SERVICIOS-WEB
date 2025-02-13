using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MiServicioWeb.controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompraController : ControllerBase
    {
        //calcular impuestos
        // formula inpuesto = compra * porcentaje de impuestos
        [HttpGet("calcularImpuestos")]
        public string CalcularImpuestos(int compra, int porcentajeImpuestos)
        {
            int impuestos = compra * porcentajeImpuestos / 100;
            return $"Los impuestos son: {impuestos}";
        }

        // Calcular precio con descuento
        // Fórmula: precio con descuento = compra - (compra * (descuento / 100))
        [HttpGet("calcularPrecioConDescuento")]
        public string CalcularPrecioConDescuento(int compra, int descuentoPorcentaje)
        {
            int montoDescuento = compra * descuentoPorcentaje / 100;
            int precioConDescuento = compra - montoDescuento;
            return $"El precio con descuento es: {precioConDescuento}";
        }

        // Calcular precio con impuestos y descuento
        // Fórmula: precio con impuestos y descuento = compra + impuestos - descuento
        [HttpGet("calcularPrecioConImpuestosYDescuento")]
        public string CalcularPrecioConImpuestosYDescuento(int compra, int porcentajeImpuestos, int porcentajeDescuento)
        {
            int montoImpuestos = compra * porcentajeImpuestos / 100;
            int montoDescuento = compra * porcentajeDescuento / 100;
            int precioFinal = compra + montoImpuestos - montoDescuento;
            return $"El precio con impuestos y descuento es: {precioFinal}";
        }


    }
}