using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;

namespace AutoSearch
{
    internal static class Query
    {

        public static string createQuery(SearchParams auto)
        {
            string query = $"SELECT * FROM cars " +
                $"WHERE mark LIKE '{auto.Mark}' AND " +
                $"category LIKE '{auto.BodyType}' AND " +
                $"engine_type LIKE '{auto.EngineType}' AND " +
                $"powers > {auto.PowerFrom} AND powers < {auto.PowerTo} AND " +
                $"transmission LIKE '{auto.Transmission}' AND " +
                $"gear_type LIKE '{auto.GearType}' AND " +
                $"wheel LIKE '{auto.Wheel}' AND " +
                $"price > {auto.PriceFrom} AND price < {auto.PriceTo}";

            return query;
        }

        public static ObservableCollection<Auto> executeQuery(string query)
        {
            using (var connection = new SQLiteConnection(@"Data Source=C:\Учеба\ИС\AutoSearch\Cars.db; Mode=ReadOnly"))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        var collection = new AutoCollection();
                        while (reader.Read())
                        {
                            var auto = new Auto()
                            {
                                Mark = Categories.marks[reader.GetValue(0).ToString()],
                                Model = reader.GetValue(1).ToString(),
                                Category = Categories.bodyType[reader.GetValue(2).ToString()],
                                EngineType = Categories.engineType[reader.GetValue(3).ToString()],
                                Powers = int.Parse(reader.GetValue(4).ToString()),
                                Transmission = Categories.transmission[reader.GetValue(5).ToString()],
                                GearType = Categories.gearType[reader.GetValue(6).ToString()],
                                Wheel = Categories.wheel[reader.GetValue(7).ToString()],
                                Image = reader.GetValue(8).ToString(),
                                Price = ulong.Parse(reader.GetValue(9).ToString()),
                            };
                            collection.Add(auto);
                        }
                        return collection.Cars;
                    }
                    return null;
                }
            }
        }

    }
}
