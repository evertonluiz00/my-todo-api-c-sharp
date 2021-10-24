using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTodo.Api
{
    [ApiController]
    [Route(template:"v1")]
    public class TodoController : ControllerBase
    {
        [HttpGet]
        [Route(template:"todos")]
        public List<Todo> Get()
        {
            return new List<Todo>();
        }
    }
}
