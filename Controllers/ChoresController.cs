using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace choreScore.Controllers;
    [ApiController]
    [Route("api/[controller]")]
    public class ChoresController : ControllerBase
{
    private readonly ChoresService _choresService;
    public ChoresController(ChoresService choresService)
    {
        _choresService = choresService;
    }

    [HttpGet]
    public ActionResult<List<Chore>> GetChores()
    {
        try
        {List<Chore> chores = _choresService.GetChores();
            return Ok(chores);
        }
        catch (Exception e)
        {
            
            return BadRequest(e.Message);
        }
    }
    [HttpGet("{choreName}")]
    public ActionResult<Chore> GetChoreByName(string choreName)
    {
        try
        {
            Chore chore = _choresService.GetChoreByName(choreName);
            return Ok(chore);
        }
        catch (Exception e)
        {
        return BadRequest(e.Message);
        }
        
    }
    [HttpGet("choreByType/{choreType}")]
    public ActionResult<List<Chore>> GetChoreByType(string choreType)
    {
    try
    {    
        List<Chore> chore = _choresService.GetChoreByType(choreType);
        return Ok(chore);
    }
     catch(Exception e) 
    {
        return BadRequest(e.Message);
    }
    }
[HttpPost]
public ActionResult<Chore> createChore([FromBody] Chore choreData)
{
    try
    {
        Chore chore = _choresService.createChore(choreData);
        return Ok(chore);
    }
    catch (Exception e)
    {
        
        return BadRequest(e.Message);
    }
}
[HttpDelete($"choreName")]
public ActionResult<string> RemoveChore(string choreName)
{
    try
    {
        Chore chore = _choresService.RemoveChore(choreName);
        return Ok($"{choreName} deleted ");
    }
    catch (Exception e)
    {
        
        return BadRequest(e.Message);
    }
}
[HttpPut($"choreName")]
public ActionResult<Chore> EditChore([FromBody] Chore choreData)
{
    try
    {
        Chore chore = _choresService.EditChore(choreData);
        return Ok(chore);
    }
    catch (Exception e)
    {
        
        return BadRequest(e.Message);
    }
}
}
