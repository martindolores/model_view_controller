using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelViewController.Controller;

namespace ModelViewController
{
    public partial class ExampleView : Form
    {
        private ExampleController _controller;

        public ExampleView()
        {
            InitializeComponent();
        }

        public void SetController(ExampleController controller)
        {
            _controller = controller;
        }

        public void UpdateView(string data)
        {
            textBox1.Text = data;
        }

        private void btnGenerateText_Click(object sender, EventArgs e)
        {
            _controller.UpdateData(Guid.NewGuid().ToString());
        }
    }
}
