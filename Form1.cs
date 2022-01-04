using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scgridcalc {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void optGrid_Click(object sender, EventArgs e) {
            if (optInPixel.Checked) {
                optInPixel.Checked = false;
            }

            procCalc();
        }

        private void optPixel_Click(object sender, EventArgs e) {
            if (optInGrid.Checked) {
                optInGrid.Checked = false;
            }

            procCalc();
        }

        private void txtX1_TextChanged(object sender, EventArgs e) {
            procCalc();
        }

        private void txtY1_TextChanged(object sender, EventArgs e) {
            procCalc();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            procCalc();
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            procCalc();
        }

        private bool isNumeric(string s) {
            float output;
            return float.TryParse(s, out output);
        }

        private void procCalc() {
            double x1, x2, y1, y2;
            if (txtX1.Text == "" || txtX2.Text == "" || txtY1.Text == "" | txtY2.Text == "") return;
            if (!isNumeric(txtX1.Text) || !isNumeric(txtX2.Text) || !isNumeric(txtY1.Text) || !isNumeric(txtY2.Text)) return;

            x1 = Double.Parse(txtX1.Text);
            y1 = Double.Parse(txtY1.Text);
            x2 = Double.Parse(txtX2.Text);
            y2 = Double.Parse(txtY2.Text);

            if (optInGrid.Checked) {
                x1 *= 32;
                x2 *= 32;
                y1 *= 32;
                y2 *= 32;
            }

            double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            if (optOutPixel.Checked) {
                txtCalc.Text = dist.ToString();
            }
            else if (optOutGrid.Checked) {
                txtCalc.Text = (dist / 32).ToString();
            }
        }

        private void optOutGrid_Click(object sender, EventArgs e) {
            if (optOutPixel.Checked) {
                optOutPixel.Checked = false;
            }

            procCalc();
        }

        private void optOutPixel_Click(object sender, EventArgs e) {
            if (optOutGrid.Checked) {
                optOutGrid.Checked = false;
            }

            procCalc();
        }
    }
}
