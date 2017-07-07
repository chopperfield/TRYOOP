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
                f2.Show();
        }
    }
}
