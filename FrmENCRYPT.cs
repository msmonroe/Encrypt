using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypt
{
    public partial class FrmEncrypt : Form
    {
        private const string ENDEROT = @"0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\]^_abcdefghijklmnopqrstuvwxyz";
        private const string ERROR = "Error";

        public FrmEncrypt()
        {
            InitializeComponent();

            PrivateFontCollection pfc = new PrivateFontCollection();

            pfc.AddFontFile(@"Roboto\Roboto-Regular.ttf");

            lblENCRYPT.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);

            txtBxENCRYPT.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);

            lblENCRYPT.Text = "                    ";

        }

        private void btnENCRYPT_Click(object sender, EventArgs e)
        {
            lblENCRYPT.Text = encrypto(txtBxENCRYPT.Text);
        }

        public string encrypto(string d)
        {
            try
            {
                string o = "";

                if (false == string.IsNullOrEmpty(d))
                {
                    string s = d.Trim();
                    int l = s.Length;

                    for (int i = 0; i < l; i++)
                    {
                        int x = ENDEROT.IndexOf(s.Substring(i, 1)) + i;

                        if (x < 0)
                        {
                            x = i;
                        }

                        o += ENDEROT.Substring(x, 1);
                    }
                }

                return o;
            }
            catch
            {
                return ERROR;
            }
        }
    }
}
