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
namespace vizeodevi
{
    public partial class Form1 : Form
    {
        string duyuru = "https://www.btk.gov.tr/rss/announcements";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument bilgi = new XmlDocument();
            bilgi.Load(duyuru);
            XmlElement root = bilgi.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("link");
        }
    }
}
