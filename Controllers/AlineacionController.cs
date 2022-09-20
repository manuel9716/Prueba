using Microsoft.AspNetCore.Mvc;
using proyectoef.Models;
using webapi.Services;

namespace webapi.Controllers;

[Route("api/[controller]")]
public class AlineacionController : ControllerBase
{
    IAlineacionService alineacionService;

    public AlineacionController(IAlineacionService service)
    {
        alineacionService = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(alineacionService.Get());
    }

    [HttpPost]
    public IActionResult Post([FromBody] Alineacion alineacion) 
    {
        alineacionService.Save(alineacion);
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult Put(Guid id, [FromBody] Alineacion alineacion) 
    {
        alineacionService.Update(id, alineacion);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        alineacionService.Delete(id);
        return Ok();
    }



}