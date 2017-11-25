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
    public partial class Form1 : Form
    {
        private WeatherStation ws;
        private Observer obs1, obs2;
        private List<FormObserver> listObs;

        public Form1()
        {
            InitializeComponent();
            ws = new WeatherStation();
            obs1 = new Website();
            obs2 = new Wireless();

            ws.Attach(obs1);
            ws.Attach(obs2);

            listObs = new List<FormObserver>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void attachBtn_Click(object sender, EventArgs e)
        {
            if (observerList.Text != "")
            {
                FormObserver f = new FormObserver(this, ws);
                f.Text = "" + observerList.Text;
                f.Show();
                listObs.Add(f);
            }
        }

        private void inputBtn_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(inputText.Text);
            ws.SetState(input);
            
            webText.Text = "" + obs1.GetData();
            wiText.Text = "" + obs2.GetData();
            
            for(int i = 0; i < listObs.Count(); i++)
            {
                
            }
        }
    }
}
