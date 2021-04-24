using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
namespace vizeodevi
{
    public partial class Form1 : Form
    {
        string dosya = "http://www.trt.net.tr/rss/turkiye.rss";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument trt = new XmlDocument();
            trt.Load(dosya);
            XmlElement root = trt.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("channel");


            foreach (XmlNode node in nodes)
            {
                string baslik = node["title"].InnerText;
                string haber = node["description"].InnerText;
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = baslik;
                row.Cells[1].Value = haber;
                dataGridView1.Rows.Add(row);







            }
        }

        
             
        
    }

}
        

        


    
