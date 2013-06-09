using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SubRenamer
{
    public partial class SettingsUC : UserControl
    {
        //private String textBoxWithSubExts;
        //private String textBoxWithVideoExtsStr;

        private ParentForm m_frmParent;
        private Color backColor;
        public Color BackColorPr
        {
            get
            {
                return backColor;
            }
        }

        public SettingsUC()
        {
            InitializeComponent();
        }
        public SettingsUC(ParentForm myForm)
        {
            InitializeComponent();
            backColor = BackColor;

            m_frmParent = myForm;
            textBoxWithVideoExts.Text = m_frmParent.VideoExtensions.ToString();
            textBoxWithSubExts.Text = m_frmParent.SubExtensions.ToString();
            initDirTextBox.Text = m_frmParent.StartFolderString;


        }
        
        public SettingsUC(ParentForm myForm, Color backColor)
        {
            InitializeComponent();
            BackColor = backColor;

            m_frmParent = myForm;
            textBoxWithVideoExts.Text = m_frmParent.VideoExtensions.ToString();
            textBoxWithSubExts.Text = m_frmParent.SubExtensions.ToString();
            initDirTextBox.Text = m_frmParent.StartFolderString;

            
        }

        private void textBoxWithVideoExts_TextChanged(object sender, EventArgs e)
        {
            m_frmParent.VideoExtensions = ExtensionList.Parse(textBoxWithVideoExts.Text);
        }

        private void textBoxWithSubExts_TextChanged(object sender, EventArgs e)
        {
             m_frmParent.SubExtensions= ExtensionList.Parse(textBoxWithSubExts.Text);

        }

        private void initDirTextBox_TextChanged(object sender, EventArgs e)
        {
            m_frmParent.StartFolderString = initDirTextBox.Text;
        }

        private void BrowseInitDirbtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = @"c:\";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                initDirTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
            
        }



        //private void UserControl1_Load(object sender, EventArgs e)
        //{
        //    textBoxWithVideoExts.Text = VideoExtensions.ToString();
        //    textBoxWithSubExts.Text = SubsExtensions.ToString();
        //}

        //private void UserControl1_VisibleChanged(object sender, EventArgs e)
        //{

        //}

        //private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        //{

        //}
        
    }
}
