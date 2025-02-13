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
    public class FechaController : Controller
    {
        private readonly ILogger<FechaController> _logger;

        public FechaController(ILogger<FechaController> logger)
        {
            _logger = logger;
        }

        [HttpGet("restaFecha")]
         public string RestaFecha()
        {
            
            DateTime hoy = DateTime.Now;
            DateTime ayer = hoy.AddDays(-1);

            TimeSpan diferencia = hoy - ayer;

            return $"Han pasado {diferencia.TotalHours} horas desde ayer.";
        }
    }
}