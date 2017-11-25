using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    abstract class AbstractWeatherStation
    {
        List<Observer> observer = new List<Observer>();

        protected void notify(int state)
        {
            foreach(Observer i in observer)
            {
                i.Update(state);
            }
        }

        public void Attach(Observer o)
        {
            observer.Add(o);
        }

        public void Detach(Observer o)
        {
            observer.Remove(o);
        }
    }
    class WeatherStation : AbstractWeatherStation
    {
        private int state;

        //public int GetState()
        //{
        //    return state;
        //}

        public void SetState(int state)
        {
            this.state = state;
            notify(state);
        }
    }
}
