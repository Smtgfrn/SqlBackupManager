using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlBackup_Yeni
{
    public class Sifreleme
    {
        public string Sifrele(string data)

        {

            byte[] tempDizi = System.Text.ASCIIEncoding.ASCII.GetBytes(data);

            string finalData = System.Convert.ToBase64String(tempDizi);

            return finalData;

        }
        public string SifreCoz(string cozulecekdata)

        {

            Label lbl = new Label();

            string deger = "atasayarteknoloji.com";

            string CozulecekVeri = "";

            lbl.Text = cozulecekdata.EndsWith(deger).ToString();

            if (lbl.Text == "True")

            {

                CozulecekVeri = cozulecekdata;

            }

            else

            {

                byte[] tempDizi = Convert.FromBase64String(cozulecekdata);

                CozulecekVeri = System.Text.ASCIIEncoding.ASCII.GetString(tempDizi);



            }

            return CozulecekVeri;

        }
    }
}
