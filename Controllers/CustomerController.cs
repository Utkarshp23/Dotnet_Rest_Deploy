namespace Rest_Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Rest_Api.DAL;
using Rest_Api.Models;

[ApiController]
[Route("[controller]")]
public class CUSTController: ControllerBase{

  [HttpGet]
  public IEnumerable<Customer> Get()
  {
    List<Customer> l=CRManager.Get();
    return l;
  }

  [HttpGet]
  [Route("{cid}")]
  public ActionResult<Customer> GetById(int cid)
  {
    return CRManager.GetById(cid);
  }
  
  [HttpPost]
  public ActionResult Insert(Customer c)
  {
    if(CRManager.Insert(c))
    {
      return NoContent();
    }
    return NotFound();
  }

  [HttpDelete]
  [Route("{cid}")]
  public ActionResult DeleteCust(int cid)
  {
    if(CRManager.DeleteCust(cid))
    {
      return NoContent();
    }
    return NotFound();
  }

  [HttpPut("{cid}")]
  public ActionResult Update(int cid, Customer c)
  {
    bool status=CRManager.Update(cid,c);
    if(status)
    {
      return NoContent();
    }
    return NotFound();
  }
}