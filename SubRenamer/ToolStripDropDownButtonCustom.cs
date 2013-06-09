using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SubRenamer
{
    class ToolStripDropDownButtonCustom : ToolStripDropDownButton
    {
        public ToolStripDropDownButtonCustom() : base() 
        {
            ((ToolStripDropDownMenu)((ToolStripDropDownItem)(this)).DropDown).ShowImageMargin = false;
        }
    }
}
