using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowToHighlightPortionOfText
{
    public partial class HilightTextDemo : Form
    {
        public HilightTextDemo()
        {
            InitializeComponent();
            textBox1.Text = "StackOverflow is a wonderful site";
            textBox1.SelectionStart = 19;
            textBox1.SelectionLength = 9;
            enableDoubleBuffering();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button3.BackColor = colorDialog1.Color;
            button1.BackColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button2.BackColor = colorDialog1.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button3.ForeColor = colorDialog1.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox1.SelectionLength == 0)
            {
                MessageBox.Show("You must enter text in textbox and also select portion in it");
                return;
            }
            using (var g = this.CreateGraphics())
            {
                int start = textBox1.SelectionStart;
                int end = start + textBox1.SelectionLength - 1;
                var rc = new Rectangle(button1.Left, 137, 860, 90);

                Invalidate(rc);
                Update();
                g.HighlightText(textBox1.Font, textBox1.Text, rc,
                    start, end, button3.ForeColor, button1.BackColor, button2.BackColor);
            }
        }
        void enableDoubleBuffering()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor, true);
            this.UpdateStyles();
        }
    }
}
