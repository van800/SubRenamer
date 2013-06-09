using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SubRenamer
{
    class ToolStripUserControl : ToolStripControlHost//ToolStripControlHost 
    {

        //private System.Windows.Forms.TextBox textBoxWithSubExts;
        //private System.Windows.Forms.TextBox textBoxWithVideoExts;
        //private System.Windows.Forms.Label label5;
        //private System.Windows.Forms.Label label4;

        public UserControl UserControl
        {
            get { return (UserControl)base.Control; }
        }

        //public ToolStripUserControl() : base(new UserControl1()) { }
        public ToolStripUserControl(ParentForm rr) : base(new UserControl1(rr)) { }
        public ToolStripUserControl(ParentForm rr, Color backColor) : base(new UserControl1(rr, backColor)) { }
    }
}
