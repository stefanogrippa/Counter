using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        // la soluzione corretta sarebbe avere una tabella su db con un campo counter che viene incrementato 
        // da ogni client connesso
        // a ogni click del bottone faccio update del campo incrementando di uno
        static int counter = 0;
        public UserControl1()
        {
            InitializeComponent();
            textBox1.Text = String.Format("counter = {0}", counter);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // incrementa contatore
            counter++;
            textBox1.Text = String.Format("counter = {0}", counter);
        }
    }
}
