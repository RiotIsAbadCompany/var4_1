using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KP2_V4
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<object> values = new List<object>();
        private void button1_Click(object sender, EventArgs e)
        {
            double value1 = 0;
            double value2 = 0;
            double value3 = 0;
            try
            {
                listBox1.Items.Add(textBox1.Text);
                listBox1.Items.Add(textBox2.Text);
                listBox1.Items.Add(textBox3.Text);
                listBox1.Items.Add(textBox4.Text);
                listBox1.Items.Add(dateTimePicker1.Value);
                
                for(int i = 0; i < listBox1.Items.Count; i++)
                {
                    values.Add(listBox1.Items[i]);
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                foreach (RadioButton rad in groupBox1.Controls)
                {
                    if (rad.Checked)
                        listBox1.Items.Add(rad.Text);
                }
                if (radioButton1.Checked)
                    value1 = 3.09;
                else if (radioButton2.Checked)
                    value1 = 5.30;
                else if (radioButton3.Checked)
                    value1 = 4.00;
                foreach (RadioButton rad in groupBox2.Controls)
                {
                    if (rad.Checked)
                        listBox1.Items.Add(rad.Text);
                }
                if (radioButton4.Checked)
                    value2 = 5.50;
                else if (radioButton5.Checked)
                    value2 = 6.00;
                else if (radioButton6.Checked)
                    value2 = 7.23;
                foreach (RadioButton rad in groupBox3.Controls)
                {
                    if (rad.Checked)
                        listBox1.Items.Add(rad.Text);
                }
                if (radioButton7.Checked)
                    value3 = 9.00;
                else if (radioButton8.Checked)
                    value3 = 6.00;
                else if (radioButton9.Checked)
                    value3 = 4.50;
                double value = value1 + value2 + value3;
                textBox5.Text = ((value * (double.Parse(textBox4.Text) / 100)) * 1.2).ToString();
                foreach(RadioButton rad in groupBox1.Controls)
                { rad.Checked = false;}
                foreach (RadioButton rad in groupBox2.Controls)
                { rad.Checked = false; }
                foreach (RadioButton rad in groupBox3.Controls)
                { rad.Checked = false; }
                textBox4.Clear();
            }
            catch{ }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(values);
            form.Show();
        }
    }
}