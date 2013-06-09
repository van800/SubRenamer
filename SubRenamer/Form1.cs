using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SubRenamer
{
    public partial class ParentForm : Form
    {

        private ToolStripUserControl _tsUserControl;
        public string StartFolderString = @"c:\";
        
        private ExtensionList vidExt;
        private ExtensionList subExt;

        string[] myStringArray = new string[] 
        {
            "Please add files",
            "If necessary resort the filenames and press Rename",
            "",
            "Nothing renamed"
        };


        public ExtensionList VideoExtensions
        {
            get
            {
                return vidExt;
            }
            set
            {
                vidExt = value;
            }
        }

        public ExtensionList SubExtensions
        {
            get
            {
                return subExt;
            }
            set
            {
                subExt = value;
            }
        }

        
        public ParentForm()
        {
            //InitializeComponent();
        }

        public ParentForm(ExtensionList videoExtensions, ExtensionList subExtensions, string[] args)
        {
            VideoExtensions = videoExtensions;
            SubExtensions = subExtensions;
            
            InitializeComponent();
            ((ToolStripDropDownMenu)((ToolStripDropDownItem)(Settings2DropDownButton1)).DropDown).ShowImageMargin = false;
            ((ToolStripDropDownMenu)((ToolStripDropDownItem)(HelpDropDownButton3)).DropDown).ShowImageMargin = false;

            _tsUserControl = new ToolStripUserControl(this);            //add usercontrol to drop down menu
            Settings2DropDownButton1.DropDownItems.Insert(0, _tsUserControl);

            string allFiles="";
            foreach (string arg in args)
                allFiles = allFiles+ arg + Environment.NewLine;
            textBoxSubs.Text = allFiles;
            toolStripStatusLabel1.Text = myStringArray[0];
        }

        private string SortFiles(string[] fileNames, ExtensionList myExtensions)
        {
            string totalFileString = "";
            foreach (string fileName in fileNames)
            {
                foreach (string myExtension in myExtensions)
                    if (Path.GetExtension(fileName) == myExtension)
                    {
                        totalFileString = totalFileString + fileName + Environment.NewLine;
                    }
            }
            if (totalFileString != "")
                updateStatusBarText(totalFileString);
            return totalFileString;
        }

        private string SortFiles(List<string> fileNames, ExtensionList myExtensions)
        {
            string totalFileString = "";
            foreach (string fileName in fileNames)
            {
                foreach (string myExtension in myExtensions)
                    if (Path.GetExtension(fileName) == myExtension)
                    {
                        totalFileString = totalFileString + fileName + Environment.NewLine;
                    }
            }
            if (totalFileString !="")
                updateStatusBarText(totalFileString);
            return totalFileString;
        }


        private void btnRename_Click(object sender, EventArgs e)
        {
            string[] separator = new string[1];
            separator[0]= Convert.ToString(Environment.NewLine);
            string[] sourceText = textBoxSubs.Text.Split(separator, StringSplitOptions.None);
            string[] newNames = textBoxVideos.Text.Split(separator, StringSplitOptions.None);
            int i = 0;
            string resultString = "";
            foreach (string fileName in sourceText)
            {
                try
                {
                    if (SourceFileExists(fileName,i))
                    {
                        string newFileName = Path.GetDirectoryName(newNames[i]).ToString() + "\\" + Path.GetFileNameWithoutExtension(newNames[i]).ToString() + Path.GetExtension(fileName).ToString();
                        File.Move(fileName, newFileName);
                        resultString = resultString + newFileName + Environment.NewLine;
                    }
                }
                catch (Exception)
                {
                    if (!SourceFileExists(fileName,i)) return;
                    resultString = resultString + fileName + Environment.NewLine;
                }
                i = i + 1;
            }
            if (i > 1)
                toolStripStatusLabel1.Text = toolStripStatusLabel1.Text + " ;" + " " + myStringArray[2];
            else
                toolStripStatusLabel1.Text = myStringArray[3];
            textBoxSubs.Text = resultString;
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private bool SourceFileExists(string fileName, int i)
        {
            if (!File.Exists(fileName))
            {
                toolStripStatusLabel1.Text = "File" +" " +(i+1) + " " + "doesn't exist";
//                MessageBox.Show("The source file does not exist!");
                return false;
            }
            else
                return true;
        }

 
        private void textBoxSubs_DragLeave(object sender, EventArgs e)
        {
                textBoxSubs.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        }

        private void textBoxSubs_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
                textBoxSubs.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBoxSubs_DragDrop(object sender, DragEventArgs e)
        {
            Debug.WriteLine("test" + ToString());
            
            
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
                textBoxSubs.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                
                //e.Data..GetDataPresent();
                string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
                List<string> fileNames = new List<string>();

                foreach (string filePath in filePaths)
                {
                    if (!Subsidary.PathIsDirectory(filePath))
                        fileNames.Add(filePath);
                    else
                    {
                        string[] files = Directory.GetFiles(filePath);
                        foreach (string file in files)
                            fileNames.Add(file);
                    }
                }
                textBoxSubs.Text = SortFiles(fileNames, subExt);
                textBoxVideos.Text = SortFiles(fileNames, vidExt);
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
            
        }

        private void browseFilesButton1_Click(object sender, EventArgs e)
        {
            openFileDialog3.InitialDirectory = StartFolderString;
            openFileDialog3.Title = "Select Videos and Subs";
            openFileDialog3.Filter = "Video and Subs|" + VideoExtensions.ToStringCustom()+";" + SubExtensions.ToStringCustom() + "|All files (*.*)|*.*";//*.BMP;*.JPG;*.GIF
            openFileDialog3.FilterIndex = 0;
            openFileDialog3.Multiselect = true;
 

            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                string[] fileNames = openFileDialog3.FileNames;
                textBoxVideos.Text = SortFiles(fileNames, vidExt);//подумать videoExtensions
                textBoxSubs.Text = SortFiles(fileNames, subExt);//подумать
            }
        }

        private void browseFoldersButton1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = StartFolderString;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string myFolder = folderBrowserDialog1.SelectedPath;
                string[] fileNames = Directory.GetFiles(myFolder);
                textBoxVideos.Text = SortFiles(fileNames, vidExt); //подумать
                textBoxSubs.Text = SortFiles(fileNames, subExt);//подумать
            }
        }

        private void howToUseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Process SysInfo = new Process();
                //SysInfo.StartInfo.ErrorDialog = true;
                SysInfo.StartInfo.FileName = ".\\help\\AboutPage.htm";
                SysInfo.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Help was not found" + Environment.NewLine + "Try searching in Help folder manually");
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 frm = new AboutBox1();
            frm.Show();
        }

        private void updateStatusBarText(string totalFileString)
        {
            if (totalFileString != "")
                toolStripStatusLabel1.Text = myStringArray[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopUpManager<UserControl1> puM =
                PopUpManager<UserControl1>.GetInstance(button1, false, true);
        }

        private void Settings2DropDownButton1_DropDownOpened(object sender, EventArgs e)
        {
//            ((ToolStripDropDownMenu)((ToolStripDropDownItem)(sender)).DropDown).ShowImageMargin = false;
        }
    }
}

