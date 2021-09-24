using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Modul5HW2.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UserRegisterController : ControllerBase
    {
        [HttpPost]
        [Route("[Action]")]
        public string Regist([FromForm]User user)
        {
            return $"{user}, Hello";
        }
    }
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
