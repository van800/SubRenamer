using System.Windows.Forms;
namespace SubRenamer
{
    partial class ParentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
      this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.browseFilesButton1 = new System.Windows.Forms.ToolStripButton();
      this.browseFoldersButton1 = new System.Windows.Forms.ToolStripButton();
      this.Settings2DropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
      this.HelpDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
      this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.howToUseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.tableLayoutPanelVideos = new System.Windows.Forms.TableLayoutPanel();
      this.textBoxVideos = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.tableLayoutPanelSubs = new System.Windows.Forms.TableLayoutPanel();
      this.label3 = new System.Windows.Forms.Label();
      this.textBoxSubs = new System.Windows.Forms.TextBox();
      this.btnRename = new System.Windows.Forms.Button();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.howToUseToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.convertToUTF8CheckBox = new System.Windows.Forms.CheckBox();
      this.toolStrip1.SuspendLayout();
      this.toolStripContainer1.ContentPanel.SuspendLayout();
      this.toolStripContainer1.SuspendLayout();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.tableLayoutPanelVideos.SuspendLayout();
      this.tableLayoutPanelSubs.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // openFileDialog3
      // 
      this.openFileDialog3.AddExtension = false;
      this.openFileDialog3.CheckFileExists = false;
      this.openFileDialog3.CheckPathExists = false;
      this.openFileDialog3.Multiselect = true;
      this.openFileDialog3.SupportMultiDottedExtensions = true;
      this.openFileDialog3.Title = "Select the filenames";
      this.openFileDialog3.ValidateNames = false;
      // 
      // folderBrowserDialog1
      // 
      this.folderBrowserDialog1.ShowNewFolderButton = false;
      // 
      // toolStrip1
      // 
      this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseFilesButton1,
            this.browseFoldersButton1,
            this.Settings2DropDownButton1,
            this.HelpDropDownButton3});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(788, 25);
      this.toolStrip1.TabIndex = 8;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // browseFilesButton1
      // 
      this.browseFilesButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.browseFilesButton1.Image = ((System.Drawing.Image)(resources.GetObject("browseFilesButton1.Image")));
      this.browseFilesButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.browseFilesButton1.Name = "browseFilesButton1";
      this.browseFilesButton1.Size = new System.Drawing.Size(73, 22);
      this.browseFilesButton1.Text = "Browse files";
      this.browseFilesButton1.Click += new System.EventHandler(this.browseFilesButton1_Click);
      // 
      // browseFoldersButton1
      // 
      this.browseFoldersButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.browseFoldersButton1.Image = ((System.Drawing.Image)(resources.GetObject("browseFoldersButton1.Image")));
      this.browseFoldersButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.browseFoldersButton1.Name = "browseFoldersButton1";
      this.browseFoldersButton1.Size = new System.Drawing.Size(88, 22);
      this.browseFoldersButton1.Text = "Browse folders";
      this.browseFoldersButton1.Click += new System.EventHandler(this.browseFoldersButton1_Click);
      // 
      // Settings2DropDownButton1
      // 
      this.Settings2DropDownButton1.BackColor = System.Drawing.SystemColors.Control;
      this.Settings2DropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.Settings2DropDownButton1.Name = "Settings2DropDownButton1";
      this.Settings2DropDownButton1.Size = new System.Drawing.Size(62, 22);
      this.Settings2DropDownButton1.Text = "Settings";
      this.Settings2DropDownButton1.DropDownOpened += new System.EventHandler(this.Settings2DropDownButton1_DropDownOpened);
      // 
      // HelpDropDownButton3
      // 
      this.HelpDropDownButton3.BackColor = System.Drawing.SystemColors.Control;
      this.HelpDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.HelpDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.howToUseToolStripMenuItem1});
      this.HelpDropDownButton3.Name = "HelpDropDownButton3";
      this.HelpDropDownButton3.Size = new System.Drawing.Size(45, 22);
      this.HelpDropDownButton3.Text = "Help";
      // 
      // aboutToolStripMenuItem1
      // 
      this.aboutToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
      this.aboutToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
      this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
      this.aboutToolStripMenuItem1.Text = "About";
      this.aboutToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
      this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
      // 
      // howToUseToolStripMenuItem1
      // 
      this.howToUseToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.howToUseToolStripMenuItem1.Name = "howToUseToolStripMenuItem1";
      this.howToUseToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
      this.howToUseToolStripMenuItem1.Text = "How to use";
      this.howToUseToolStripMenuItem1.Click += new System.EventHandler(this.howToUseToolStripMenuItem1_Click);
      // 
      // toolStripContainer1
      // 
      // 
      // toolStripContainer1.ContentPanel
      // 
      this.toolStripContainer1.ContentPanel.Controls.Add(this.convertToUTF8CheckBox);
      this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
      this.toolStripContainer1.ContentPanel.Controls.Add(this.splitter1);
      this.toolStripContainer1.ContentPanel.Controls.Add(this.statusStrip1);
      this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStrip1);
      this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(788, 355);
      this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
      this.toolStripContainer1.Name = "toolStripContainer1";
      this.toolStripContainer1.Size = new System.Drawing.Size(788, 380);
      this.toolStripContainer1.TabIndex = 7;
      this.toolStripContainer1.Text = "toolStripContainer2";
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(3, 25);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanelVideos);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanelSubs);
      this.splitContainer1.Size = new System.Drawing.Size(785, 308);
      this.splitContainer1.SplitterDistance = 260;
      this.splitContainer1.TabIndex = 13;
      // 
      // tableLayoutPanelVideos
      // 
      this.tableLayoutPanelVideos.ColumnCount = 1;
      this.tableLayoutPanelVideos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanelVideos.Controls.Add(this.textBoxVideos, 0, 1);
      this.tableLayoutPanelVideos.Controls.Add(this.button1, 0, 2);
      this.tableLayoutPanelVideos.Controls.Add(this.label2, 0, 0);
      this.tableLayoutPanelVideos.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanelVideos.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanelVideos.Name = "tableLayoutPanelVideos";
      this.tableLayoutPanelVideos.RowCount = 4;
      this.tableLayoutPanelVideos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanelVideos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanelVideos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanelVideos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanelVideos.Size = new System.Drawing.Size(260, 308);
      this.tableLayoutPanelVideos.TabIndex = 0;
      // 
      // textBoxVideos
      // 
      this.textBoxVideos.AllowDrop = true;
      this.textBoxVideos.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBoxVideos.Location = new System.Drawing.Point(3, 23);
      this.textBoxVideos.Multiline = true;
      this.textBoxVideos.Name = "textBoxVideos";
      this.textBoxVideos.ReadOnly = true;
      this.textBoxVideos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBoxVideos.Size = new System.Drawing.Size(254, 232);
      this.textBoxVideos.TabIndex = 3;
      this.textBoxVideos.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxSubs_DragDrop);
      this.textBoxVideos.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxSubs_DragEnter);
      this.textBoxVideos.DragLeave += new System.EventHandler(this.textBoxSubs_DragLeave);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(3, 261);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(42, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "test";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Visible = false;
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 3);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(42, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Videos:";
      // 
      // tableLayoutPanelSubs
      // 
      this.tableLayoutPanelSubs.ColumnCount = 1;
      this.tableLayoutPanelSubs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanelSubs.Controls.Add(this.label3, 0, 0);
      this.tableLayoutPanelSubs.Controls.Add(this.textBoxSubs, 0, 1);
      this.tableLayoutPanelSubs.Controls.Add(this.btnRename, 0, 2);
      this.tableLayoutPanelSubs.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanelSubs.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanelSubs.Name = "tableLayoutPanelSubs";
      this.tableLayoutPanelSubs.RowCount = 4;
      this.tableLayoutPanelSubs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanelSubs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanelSubs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanelSubs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanelSubs.Size = new System.Drawing.Size(521, 308);
      this.tableLayoutPanelSubs.TabIndex = 11;
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 3);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(34, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "Subs:";
      // 
      // textBoxSubs
      // 
      this.textBoxSubs.AllowDrop = true;
      this.textBoxSubs.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBoxSubs.Location = new System.Drawing.Point(3, 23);
      this.textBoxSubs.Multiline = true;
      this.textBoxSubs.Name = "textBoxSubs";
      this.textBoxSubs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBoxSubs.Size = new System.Drawing.Size(515, 232);
      this.textBoxSubs.TabIndex = 1;
      this.textBoxSubs.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxSubs_DragDrop);
      this.textBoxSubs.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxSubs_DragEnter);
      this.textBoxSubs.DragLeave += new System.EventHandler(this.textBoxSubs_DragLeave);
      // 
      // btnRename
      // 
      this.btnRename.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.btnRename.Location = new System.Drawing.Point(391, 261);
      this.btnRename.Name = "btnRename";
      this.btnRename.Size = new System.Drawing.Size(127, 23);
      this.btnRename.TabIndex = 0;
      this.btnRename.Text = "Rename";
      this.btnRename.UseVisualStyleBackColor = true;
      this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
      // 
      // splitter1
      // 
      this.splitter1.Location = new System.Drawing.Point(0, 25);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(3, 308);
      this.splitter1.TabIndex = 12;
      this.splitter1.TabStop = false;
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
      this.statusStrip1.Location = new System.Drawing.Point(0, 333);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(788, 22);
      this.statusStrip1.TabIndex = 11;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
      // 
      // howToUseToolStripMenuItem
      // 
      this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
      this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
      // 
      // howToUseToolStripMenuItem2
      // 
      this.howToUseToolStripMenuItem2.Name = "howToUseToolStripMenuItem2";
      this.howToUseToolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
      // 
      // sToolStripMenuItem
      // 
      this.sToolStripMenuItem.Name = "sToolStripMenuItem";
      this.sToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
      // 
      // convertToUTF8CheckBox
      // 
      this.convertToUTF8CheckBox.AutoSize = true;
      this.convertToUTF8CheckBox.Checked = true;
      this.convertToUTF8CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.convertToUTF8CheckBox.Location = new System.Drawing.Point(307, 4);
      this.convertToUTF8CheckBox.Name = "convertToUTF8CheckBox";
      this.convertToUTF8CheckBox.Size = new System.Drawing.Size(105, 17);
      this.convertToUTF8CheckBox.TabIndex = 14;
      this.convertToUTF8CheckBox.Text = "Convert to UTF8";
      this.convertToUTF8CheckBox.UseVisualStyleBackColor = true;
      // 
      // ParentForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(788, 380);
      this.Controls.Add(this.toolStripContainer1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "ParentForm";
      this.Text = "SubRenamer";
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.toolStripContainer1.ContentPanel.ResumeLayout(false);
      this.toolStripContainer1.ContentPanel.PerformLayout();
      this.toolStripContainer1.ResumeLayout(false);
      this.toolStripContainer1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.ResumeLayout(false);
      this.tableLayoutPanelVideos.ResumeLayout(false);
      this.tableLayoutPanelVideos.PerformLayout();
      this.tableLayoutPanelSubs.ResumeLayout(false);
      this.tableLayoutPanelSubs.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private ToolStrip toolStrip1;
        private ToolStripButton browseFilesButton1;
        private ToolStripButton browseFoldersButton1;
        private ToolStripContainer toolStripContainer1;
        private ToolStripDropDownButton Settings2DropDownButton1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem sToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanelVideos;
        private TableLayoutPanel tableLayoutPanelSubs;
        private TextBox textBoxSubs;
        private Button btnRename;
        private Label label2;
        private Button button1;
        private Label label3;
        private Splitter splitter1;
        private TextBox textBoxVideos;
        private ToolStripDropDownButton HelpDropDownButton3;
        private ToolStripMenuItem howToUseToolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem howToUseToolStripMenuItem;
        private ToolStripMenuItem howToUseToolStripMenuItem2;
        private CheckBox convertToUTF8CheckBox;
    }
}