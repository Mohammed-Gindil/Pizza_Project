using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.HtmlRenderer.Adapters.RGraphicsPath;

namespace PizzaProject2
{
    public partial class FormOrderPizza : Form
    {
        public FormOrderPizza()
        {
            InitializeComponent();
        }

        float GetSizePrise()
        {
            if (rbSmallSize.Checked)
            {
                return Convert.ToSingle(rbSmallSize.Tag);
            }
            else if (rbMeduim.Checked)
            {
                return Convert.ToSingle(rbMeduim.Tag);
            }
            else {
                return Convert.ToSingle(rbLarg.Tag);
            }
         }

        float GetSelectedCrutPrice()
        {
            if (rbThinCrust.Checked)
                return Convert.ToSingle(rbThinCrust.Tag);
            else
                return Convert.ToSingle(rbThinkCrust.Tag);

        }

        float CalcoluteToppingPrise()
        {
            float totalpriseTopping = 0;

            if (chkExtraChees.Checked)
            {
                totalpriseTopping += Convert.ToSingle(chkExtraChees.Tag);
            }

            if (chkOnion.Checked)
            {
                totalpriseTopping += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkMushroums.Checked)
            {
                totalpriseTopping += Convert.ToSingle(chkMushroums.Tag);
            }

            if (chkOlves.Checked)
            {
                totalpriseTopping += Convert.ToSingle(chkOlves.Tag);
            }

            if (chkTomatoes.Checked)
            {
                totalpriseTopping += Convert.ToSingle(chkTomatoes.Tag);
            }

            if (chkGreenPeppers.Checked)
            {
                totalpriseTopping += Convert.ToSingle(chkGreenPeppers.Tag);
            }

            return totalpriseTopping;
        }


        void UpdatePrise()
        {
            float totalprs = (GetSizePrise()+GetSelectedCrutPrice()+CalcoluteToppingPrise())*Convert.ToInt16(guna2NumericUpDown1.Value);
            lbTotalPrice.Text = "$"+totalprs.ToString();
            lblOrdrerPrise2.Text = "$"+totalprs.ToString();
        }

        void UpdateSize()
        {
            UpdatePrise();

            if (rbSmallSize.Checked)
            {
                lblSize.Text = "Small";
                return;
            }

            if (rbMeduim.Checked)
            {
                lblSize.Text = "Meduim";
                return;
            }

            if (rbLarg.Checked)
            {
                lblSize.Text = "Larg";
                return;
            }
        }

        void UpdateCrust()
        {
            UpdatePrise();

            if (rbThinCrust.Checked)
            {
                lblCrustType.Text = "Thin Crust";
            }
            else
            {
                lblCrustType.Text = "Think Crust";
            }
        }

        void UpdateWhereYouEat()
        {
            UpdatePrise();

            if (rbEatin.Checked)
            {
                lblWhereEat.Text = "Eat in.";
                return;
            }
            if (rbTakeOut.Checked)
            {
                lblWhereEat.Text = "Take Out.";
                return;
            }

        }

        void UpdateTopping()
        {
            UpdatePrise();

            string sToppingtype = "";

            if (chkExtraChees.Checked)
            {
                sToppingtype = "Extra Chees";
            }


            if (chkOnion.Checked)
            {
                sToppingtype += ", Onion";
            }

            if (chkMushroums.Checked)
            {
                sToppingtype += ", Mushrooms";
            }

            if (chkOlves.Checked)
            {
                sToppingtype += ", Olives";
            }

            if (chkTomatoes.Checked)
            {
                sToppingtype += ", Tomatos";
            }

            if (chkGreenPeppers.Checked)
            {
                sToppingtype += ", Green Peppars";
            }

            if (sToppingtype.StartsWith(","))
            {
                sToppingtype = sToppingtype.Substring(1, sToppingtype.Length - 1).Trim();
            }

            if (sToppingtype=="")
            {
                lblTopping.Text = "No topping";
                return;
            }

            lblTopping.Text = sToppingtype;
        }

        private void rbSmallSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbEatin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereYouEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereYouEat();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

        private void chkMushroums_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

        private void chkOlves_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order","Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
            }
            else
            {
                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void RestForm()
        {
            //checkBox

            groupBox1.Enabled=true;
            groupBox2.Enabled=true;
            groupBox3.Enabled=true;
            groupBox4.Enabled=true;
            

            rbMeduim.Checked=true;

            rbThinCrust.Checked=true;

            rbEatin.Checked=true;

            chkExtraChees.Checked=false;
            chkGreenPeppers.Checked=false;
            chkTomatoes.Checked=false;
            chkOnion.Checked=false;
            chkOlves.Checked=false; 
            chkMushroums.Checked=false;

            btnOrderPizza.Enabled=true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestForm();
        }

        void UpdateOrderSummary()
        {
            UpdateCrust();
            UpdateSize();
            UpdateTopping();
            UpdateWhereYouEat();
        }

        private void FormOrderPizza_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrise();
        }
    }
}
