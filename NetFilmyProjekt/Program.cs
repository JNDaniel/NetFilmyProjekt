using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFilmyProjekt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using(filmdbEntities context = new filmdbEntities())
            {
                var filmy = context.Film;
                //context.Film.RemoveRange(filmy);
                Film x1 = new Film();
                x1.tytul = "FILMIK";
                x1.rok_prod = 1995;
                x1.jezyk = "Polski";
                Console.WriteLine(x1);
                List<Film> result = context.Film.ToList();
                foreach (Film f in result)
                {
                    Console.WriteLine(f);
                }
                
                try
                {
                    context.SaveChanges();
                }
                catch(System.Data.Entity.Infrastructure.DbUpdateException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("TEST");
               
            }
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
