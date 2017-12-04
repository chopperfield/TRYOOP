using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRYOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
                 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Global.GlobalVar +" - "+ Class1.s_Name);
            Global.GlobalVar = "test1";
            Class1.s_Name = "test2";
            MessageBox.Show(Global.GlobalVar +" - "+ Class1.s_Name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SimpleMath SM = new SimpleMath();
                int x = SM.AddTwoNumbers(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                MessageBox.Show(x.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Person person1 = new Person();
            MessageBox.Show(person1.name);
            

            person1.SetName("John Smith");
            MessageBox.Show(person1.name);

            // Call the constructor that has one parameter.
            Person person2 = new Person("Sarah Jones");
            MessageBox.Show(person2.name);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Personv2 person1 = new Personv2("Leopold", 6);
            MessageBox.Show("person1 Name = "+person1.Name+", Age = "+person1.Age+"");

            // Declare  new person, assign person1 to it.
            Personv2 person2 = person1;

            //Change the name of person2, and person1 also changes.
            person2.Name = "Molly";
            person2.Age = 16;

            MessageBox.Show("person2 Name = " + person2.Name + ", Age = " + person2.Age + "");
            MessageBox.Show("person1 Name = " + person1.Name + ", Age = " + person1.Age + "");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Personv3 person1 = new Personv3("Leopold", 6);
            MessageBox.Show("person1 Name = " + person1.Name + ", Age = " + person1.Age + "");

            // Declare  new person, assign person1 to it.
            Personv3 person2 = person1;

            //Change the name of person2, and person1 also changes.
            person2.Name = "Molly";
            person2.Age = 16;

            MessageBox.Show("person2 Name = " + person2.Name + ", Age = " + person2.Age + "");
            MessageBox.Show("person1 Name = " + person1.Name + ", Age = " + person1.Age + "");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double x = TemperatureConverter.CelsiusToFahrenheit(textBox1.Text);
            MessageBox.Show(x.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            MyClass myClass = new MyClass();
            myClass.ChangeBackgroundColor(f2);

            f2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            colorPickEdit1.Color = Color.FromArgb(Convert.ToInt32(textEdit1.Text));
        }
        private void button12_Click(object sender, EventArgs e)
        {
            textEdit1.Text = colorPickEdit1.Color.ToArgb().ToString();
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = e.Location.X.ToString();
            textBox2.Text = e.Location.Y.ToString();

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X == 10 && e.Y == 10)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        int count = 0;
        private void button11_Click(object sender, EventArgs e)
        {
            if (count == 4) this.Close();
            count++;
            String[] strpleaseloop = { "Monday", "Tuesday", "Wednesday" };
            Random r = new Random();
            int iSelect = r.Next(0,3);
           
            textBox1.Text = strpleaseloop[iSelect];
        }


    }
}
