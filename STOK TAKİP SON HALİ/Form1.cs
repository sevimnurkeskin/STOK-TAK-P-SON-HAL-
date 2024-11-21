using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STOK_TAKİP_SON_HALİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Form2'yi örnekleyin
            form2.Show(); // Formu gösterin
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); // Form3'ü örnekleyin
            form3.Show(); // Formu gösterin
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(); // Form3'ü örnekleyin
            form4.Show(); // Formu gösterin
        }

    }

}
