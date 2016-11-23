using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public enum TestEnum : byte
    {
        one = 1,
        two = 2
    }

    [Flags]
    public enum DaysOfWeek
    {
        sunday = 1,
        monday = 2,
        tuesday = 4,
        wednesday = 8,
        thursday = 16,
        friday = 32,
        saturday = 64,
        sundayAndMonday = sunday | monday,
        first = 33,
        second = 34,
        firstOrSecond = first | second
    }


    [Flags]
    public enum DocumentButtonType
    {
        Send = 1,
        SignSend = 2,
        Delete = 4,
        DeclineAndDelete = 8,
        SignByContractor = 16,
        SignByOwnerAndPublish = 32,
        Recovery = 64,
        FullDelete = 128,
        NotAgreedWithTermsSend = 256,
        NotAgreedWithTermsSignSend = 512,
        EcpErrorSend = 1024,
        EcpErrorSignSend = 2048,
        UserAgree = 4096,
        UserDisagree = 8192,
        UserAgreeRequiresDS = 16384
    }

    public static class DaysOfWeekExtension
    {
        public static void Ext(this DaysOfWeek daysOfWeek)
        {
            Console.WriteLine(daysOfWeek + " + extension string!");
        }

    }
}
