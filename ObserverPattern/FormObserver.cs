using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPattern
{
    public partial class FormObserver : Form
    {
        private Form form;
        private WeatherStation ws;
        public FormObserver(Form1 form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FormObserver_Load(object sender, EventArgs e)
        {

        }

        private void FormObserver_FormClosing(object sender, FormClosingEventArgs fe)
        {
            //detach
        }
    }
}
