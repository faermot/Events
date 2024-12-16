using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Utils
{
    public class Subscriber : Publisher
    {
        public Subscriber(Publisher publisher)
        {
            publisher.Notify += OnNotify;
        }

        public void OnNotify(object sender, EventArgs e, string message)
        {
            Console.WriteLine(message);
        }
    }
}
