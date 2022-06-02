namespace BTBRestaurant
{
    public partial class GettingStarted : Form
    {
        public GettingStarted()
        {
            InitializeComponent();
        }

        private void GettingStarted_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button_GetStarted_Click(object sender, EventArgs e)
        {
            Form_Vaccination form_Vaccination = new Form_Vaccination();
            this.Hide();
            form_Vaccination.ShowDialog();
            this.Close();
        }
    }
}