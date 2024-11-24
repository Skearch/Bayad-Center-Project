using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayad_Center_Project.Utilities
{
    public class DraggableForm
    {
        private bool isMouseDown = false;
        private Point lastMousePos;

        private Control control;
        private Form form;

        public DraggableForm(Control Control, Form Form)
        {
            control = Control;
            form = Form;

            Control.MouseDown += new MouseEventHandler(Form_MouseDown);
            Control.MouseMove += new MouseEventHandler(Form_MouseMove);
            Control.MouseUp += new MouseEventHandler(Form_MouseUp);
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                lastMousePos = e.Location;
            }
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                int dx = e.X - lastMousePos.X;
                int dy = e.Y - lastMousePos.Y;
                form.Location = new Point(form.Location.X + dx, form.Location.Y + dy);
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
    }
}
