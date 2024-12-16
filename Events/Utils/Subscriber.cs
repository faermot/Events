using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Utils
{
    public class Subscriber : Publisher
    {
        private string _name;

        public Subscriber(Publisher publisher)
        {
            publisher.Notify += OnNotify;
        }

        public Subscriber(string name, Publisher publisher) 
        {
            _name = name;
            publisher.Notify += OnNotify;
        }

        public void Unsubscribe(Publisher publisher)
        {
            publisher.Notify -= OnNotify;
        }

        public void OnNotify(object sender, EventArgs e, string message)
        {
            if (_name != null) Console.WriteLine($"{_name} : {message}");
            else Console.WriteLine(message);
        }
    }
}
