using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MiServicioWeb.controller
{
    [Route("api/[controller]")]
    public class OperacionesController : Controller
    {
        private readonly ILogger<OperacionesController> _logger;

        public OperacionesController(ILogger<OperacionesController> logger)
        {
            _logger = logger;
        }
 
        // Sumar: /api/fecha/sumar?num1=5&num2=3
        [HttpGet("sumar")]
        public string Sumar(int num1, int num2)
        {
            int resultado = num1 + num2;
            return $"La suma de {num1} y {num2} es: {resultado}";
        }

        // Restar /api/fecha/restar?num1=10&num2=4
        [HttpGet("restar")]
        public string Restar(int num1, int num2)
        {
            int resultado = num1 - num2;
            return $"La resta de {num1} menos {num2} es: {resultado}";
        }

        // Multiplicar /api/fecha/multiplicar?num1=2&num2=8
        [HttpGet("multiplicar")]
        public string Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            return $"La multiplicación de {num1} por {num2} es: {resultado}";
        }

        // Dividir /api/fecha/dividir?num1=20&num2=4
        [HttpGet("dividir")]
        public string Dividir(int num1, int num2)
        {
            if (num2 == 0)
                return "No se puede dividir entre cero.";

            int resultado = num1 / num2;
            return $"La división de {num1} entre {num2} es: {resultado}";
        }

    }
}