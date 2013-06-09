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
            ((ToolStripDropDownMenu)this.DropDown).ShowImageMargin = false;
        }
    }
}
