using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul10_103022330138.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private static List<Movie> movieList = new List<Movie>()
        {
            new Movie("The Shawshank Redemption", "Frank Darabont", ["Tim Robbins", "Morgan Freeman", "Bob Gunton"],
                "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, " +
                "while maintaining his innocence and trying to remain hopeful through simple compassion."),
            new Movie("The Godfather", "Francis Ford Coppola", ["Marlon Brando", "Al Pacino", "James Caan"],
                "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
            new Movie("The Dark Knight", "Christoper Nolan", ["Christian Bale", "Heath Ledger", "Aaron Eckhart"],
                "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, " +
                "James Gordon and Harvey Dent must work together to put an end to the madness.")
        };
        
        
        // GET: api/<MovieController>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return movieList;
        }

        // GET api/<MovieController>/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return movieList[id];
        }

        // POST api/<MovieController>
        [HttpPost]
        public void Post([FromBody] Movie movie)
        {
            movieList.Add(movie);
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            movieList.RemoveAt(id);
        }
    }
}
