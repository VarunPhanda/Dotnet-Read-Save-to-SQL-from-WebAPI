using System;
using System.Collections.Generic;
using System.Linq;

namespace AppSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("READING records");
            var geoclientResponse = AppRequest.GetData();
            SaveData(geoclientResponse);
        }

        private static void SaveData(IEnumerable<GeoClientResponse> responseList)
        {
            try
            {
                Console.WriteLine("WRITING" + responseList.Count().ToString() + "records");
                AppRequest.SaveCollection(responseList);
                Console.WriteLine("SUCESS!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

        }
    }
}
