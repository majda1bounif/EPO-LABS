using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kpo_8
{
    public partial class Form1 : Form
    {
        int count = 1;
        Subject subject = new Subject("Harry Potter Novels", 1000);

        public Form1()
        {
            InitializeComponent();
            panel1.Hide();
            button2.Visible = false;
            //panel2.Hide();
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                panel1.Show();
                //panel2.Hide();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                string userName = textBox1.Text;
                Observer observer = new Observer(userName);
                subject.Price = 800;
                subject.registerObserver(observer);
                int dataa = subject.CountObserver(observer);
                textBox3.Text = dataa.ToString();
                string data = observer.GeInfo(subject);
                textBox2.Text = data + "\n\n --------- You Have Already Subscribe To This Product -----\n";
                richTextBox1.AppendText(textBox1.Text + "\n");
                richTextBox2.AppendText(textBox1.Text + "  // Subscribed At // " + DateTime.Now + "\n");
                button1.Visible = false;
                button2.Visible = true;
                //richTextBox1.AppendText(textBox1.Text);
                //File.WriteAllText("C:\\Users\\Majda\\Desktop\\UserName.txt", richTextBox1.Text.Replace("\n", Environment.NewLine));
            }
            else
            {
                MessageBox.Show("Please Enter a Subscriber Name");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int index;
                do
                {
                    index = richTextBox1.Find(textBox1.Text);
                    if (index >= 0)
                    {
                        Observer observer = new Observer(textBox1.Text);
                        subject.Price = 800;
                        subject.unregisterObserver(observer);
                        int dataaa = subject.CountObserver(observer) - 1;
                        textBox3.Text = dataaa.ToString();
                        string data = observer.GeInfo(subject);
                        textBox2.Text = data + "\n\n --------- You Have Already UnSubscribe To This Product -----\n";
                        richTextBox1.Select(index, textBox1.Text.Length);
                        richTextBox1.SelectedText = String.Empty;
                        button2.Visible = false;
                        button1.Visible = true;
                        //string userName = textBox1.Text;
                        //Observer observer = new Observer(textBox1.Text);
                        //subject.Price = 800;
                        //subject.unregisterObserver(observer);
                        //int D = subject.CountObserver(observer);
                        //textBox2.Text = D.ToString();
                        //string data = observer.GeInfo(subject);
                        //textBox2.Text = data + "\n\n --------- You Have Already Subscribe To This Product -----\n";
                        ////richTextBox1.AppendText(textBox1.Text + "\n");

                    }
                }
                while (index >= 0);
            }

            else
            {
                MessageBox.Show("Please Enter a Subscriber Name");
            }
        }
    }
}
