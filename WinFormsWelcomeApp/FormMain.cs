namespace WinFormsWelcomeApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            //this.Text = "Main Form";
            //btnHello.Text = "Сказать привет";
            //btnHello.BackColor = Color.Red;
            //btnHello.ForeColor = Color.White;
            btnHello.Location = new Point((this.Size.Width - btnHello.Size.Width)/2, 250);

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length > 0)
            {
                HelloForm helloForm = new HelloForm(txtName.Text);
                helloForm.ShowDialog();
            }
                //MessageBox.Show($"Привет {txtName.Text}");
        }
    }
}
