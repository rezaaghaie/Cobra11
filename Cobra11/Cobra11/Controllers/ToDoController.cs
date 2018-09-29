using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cobra11.Model;
using Cobra11.Model.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Cobra11.Controllers
{
    [Route("api/todo")]
    public class ToDoController : Controller
    {
        private readonly ToDoAppDbContext _db;

        public ToDoController(ToDoAppDbContext db)
        {
            _db = db;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<List<ToDoItem>> Get()
        {
            return await _db.ToDoItems.ToListAsync();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ToDoItem> Get(int id)
        {
            return await _db.ToDoItems.FirstOrDefaultAsync(x => x.Id == id);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task Post([FromBody]ToDoItem model)
        {
            model.CreationTime = DateTime.Now;
            model.LastUpdateDateTime = DateTime.Now;
            model.IsCompleted = false;
            
            await _db.ToDoItems.AddAsync(model);
            await _db.SaveChangesAsync();
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody]ToDoItem input)
        {
            var model = await _db.ToDoItems.FirstOrDefaultAsync(x => x.Id == id);
            model.IsCompleted = input.IsCompleted;
            model.Title = input.Title;
            model.LastUpdateDateTime = DateTime.Now;
            await _db.SaveChangesAsync();
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var temp = await _db.ToDoItems.FirstOrDefaultAsync(x=>x.Id == id);
            _db.Entry(temp).State = EntityState.Deleted;
            _db.SaveChanges();
        }
    }
}
