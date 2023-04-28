using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSearch
{
    internal static class Categories
    {
        public static Dictionary<string, string> marks = new Dictionary<string, string>()
        {
            {"BMW", "BMW" },
            {"Mercedes-Benz", "Mercedes" },
            {"Ford", "Ford" },
            {"Lexus", "Lexus" },
            {"Audi", "Audi" },
            {"Haval", "Haval" },
            {"Honda", "Honda" },
            {"Hyundai", "Hyundai" },
            {"Kia", "Kia" },
            {"Mazda", "Mazda" },
            {"Nissan", "Nissan" },
            {"Porsche", "Porshe" },
            {"Subaru", "Subaru" },
            {"Toyota", "Toyota" }
        };

        public static Dictionary<string, string> bodyType = new Dictionary<string, string>()
        {
            {"Седан", "SEDAN" },
            {"Хэтчбек 3 дв.", "HATCHBACK_3_DOORS" },
            {"Хэтчбек 5 дв.", "HATCHBACK_5_DOORS"},
            {"Лифтбек", "LIFTBACK" },
            {"Внедорожник 5 дв.", "ALLROAD_5_DOORS" },
            {"Универсал", "WAGON_5_DOORS" },
            {"Кабриолет", "CABRIO" },
            {"Купе", "COUPE" }
        };

        public static Dictionary<string, string> engineType = new Dictionary<string, string>()
        {
            {"Бензин", "GASOLINE" },
            {"Дизель", "DIESEL" },
            {"Электро", "ELECTRO" },
            {"Гибрид", "HYBRID" },
        };

        public static Dictionary<string, string> transmission = new Dictionary<string, string>()
        {
            {"Автоматическая", "AUTOMATIC" },
            {"Механическая", "MECHANICAL" },
            {"Робот", "ROBOT" },
            {"Вариатор", "VARIATOR" }
        };

        public static Dictionary<string, string> gearType = new Dictionary<string, string>()
        {
            {"Полный привод", "ALL_WHEEL_DRIVE" },
            {"Передний привод", "FORWARD_CONTROL" },
            {"Задний привод", "REAR_DRIVE" }
        };

        public static Dictionary<string, string> wheel = new Dictionary<string, string>()
        {
            {"Левый", "LEFT" },
            {"Правый", "RIGHT" }
        };

    }
}
