using Bayad_Center_Project.Contexts;
using Bayad_Center_Project.Entities;
using Bayad_Center_Project.Enums;
using Bayad_Center_Project.Services;
using System.Drawing.Imaging;

namespace Bayad_Center_Project
{
    public partial class FrmService : Form
    {
        FormRequest serviceFormRequest;
        public Service service;

        string imageFile = "";

        public FrmService(FormRequest serviceFormRequest, Service service)
        {
            InitializeComponent();
            this.service = service;
            this.serviceFormRequest = serviceFormRequest;
        }

        private byte[] ImageDirectoryToByte(string fileName)
        {
            byte[] iconData = null;
            if (!string.IsNullOrEmpty(fileName))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    Image.FromFile(fileName).Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    iconData = ms.ToArray();
                }
            }

            return iconData;
        }

        private byte[] ImageToByteArray(Image image)
        {
            if (image == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void FrmService_Load(object sender, EventArgs e)
        {
            var _ = new DatabaseContext();
            var serviceService = new ServiceService(_);

            if (serviceFormRequest.Equals(FormRequest.Edit) || serviceFormRequest.Equals(FormRequest.View))
            {
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
                    btnSetImage.Text = "Change";
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
                        {
                            control.Text = control.Text.Replace(" *", "");
                            control.Text = control.Text.Replace("220x220", "");
                        }
                    }

                    break;
                case FormRequest.Create:
                    btnAction.Text = "Create";
                    break;
            }
        }

        private void btnSetImage_Click(object sender, EventArgs e)
        {
            try
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
            catch { }
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
                var _ = new DatabaseContext();
                var serviceService = new ServiceService(_);

                switch (serviceFormRequest)
                {
                    case FormRequest.Edit:
                        Service serviceEdit = new Service()
                        {
                            Name = string.IsNullOrEmpty(tbName.Text) ? null : tbName.Text,
                            Description = string.IsNullOrEmpty(rtbDescription.Text) ? null : rtbDescription.Text,
                            Icon = ImageToByteArray(pbIcon.Image)
                        };

                        serviceService.UpdateService(service.ServiceID, serviceEdit);
                        break;
                    case FormRequest.Create:
                        Service serviceCreate = new Service()
                        {
                            Name = string.IsNullOrEmpty(tbName.Text) ? null : tbName.Text,
                            Description = string.IsNullOrEmpty(rtbDescription.Text) ? null : rtbDescription.Text,
                            Icon = ImageDirectoryToByte(imageFile)
                        };

                        serviceService.AddService(serviceCreate);
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