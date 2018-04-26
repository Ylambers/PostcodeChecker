using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Deserializers;
using SimpleJson;

namespace PostCode
{
    class ApiManager
    {
        public string Name { get; set; }
        public string StreetName { get; set; }
        public string HouseNumber { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Province { get; set; }
        public bool Error { get; set; }

        public void BuildData(string zipcode, string number)
        {
        dynamic jo = JObject.Parse(JsonData(zipcode, number));
            try
            {
                var items = jo._embedded.addresses[0];

                Name = items.name;
                StreetName = items.street;
                HouseNumber = items.number;
                City = items.city.label;
                ZipCode = items.postcode;
                Province = items.province.label;


            }
            catch (Exception e)
            {
                Error = true;
                Console.WriteLine("Address niet gevonden");
            }
        }

        public string JsonData(string zipcode, string number)
        {
            try
            {
                var client = new RestClient("https://api.postcodeapi.nu/v2/addresses/?postcode=" + zipcode +
                                            "&number=" + number + "");
                var request = new RestRequest(Method.GET);
                request.AddHeader("accept", "application/hal+json");
                request.AddHeader("x-api-key", "lERtIpPkzw3L1MQ1owbE9ZsC6lL4WasaeTD2Ovod");
                IRestResponse response = client.Execute(request);

                return response.Content;
            }
            catch (Exception e)
            {
                Console.WriteLine("Geen adress gevonden" + e);
            }
            return null;
        }
    }
}
