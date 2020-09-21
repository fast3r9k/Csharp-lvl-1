using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WpfApp1
{
    class DataWeather
    {
        WebClient client;
        public List<FORECAST> Data { get; set; }
        public void AddCity(string url, string name)
        {
            string xml = client.DownloadString(url);

             var list =   XDocument.Parse(xml)
                         .Descendants("MMWEATHER")
                         .Descendants("REPORT")
                         .Descendants("TOWN")
                         .Descendants("FORECAST")
                         .ToList();

            foreach (var item in list)
            {
                //Console.WriteLine(item);
                var temp =
                new FORECAST()
                {
                    PRESSUREMax = item.Element("PRESSURE").Attribute("max").Value,
                    PRESSUREMin = item.Element("PRESSURE").Attribute("min").Value,
                    TEMPERATUREMax = item.Element("TEMPERATURE").Attribute("max").Value,
                    TEMPERATUREMin = item.Element("TEMPERATURE").Attribute("min").Value,
                    CityName = name,
                    Date = $"{item.Attribute("day").Value} {item.Attribute("month").Value} {item.Attribute("year").Value}" +
                    $"  {item.Attribute("hour").Value}:00"
                };
                Data.Add(temp);
            }



        }



        public DataWeather( )
        {
            Data = new List<FORECAST>();
            client = new WebClient();

            this.AddCity("https://xml.meteoservice.ru/export/gismeteo/point/37.xml", "Москва");
            this.AddCity("https://xml.meteoservice.ru/export/gismeteo/point/5.xml", "Астрахань");
            this.AddCity("https://xml.meteoservice.ru/export/gismeteo/point/116.xml", "Сочи");
            this.AddCity("https://xml.meteoservice.ru/export/gismeteo/point/486.xml", "Казань");
        }


    }
}
