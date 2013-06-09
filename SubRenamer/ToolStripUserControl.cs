using System.Windows.Forms;
using System.Drawing;

namespace SubRenamer
{
    class ToolStripUserControl : ToolStripControlHost
    {
        public UserControl UserControl
        {
            get { return (UserControl)base.Control; }
        }

      private bool convertToUtf8 = true;
      public bool ConvertToUtf8 { get { return convertToUtf8; } }

      public ToolStripUserControl(ParentForm rr) : base(new SettingsUC(rr)) { this.LostFocus += ToolStripUserControl_LostFocus; }
      public ToolStripUserControl(ParentForm rr, Color backColor) : base(new SettingsUC(rr, backColor)) { this.LostFocus += ToolStripUserControl_LostFocus; }

      void ToolStripUserControl_LostFocus(object sender, System.EventArgs e)
      {
        convertToUtf8 = ((SettingsUC)sender).ConvertToUtf8;
      }
    }
}
