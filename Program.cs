using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelViewController.Controller;
using ModelViewController.Model;

namespace ModelViewController
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ExampleView view = new ExampleView();
            Example model = new Example();
            ExampleController controller = new ExampleController(model, view);
            view.SetController(controller);
            Application.Run(view);
        }
    }
}
