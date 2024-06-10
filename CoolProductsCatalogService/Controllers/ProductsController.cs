using CoolProductsCatalogService.Model.Data;
using CoolProductsCatalogService.Model.Entities;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoolProductsCatalogService.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsDbContext db;

        public ProductsController(ProductsDbContext db)
        {
            this.db = db;
        }


        //GET  https:coolproducts.com/api/products
        // Action Methods
        [HttpGet]
        [EnableQuery]
        //[EnableCors()]
        public IQueryable<Product> GetProducts()
        {
            return db.Products.AsQueryable();
        }


        //1.  GET .../api/products/1
        [HttpGet]
        [Route("{pid:int}")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200)]
        [Authorize]
        public IActionResult GetProduct(int pid)
        {
            var product = db.Products.Find(pid);
            if (product == null)
            {
                // return status code 404
                return NotFound($"Product ID {pid} not found");

            }
            // if found return 200 - ok with resource
            return Ok(product);
        }


        //2.  GET .../api/products/category/{mobiles}
        [HttpGet]
        [Route("category/{category:alpha}")]
        //[AllowAnonymous]
        [Authorize(Roles = "superadmin")]
        public IActionResult GetProductsByCategory(string category)
        {
            var products = db.Products.Where(p => p.Category == category).ToList();
            if (products.Count > 0)
            {
                return Ok(products);
            }
            return NotFound();
        }

        //3.  GET .../api/products/instock
        //4.  GET .../api/products/cheapest
        //5.  GET .../api/products/costliest
        //6.  GET .../api/products/country/{india}
        //7.  GET .../api/products/brand/{apple}


        // Project : Identify all endpoints for our KHP project

        // POST .../api/products
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]

        public IActionResult PostProduct([FromBody] Product product)
        {
            // validate
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid Input");
            }
            db.Products.Add(product);
            db.SaveChanges();
            // status code - 201, location, added resource
            return Created($"api/products/{product.Id}", product);
        }


        // DELETE .../api/products/1
        [HttpDelete]
        [Route("{id:int}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult DeleteProduct(int id)
        {
            var product = db.Products.Find(id);
            if (product == null)
            {
                // return status code 404
                return NotFound($"Product ID {id} not found");

            }
            // if found delete and return no content
            db.Products.Remove(product);
            db.SaveChanges();
            return NoContent();
        }

        // PUT .../api/products/1
        [HttpPut]
        //[Route("{id}")]
        public async Task<IActionResult> EditProductAsync(Product productToEdit)
        {
            // validate
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid Input");
            }
            db.Entry(productToEdit).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok();
        }


    }
}
