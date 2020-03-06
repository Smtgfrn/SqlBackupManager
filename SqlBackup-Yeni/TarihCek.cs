using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SqlBackup_Yeni
{
    public class TarihCek
    {
        public  DateTime GetNistTime()
        {
            var myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");
            var response = myHttpWebRequest.GetResponse();
            string todaysDates = response.Headers["date"];
            return DateTime.ParseExact(todaysDates,
                                       "ddd, dd MMM yyyy HH:mm:ss 'GMT'",
                                       CultureInfo.InvariantCulture.DateTimeFormat,
                                       DateTimeStyles.AssumeUniversal);
        }
    }
}
