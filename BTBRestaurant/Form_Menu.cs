using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTBRestaurant
{
    public partial class Form_Menu : Form
    {
        int[] tallyOrders = { 0, 0, 0, 0, 0, 0, 0, 0 };
        Double totalOrder = 0;
        String receipt = "";
        Double discountPrice = 0.0;
        public bool Discount { get; set; }

        public Form_Menu()
        {
            InitializeComponent();
        }

        private void Form_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tallyOrders.Count(); i++)
            {
                tallyOrders[i] = 0;
                _Labels[i].Text = tallyOrders[i].ToString();
            }
            totalOrder = 0.00;
            textBox_Total.Text = String.Format("{0:0.00}", totalOrder);

            receipt = "";
        }

        Label[] _Labels = new Label[8];
        Label[] _OrderNames = new Label[8];
        private void Form_Menu_Load(object sender, EventArgs e)
        {
            _Labels[0] = this.label_tallyCombo0;
            _Labels[1] = this.label_tallyCombo1;
            _Labels[2] = this.label_tallyAddon0;
            _Labels[3] = this.label_tallyAddon1;
            _Labels[4] = this.label_tallyAddon2;
            _Labels[5] = this.label_tallyDrinks0;
            _Labels[6] = this.label_tallyDrinks1;
            _Labels[7] = this.label_tallyDrinks2;

            _OrderNames[0] = this.label_Combo0;
            _OrderNames[1] = this.label_Combo1;
            _OrderNames[2] = this.label_Addon0;
            _OrderNames[3] = this.label_Addon1;
            _OrderNames[4] = this.label_Addon2;
            _OrderNames[5] = this.label_Drinks0;
            _OrderNames[6] = this.label_Drinks1;
            _OrderNames[7] = this.label_Drinks2;

            if(Discount == true)
            {
                label_discount.Text = "eligible for 10% Discount";
                discountPrice = 0.1;
            }
        }

        private void add_math(int i, Double item, EventArgs e)
        {
            tallyOrders[i]++;
            _Labels[i].Text = tallyOrders[i].ToString();
            totalOrder += item;

            textBox_Total.Text = String.Format("{0:0.00}", totalOrder);
        }

        private void minus_math(int i, Double item, EventArgs e)
        {
            if (tallyOrders[i] > 0)
            {
                tallyOrders[i]--;
                _Labels[i].Text = tallyOrders[i].ToString();
                totalOrder -= item;
            }
            textBox_Total.Text = String.Format("{0:0.00}", totalOrder);
        }

        private void button_addCombo0_Click(object sender, EventArgs e)
        {
            int i = 0;
            Double item = 150.00;

            add_math(i, item, null);
        }

        private void button_minusCombo0_Click(object sender, EventArgs e)
        {
            int i = 0;
            Double item = 150.00;

            minus_math(i, item, null);
        }

        private void button_addCombo1_Click(object sender, EventArgs e)
        {
            int i = 1;
            Double item = 500.00;

            add_math(i, item, null);
        }

        private void button_minusCombo1_Click(object sender, EventArgs e)
        {
            int i = 1;
            Double item = 500.00;

            minus_math(i, item, null);
        }

        private void button_addAddon0_Click(object sender, EventArgs e)
        {
            int i = 2;
            Double item = 20.00;

            add_math(i, item, null);
        }

        private void button_minusAddons0_Click(object sender, EventArgs e)
        {
            int i = 2;
            Double item = 20.00;

            minus_math(i, item, null);
        }

        private void button_addAddon1_Click(object sender, EventArgs e)
        {
            int i = 3;
            Double item = 60.00;

            add_math(i, item, null);
        }

        private void button_minusAddons1_Click(object sender, EventArgs e)
        {
            int i = 3;
            Double item = 60.00;

            minus_math(i, item, null);
        }

        private void button_addAddon2_Click(object sender, EventArgs e)
        {
            int i = 4;
            Double item = 100.00;

            add_math(i, item, null);
        }

        private void button_minusAddons2_Click(object sender, EventArgs e)
        {
            int i = 4;
            Double item = 100.00;

            minus_math(i, item, null);
        }

        private void button_addDrinks0_Click(object sender, EventArgs e)
        {
            int i = 5;
            Double item = 30.00;

            add_math(i, item, null);
        }

        private void button_minusDrinks0_Click(object sender, EventArgs e)
        {
            int i = 5;
            Double item = 30.00;

            minus_math(i, item, null);
        }

        private void button_addDrinks1_Click(object sender, EventArgs e)
        {
            int i = 6;
            Double item = 30.00;

            add_math(i, item, null);
        }

        private void button_minusDrinks1_Click(object sender, EventArgs e)
        {
            int i = 6;
            Double item = 30.00;

            minus_math(i, item, null);
        }

        private void button_addDrinks2_Click(object sender, EventArgs e)
        {
            int i = 7;
            Double item = 30.00;

            add_math(i, item, null);
        }

        private void button_minusDrinks2_Click(object sender, EventArgs e)
        {
            int i = 7;
            Double item = 30.00;

            minus_math(i, item, null);
        }

        private void button_Order_Click(object sender, EventArgs e)
        {
            Double finalDiscount = totalOrder * discountPrice;
            totalOrder -= finalDiscount;

            receipt = "RECEIPT: ";
            for (int i = 0; i < tallyOrders.Count(); i++)
            {
                if(tallyOrders[i] != 0)
                {
                    receipt += "\n" + tallyOrders[i] + "*" + _OrderNames[i].Text;
                }
            }
            receipt += "\n TOTAL ORDER: " + totalOrder +
                       "\n======= END =======";

            MessageBox.Show(receipt);
        }
    }
}
