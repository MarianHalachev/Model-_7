namespace P02_StudentsConsoleApp
{
    using P02_StudentsServices;
    using System;
    using System.Text;

    public class Engine
    {
        private CountryService countryService;
        private TownsService townsService;

        public Engine()
        {
            this.countryService = new CountryService();
            this.townsService = new TownsService(countryService);
        }
        public void Run()
        {
            while (true)
            {
                PrintMenu();

                string cmd = Console.ReadLine();
                string result = string.Empty;

                switch (cmd)
                {
                    case "1":
                        result = AddCountry();
                        break;
                    case "2":
                        result = countryService.GetAllCountries();
                        break;
                    case "3":
                        result = EditCountryName();
                        break;
                    case "4":
                        result = DeleteCountryByName();
                        break;
                    case "5":
                        result = AddTown();
                        break;
                    case "6":
                        result = townsService.GetAllTowns();
                        break;
                    default:
                        result = ">> Not supported command!";
                        break;
                }
                if (!string.IsNullOrWhiteSpace(result))
                {
                    Console.WriteLine(result);
                }
            }
        }

        private void PrintMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1: << Add country");
            sb.AppendLine("2: Country list");
            sb.AppendLine("3: Change country name");
            sb.AppendLine("4: Delete country by name");
            sb.AppendLine("5: Add town");
            sb.AppendLine("6: Towns list");
            sb.AppendLine("<< Enter command: ");
            Console.WriteLine(sb.ToString().TrimEnd());
        }
        private string AddCountry()
        {
            Console.Write("<< Enter country name: ");
            string name = Console.ReadLine();
            return countryService.AddCountry(name);
        }

        private string AddTown()
        {
            Console.Write("<< Enter town name: ");
            string townName = Console.ReadLine();
            Console.Write("<< Enter country name: ");
            string countryName = Console.ReadLine();
            return townsService.AddTown(townName, countryName);
        }

        private string EditCountryName()
        {
            Console.Write("<< Enter country id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("<< Enter country new name: ");
            string newName = Console.ReadLine();
            return countryService.EditCoutryNameById(id,newName);
        }

        private string DeleteCountryByName()
        {
            Console.Write("<< Enter country name: ");
            string name = Console.ReadLine();
            return countryService.DeleteCountryByName(name);
        }
    }
}
