using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using PostCode;

namespace msl.xml
{
    class XMLManager
    {
        private const string FileLocation = "\\addressen.xml";
        private string Path { get; set; }

        public List<Addres> Addressen = new List<Addres>();

        /// <summary>
        /// This tries to create a xml file if not exist on the current dirrectory
        /// </summary>
        public void CreateDoc()
        {
            try
            {
                Path = Directory.GetCurrentDirectory();

                if (File.Exists(Path + FileLocation)) return;
                var doc = new XDocument(new XElement("Addressen"));
                doc.Save(Path + FileLocation);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// Create new xml element, string name, string zipcode, string number, string city, string street, string province
        /// </summary>
        /// <param name="zipcode"></param>
        public void InsertData(string name ,string zipcode, string number, string city, string street, string province)
        {
            CreateDoc();
           
            XDocument doc = XDocument.Load(Path+FileLocation);
            XElement root = new XElement("Addres");
            root.Add(new XElement("name", name));
            root.Add(new XElement("zipcode", zipcode));
            root.Add(new XElement("housenumber", number));
            root.Add(new XElement("city", city));
            root.Add(new XElement("Street", street));
            root.Add(new XElement("province", province));
            doc.Element("Addressen").Add(root);
            doc.Save(Path+FileLocation);

            Read();
        }

        /// <summary>
        /// This loops through the file and returns the data
        /// </summary>
        public void Read()
        { 
            CreateDoc();
            XDocument doc = XDocument.Load(Path + FileLocation);

            foreach (XElement el in doc.Root.Elements())
            {
                Addressen.Add(new Addres()
                {
                    Name = el.Element("name")?.Value,
                    ZipCode = el.Element("zipcode")?.Value,
                    Number = el.Element("housenumber")?.Value,
                    City = el.Element("city")?.Value,
                    Province = el.Element("province")?.Value,
                    Street = el.Element("Street")?.Value
                 });
                
            }
        }
    }
}