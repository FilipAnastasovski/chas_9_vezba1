using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmovi
{
    public class Movie
    {
       

        public string Title { get; set; }
        public Genre Tip { get; set; }
        public int Rating { get; set; }
        public double TicketPrice { get; set; }

        public Movie()
        {

        }
        
        public Movie(string title, Genre tip, int rating, double ticketP)
        {
            try
            {

                if(rating>= 1 && rating <= 5)
                {
                    Rating = rating;
                }
                else { throw new Exception("not proper rating"); }


                Title = title;
                Tip = tip;

                if (ticketP == 0)
                {
                    TicketPrice = 5;
                }
                else { TicketPrice = ticketP * Rating; }

            }
            catch
            {
                Console.WriteLine("nesto greshka vo podatoci");
            }
        }
    }
   

    }

