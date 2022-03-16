using System;

namespace _71._1___ExVetores {
    class Program {
        static void Main(string[] args) {

            int n;
            Studant[] vect = new Studant[10];

            Console.Write("How many rooms will be rented? ");
            n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++) {
                string name, email;
                int room;

                Console.WriteLine();
                Console.WriteLine($"Rent #{i + 1}:");
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Room: ");
                room = int.Parse(Console.ReadLine());

                vect[room] = new Studant { Name = name, Email = email };
            }

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine($"{i}: {vect[i]}");
                }
            }



        }
    }
}
