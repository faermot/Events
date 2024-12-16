using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Utils
{
    public class PublisherTwo
    {
        public event EventHandler Notify;
        public void TriggerEvent()
        {
            Notify?.Invoke(this, EventArgs.Empty);
        }
    }
}
