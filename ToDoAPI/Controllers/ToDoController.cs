using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Text.RegularExpressions;
using ToDoAPI.Context;
using ToDoAPI.Model;

namespace ToDoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly ApplicationDbContext _dbcontext;

        public ToDoController(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpGet]
        [ProducesResponseType(statusCode: 200)]
        [ProducesResponseType(statusCode: 400)]

        public ActionResult GetALL()
        {
            var todo = _dbcontext.ToDos.ToList();
            if (todo.Count >0) {
            return Ok(todo);
            }
            return NotFound();
        }

        //public IEnumerable<ToDo> GetToDos()
        //{
        //    //var ToDos = new List<ToDo>()
        //    //{
        //        //new ToDo{ Id = 1, Name = "Api Section", Description = "this is API section" },
        //        //new ToDo{ Id = 2, Name = "Api Section", Description = "this is API section for makeen" },
        //        // new ToDo{ Id = 3, Name = "MVC Section", Description = "this is MVC application for makeen" },

                 

        //    //};
        //    //return ToDos;


           
        //}


        [HttpGet("id:int")]
        [ProducesResponseType(statusCode: 200)]
        [ProducesResponseType(statusCode:400)]

        public ActionResult Get(int id) { 
            if (id==0)
            {
                return BadRequest();
              }
            return Ok();
        }
        [HttpPost]
        [ProducesResponseType(statusCode: 200)]
        [ProducesResponseType(statusCode:400)]
        public ActionResult Create(ToDo todo) { 
              if(ModelState.IsValid)
            {
                _dbcontext.ToDos.Add(todo);
                _dbcontext.SaveChanges();
                return Ok();
            }
              return BadRequest();
        }
        [HttpPut
            ]
        [ProducesResponseType(statusCode: 200)]
        [ProducesResponseType(statusCode:400)]
        public ActionResult Update(int id)
        {
           if(id==Model.ToDo.Id)
            {

            }
        }
    }
}
