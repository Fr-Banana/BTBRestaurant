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

        private void label_Heading_Click(object sender, EventArgs e)
        {

        }
    }
}
