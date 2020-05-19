using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customclassLib
{
    public class CustomClass
    {

        public async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    count++;
                }
            });
            return count;
        }
        public int Method2()
        {
            return 1;
        }


    }
}
