using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "video files|*.mp4;*.mov;*.wmv;*.mpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                axWindowsMediaPlayer1.URL = openFileDialog.FileName;
        }
    }
}
