using Events.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Utils
{
    public delegate void NotifyEventHandler(object sender, EventArgs e, string message);

    public class Publisher
    {
        public event NotifyEventHandler Notify;

        public void TriggerEvent(string message)
        {
            Notify?.Invoke(this, EventArgs.Empty, message);
        }
    }
}
