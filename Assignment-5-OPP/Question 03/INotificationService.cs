using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_OPP.Question_03
{
    public interface INotificationService
    {
        void SendNotification(string message, string recipient);
    }
}
