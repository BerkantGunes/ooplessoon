using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Kullanıcın girdiği tüm sayıları listbox a ekleyiniz ve farklı bir buton ile büyükten küçüğe sıralanmasını sağlayınız.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı;
            sayı =int.Parse(textBox1.Text);
            listBox1.Items.Add(sayı);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] sayılar =new int[listBox1.Items.Count];
            for (int i= 0;i<listBox1.Items.Count;i++)
            {
                sayılar[i] = Convert.ToInt32(listBox1.Items[i]);
            }
            Array.Sort(sayılar);
            Array.Reverse(sayılar);
            listBox1.Items.Clear();
            for (int i= 0;i<sayılar.Length;i++)
            {
                listBox1.Items.Add(sayılar[i]);
            }
        }
    }
}
