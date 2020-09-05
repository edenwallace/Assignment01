using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment01
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblshift_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string origMessage = normalText.Text;
            int shiftNum = Int32.Parse(textBox3.Text);

            cypherText.Text = DoEncryption(origMessage.ToLower(), shiftNum);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private static string DoEncryption(string words, int shiftNo)
        {
            char[] buffer = words.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                letter = (char)(letter + shiftNo);

                if (letter > 'z')
                {
                    letter = (char)(letter - 26);
                }
                else if (letter < 'a')
                {
                    letter = (char)(letter + 26);
                }

                buffer[i] = letter;
            }

            return new string(buffer);
        }

        private static string DoDecryption(string words, int shiftNo)
        {
            char[] buffer = words.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                letter = (char)(letter - shiftNo);

                if (letter > 'z')
                {
                    letter = (char)(letter - 26);
                }
                else if (letter < 'a')
                {
                    letter = (char)(letter + 26);
                }

                buffer[i] = letter;
            }

            return new string(buffer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string origMessage = normalText.Text;
            int shiftNum = Int32.Parse(textBox3.Text);

            cypherText.Text = DoDecryption(origMessage.ToLower(), shiftNum);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpScreen helpForm = new helpScreen();
            helpForm.Show();
        }
    }

    

}

