namespace PW_Lab10
{
    public partial class Form1 : Form
    {
        private mp3 mp3player = new mp3();
        List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 Files|*.mp3";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                list.Add(openFileDialog.FileName);
                //dataGridView1.Rows.Add
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mp3player.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mp3player.stop();
        }
    }
}