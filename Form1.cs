using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reading_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReadXmlButton_Click_1(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\RafalC\\Desktop\\Exercise\\ReadingXML\\ReadingXML\authors.xml";

            AuthorsDataSet.ReadXml(filePath);

            dataGridView1.DataSource = AuthorsDataSet;
            dataGridView1.DataMember = "\authors";
        }

        private void ShowSchemaButton_Click(object sender, EventArgs e)
        {
            System.IO.StringWriter swXML = new System.IO.StringWriter();
            AuthorsDataSet.WriteXmlSchema(swXML);
            textBox1.Text = swXML.ToString();
        }

  
    }
}
