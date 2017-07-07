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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            // Create an instance of WorkItem by using the constructor in the 
            // base class that takes three arguments.
            WorkItem item = new WorkItem("Fix Bugs",
                                         "Fix all bugs in my code branch",
                                         new TimeSpan(3, 4, 0, 0));
            //test default constructor
            WorkItem item2 = new WorkItem();
            MessageBox.Show(item2.ToString());

            // Create an instance of ChangeRequest by using the constructor in
            // the derived class that takes four arguments.
            ChangeRequest change = new ChangeRequest("Change Base Class Design",
                                                     "Add members to the class",
                                                     new TimeSpan(4, 0, 0),
                                                     3);

            // Use the ToString method defined in WorkItem.
            MessageBox.Show(item.ToString());
            // Use the inherited Update method to change the title of the 
            // ChangeRequest object.
            change.Update("Cx",
                new TimeSpan(5, 0, 0));

            // ChangeRequest inherits WorkItem's override of ToString.
            MessageBox.Show(change.ToString());

            MessageBox.Show(item.test1("aaa"));
            MessageBox.Show(change.test1("hi"));
            
        }
    }
}
