using Bayad_Center_Project.DbContexts;
using Bayad_Center_Project.Entities;
using Bayad_Center_Project.Enums;
using Bayad_Center_Project.Services;
using Microsoft.Data.Sqlite;

namespace Bayad_Center_Project
{
    public partial class FrmService : Form
    {
        FormRequest serviceFormRequest;
        public int userID = -1;

        string imageFile = "";

        public FrmService(FormRequest ServiceFormRequest, int ServiceID)
        {
            InitializeComponent();
            userID = ServiceID;
            serviceFormRequest = ServiceFormRequest;
        }

        private void FrmService_Load(object sender, EventArgs e)
        {
            ServiceContext _ = new ServiceContext();
            var serviceService = new ServiceService(_);

            if (serviceFormRequest.Equals(FormRequest.Edit) || serviceFormRequest.Equals(FormRequest.View))
            {
                Service service = serviceService.GetServiceById(userID);
                tbName.Text = service.Name;
                rtbDescription.Text = service.Description;

                if (service.Icon != null && service.Icon.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(service.Icon))
                        pbIcon.Image = Image.FromStream(ms);
                }

                pbIcon.SizeMode = PictureBoxSizeMode.Zoom;
            }

            switch (serviceFormRequest)
            {
                case FormRequest.Edit:
                    btnAction.Text = "Save";
                    break;
                case FormRequest.View:
                    btnAction.Text = "Close";
                    btnSetImage.Visible = false;
                    btnClearImage.Visible = false;
                    lblRequiredFields.Visible = false;

                    foreach (Control control in Controls)
                    {
                        if (control is TextBox textBox)
                            textBox.ReadOnly = true;

                        if (control is RichTextBox richTextBox)
                            richTextBox.ReadOnly = true;

                        if (control is Label)
                            control.Text = control.Text.Replace(" *", "");
                    }

                    break;
                case FormRequest.Create:
                    btnAction.Text = "Create";
                    break;
            }
        }

        private void btnSetImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Image File";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    imageFile = openFileDialog.FileName;

                pbIcon.Image = Image.FromFile(imageFile);
                pbIcon.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            if (pbIcon.Image != null)
            {
                pbIcon.Image.Dispose();
                pbIcon.Image = null;
            }

            imageFile = "";
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceContext _ = new ServiceContext();
                var serviceService = new ServiceService(_);

                switch (serviceFormRequest)
                {
                    case FormRequest.Edit:

                        break;
                    case FormRequest.Create:
                        byte[] iconData = null;
                        if (!string.IsNullOrEmpty(imageFile))
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                Image.FromFile(imageFile).Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                iconData = ms.ToArray();
                            }
                        }

                        Service serviceCreate = new Service()
                        {
                            Name = string.IsNullOrEmpty(tbName.Text) ? null : tbName.Text,
                            Description = string.IsNullOrEmpty(rtbDescription.Text) ? null : rtbDescription.Text,
                            Icon = iconData
                        };

                        serviceService.RegisterService(serviceCreate);
                        break;
                }

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}