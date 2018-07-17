using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hex_Color
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            txtNumber.Text = "#654321";
            RGB();
            CMYK();
            colorSample();
        }

        private void colorSample()
        {
            boxColor.BackColor = Color.FromArgb(Int32.Parse(R.Text),
                Int32.Parse(G.Text),
                Int32.Parse(B.Text));
        }

        private void CMYK()
        {
            Hex_Color.convert transf = new Hex_Color.convert();
            string[] CMYK = new string[4];
            CMYK = transf.toCMYK(R.Text, G.Text, B.Text);
            C.Text = CMYK[0];
            M.Text = CMYK[1];
            Y.Text = CMYK[2];
            K.Text = CMYK[3];
        }

        private void fromCMYK()
        {
            Hex_Color.convert transf = new Hex_Color.convert();
            string[] RGB = new string[3];
            RGB = transf.fromCMYK(C.Text,Y.Text,M.Text,K.Text);
            R.Text = RGB[0];
            G.Text = RGB[1];
            B.Text = RGB[2];
        }


        private void RGB()
        {
            Hex_Color.convert transf = new Hex_Color.convert();
            string[] RGB = new string[3];
            RGB = transf.todec(txtNumber.Text);
            R.Text = RGB[0];
            G.Text = RGB[1];
            B.Text = RGB[2];
        }

        private void hexa()
        {
            Hex_Color.convert transf = new Hex_Color.convert();
            txtNumber.Text = transf.toHex(R.Text, G.Text, B.Text);
        }

        private void btnFromHex_Click(object sender, EventArgs e)
        {
            //https://www.rapidtables.com/convert/color/rgb-to-cmyk.html

            RGB();
            CMYK();
            colorSample();
        }

        private void btnFromRGB_Click(object sender, EventArgs e)
        {
            hexa();
            CMYK();
            colorSample();

            
        }

        private void btnFromCMYK_Click(object sender, EventArgs e)
        {
            fromCMYK();
            hexa();    
            colorSample();
        }
    }
}
