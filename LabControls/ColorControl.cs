using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabControls
{
    public partial class ColorControl : UserControl
    {
        private Color color;

        public event EventHandler<EventArgs> ColorChanged;

        bool blockColorChange = false;

        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                OnColorChanged();

                blockColorChange = true;

                if (rbDec.Checked)
                {
                    cprRed.Text = value.R.ToString();
                    cprGreen.Text = value.G.ToString();
                    cprBlue.Text = value.B.ToString();
                }
                else if (rbHex.Checked)
                {
                    cprRed.Text = value.R.ToString("X");
                    cprGreen.Text = value.G.ToString("X");
                    cprBlue.Text = value.B.ToString("X");
                }

                blockColorChange = false;
            }
        }

        private byte GetByteFromText(string text)
        {
            byte b = 0;

            if (rbDec.Checked)
                b = byte.Parse(text);
            else if (rbHex.Checked)
                b = byte.Parse(text, System.Globalization.NumberStyles.HexNumber);

            return b;
        }

        private Color GetColorFromText()
        {
            byte r, g, b;
            r = GetByteFromText(cprRed.Text);
            g = GetByteFromText(cprGreen.Text);
            b = GetByteFromText(cprBlue.Text);
            return Color.FromArgb(r, g, b);
        }
        public ColorControl()
        {
            InitializeComponent();
            Color = GetColorFromText();

        }
        protected void OnColorChanged()
        {
            pbColor.BackColor = Color;
            if (ColorChanged != null)
                ColorChanged(this, new EventArgs());
        }

        private void cprRed_TextChanged(object sender, EventArgs e)
        {
            if (!blockColorChange)
            {
                color = GetColorFromText();
                OnColorChanged();
            }
        }

        private void cprGreen_TextChanged(object sender, EventArgs e)
        {
            if (!blockColorChange)
            {
                color = GetColorFromText();
                OnColorChanged();
            }
        }

        private void cprBlue_TextChanged(object sender, EventArgs e)
        {
            if (!blockColorChange)
            {
                color = GetColorFromText();
                OnColorChanged();
            }
        }

        private void rbDec_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDec.Checked)
            {
                cprRed.IsDigit = cprGreen.IsDigit = cprBlue.IsDigit = true;

                blockColorChange = true;

                cprRed.Text = (byte.Parse(cprRed.Text, System.Globalization.NumberStyles.HexNumber)).ToString();
                cprBlue.Text = (byte.Parse(cprBlue.Text, System.Globalization.NumberStyles.HexNumber)).ToString();
                cprGreen.Text = (byte.Parse(cprGreen.Text, System.Globalization.NumberStyles.HexNumber)).ToString();

                blockColorChange = false;
            }
        }

        private void rbHex_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHex.Checked)
            {
                cprRed.IsDigit = cprGreen.IsDigit = cprBlue.IsDigit = false;

                blockColorChange = true;

                cprRed.Text = (byte.Parse(cprRed.Text)).ToString("X");
                cprBlue.Text = (byte.Parse(cprBlue.Text)).ToString("X");
                cprGreen.Text = (byte.Parse(cprGreen.Text)).ToString("X");

                blockColorChange = false;
            }
        }
    }
}
