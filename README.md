# **RESTAURANT CUSTOMER SERVICES IDENTIFIER SYSTEM**

### __INTRODUCTION__ 

- RCSIS is a system that collects data regarding with the customers’ vaccination card and will automatically generates decision if you will be allowed to dine in or take out in which the staff or workers won’t have to interact face to face to the costumers that would make them vulnerable to the virus.  

### __PURPOSE__

- This system will lessen the vulnerability and risk of the crew, staff, and customers in terms of getting the virus. 

### __SCOPE AND LIMITATION__
### Scope

- This system is a web application wherein it has a graphical user interface where the system will ask for the ID Vaccination Number of the customer. This system maybe simple however this is helpful to those customer service owners and workers who have to risk their safety just to earn some money. 

### Limitation

- When someone is newly vaccinated there might be chances that the vaccination card he/she holds will be denied and will registered as unvaccinated in the system.  

### __ROLES__
### Backend Programmer
- Nuñez, Kent
- Rucas, Ian Vincent

### Frontend Programmer
- Rucas, Ian Vincent
- Sinoy, Jay
- Tabunag Jay

### Cook
- Babatuan, James Bryan

### Courier
- Babatuan, James Bryan
- Ochea, Kier

### Layout Editor
- Ochea, Kier John

### Documentation
- Cabahug, Zinc
- Geraldez, Rica Mae

### Producer
- Cabahug, Zinc
- Tabunag Jay

### __DEFINITION OF TERMS__

### UML 
- The Unified Modelling Language (UML) is a general-purpose, developmental, modelling language in the field of software engineering that is intended to provide a standard way to visualize the design of a system.  

### GUI
- Graphical User Interface - a form of user interface that allows users to interact with electronic devices through graphical icons and audio indicator such as primary notation, instead of text-based user interfaces, typed command labels or text navigation. 

### __UML: Use Case Diagram__

[![N|Solid](https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEhlcmGqApJbP6dFE33_2BF9g0h_r1U6j_mJpGb8ePnjIg-TX1vCi6h10zV-hqxEVFywg78WKC7hSQ8IHJzDvsg82a5l_EkreBZiEQtphYF-tmoynyXynlrPFsBK6jYcQlX-3gFt8GrxizVMCSrWNivdGV81dW3ZWgYkIuHBakmRkY-t_n5-iLOnb53CDQ/w582-h494/umlusecasediagram.jpg)](https://nodesource.com/products/nsolid) 

### __SYSTEM FLOW__
- The system will ask a question in which you are vaccinated or not vaccinated. Then customer will enter/present his/her ID Vaccination number if he/she is vaccinated, then the system will process and read it. If he/she is not vaccinated, the system will directly suggest a take-out or dine out option. Then the system will release a result whether his/her card is valid. If the person is vaccinated, the system will give a suggestion to dine in or take out and show available promo and freebies you can avail as vaccinated person. After the system gives the result, the system then will show the Menu, then the customer picks his/her order/s, he/she has to wait more or less 15 minutes before his/her order will be served.  

### __PROGRAM CODE__
- Program.cs
```sh 
namespace BTBRestaurant
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new GettingStarted());
        }
    }
}
``` 
- GettingStarted.cs
```sh 
namespace BTBRestaurant
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new GettingStarted());
        }
    }
}
``` 
- Form_Vaccination.cs
```sh 
namespace BTBRestaurant
{
    public partial class Form_Vaccination : Form
    {

        private bool discount;

        public Form_Vaccination()
        {
            InitializeComponent();
        }

        public void button_Confirm_Click(object sender, EventArgs e)
        {
            

            for (int i = 0; i < 10; i++)
            {
                if (textBox_VaxxID.Text == _VaxxID[i])
                {
                    discount = true;
                    label_discount.Text = discount.ToString();
                    label_error.Text = "";

                    Form_Menu form1 = new Form_Menu();
                    form1.Discount = discount;
                    this.Hide();
                    form1.ShowDialog();
                    this.Close();
                }
                else
                {
                    label_error.Text = "Please enter a valid ID";
                }
            }
        }

        private void Form_Vaccination_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void button_Skip_Click(object sender, EventArgs e)
        {
            discount = false;
            label_discount.Text = discount.ToString();

            Form_Menu form_Menu = new Form_Menu();
            form_Menu.Discount = discount;
            this.Hide();
            form_Menu.ShowDialog();
            this.Close();
        }

        String[] _VaxxID = new String[10];
        private void Form_Vaccination_Load(object sender, EventArgs e)
        {
            // SAMPLE DATABASE
            _VaxxID[0] = "123456";
            _VaxxID[1] = "234567";
            _VaxxID[2] = "345678";
            _VaxxID[3] = "456789";
            _VaxxID[4] = "567890";
            _VaxxID[5] = "678901";
            _VaxxID[6] = "098765";
            _VaxxID[7] = "987654";
            _VaxxID[8] = "876543";
            _VaxxID[9] = "765432";
        }
    }
}
``` 
- Form_Menu.cs
```sh 
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

            receipt += "RECEIPT: ";
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
``` 
