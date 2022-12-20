using System.Security.Cryptography;
using System.Windows.Forms;

namespace PW_Lab10_nowy
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        List<string> list = new List<string>();
        public int ID = 0;
        public int index;
        public bool paused = false;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(list.Count > 0)
            {
                if(paused == false)
                {
                    if(checkBox1.Checked)
                    {
                        var lowerBound = 0;
                        var upperBound = list.Count;                  
                        player.URL = list[RandomNumberGenerator.GetInt32(lowerBound, upperBound)];
                    }
                    else
                    {
                        player.URL = list[(int)dataGridView1.CurrentRow.Cells[1].Value];
                    }
                    player.controls.play();
                }
                else
                {
                    player.controls.play();
                    paused = false;
                }
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.controls.pause();
            paused = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.controls.stop();    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 Files|*.mp3";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add(openFileDialog.SafeFileName, ID);
                list.Add(openFileDialog.FileName);
                ID++;
            }
            
        }
    }
}