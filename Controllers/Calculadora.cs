using Microsoft.AspNetCore.Mvc;
namespace Api02.Controllers
{
    [ApiController]
    [Route("Calculadora API")]
    public class Calculadora : ControllerBase
    {
        [HttpGet("Somar")]
        public IActionResult Somar(double NumeroUm, double NumeroDois)
        {
            if(NumeroUm > 999 || NumeroUm == 0 || NumeroDois > 999 || NumeroDois == 0)
            {
                return BadRequest("um dos número é maior que 999 ou é igual a 0, digite outro valor...");

            }
            double resultado = NumeroUm+NumeroDois;
            return Ok($"o resultado é: {resultado}");
        }

        [HttpGet("Subtrair")]
        public IActionResult Subtrair(double NumeroUm, double NumeroDois)
        {
            if(NumeroUm > 999 || NumeroUm == 0 || NumeroDois > 999 || NumeroDois == 0)
            {
                return BadRequest("um dos número é maior que 999 ou é igual a 0, digite outro valor...");

            }
            double resultado = NumeroUm-NumeroDois;
            return Ok($"o resultado é: {resultado}");
        }

        [HttpGet("Multiplicar")]
        public IActionResult Multiplicar(double NumeroUm, double NumeroDois)
        {
            if(NumeroUm > 999 || NumeroUm == 0 || NumeroUm <0 || NumeroDois > 999 || NumeroDois == 0 || NumeroDois < 0)
            {
                return BadRequest("um dos número é maior que 999, ou é igual ou maior que 0, digite outro valor...");

            }
            double resultado = NumeroUm*NumeroDois;
            return Ok($"o resultado é: {resultado}");
        }

        [HttpGet("Dividir")]
        public IActionResult Dividir(double NumeroUm, double NumeroDois)
        {
            if(NumeroUm > 999 || NumeroUm == 0 || NumeroUm <0 || NumeroDois > 999 || NumeroDois == 0 || NumeroDois < 0)
            {
                return BadRequest("um dos número é maior que 999, ou é igual ou menor que 0 , digite outro valor...");

            }
            double resultado = NumeroUm/NumeroDois;
            return Ok($"o resultado é: {resultado}");
        }
        
    }
}