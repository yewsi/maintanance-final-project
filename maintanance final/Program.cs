using maintanance_final.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maintanance_final
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            string readOption="";
            int option;

            Service service = new Service();

            while (!readOption.Equals("0")) {
                Console.WriteLine("Choose Action:");
                Console.WriteLine("1. Add Player \n2. Devide Players Into Teams \n3. Pick A Random Team \n4. Show Teams \n0. Exit");
                readOption = Console.ReadLine();
                
                if (readOption.Equals("1"))
                {
                    Console.Write("Enter Player Name: ");
                    line = Console.ReadLine();
                    service.AddPlayer(line);
                }

                if (readOption.Equals("2"))
                {
                    Console.Write("Enter Number of teams: ");
                    line = Console.ReadLine();

                    //Werkt niet zoals het hoort, Vorige teams opruimen en dan spelers verdelen. Elk team heeft alle spelers
                    if (int.TryParse(line, out option))
                        service.DevidePlayersIntoTeams(option);
                }

                if (readOption.Equals("3"))
                {
                    Console.WriteLine(service.PickRandomTeam());
                }

                if (readOption.Equals("4"))
                {
                    Console.WriteLine(service.ShowTeams());
                }

            }
            Console.ReadKey();
        }
    }
}
