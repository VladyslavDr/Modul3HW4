using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3CW4
{
    public class Task1
    {
        // public Func<int, int, int> FuncDelegate { get; set; }
        private Func<int, int, int> _funcHandler;

        public int Sum(int value1, int value2)
        {
            return value1 + value2;
        }

        public int Run()
        {
            _funcHandler += Sum;
            _funcHandler += Sum;

            var listOfDelegate = _funcHandler.GetInvocationList();

            var sum = 0;
            foreach (var item in listOfDelegate)
            {
                int.TryParse(item.DynamicInvoke(2, 5).ToString(), out var res);

                sum += res;
            }

            return sum;
        }

        public void TryCatch(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exe)
            {
                Console.WriteLine(exe);
            }
        }
    }
}
