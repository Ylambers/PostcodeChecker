using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using msl.xml;

namespace PostCode
{
    public partial class Form1 : Form
    {
        public string link { get; set; }

        /// <summary>
        /// Form load
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            gotogoogle.Visible = false;

           history();
        }

        /// <summary>
        /// Button click for the api request and the magic happens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_zoeken_Click(object sender, EventArgs e)
        {
            ApiManager api = new ApiManager();

            api.BuildData(tb_zipcode.Text, tb_housenumber.Text);

            if (api.Error == false)
            {
                api.Name = tf_name.Text;
                lb_city.Text = api.City;
                lb_streetname.Text = api.StreetName;
                lb_number.Text = api.HouseNumber;
                lb_zipcode.Text = api.ZipCode;
                lb_province.Text = api.Province;

                XMLManager xml = new XMLManager();
                xml.InsertData(api.Name, api.ZipCode, api.HouseNumber, api.City, api.StreetName, api.Province);


                StringBuilder query = new StringBuilder();
                query.Append("https://www.google.nl/maps/place/"+ api.StreetName + "+" + api.HouseNumber + ",+" +api.ZipCode + "+"+ api.City);
                link = query.ToString();
                gotogoogle.Visible = true;
                history();
            }
            else
            {
                gotogoogle.Visible = false;
                MessageBox.Show("Address niet gevonden");
            }
        }

        /// <summary>
        /// Build google link
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gotogoogle_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(link);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geen address gevonden");
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Makes the historylist bigger
        /// </summary>
        public void history()
        {
            XMLManager xml = new XMLManager();
            xml.Read();

            foreach (var i in xml.Addressen)
            {
                list.Items.Add(i.Name + " - " + i.Street + ", " + i.Number + " " + i.City + " " + i.ZipCode);
            }
        }
    }
}
