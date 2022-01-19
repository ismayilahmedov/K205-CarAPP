using K205_CarAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K205_CarAPP.Methods
{
    public class TelebeManager
    {
        public void QiymetYaz(Telebe telebe)
        {
            Console.WriteLine("HELLOOOO");
        }


       
       
        public void TelebeInfo(Telebe telebe)
        {
            Console.WriteLine("telebe adi: " + telebe.Name);
            Console.WriteLine("telebenin qiymeti: " + telebe.Qiymeti);

        }
    }
}
