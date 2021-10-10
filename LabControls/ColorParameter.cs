using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabControls
{
    public partial class ColorParameter : TextBox
    {

        bool isDigit;

        public bool IsDigit
        {
            get { return isDigit; }
            set { isDigit = value; }
        }
        public ColorParameter()
        {
            InitializeComponent();
            IsDigit = true;

        }

        public ColorParameter(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            Text = "0";
            TextAlign = HorizontalAlignment.Right;
        }

        int Convert()
        {
            if (IsDigit)
            {
                if (!int.TryParse(Text, out _))
                    return -1;
                return int.Parse(Text);
            }
            else
            {
                if (Text.Length > 7)
                    return -1;
                foreach (char ch in Text)
                {
                    if (!char.IsDigit(ch) &&
                    (ch < 'a' || ch > 'f') &&
                    (ch < 'A' || ch > 'F'))
                        return -1;
                }
                return int.Parse(Text, System.Globalization.NumberStyles.HexNumber);
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            int num = Convert();
            if (num < 0)
                Text = "0";
            else if (num > 255)
                Text = IsDigit ? "255" : "FF";
            base.OnTextChanged(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (IsDigit)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl((e.KeyChar)))
                    e.Handled = true;
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl((e.KeyChar)) &&
                    (e.KeyChar < 'a' || e.KeyChar > 'f') &&
                    (e.KeyChar < 'A' || e.KeyChar > 'F'))
                    e.Handled = true;
            }
            base.OnKeyPress(e);
        }
    }
}
