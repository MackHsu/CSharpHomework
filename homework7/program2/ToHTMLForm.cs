using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program2
{
    public partial class ToHTMLForm : Form
    {
        public String XmlFileName { get; set; }
        public String XsltFileName { get; set; }
        public String HtmlFileName { get; set; }

        public ToHTMLForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlFileName = textBoxXml.Text;
            textBoxXml.DataBindings.Add("Text", this, "XmlFileName");
            XsltFileName = textBoxXslt.Text;
            textBoxXslt.DataBindings.Add("Text", this, "XsltFileName");
            HtmlFileName = textBoxHtml.Text;
            textBoxHtml.DataBindings.Add("Text", this, "HtmlFileName");
            Close();
        }
    }
}
