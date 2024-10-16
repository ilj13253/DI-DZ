using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Model;
using WebApplication3.Data;
namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimeController : Controller
    {
        private readonly Database _database = new();
        [HttpGet]
        public ActionResult<List<Anime>> Get()
        {
            return Ok(_database.anime);
        }

        /*
        public AnimeController(Database database)
        {
            _database = database;
        }
        */
        [HttpDelete("{id}")]

        public ActionResult Delete(int id)
        {
            var anime = _database.anime.First(x => x.Id == id);
            if (anime == null)
            {
                return NotFound();
            }

            _database.anime.Remove(anime);

            return NoContent();
        }
        [HttpPost]
        public ActionResult Create(Anime anime)
        {
            try
            {
                _database.anime.Add(anime);
            }
            catch (System.InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return CreatedAtAction(nameof(Get), new { id = anime.Id }, anime);
        }
        [HttpPut]
        public ActionResult Update(int id, Anime anime)
        {
            try
            {
                var anim = _database.anime.First(x => x.Id == id);
                anim.Name = anime.Name;
                anim.Description = anime.Description;
                anim.Genre = anime.Genre;
                anim.Year = anime.Year;
                anim.Studio = anime.Studio;
                
            }
            catch(System.InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return NoContent();
        }
    }
}
