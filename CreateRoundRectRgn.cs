using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bayad_Center_Project
{
    public class CreateRoundRectRgn
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr Apply(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
    }
}
