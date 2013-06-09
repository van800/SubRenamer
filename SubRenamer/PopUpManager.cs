using System;
using System.Windows.Forms;
using System.Drawing;

namespace SubRenamer
{
    //[ToolboxItem(false)]
    public class PopUpManager<TControl> where TControl : Control
    {
        private PopUpManager()
        { }

        #region Properties

        private ToolStripDropDown _toolStripDropDown;
        public ToolStripDropDown ToolStripDropDown
        {
            get { return _toolStripDropDown; }
        }

        private TControl _childControl;
        public TControl ChildControl
        {
            get { return _childControl; }
        }

        private Control _parentControl;
        public Control ParentControl
        {
            get { return _childControl; }
        }

        #endregion

        #region GetInstance

        public static PopUpManager<TControl> GetInstance<T>(Control parParentControl, bool parAutoSize,
            bool parAutoClose) where T : TControl
        {
            PopUpManager<TControl> retVal = new PopUpManager<TControl>();

            retVal._toolStripDropDown = new ToolStripDropDown();
            retVal._toolStripDropDown.AutoClose = parAutoClose;

            T control =
                Activator.CreateInstance<T>();

            if (parAutoSize)
            {
                int width =
                    parParentControl.Size.Width < control.MinimumSize.Width ? control.MinimumSize.Width : parParentControl.Size.Width;
                control.Size = new Size(width, control.Size.Height);
            }

            ToolStripControlHost host = new ToolStripControlHost(control);

            host.Padding = retVal._toolStripDropDown.Padding = Padding.Empty;
            host.Margin = retVal._toolStripDropDown.Margin = Padding.Empty;
            host.AutoSize = false;
            host.Size = control.Size;

            retVal._toolStripDropDown.Items.Add(host);

            Point p = new Point(parParentControl.PointToScreen(new Point(0, 0)).X,
                parParentControl.PointToScreen(new Point(0, parParentControl.Height + control.Height)).Y);

            if (Screen.PrimaryScreen.WorkingArea.Contains(p))
                retVal._toolStripDropDown.Show(parParentControl, new Point(0, parParentControl.Height), ToolStripDropDownDirection.Right);
            else
                retVal._toolStripDropDown.Show(parParentControl, new Point(0, -control.Size.Height - 1), ToolStripDropDownDirection.Right);

            retVal._childControl = control;
            retVal._parentControl = parParentControl;
            return retVal;
        }

        public static PopUpManager<TControl> GetInstance(Control parParentControl, bool parAutoSize,
            bool parAutoClose)
        {
            return GetInstance<TControl>(parParentControl, parAutoSize, parAutoClose);
        }

        #endregion

    }
}
