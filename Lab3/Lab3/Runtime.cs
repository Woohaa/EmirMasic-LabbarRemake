using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Events;

namespace Lab3
{
    class Runtime
    {
        List<Concerts> concertList = new List<Concerts>
        {
            new Concerts {Band = "Kiss", EventName = "Crazy crazy nights!", EventType = EventType.Concert,  DateAndTime = new DateTime(2016,11,25), Price = 499.99M },
            new Concerts {Band = "Justin Bieber", EventName = "Purpose", EventType = EventType.Concert,  DateAndTime = new DateTime(2016,12,31), Price = 799.99M },
            new Concerts {Band = "Tunnan och Moroten", EventName = "Bajs i bastun", EventType = EventType.Concert,  DateAndTime = new DateTime(2017,03,11), Price = 0.99M }
        };
        List<Festivals> festivalList = new List<Festivals>
        {
            new Festivals {FestivalType = "Rock", EventName = "Annihilation", EventType = EventType.Festival,  DateAndTime = new DateTime(2017,06,12), NumberOfDays = 5, Price = 2399.39M  },
            new Festivals {FestivalType = "Pop", EventName = "La Musica", EventType = EventType.Festival,  DateAndTime = new DateTime(2017,08,17), NumberOfDays = 4, Price = 4999.39M  },
            new Festivals {FestivalType = "Rave", EventName = "Blowout", EventType = EventType.Festival,  DateAndTime = new DateTime(2017,04,22), NumberOfDays = 2, Price = 1349.49M  }
        };
        List<Movies> movieList = new List<Movies>
        {
            new Movies {EventName = "Lord of the Rings", EventType = EventType.Movie, MovieGenre = Genre.Fantasy,  DateAndTime = new DateTime(2016,12,11), MovieRuntime = 200, Price = 199.49M },
            new Movies {EventName = "The shady man", EventType = EventType.Movie, MovieGenre = Genre.Thriller,  DateAndTime = new DateTime(2016,12,25), MovieRuntime = 120, Price = 99.49M },
            new Movies {EventName = "Worst movie ever", EventType = EventType.Movie, MovieGenre = Genre.Horror, DateAndTime = new DateTime(2016,12,27), MovieRuntime = 3, Price = 1.99M },
        };

        List<string> bookedConcerts = new List<string>();
        List<string> bookedFestivals = new List<string>();
        List<string> bookedMovies = new List<string>();

        public void ShowConcertLists()
        {
            for (int i = 0; i < concertList.Count; i++)
            {
                Console.WriteLine((i + 1) + " " + concertList[i]);
            }
        }
        public void ShowFestivalLists()
        {
            for (int i = 0; i < festivalList.Count; i++)
            {
                Console.WriteLine((i + 1) + " " + festivalList[i]);
            }
        }
        public void ShowMovieLists()
        {
            for (int i = 0; i < movieList.Count; i++)
            {
                Console.WriteLine((i + 1) + " " + movieList[i]);
            }
        }

        public void BookConcertEvent(string name, int input)
        {
            
            bookedConcerts.Add(string.Format("Booked as: {0} \nConcert: {1}",name, concertList[input - 1]));

        }

        public void BookFestivalEvent(string name, int input)
        {
            bookedFestivals.Add(string.Format("Booked as: {0} \nFestival: {1}", name, festivalList[input - 1]));
        }

        public void BookMovieEvent(string name, int input)
        {
            bookedMovies.Add(string.Format("Booked as: {0} \nMovies: {1}", name, movieList[input - 1]));
        }

        public void ShowBookedConcerts()
        {
            foreach (var concert in bookedConcerts)
            {
                Console.WriteLine(concert);
            }
        }
        public void ShowBookedFestivals()
        {
            foreach (var festival in bookedFestivals)
            {
                Console.WriteLine(festival);
            }
        }
        public void ShowBookedMovies()
        {
            foreach (var movie in bookedMovies)
            {
                Console.WriteLine(movie);
            }
        }


    }
}
