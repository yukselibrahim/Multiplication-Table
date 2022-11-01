using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Alıştırma_9
{
    public class Islem
    {

        public  void CarpimTablosu()
        {
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine("********");
                for (int j = 1; j <=10; j++)
                {

                    Console.WriteLine(i+"x"+j+"="+(i*j));
                }

            }

        }

       
        
        



    }
}
