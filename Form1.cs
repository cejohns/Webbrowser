using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserSSFS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string webPage = textBox1.Text.Trim();
            webBrowser1.Navigate(webPage);
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }
            string webPage = textBox1.Text.Trim();
            webBrowser1.Navigate(webPage);
        }

        private void textBox1_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }
            string webPage = textBox1.Text.Trim();
            webBrowser1.Navigate(webPage);
        }
    }
}
