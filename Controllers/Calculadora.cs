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
            double resultado = NumeroUm+NumeroDois;
            return Ok($"o resultado é: {resultado}");
        }

        [HttpGet("Subtrair")]
        public IActionResult Subtrair(double NumeroUm, double NumeroDois)
        {
            double resultado = NumeroUm-NumeroDois;
            return Ok($"o resultado é: {resultado}");
        }

        [HttpGet("Multiplicar")]
        public IActionResult Multiplicar(double NumeroUm, double NumeroDois)
        {
            double resultado = NumeroUm*NumeroDois;
            return Ok($"o resultado é: {resultado}");
        }

        [HttpGet("Dividir")]
        public IActionResult Dividir(double NumeroUm, double NumeroDois)
        {
            double resultado = NumeroUm/NumeroDois;
            return Ok($"o resultado é: {resultado}");
        }
        
    }
}