using System;
using System.Linq;
using System.Threading.Channels;
using Microsoft.EntityFrameworkCore;

namespace ProductCost
{
    class Program
    {

        static void Main(string[] args)
        {

            //ShowRemove();
          
          


            //public class Employee
            //{

            //    public int  id { get; set; }
            //    public string FirstName { get; set; }
            //    public string LastName { get; set; }
            //}

            //public static void AvtoCar()
            //{
            //    string[] avto = {"Volvo", "Nissan", "Audi"};
            //    bool any = avto.All(s=>s.Length > 3);
            //    Console.WriteLine(any);
            //}





            ////////////////////////////////////////////////////////////////////////////////////////////

            using (AppProduct db = new AppProduct())
            {


                //Product product = new Product {CBЧ = "Tomson", Kettle = "Filips", Cleanear = "Toshiba"};
                //db.Products.Add(product);
                //db.SaveChanges();


                //Prices prices1 = new Prices {Data = new DateTime(2016, 01, 05), Cost = 1000};
                //Prices prices2 = new Prices {Data = new DateTime(2017, 02, 03), Cost = 9000};
                //Prices prices3 = new Prices {Data = new DateTime(2017, 03, 05), Cost = 8000};
                //Prices prices4 = new Prices {Data = new DateTime(2017, 04, 06), Cost = 12000};
                //Prices prices5 = new Prices {Data = new DateTime(2016, 01, 03), Cost = 15900};
                //Prices price6 = new Prices {Data = new DateTime(2016, 01, 05), Cost = 1000};
                //Prices price7 = new Prices {Data = new DateTime(2018, 01, 08), Cost = 10990};
                //Prices price8 = new Prices {Data = new DateTime(2013, 11, 05), Cost = 1000};
                //Prices price9 = new Prices {Data = new DateTime(2017, 05, 12), Cost = 12000};
                //Prices price10 = new Prices {Data = new DateTime(2018, 01, 02), Cost = 9200};
                //db.AddRange(prices1, prices2, prices3, prices4, prices5, price6, price7, price8, price9, price10);
                //db.SaveChanges();
                var Query = db.Products.Join(db.Priceses, product => product.id, prices => prices.id, (product, prices) => new
                {
                    productNmae = product.Cleanear,
                    priceCost = prices.Cost,
                    data = prices.Data
                    
                });
                foreach (var result in Query)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nТовар пылесос:" +
                                      $"{result.productNmae}:" +
                                      $"\nНа сегодняшний день:"+
                                      $"{result.data.ToShortDateString()}:"+
                                      $"\nего цена, составляет:{result.priceCost} рублей");
                   
                }
                Console.WriteLine("Done");
                Console.ReadLine();
                //var result = db.Priceses.Average(t=>t.Cost);
                //Console.WriteLine( $"Средняя зарплата составляет:{result}");

                //Console.WriteLine("Вывод всей зарплат сотрудников в фирме");
                //Console.WriteLine(new string('-', 10));
                //var Query = db.Priceses.Select(t => t.Cost).ToList();
                //foreach (var resulPrice in Query)
                //{
                //    Console.WriteLine($"Вся зарплата :{resulPrice}");

                //}

                //public  static void ShowRemove()
                //{
                //    using (AppProduct db = new AppProduct())
                //    {
                //       db.RemoveRange(db.Priceses);
                //       db.SaveChanges();
                //       Console.WriteLine("Done");
                //    }
                //}

            }

        }


    }
}
    




