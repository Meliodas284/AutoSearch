using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSearch
{
    public static class Categories
    {
        public static Dictionary<string, string> marks = new Dictionary<string, string>()
        {
            {"%", "Любая" },
            {"BMW", "BMW" },
            {"Mercedes-Benz", "Mercedes-Benz" },
            {"Ford", "Ford" },
            {"Lexus", "Lexus" },
            {"Audi", "Audi" },
            {"Haval", "Haval" },
            {"Honda", "Honda" },
            {"Hyundai", "Hyundai" },
            {"Kia", "Kia" },
            {"Mazda", "Mazda" },
            {"Nissan", "Nissan" },
            {"Porsche", "Porsche" },
            {"Subaru", "Subaru" },
            {"Toyota", "Toyota" },
            {"Suzuki", "Suzuki" },
            {"Volkswagen", "Volkswagen" }
        };

        public static Dictionary<string, string> bodyType = new Dictionary<string, string>()
        {
            {"%", "Любой" },
            {"SEDAN", "Седан" },
            {"SEDAN_HARDTOP", "Седан с жесткой крышей" },
            {"SEDAN_2_DOORS", "Седан 2 дв." },
            {"HATCHBACK_3_DOORS", "Хэтчбек 3 дв." },
            {"HATCHBACK_4_DOORS", "Хэтчбек 4 дв." },
            {"HATCHBACK_5_DOORS", "Хэтчбек 5 дв."},
            {"LIFTBACK", "Лифтбек" },
            {"ALLROAD_5_DOORS", "Внедорожник 5 дв." },
            {"ALLROAD_3_DOORS", "Внедорожник 3 дв." },
            {"WAGON_5_DOORS", "Универсал" },
            {"CABRIO", "Кабриолет" },
            {"COUPE", "Купе" },
            {"COMPACTVAN", "Компакт" },
            {"ROADSTER", "Родстер" },
            {"WAGON", "Фургон" },
            {"ALLROAD_OPEN", "Внедорожник открытый" },
            {"COUPE_HARDTOP", "Купе с жесткой крышей"},
            {"MINIVAN", "Минивэн"},
            {"MICROVAN", "Микровэн" },
            {"PICKUP_ONE", "Пикап 1" },
            {"PICKUP_TWO", "Пикап 2" },
            {"VAN", "Van" },
            {"TARGA", "Тарга" }
        };

        public static Dictionary<string, string> engineType = new Dictionary<string, string>()
        {
            {"%", "Любой" },
            {"GASOLINE", "Бензин" },
            {"DIESEL", "Дизель" },
            {"ELECTRO", "Электро" },
            {"HYBRID", "Гибрид" },
            {"LPG", "Газ" },
        };

        public static Dictionary<string, string> transmission = new Dictionary<string, string>()
        {
            {"%", "Любая" },
            {"AUTOMATIC", "Автоматическая" },
            {"MECHANICAL", "Механическая" },
            {"ROBOT", "Робот" },
            {"VARIATOR", "Вариатор" }
        };

        public static Dictionary<string, string> gearType = new Dictionary<string, string>()
        {
            {"%", "Любой" },
            {"ALL_WHEEL_DRIVE", "Полный привод" },
            {"FORWARD_CONTROL", "Передний привод" },
            {"REAR_DRIVE", "Задний привод" }
        };

        public static Dictionary<string, string> wheel = new Dictionary<string, string>()
        {
            {"%", "Любой" },
            {"LEFT", "Левый" },
            {"RIGHT", "Правый" }
        };

    }
}
