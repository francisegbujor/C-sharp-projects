using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            WindowsMediaPlayerMusic.ClientSize = new Size(WindowsMediaPlayerMusic.ClientSize.Width, 450);
            WindowsMediaPlayerMusic.ClientSize = new Size(WindowsMediaPlayerMusic.ClientSize.Height, 250);
            base.OnLoad(e);
        }

        //create Global Variables of String Type Array to save the titles or name of the Tracks and path of the track
        String[] paths, files;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //code to close the app
            this.Close();
        }

        private void ListBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Write a code to play music
            WindowsMediaPlayerMusic.URL = paths[ListBoxSongs.SelectedIndex];
        }

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            //Code to Select Songs
            OpenFileDialog ofd = new OpenFileDialog();

            //code to select multiple files
            ofd.Multiselect = true;

            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                files = ofd.SafeFileNames; //save the names of the track in files array
                paths = ofd.FileNames; //save the paths of the tracks in path array
                //Display the music titles in listbox
                for(int i = 0; i < files.Length; i++) 
                {
                    ListBoxSongs.Items.Add(files[i]); //Display Songs in listbox
                }
            }
        }
    }
}
