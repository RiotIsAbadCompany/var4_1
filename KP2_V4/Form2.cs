using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KP2_V4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       public  List<object> m_list = new List<object>();
        public Form2(List<object> values)
        {
            InitializeComponent();
            this.m_list = values; 
            listBox1.DataSource = m_list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter(@"listbox.txt");
           
            string combinedString = string.Join(",", m_list);
            txt.Write(combinedString);
            txt.Close();
            MessageBox.Show("Saved");
        }


    }
}
