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
using MainClassLibrary;


namespace MainForm
{
    public partial class Form1 : Form
    {
        private string View;
        private string FilePath;
        private Dictionary<RadioButton, string> views;

        public Form1()
        {
            InitializeComponent();
            views = new Dictionary<RadioButton, string>();
            views.Add(radioButton1, "HTML");
            views.Add(radioButton2, "TXT");
            View = "TXT";
            openFileDialog1.Filter = "YAML Files | *.yaml";
            saveFileDialog1.Filter = "Viewable docs | *.txt;*.html";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            FilePath = openFileDialog1.FileName;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(FilePath, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            YAMLFile manager = new YAMLFile(sr);
            Customer customer = manager.GetCustomer(); BillGenerator res;
            switch (View)
            {
                case "TXT":
                    res = new BillGenerator(customer, new TXTPresenter());
                    break;
                case "HTML":
                    res = new BillGenerator(customer, new HTMLPresenter());
                    break;
                default:
                    throw new ArgumentException("no such view");
            }

            int cnt = manager.GetGoodsCount();
            Goods[] g = new Goods[cnt];
            for (int i = 0; i < cnt; i++)
            {
                g[i] = manager.GetNextGood();
            }
            int itemsQty = manager.GetItemsCount();
            for (int i = 0; i < itemsQty; i++)
            {
                res.addGoods(manager.GetNextItem(g));
            }
            string output = res.GenerateBill();

            sr.Close();
            fs.Close();
            saveFileDialog1.FileName = "bill." + View.ToLower();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string target = saveFileDialog1.FileName;
                if (File.Exists(target))
                {
                    File.Delete(target);
                }
                StreamWriter w = new StreamWriter(target);
                w.WriteLine(output);
                w.Close();
                MessageBox.Show("Your Data Has been Saved", "Succed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FilePath = "";
                button2.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            View = views[(RadioButton)sender];

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
