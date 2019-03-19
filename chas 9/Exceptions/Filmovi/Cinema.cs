using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmovi
{
    public class Cinema
    {
        public string Name { get; set; }
        public  List<int> Halls { get; set; }
        public List<Movie> ListOfMovies { get; set; }

        public Cinema()
        {

        }

        public Cinema(string name)
        {
            Name = name;

        }

        static void MoviePlaying( Movie movie)
        {
           Console.WriteLine($"Watching {movie.Title}");
        }

    }
}
