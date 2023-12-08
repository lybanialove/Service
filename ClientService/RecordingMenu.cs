using ClientService.ServiceContext;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class RecordingMenu : Form
    {
        ServiceContractClient client;
        TimeSpan ts;
        public RecordingMenu(ServiceContractClient _client)
        {
            InitializeComponent();
            client = _client;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datetime = dateTimePicker1.Value.Date + ts;

            RecordingRequest request = new RecordingRequest { master = comboBox1.SelectedValue.ToString() };
            try
            {
                client.Recording(request);
                MessageBox.Show("Вы записались");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ts = new TimeSpan(10, 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ts = new TimeSpan(12, 0, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ts = new TimeSpan(14, 0, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ts = new TimeSpan(16, 0, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ts = new TimeSpan(18, 0, 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ts = new TimeSpan(20, 0, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ts = new TimeSpan(22, 0, 0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ts = new TimeSpan(00, 0, 0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ts = new TimeSpan(02, 0, 0);
        }
    }
}
