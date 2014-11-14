using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;

namespace QrCodeBuilder.WinForm
{
    public partial class MainForm : Form
    {
        private Brush lightBrush;
        private Brush darkBrush;

        public MainForm()
        {
            InitializeComponent();
            ErrorCorrectLevelComboBox.SelectedItem = "M";
            QuietZoneComboBox.SelectedItem = "默认";
            lightBrush = new SolidBrush(Color.White);
            darkBrush = new SolidBrush(Color.Black);
            qrCodeGraphicControl.LightBrush = lightBrush;
            qrCodeGraphicControl.DarkBrush = darkBrush;
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            var text = InputTextBox.Text;
            qrCodeGraphicControl.Text = text;
        }

        private void SelectDarkColorButton_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            var brush = qrCodeGraphicControl.DarkBrush as SolidBrush;
            if (brush != null)
            {
                colorDialog.Color = brush.Color;
            }
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                darkBrush = new SolidBrush(colorDialog.Color);
                qrCodeGraphicControl.DarkBrush = darkBrush;
            }
        }

        private void SelectLightColorButton_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            var brush = qrCodeGraphicControl.LightBrush as SolidBrush;
            if (brush != null)
            {
                colorDialog.Color = brush.Color;
            }
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lightBrush = new SolidBrush(colorDialog.Color);
                qrCodeGraphicControl.LightBrush = lightBrush;
            }
        }

        private void ErrorCorrectLevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ErrorCorrectLevelComboBox.SelectedItem.ToString())
            {
                case "L":
                    qrCodeGraphicControl.ErrorCorrectLevel = ErrorCorrectionLevel.L;
                    break;
                case "M":
                    qrCodeGraphicControl.ErrorCorrectLevel = ErrorCorrectionLevel.M;
                    break;
                case "Q":
                    qrCodeGraphicControl.ErrorCorrectLevel = ErrorCorrectionLevel.Q;
                    break;
                case "H":
                    qrCodeGraphicControl.ErrorCorrectLevel = ErrorCorrectionLevel.H;
                    break;
            }
        }

        private void BackgroundTransparentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BackgroundTransparentCheckBox.Checked)
            {
                lightBrush = new SolidBrush(Color.Transparent);
            }
            else
            {
                lightBrush = new SolidBrush(Color.White);
            }
            qrCodeGraphicControl.LightBrush = lightBrush;
        }

        private void QuietZoneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (QuietZoneComboBox.SelectedItem.ToString())
            {
                case "无":
                    qrCodeGraphicControl.QuietZoneModule = QuietZoneModules.Zero;
                    break;
                case "默认":
                    qrCodeGraphicControl.QuietZoneModule = QuietZoneModules.Two;
                    break;
                case "多":
                    qrCodeGraphicControl.QuietZoneModule = QuietZoneModules.Four;
                    break;
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            try
            {
                var sizeNumber = int.Parse(SizeTextBox.Text);
                var fixedCodeSize = new FixedCodeSize(sizeNumber, qrCodeGraphicControl.QuietZoneModule);
                var saveFileDialog = new SaveFileDialog();
                var lightColor = (lightBrush as SolidBrush).Color;
                var darkColor = (darkBrush as SolidBrush).Color;
                saveFileDialog.Filter = @"PNG (*.png)|*.png|Encapsuled PostScript (*.eps)|*.eps|SVG (*.svg)|*.svg";
                saveFileDialog.FileName = Path.GetFileName(DateTime.Now.ToString("yyyyMMddHHmmss"));
                saveFileDialog.DefaultExt = "png";

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                var matrix = qrCodeGraphicControl.GetQrMatrix();

                if (saveFileDialog.FileName.EndsWith("eps"))
                {
                    var renderer = new EncapsulatedPostScriptRenderer(fixedCodeSize, new FormColor(darkColor), new FormColor(lightColor));

                    using (var file = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                    {
                        renderer.WriteToStream(matrix, file);
                    }
                }
                else if (saveFileDialog.FileName.EndsWith("svg"))
                {
                    var renderer = new SVGRenderer(fixedCodeSize, new FormColor(darkColor), new FormColor(lightColor));

                    using (var file = File.OpenWrite(saveFileDialog.FileName))
                    {
                        renderer.WriteToStream(matrix, file, false);
                    }
                }
                else
                {
                    var renderer = new GraphicsRenderer(fixedCodeSize, darkBrush, lightBrush);
                    using (var stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        renderer.WriteToStream(matrix, ImageFormat.Png, stream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
