using Microsoft.AspNetCore.Mvc;
using AlcoholemiaAPI.Domain;

namespace AlcoholemiaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlcaholemiaController : ControllerBase
    {
        [HttpGet]
        [Route("calcular/{operacion}/{vasoBebida}/{Peso}")]
        public IActionResult EjecutarCalculo(string operacion, double vasoBebida, double Peso)
        {
            IConsumirAlcohol  consumirAlcohol = CreateOperation(operacion);
            
            
            consumirAlcohol.Calcular(vasoBebida,Peso);
            var resultado = consumirAlcohol.RetornarResultado();
            return Ok(resultado);
        }
        
        private IConsumirAlcohol CreateOperation(string operacion)
        {
            IConsumirAlcohol consumirAlcohol = null;
             switch(operacion)
            {
                case "Bebida_Brandy":
                return consumirAlcohol = new Bebida_Brandy();

                case "Bebida_Cerveza":
                return consumirAlcohol = new Bebida_Cerveza();

                case "Bebida_Licor":
                return consumirAlcohol = new Bebida_Licor();

                case "Bebida_Vermu":
                return consumirAlcohol = new Bebida_Vermu();

                case "Bebida_VinoCava":
                return consumirAlcohol = new Bebida_VinoCava();
                
            }
            return null;
        }
    }
}