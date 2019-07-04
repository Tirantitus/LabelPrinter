using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Label_Printer
{
    public partial class FrmLabelPrinter : Form
    {
        public FrmLabelPrinter()
        {
            InitializeComponent();
        }

        private void BttnGetItemNumber_Click(object sender, EventArgs e)
        {
            if (txtbxItemNumber.Text.Length < 1)
            {
                FrmLabelPrinter.ActiveForm.Size = new Size(655, 110);
                MessageBox.Show("Enter item number please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtbxSerialNumber.Text.Length >= 1 && txtbxItemNumber.Text.Length >= 1)
            {
                FrmLabelPrinter.ActiveForm.Size = new Size(685, 560);
                lblQRCode.Visible = true;
                pctrbxSerialNumber.Visible = true;
                pctrbxQRCode.Visible = true;
                bttnPrint.Visible = true;
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pctrbxSerialNumber.Image = barcode.Draw(txtbxSerialNumber.Text, 53);
                Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pctrbxItemNumber.Image = barcode.Draw(txtbxItemNumber.Text, 53);
                pctrbxQRCode.Image = qrcode.Draw(txtbxItemNumber.Text + "\n" + txtbxSerialNumber.Text, 5);
            }
            else
            {
                FrmLabelPrinter.ActiveForm.Size = new Size(670, 230);
                txtbxSerialNumber.Visible = true;
                lblSerialNumber.Visible = true;
                pctrbxItemNumber.Visible = true;
                bttnGetSerialNumber.Visible = true;
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pctrbxItemNumber.Image = barcode.Draw(txtbxItemNumber.Text, 53);
            }

        }

        private void BttnGetSerialNumber_Click(object sender, EventArgs e)
        {
            if (txtbxSerialNumber.Text.Length < 1)
            {
                FrmLabelPrinter.ActiveForm.Size = new Size(670, 230);
                MessageBox.Show("Enter serial number please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtbxSerialNumber.Text.Length >= 1)
            {
                FrmLabelPrinter.ActiveForm.Size = new Size(685, 560);
                lblQRCode.Visible = true;
                pctrbxSerialNumber.Visible = true;
                pctrbxQRCode.Visible = true;
                bttnPrint.Visible = true;
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pctrbxSerialNumber.Image = barcode.Draw(txtbxSerialNumber.Text, 53);
                Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                pctrbxQRCode.Image = qrcode.Draw(txtbxItemNumber.Text + "\n" + txtbxSerialNumber.Text, 5);
            }
        }

        private void BttnPrint_Click(object sender, EventArgs e)
        {
            if (txtbxSerialNumber.Text.Length < 1)
            {
                MessageBox.Show("Enter item number please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtbxSerialNumber.Text.Length < 1)
            {
                MessageBox.Show("Enter serial number please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                PrintDialog pd = new PrintDialog();
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += Doc_PrintPage;
                pd.Document = doc;
                if (pd.ShowDialog() == DialogResult.OK)
                {
                    doc.Print();
                }
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pctrbxItemNumber.Width * 40, pctrbxItemNumber.Height * 150);
            pctrbxItemNumber.DrawToBitmap(bm, new Rectangle(0, 0, pctrbxItemNumber.Width, pctrbxItemNumber.Height));
            e.Graphics.DrawImage(bm, 10, 10);

            bm = new Bitmap(pctrbxSerialNumber.Width, pctrbxSerialNumber.Height);
            pctrbxSerialNumber.DrawToBitmap(bm, new Rectangle(0, 0, pctrbxSerialNumber.Width, pctrbxSerialNumber.Height));
            e.Graphics.DrawImage(bm, 10, 100);

            bm = new Bitmap(pctrbxQRCode.Width, pctrbxQRCode.Height);
            pctrbxQRCode.DrawToBitmap(bm, new Rectangle(0, 0, pctrbxQRCode.Width, pctrbxQRCode.Height));
            e.Graphics.DrawImage(bm, 600, 10);
            bm.Dispose();
        }
    }
}
