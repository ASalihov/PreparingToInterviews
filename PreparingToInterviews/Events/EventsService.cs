using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews.Events
{
    public class EventsService
    {
        public EventsService()
        {

        }

        private void MailManagerCall()
        {
            var mm = new MailManager();
            mm.NewMail += Fax.On_newmail;
            mm.NewMail += Phone.On_newmail;
            mm.SimulateNewMail("SENDER", "RECIPIENT");
        }
    }
}
