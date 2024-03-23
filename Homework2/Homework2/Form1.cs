using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2
{
    public partial class Form1 : Form
    {

        Button button;

        public Form1()
        {
            InitializeComponent();
            InitializeButton();
        }


        private void InitializeButton()
        {
            button = new Button();
            button.Text = "Runner";
            button.Size = new Size(75, 40);
            button.Click += Runner_Click;
            Controls.Add(button);
        }

        private void Runner_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int a = random.Next(0, this.ClientSize.Width - button.Width);
            int b = random.Next(0, this.ClientSize.Height - button.Height);
            button.Location = new Point(a, b);

        }
    }
}
