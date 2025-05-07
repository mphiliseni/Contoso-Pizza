using Microsoft.AspNetCore.Mvc;
using Contoso_Pizza.Models;
using Contoso_Pizza.Services;

namespace Contoso_Pizza.Controllers;
[ApiController] //
[Route("[controller]")] //PizzaController
public class PizzaController : ControllerBase
{
    public PizzaController()
    {
    }
        //Get all pizzas
        [HttpGet]
        public ActionResult<List<Pizza>> GetAll() => PizzaServices.GetAll();

        //Get pizza by id   
         [HttpGet("{id}")]
        public ActionResult<Pizza> Get(int id)
        {
            var pizza = PizzaServices.Get(id);
            if (pizza is null)
            {
                return NotFound();
            }
            return pizza;
        }
        //Post pizza
        [HttpPost]
        public IActionResult Create(Pizza pizza)
        {
            PizzaServices.Add(pizza);
            return CreatedAtAction(nameof(Get), new { id = pizza.Id }, pizza);
        }

        //Put pizza
        [HttpPut("{id}")]
        public IActionResult Update(int id, Pizza pizza)
        {
            if (id != pizza.Id)
            {
                return BadRequest();
            }
            var existingPizza = PizzaServices.Get(id);
            if (existingPizza is null)
            {
                return NotFound();
            }
            PizzaServices.Update(pizza);
            return NoContent();
        }

        //Delete pizza
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pizza = PizzaServices.Get(id);
            if (pizza is null)
            {
                return NotFound();
            }
            PizzaServices.Delete(id);
            return NoContent();
        }
}


