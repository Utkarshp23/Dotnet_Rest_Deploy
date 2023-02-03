using Microsoft.AspNetCore.Mvc;

namespace Rest_Api.Controllers;
using Rest_Api.DAL;
using Rest_Api.Models;

[ApiController]
[Route("[controller]")]
public class HRController : ControllerBase
{

  [HttpGet(Name="GetAllEmployees")]
  public IEnumerable<Employee> Get()
  {
    List<Employee> l=HRManager.Get();
    return l;
  }

  [HttpGet]
  [Route("{id}")]
  public ActionResult<Employee> GetById(int id)
  {
    
    return HRManager.GetById(id);
  }

  [HttpPost]
  public ActionResult Insert(Employee e)
  {
    if(HRManager.AddEmployee(e))
    {
      return NoContent();
    }
    return NotFound();
  }

  [HttpDelete]
  [Route("{id}")]
  public ActionResult DeleteEmp(int id)
  {
    if(HRManager.DeleteEmp(id))
    {
      return NoContent();
    }
    return NotFound();
  }
}
