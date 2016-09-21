using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public class NewMailEventArgs : EventArgs
    {
        private string _from;
        private string _to;

        public NewMailEventArgs(string from, string to)
        {
            this._from = from;
            this._to = to;
        }

        public string from { get { return _from; } }
        public string to { get { return _to; } }
    }

    public class MailManager
    {
        public event EventHandler<NewMailEventArgs> NewMail;
        public virtual void OnNewMail(NewMailEventArgs e)
        {
            if (NewMail != null)
            {
                NewMail(this, e);
            }
        }

        public void SimulateNewMail(string from, string to)
        {
            OnNewMail(new NewMailEventArgs(from, to));
        }
        public int MyProperty { get { return 123; } }
    }

    public class Fax
    {
        public static void On_newmail(Object sender, NewMailEventArgs e)
        {
            var r = (MailManager)sender;
            var prop = r.MyProperty;
            Console.WriteLine("FAX is Speaking - from " + e.from + " to " + e.to + ". And prop - " + prop);
        }
    }

    public class Phone
    {
        public static void On_newmail(Object sender, NewMailEventArgs e)
        {
            Console.WriteLine("Phone is Speaking - from " + e.from + " to " + e.to);
        }
    }
}
