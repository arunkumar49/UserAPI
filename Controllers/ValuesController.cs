using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using UserData;

namespace UserAPI.Controllers
{
  public class ValuesController : ApiController
    {
    FormDataEntities db = new FormDataEntities();

    public List<UserDetail> Get()
    {
      return db.UserDetails.ToList();
    }

    [HttpPost]
    [Route("api/register/")]
    public void Post(UserDetail data)
    {
      db.UserDetails.Add(data);
      db.SaveChanges();
    }

    [HttpPost]
    [Route("api/login/")]
    public int Login_Post(UserDetail data)
    {
      var row = db.UserDetails.Where(model => model.Email == data.Email && model.Passwords == data.Passwords).FirstOrDefault();
      if (row != null)
      {
        return 1;
      }
      else
      {
        return 0;
      }
    }
  }
}
