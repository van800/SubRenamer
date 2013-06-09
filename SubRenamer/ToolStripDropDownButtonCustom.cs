using System.Windows.Forms;

namespace SubRenamer
{
    class ToolStripDropDownButtonCustom : ToolStripDropDownButton
    {
        public ToolStripDropDownButtonCustom() : base() 
        {
            ((ToolStripDropDownMenu)this.DropDown).ShowImageMargin = false;
        }
    }
}
