using Microsoft.AspNetCore.Mvc;

namespace MvcIntroViews.Controllers;

public class OperacoesMatematicasController : Controller
{

    public IActionResult Operacoes()
    {
      return View();  
    }

    public IActionResult ResultadoSoma([FromForm] double n1, [FromForm] double n2)
    {
      ViewBag.n1 = n1;
      ViewBag.n2 = n2;
      ViewBag.resultado = n1 + n2;

      return View();
    }

    public IActionResult ResultadoSubtracao([FromForm] double n1, [FromForm] double n2)
    {
      ViewBag.n1 = n1;
      ViewBag.n2 = n2;
      ViewBag.resultado = n1 - n2;

      return View();
    }

    public IActionResult ResultadoMultiplicacao([FromForm] double n1, [FromForm] double n2)
    {
      ViewBag.n1 = n1;
      ViewBag.n2 = n2;
      ViewBag.resultado = n1 * n2;

      return View();
    }

    public IActionResult ResultadoDivisao([FromForm] double n1, [FromForm] double n2)
    {
      ViewBag.n1 = n1;
      ViewBag.n2 = n2;
      ViewBag.resultado = n1 / n2;

      return View();
    }


}

