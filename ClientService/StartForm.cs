using ClientService.ServiceContext;
using System;
using System.Windows.Forms;


namespace View
{

    public partial class StartForm : Form
    {

        ServiceContractClient client = new ServiceContractClient();
        public StartForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration(client);
            registration.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Autorization autorization = new Autorization(client);
            autorization.Show();
        }
    }
}
