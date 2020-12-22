using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kpo_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



            Subject book = new Subject("La petite chaperon rouge ", 1000);
            book.Price = 900;
            Observer obs = new Observer("Ana");
            book.registerObserver(obs);
            string actual = obs.GeInfo(book);
            Console.WriteLine(actual);
            Console.ReadKey();
        }
    }
}
