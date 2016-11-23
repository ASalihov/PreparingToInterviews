using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PreparingToInterviews
{
    public class DelegatesService
    {
        public DelegatesService()
        {
            //StaticDelegateDemo();
            //InstanceDelegateDemo();
            //ChanDelegateDemo1(new DelegatesService(false));
            //ChanDelegateDemo2(new DelegatesService(false));
            //ChangeDelegateDemo3();
            ChangeDelegateDemo4();
        }



        #region Richter delegates example

        private void ChangeDelegateDemo4()
        {
            //Counter2(1, 3, (Int32 del, Int32 del2) => { return $"Console.WriteLine({del} + -  + {del2}))"; });
        }

        private void ChangeDelegateDemo3()
        {
            Feedback fbchain = null;
            fbchain += FeedbackToConsole1;
            fbchain += FeedbackToConsole2;
            fbchain += FeedbackToConsole3;

            Counter(1, 3, fbchain);
        }

        private void ChanDelegateDemo2(DelegatesService p)
        {
            Console.WriteLine("­­­­­Chain Delegate Demo 2 ­­­­­");
            Feedback fb1 = new Feedback(FeedbackToConsole1);
            Feedback fb2 = new Feedback(FeedbackToConsole2);
            Feedback fb3 = new Feedback(p.FeedbackToConsole3);

            Feedback fbchain = null;
            fbchain += fb1;
            fbchain += fb2;
            fbchain += fb3;

            Counter(1, 2, fbchain);
            Console.WriteLine();

            fbchain -= new Feedback(FeedbackToConsole2);
            Counter(1, 2, fbchain);
        }

        private void ChanDelegateDemo1(DelegatesService p)
        {
            Console.WriteLine("­­­­­Chain Delegate Demo 1 ­­­­­");
            Feedback fb1 = new Feedback(FeedbackToConsole1);
            Feedback fb2 = new Feedback(FeedbackToConsole2);
            Feedback fb3 = new Feedback(p.FeedbackToConsole3);

            Feedback fbchain = null;
            fbchain = (Feedback)Delegate.Combine(fbchain, fb1);
            fbchain = (Feedback)Delegate.Combine(fbchain, fb2);
            fbchain = (Feedback)Delegate.Combine(fbchain, fb3);

            Console.WriteLine();

            fbchain = (Feedback)Delegate.Remove(fbchain, new Feedback(FeedbackToConsole2));
            Counter(1, 2, fbchain);
        }

        private void InstanceDelegateDemo()
        {
            Console.WriteLine("­­­­­Instance Delegate Demo ­­­­­");
            DelegatesService d = new DelegatesService(false);
            Counter(1, 3, new Feedback(d.FeedbackToConsole3));
            Console.WriteLine();

        }

        private void StaticDelegateDemo()
        {
            Console.WriteLine("­­­­­Static Delegate Demo ­­­­­");
            Counter(1, 3, null);
            Counter(1, 3, new Feedback(FeedbackToConsole1));
            Console.WriteLine();
        }

        private static void Counter(Int32 from, Int32 to, Feedback fb)
        {
            for (int i = from; i <= to; i++)
            {
                if (fb != null)
                {
                    fb(i);
                }
            }
        }
        private static void Counter2(Int32 from, Int32 to, Feedback2 fb)
        {
            for (int i = from; i <= to; i++)
            {
                if (fb != null)
                {
                    Console.WriteLine(fb(i, i+100));
                }
            }
        }

        private static void FeedbackToConsole1(Int32 val)
        {
            Console.WriteLine("FeedbackToConsole1 - item = {0}", val);
        }
        private static void FeedbackToConsole2(Int32 val)
        {
            Console.WriteLine("FeedbackToConsole2 - item = {0}", val);
        }
        private void FeedbackToConsole3(Int32 val)
        {
            Console.WriteLine("FeedbackToConsole3 - item = {0}", val);
        }

        #endregion

        private void DisplaySomeStuff()
        {

            List<Movie> m = new List<Movie>();
            m.ForEach(mov => Console.WriteLine(mov.Director));
            Delegates.ShowInfo(1, Delegates.SomeMeth);
        }

        private void AnonTypes()
        {
            var anon = new { a = 1, b = "2", c = new Human() };
            Console.WriteLine("anon.ToString() - " + anon.a);
        }

        public DelegatesService(bool needStart = false)
        {
            DelegatesService newService;
            if (needStart)
                newService = new DelegatesService();
        }
    }
}
