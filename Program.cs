using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

//Nombre de la escuela: UNIVERSIDAD TECNOLOGICA METROPOLITANA
//Asignatura: APLICACIONES WEB ORIENTADA A SERVICIOS
//Nombre del Maestro: JOEL IVAN CHUC UC
//Nombre de la actividad: Ejercicio 2 - Cálculo del nivel del alcohol en la sangre (alcoholemia)
//Nombre del alumno: SANTOS ANTONIO PECH SANTIAGO
//Cuatrimestre: 4
//Grupo: 4 "B"
//Parcial: SEGUNDO


namespace AlcoholemiaAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
