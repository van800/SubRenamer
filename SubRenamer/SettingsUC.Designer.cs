namespace SubRenamer
{
  partial class SettingsUC
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.textBoxWithSubExts = new System.Windows.Forms.TextBox();
      this.textBoxWithVideoExts = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.initDirTextBox = new System.Windows.Forms.TextBox();
      this.BrowseInitDirbtn = new System.Windows.Forms.Button();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.convertToUTF8CheckBox = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // textBoxWithSubExts
      // 
      this.textBoxWithSubExts.Location = new System.Drawing.Point(99, 34);
      this.textBoxWithSubExts.Margin = new System.Windows.Forms.Padding(5);
      this.textBoxWithSubExts.Name = "textBoxWithSubExts";
      this.textBoxWithSubExts.Size = new System.Drawing.Size(345, 20);
      this.textBoxWithSubExts.TabIndex = 17;
      this.textBoxWithSubExts.TextChanged += new System.EventHandler(this.textBoxWithSubExts_TextChanged);
      // 
      // textBoxWithVideoExts
      // 
      this.textBoxWithVideoExts.Location = new System.Drawing.Point(99, 6);
      this.textBoxWithVideoExts.Name = "textBoxWithVideoExts";
      this.textBoxWithVideoExts.Size = new System.Drawing.Size(345, 20);
      this.textBoxWithVideoExts.TabIndex = 18;
      this.textBoxWithVideoExts.TextChanged += new System.EventHandler(this.textBoxWithVideoExts_TextChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(4, 37);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(87, 13);
      this.label5.TabIndex = 15;
      this.label5.Text = "Subs extensions:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(1, 9);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(90, 13);
      this.label4.TabIndex = 16;
      this.label4.Text = "Video extensions:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 65);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(79, 13);
      this.label1.TabIndex = 15;
      this.label1.Text = "Initial Directory:";
      // 
      // initDirTextBox
      // 
      this.initDirTextBox.Location = new System.Drawing.Point(99, 62);
      this.initDirTextBox.Margin = new System.Windows.Forms.Padding(5);
      this.initDirTextBox.Name = "initDirTextBox";
      this.initDirTextBox.Size = new System.Drawing.Size(262, 20);
      this.initDirTextBox.TabIndex = 17;
      this.initDirTextBox.TextChanged += new System.EventHandler(this.initDirTextBox_TextChanged);
      // 
      // BrowseInitDirbtn
      // 
      this.BrowseInitDirbtn.Location = new System.Drawing.Point(369, 60);
      this.BrowseInitDirbtn.Name = "BrowseInitDirbtn";
      this.BrowseInitDirbtn.Size = new System.Drawing.Size(75, 23);
      this.BrowseInitDirbtn.TabIndex = 19;
      this.BrowseInitDirbtn.Text = "Browse...";
      this.BrowseInitDirbtn.UseVisualStyleBackColor = true;
      this.BrowseInitDirbtn.Click += new System.EventHandler(this.BrowseInitDirbtn_Click);
      // 
      // convertToUTF8CheckBox
      // 
      this.convertToUTF8CheckBox.AutoSize = true;
      this.convertToUTF8CheckBox.Checked = true;
      this.convertToUTF8CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.convertToUTF8CheckBox.Location = new System.Drawing.Point(99, 90);
      this.convertToUTF8CheckBox.Name = "convertToUTF8CheckBox";
      this.convertToUTF8CheckBox.Size = new System.Drawing.Size(105, 17);
      this.convertToUTF8CheckBox.TabIndex = 20;
      this.convertToUTF8CheckBox.Text = "Convert to UTF8";
      this.convertToUTF8CheckBox.UseVisualStyleBackColor = true;
      // 
      // SettingsUC
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.WhiteSmoke;
      this.Controls.Add(this.convertToUTF8CheckBox);
      this.Controls.Add(this.BrowseInitDirbtn);
      this.Controls.Add(this.initDirTextBox);
      this.Controls.Add(this.textBoxWithSubExts);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxWithVideoExts);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Margin = new System.Windows.Forms.Padding(0);
      this.Name = "SettingsUC";
      this.Size = new System.Drawing.Size(451, 104);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxWithSubExts;
    private System.Windows.Forms.TextBox textBoxWithVideoExts;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox initDirTextBox;
    private System.Windows.Forms.Button BrowseInitDirbtn;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.CheckBox convertToUTF8CheckBox;
  }
}