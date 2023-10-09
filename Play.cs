using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    public class Play : IDisposable
    {
        private bool disposed;

        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public Play(string title, string author, string genre, int year)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title of the play: {Title}");
            Console.WriteLine($"Autho: {Author}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Year: {Year}");
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Освобождение управляемых ресурсов
                    Console.WriteLine($"Managed Object Resources {Title} released");
                }

                // Освобождение неуправляемых ресурсов
                Console.WriteLine($"An object{Title} deleted");

                disposed = true;
            }
        }

        ~Play()
        {
            Dispose(false);
        }
    }
}




