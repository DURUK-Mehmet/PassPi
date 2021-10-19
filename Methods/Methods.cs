using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassPi.Methods
{
    public class Methods
    {
        public List<string> simple = new List<string>();

        int second, order,ret;

        string[] pim = new string[] { "141","897","264","502","693","582","592","062","862","342",
                                      "821","328","093","505","535","481","841","852","644","549",
                                      "442","665","284","378","271","456","346","454","133"};

        string[] pis = new string[] { "1415926535","8979323846","2643383279","5028841971","6939937510","5820974944","5923078164","0628620899","8628034825","3421170679",
                                      "8214808651","3282306647","0938446095","5058223172","5359408128","4811174502","8410270193","8521105559","6446229489","5493038196",
                                      "4428810975","6659334461","2847564823","3786783165","2712019091","4564856692","3460348610","4543266482","1339360726"};

        public void send(string[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                int y = Proce(x[i]);
                simple.Add(Convert.ToString(y));
            }
        }

        public int Proce(string val)
        {
            for (int i = 0; i < val.Length; i++)
            {
                string first = val.Substring(i, 1);
                second = Finding(first);
            }

            return second;
        }

        public int Finding(string first)
        {
            order = 0;
            char x = Convert.ToChar(first.ToLower());
            for (char alphabet = 'a'; alphabet <= 'z'; alphabet++)
            {
                if (x == alphabet)
                {
                     ret = (int)Convert.ToInt64(pis[order]);
                }
                order++;
            }
            return ret;
        }
    }
}
