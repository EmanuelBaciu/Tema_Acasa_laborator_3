using LibrarieEntitati;
using System;


namespace ManagementStudenti
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Baciu Emanuel-Ionut");
            while (true)
            {
                Console.WriteLine("Alege o varianta:");
                Console.WriteLine("S: Citeste note de la tastatura ca un sir de carctere\n"+
                                  "T: Citeste note de la tastatura (Cate o nota pe rand)\n "+
                                  "A:Afisare:\n"+
                                  "C: Citeste note din linia de comanda\n"+
                                  "I: Info autor\n"+
                                  "X: !!EXIT!!");
                switch (Console.ReadLine().ToLower())
                {
                    case "s":
                        s.SetNote(Console.ReadLine());
                        break;

                    case "t":
                        s.SetNote();
                        break;

                    case "a":
                        Console.WriteLine(s.ConversieLaSir());
                        break;
                    case "i":
                        s.Info();
                        break;

                    case "x":
                        return;
                        
                }

            }
            Console.WriteLine(s.ConversieLaSir());
            Console.ReadKey();
        }
    }
}
