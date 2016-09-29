using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars
{
    public partial class Form1 : Form
      
    {
        public Form1()
        {
            InitializeComponent();
        }
            int carPos1 = 50;
            int carPos2 = 50;
            int carPos3 = 50;
            int carPos4 = 50;
            int carPos5 = 50;
            int red, orange, yellow, blue, green;

        private void button1_Click(object sender, EventArgs e)
          {
                Random i = new Random();

                int car1Speed1 = i.Next(5, 50);
                int car2Speed2 = i.Next(5, 50);
                int car3Speed3 = i.Next(5, 50);
                int car4Speed4 = i.Next(5, 50);
                int car5Speed5 = i.Next(5, 50);

                carPos1 = carPos1 + car1Speed1;
                carPos2 = carPos2 + car2Speed2;
                carPos3 = carPos3 + car3Speed3;
                carPos4 = carPos4 + car4Speed4;
                carPos5 = carPos5 + car5Speed5;

                this.Car1.Left = this.Car1.Left + car1Speed1;
                this.Car2.Left = this.Car2.Left + car2Speed2;
                this.Car3.Left = this.Car3.Left + car3Speed3;
                this.Car4.Left = this.Car4.Left + car4Speed4;
                this.Car5.Left = this.Car5.Left + car5Speed5;

            if (carPos1 >= 700)
            {
                label1.Text = "Red";

                label1.Visible = true;
                label2.Visible = true;
                red = +1;

                button1.Visible = false;
            }
            if (carPos2 >= 700)
            {
                label1.Text = "Orange";

                label1.Visible = true;
                label2.Visible = true;
                orange = +1;

                button1.Visible = false;
            }
            if (carPos3 >= 700)
            {
                label1.Text = "Yellow";

                label1.Visible = true;
                label2.Visible = true;
                yellow = +1;

                button1.Visible = false;
            }
            if (carPos4 >= 700)
            {
                label1.Text = "Green";

                label1.Visible = true;
                label2.Visible = true;
                green = +1;

                button1.Visible = false;
            }
            if (carPos5 >= 700)
            {
                label1.Text = "Blue";

                label1.Visible = true;
                label2.Visible = true;
                blue = +1;

                button1.Visible = false;
            }

            lblRed.Text = " " + red;
            lblOrange.Text = " " + orange;
            lblYellow.Text = " " + yellow;
            lblGreen.Text = " " + green;
            lblBlue.Text = " " + blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Car1.Left = 84;
            this.Car2.Left = 84;
            this.Car3.Left = 84;
            this.Car4.Left = 84;
            this.Car5.Left = 84;

            carPos1 = 50;
            carPos2 = 50;
            carPos3 = 50;
            carPos4 = 50;
            carPos5 = 50;

            button1.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            red = 0;
            orange = 0;
            yellow = 0;
            green = 0;
            blue = 0;

            lblRed.Text = " " + red;
            lblOrange.Text = " " + orange;
            lblYellow.Text = " " + yellow;
            lblGreen.Text = " " + green;
            lblBlue.Text = " " + blue;
        }
    }
}
