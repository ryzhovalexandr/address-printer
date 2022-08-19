namespace VitaConsoleApp
{
    class Program
    {
        static void Main()
        {
            string s = "";
            string[] StockConfig = { "1.1", "1.2", "2.1", "2.2", "3.1", "3.2", "4.1", "4.2", "5.0", "6.0", "7.0", "8.0", "9.0", "10.0", "11.0"};
            string[] ShowCaseConfig = { "0", "1", "2", "3", "4", "5", "6", "7"};

            //Тип комнаты
            Console.WriteLine("Введите тип комнаты:");
            Console.WriteLine("1. Торговый зал \n2. Материальная");
            int RoomType = Convert.ToInt32(Console.ReadLine());
            switch (RoomType)
            {
                case 1:
                    s += "Т.";
                    break;
                case 2:
                    s += "М.";
                    break;
            }
            Console.WriteLine("");

            //Тип мебели
            Console.WriteLine("Введите тип мебели:");
            Console.WriteLine("1.Сток \n2.Витрина(Шкаф)");
            int TypeOfFurniture = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            //Номер мебели
            List<string> AddressList = new List<string>();
            Console.WriteLine("Введите номер мебели:");
            string FurnitureNumber = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");
            switch (TypeOfFurniture)
            {
                case 1:
                    s += "С." + FurnitureNumber + ".";
                    AddressList = CreateAddressList_Output(StockConfig, s);
                    break;
                case 2:
                    s += "Ш." + FurnitureNumber + ".";
                    AddressList = CreateAddressList_Output(ShowCaseConfig, s);
                    break;
            }

            Label:
            Console.WriteLine("");
            Console.WriteLine("1. Удалить адрес \n2. Cформировать документ на печать");
            int choise = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            switch (choise)
            {
                case 1:
                    DeleteAddress(AddressList);
                    goto Label;
                case 2:
                    Console.WriteLine("Документ сформирован");
                    Main();
                    break;
            }
        }

        //Создание списка адресов и их вывод
        static List<string> CreateAddressList_Output(string[] Furniture, string Position)
        {
            //Вывод
            List<string> AddressList = new List<string>();
            Console.WriteLine("Список адресов:");
            for(int i = 0; i < Furniture.Length; i++)
            {
                AddressList.Add(Position+Furniture[i]);
                Console.WriteLine(AddressList[i]);
            }
            return AddressList;
        }

        //Вывод адресов после удаления
        static void AddressListAfterDelete_Output(List<string> Furniture)
        {
            for(int i = 0; i<Furniture.Count; i++)
            {
                Console.WriteLine(Furniture[i]);
            }
        }

        //Удаление адресов
        static void DeleteAddress(List<string> Address)
        {
            //Выбор адреса для удаления
            Console.WriteLine("Введите адрес:");
            string DeleteAddress = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");
            Address.Remove(DeleteAddress);
            AddressListAfterDelete_Output(Address);
        }
    }
}