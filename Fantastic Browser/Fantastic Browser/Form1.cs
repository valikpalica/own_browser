using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fantastic_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Url = new Uri("http://google.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //search
            if (!webBrowser1.IsOffline) {
                webBrowser1.Navigate(textBox1.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!webBrowser1.IsOffline) {
                webBrowser1.Navigate("http://google.com");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //back
            if (!webBrowser1.IsOffline && webBrowser1.CanGoBack) {
                webBrowser1.GoBack();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //go ahead
            if(webBrowser1.CanGoForward && !webBrowser1.IsOffline) {
                webBrowser1.GoForward();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //refresh
            if (!webBrowser1.IsOffline) {
                webBrowser1.Refresh();
            }
        }

    }
}
