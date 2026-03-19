namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string typed_msg = textBox1.Text;
            if (string.IsNullOrWhiteSpace(typed_msg))
                return;
            listBox1.Items.Add($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} {typed_msg}");
            label2.Text = $"메시지: {listBox1.Items.Count}개";
            textBox1.Clear();
            textBox1.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string.IsNullOrWhiteSpace(null);    // true
            string.IsNullOrWhiteSpace(" ");     // true
            string.IsNullOrWhiteSpace("   ");      // true
            string.IsNullOrWhiteSpace("abc");      // false

            {
                string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string msg = "Hello";
                string result = time + " " + msg;
            }
            {
                string msg = "Hello";
                string result = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} {msg}";
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {
            string msg = "   Hello   ";
            string result = msg.Trim();
        }
    }
}       