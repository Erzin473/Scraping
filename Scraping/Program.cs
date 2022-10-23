using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scraping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetProductFreezer();
            GetProductBags();
            GetProductKit();
            Console.ReadLine();
           
        }

        private static void GetProductFreezer()
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.100percent.co.nz/Product/wcm7000wd/westinghouse-700l-chest-freezer");

            foreach (var item in doc.DocumentNode.SelectNodes("//h1[@itemprop='name']"))
            {
                Console.WriteLine("productName:" + " " + item.InnerText);

            }

            foreach (var item1 in doc.DocumentNode.SelectNodes("//div[@class='prices']"))
            {

                Console.WriteLine("price:" + " " + item1.InnerText);

            }

            //I can't find a rating for scraping on the website

            //foreach (var item2 in doc.DocumentNode.SelectNodes(""))
            //{

            //    Console.WriteLine("rating:" + " " + item2.InnerText);

            //}

        }


        private static void GetProductBags()
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.100percent.co.nz/Product/E203S/Electrolux-Anti-Odour-Vacuum-Bags");

            foreach (var item in doc.DocumentNode.SelectNodes("//h1[@itemprop='name']"))
            {
                Console.WriteLine("productName:" + " " + item.InnerText);

            }

            foreach (var item1 in doc.DocumentNode.SelectNodes("//div[@class='prices']"))
            {

                Console.WriteLine("price:" + " " + item1.InnerText);

            }

            //I can't find a rating for scraping on the website

            //foreach (var item2 in doc.DocumentNode.SelectNodes(""))
            //{

            //    Console.WriteLine("rating:" + " " + item2.InnerText);

            //}
        }


        private static void GetProductKit()
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.100percent.co.nz/Product/USK11ANZ/Electrolux-UltraFlex-Starter-Kit");

            foreach (var item in doc.DocumentNode.SelectNodes("//h1[@itemprop='name']"))
            {
                Console.WriteLine("productName:" + " " + item.InnerText);

            }

            foreach (var item1 in doc.DocumentNode.SelectNodes("//div[@class='prices']"))
            {

                Console.WriteLine("price:" + " " + item1.InnerText);

            }

            //I can't find a rating for scraping on the website

            //foreach (var item2 in doc.DocumentNode.SelectNodes(""))
            //{

            //    Console.WriteLine("rating:" + " " + item2.InnerText);

            //}
        }
    }
}

