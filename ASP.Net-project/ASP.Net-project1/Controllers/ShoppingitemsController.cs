using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ASP.Net_project1.Models;

namespace ASP.Net_project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingitemsController : ControllerBase
    {
        private static List<ShoppingItem> shoppingitems = new List<ShoppingItem>();

        [HttpGet]

        public IActionResult GetAllShoppingItems()
        {
            return Ok(shoppingitems);
        }

        [HttpPost]
        public IActionResult AddShoppingItems([FromBody] ShoppingItem item)
        { 
            if (item == null)
            {
                return BadRequest("Shopping Item Data Is Invalid");
            }

            item.Id = shoppingitems.Count+1;
            shoppingitems.Add(item);
            return CreatedAtAction(nameof(GetAllShoppingItems), new {id = item.Id}, item);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateShoppingItems(int id, [FromBody] ShoppingItem updateditem)
        {
            var item = shoppingitems.FirstOrDefault(x => x.Id == id);

            if (item == null) return NotFound();

            item.Name = updateditem.Name;
            item.Quantity = updateditem.Quantity;
            item.Price = updateditem.Price;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteShoppingItems(int id)
        {
            var item = shoppingitems.FirstOrDefault(x=> x.Id == id);

            if (item == null) return NotFound(); 

            shoppingitems.Remove(item);
            return NoContent();
        }
    }
}
