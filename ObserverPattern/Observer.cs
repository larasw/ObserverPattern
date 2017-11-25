using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    interface Observer
    {
        void Update(int state);
        int GetData();
    }

    class Website : Observer
    {
        private int input;

        public void Update(int state)
        {
            input = state;
        }

        public int GetData()
        {
            return input;
        }
    }

    class Wireless : Observer
    {
        private int input;

        public void Update(int state)
        {
            input = state;
        }
        public int GetData()
        {
            return input;
        }
    }
}
