using Microsoft.AspNetCore.Mvc;
using proyectoef.Models;
using webapi.Services;

namespace webapi.Controllers;

[Route("api/[controller]")]

public class FormulacionController : ControllerBase
{
    IFormulacionService formulacionService;

    public FormulacionController(IFormulacionService service)
    {
        formulacionService = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(formulacionService.Get());
    }

    [HttpPost]
    public IActionResult Post([FromBody] Formulacion formulacion) 
    {
        formulacionService.Save(formulacion);
        return Ok("hola mundo");
    }

    [HttpPut("{id}")]
    public IActionResult Put(Guid id, [FromBody] Formulacion formulacion) 
    {
        formulacionService.Update(id, formulacion);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        formulacionService.Delete(id);
        return Ok();
    }


}