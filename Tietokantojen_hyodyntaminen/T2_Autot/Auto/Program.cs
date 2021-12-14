using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autokauppa.view;

namespace Autokauppa
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu MainWindow = new MainMenu();
            MainWindow.ShowDialog();
        }
    }
}
