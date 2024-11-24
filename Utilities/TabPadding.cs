using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayad_Center_Project.Utilities
{
    internal class TabPadding : NativeWindow
    {
        private const int WM_PAINT = 0xF;
        private TabControl tabControl;

        public TabPadding(TabControl tc)
        {
            tabControl = tc;
            tabControl.Selected += new TabControlEventHandler(tabControl_Selected);
            AssignHandle(tc.Handle);
        }

        void tabControl_Selected(object sender, TabControlEventArgs e) => tabControl.Invalidate();

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_PAINT)
            {
                Graphics g = Graphics.FromHwnd(m.HWnd);

                if (tabControl.Parent != null)
                {
                    g.SetClip(new Rectangle(0, 0, tabControl.Width - 2, tabControl.Height - 1), CombineMode.Exclude);
                    SolidBrush sb = new SolidBrush(tabControl.Parent.BackColor);
                    g.FillRectangle(sb, new Rectangle(0, tabControl.ItemSize.Height + 2, tabControl.Width, tabControl.Height - (tabControl.ItemSize.Height + 2)));

                    sb.Dispose();
                }

                if (tabControl.SelectedTab != null)
                {
                    g.ResetClip();
                    Rectangle r = tabControl.SelectedTab.Bounds;
                    g.SetClip(r, CombineMode.Exclude);
                    SolidBrush sb = new SolidBrush(tabControl.SelectedTab.BackColor);
                    g.FillRectangle(sb, new Rectangle(r.Left - 5, r.Top - 5, r.Width + 10, r.Height + 10));

                    sb.Dispose();
                }

                g.Dispose();
            }
        }

    }
}
