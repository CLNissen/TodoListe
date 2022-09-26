using Microsoft.AspNetCore.Mvc;

namespace todobackend.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoController : ControllerBase
{
   

    //Create todo
    [HttpPost]

    public ActionResult<TodoModel> CreateTodo(string id, string name) {
      if (string.IsNullOrWhiteSpace(id)) return BadRequest("No ID Entered");
      if (string.IsNullOrWhiteSpace(name)) return BadRequest("No Name Selected");      

      TodoModel todo = new TodoModel(){
         Id = id,
         Name = name
      };

      TestContext.todos.Add(todo);

      return todo;
    }

    //Get all todos

    [HttpGet]

    public ActionResult<List<TodoModel>> GetAllTodos() {
      if(TestContext.todos.Count < 1) return NoContent();

      return Ok(TestContext.todos);
    }




    //Delete todo from todolist

    [HttpDelete]
    public ActionResult<string> DeleteTodo(string id) {
      for (int i = 0; i < TestContext.todos.Count; i++)
      {
         
         if (TestContext.todos[i].Id == id)
         {
            TestContext.todos.RemoveAt(i);
            return Ok(id);
         }
      }

      return BadRequest("Id not found");
    }

    
}
