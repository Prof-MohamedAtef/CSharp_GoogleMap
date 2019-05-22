using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Embed_Google_Map
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1370, 726);
            Show_Map();
        }
        public void Show_Map()
        {
            StringBuilder Query_Address = new StringBuilder();
            Query_Address.Append("https://www.google.com.eg/maps/@31.13122,33.7908761,15z?hl=ar");
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate(Query_Address.ToString());
        }
        public void Draw_Lines_Rectangles(PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Black, 50, 50, 500, 500);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
//            Draw_Lines_Rectangles(e);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
