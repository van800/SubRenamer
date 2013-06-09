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

            this._tsUserControl = new ToolStripUserControl(this);            //add usercontrol to drop down menu
            this.Settings2DropDownButton1.DropDownItems.Insert(0, this._tsUserControl);
            

            //this.HelpDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            //this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            //this.howToUseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            //this.HelpDropDownButton3.DropDown = new ContextMenuStrip();
            //((ContextMenuStrip)HelpDropDownButton3.DropDown).ShowImageMargin = false;
            //this.Settings2DropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            //this._tsUserControl = new ToolStripUserControl(this);            //add usercontrol to drop down menu
            ////(ContextMenuStrip)_tsUserControl.

            //this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            //this.Settings2DropDownButton1,
            //this.HelpDropDownButton3});
            
            //// 
            //// aboutToolStripMenuItem1
            //// 
            //this.aboutToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            //this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            //this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            //this.aboutToolStripMenuItem1.Text = "About";
            //this.aboutToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            //this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            //// 
            //// howToUseToolStripMenuItem1
            //// 
            //this.howToUseToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            //this.howToUseToolStripMenuItem1.Name = "howToUseToolStripMenuItem1";
            //this.howToUseToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            //this.howToUseToolStripMenuItem1.Text = "How to use";
            //this.howToUseToolStripMenuItem1.Click += new System.EventHandler(this.howToUseToolStripMenuItem1_Click);
            //// 
            //// HelpDropDownButton3
            //// 
            //this.HelpDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            //this.HelpDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            //this.aboutToolStripMenuItem1,
            //this.howToUseToolStripMenuItem1});
            //this.HelpDropDownButton3.Name = "HelpDropDownButton2";
            //this.HelpDropDownButton3.Size = new System.Drawing.Size(41, 22);
            //this.HelpDropDownButton3.Text = "Help";


            //// 
            //// Settings2DropDownButton1
            //// 
            //this.Settings2DropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            //this.Settings2DropDownButton1.DropDownItems.Insert(0, this._tsUserControl);            
            //this.Settings2DropDownButton1.Name = "Settings2DropDownButton1";
            //this.Settings2DropDownButton1.Size = new System.Drawing.Size(59, 22);
            //this.Settings2DropDownButton1.Text = "Settings";
            //this.Settings2DropDownButton1.DropDownOpened += new System.EventHandler(this.Settings2DropDownButton1_DropDownOpened);
            
 

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
            separator[0]= System.Convert.ToString(Environment.NewLine);
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
                        System.IO.File.Move(fileName, newFileName);
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
            if (!System.IO.File.Exists(fileName))
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
                textBoxSubs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        }

        private void textBoxSubs_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(System.Windows.Forms.DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
                textBoxSubs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBoxSubs_DragDrop(object sender, DragEventArgs e)
        {
            Debug.WriteLine("test" + this.ToString());
            
            
            if (e.Data.GetDataPresent(System.Windows.Forms.DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
                textBoxSubs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                
                //e.Data..GetDataPresent();
                string[] filePaths = (string[])e.Data.GetData(System.Windows.Forms.DataFormats.FileDrop);
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

        private void textBoxSubs_MouseHover(object sender, EventArgs e)
        {
            if (textBoxSubs.Text == "")
            {
                toolTip1.SetToolTip(textBoxSubs, "Drag and drop your files here from Windows Explorer");
                toolTip1.Active = true;
                toolTip1.GetToolTip(this.textBoxSubs);
            }
        }

        private void textBoxSubs_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Active = false;
        }

        private void browseFilesButton1_Click(object sender, EventArgs e)
        {
            openFileDialog3.InitialDirectory = StartFolderString;
            openFileDialog3.Title = "Select Videos and Subs";
            openFileDialog3.Filter = "Video and Subs|" + VideoExtensions.ToStringCustom()+";" + SubExtensions.ToStringCustom() + "|All files (*.*)|*.*";//*.BMP;*.JPG;*.GIF
            openFileDialog3.FilterIndex = 0;
            //openFileDialog3.RestoreDirectory = true;
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

        //private void ExitButton1_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

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

    //    private void SettingsButton1_Click(object sender, EventArgs e)
    //    {
    //        //ChildForm mySettingsForm = new ChildForm(this);
    //        //mySettingsForm.Show();
    ////        PopUpManager<UserControl1> puM =
    ////PopUpManager<UserControl1>.GetInstance((Control)SettingsButton1, false, true);

    //        this.SettingsButton1.DropDown = new ContextMenuStrip();
    //        ((ContextMenuStrip)SettingsButton1.DropDown).ShowImageMargin = false;

    //    }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 frm = new AboutBox1();
            frm.Show();
        }

        //private void toolStripVideoTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    VideoExtensions = ExtensionList.Parse(toolStripVideoTextBox.Text);
        //}

        //private void toolStripSubsTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    SubExtensions = ExtensionList.Parse(toolStripSubsTextBox.Text);
        //}

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

        //private void SettingsDropDownButton3_Click_1(object sender, EventArgs e)
        //{
        //    this.SettingsDropDownButton3.DropDown = new ContextMenuStrip();
        //    ((ContextMenuStrip)SettingsDropDownButton3.DropDown).ShowImageMargin = false;
        //    // 
        //    // SettingsButton1
        //    // 
        //    this.SettingsDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        //    this.toolStripVideoTextBox,
        //    this.toolStripSubsTextBox});
        //}

        //private void toolStripButton1_Click(object sender, EventArgs e)
        //{
        //    ChildForm mySettingsForm = new ChildForm(this);
        //    mySettingsForm.Show();
        //    //UserControl1 userControl1 = new UserControl1();
        //    ////userControl1.Location = this.Location;
        //    //userControl1.Show();
        //}



    }
}

