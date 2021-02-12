using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary2
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> colores = new List<string>();

            colores.Add("red");
            colores.Add("yellow");
            colores.Add("green");
            colores.Add("blue");
            colores.Add("grey");

            if (textBox1.Text.Equals(colores[0]))
            {
                Console.BackgroundColor = ConsoleColor.Red;
                label3.Text = "Rojo";
            }

            if (textBox1.Text.Equals(colores[1]))
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                label3.Text = "Amarillo";
                
            }

            if (textBox1.Text.Equals(colores[2]))
            {
                Console.BackgroundColor = ConsoleColor.Green;
                label3.Text = "Verde";
                
            }

            if (textBox1.Text.Equals(colores[3]))
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                label3.Text = "Azul";
            }
            if (textBox1.Text.Equals(colores[4]))
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                label3.Text = "Gris";

            }
           if (textBox1.Text.Equals(" "))
            {
                label3.Text = "Espacio en blanco";
            }
        }


        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = textBox1.Focused;
        }

        public static ConsoleColor BackgroundColor { get; set; }


        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
