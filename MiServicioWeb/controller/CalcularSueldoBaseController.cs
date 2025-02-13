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
    public class CalcularSueldoBaseController : Controller
    {
        private readonly ILogger<CalcularSueldoBaseController> _logger;

        public CalcularSueldoBaseController(ILogger<CalcularSueldoBaseController> logger)
        {
            _logger = logger;
        }

        //calcular sueldo base  
        //formular sueldo base = horas trabajadas * tarifa por hora
        /************************************************************************************/
        [HttpGet("sueldoBase")]
        public string CalcularSueldoBase(int horasTrabajadas, int tarifaPorHora)
        {

            int sueldoBase = horasTrabajadas * tarifaPorHora;
            return $"Su sueldo base es: {sueldoBase}";
        }

        // calcular sueldo final 
        //formular bono = sueldo base * porcentaje de bono  
        // sueldo final = sueldo base + bono 
        /************************************************************************************/
        [HttpGet("sueldoFinal")]
        public string CalcularSueldoFinal(int sueldoBase, int porcentajeBono)
        {
            int bono = sueldoBase * (porcentajeBono / 100);
            int sueldoFinal = sueldoBase + bono;
            return $"Su sueldo final es: {sueldoFinal}";
        }
        //nota para el docente ejecutar mediante swagger
        //http://localhost:5070/swagger


    }
}