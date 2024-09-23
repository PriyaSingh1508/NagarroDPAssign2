using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    public interface IObserver
    {
        void Update(string channel, string subject, string message);
    }
}
