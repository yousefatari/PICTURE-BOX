namespace ASSIGNMENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
                {
               pictureBox1.ImageLocation = ofd.FileName;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "https://www.amny.com/wp-content/uploads/2022/11/AP22326415727673-1200x800.jpg";
        }
    }
}