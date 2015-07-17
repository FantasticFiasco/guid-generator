using System;
using System.Windows.Forms;

namespace ShortGuidGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            GenerateNewShortGuid();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labelResult.Text);
        }

        private void buttonNewGuid_Click(object sender, EventArgs e)
        {
            GenerateNewShortGuid();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GenerateNewShortGuid()
        {
            var guid = Guid.NewGuid();
            string endodedGuid = Encode(guid);
            labelResult.Text = endodedGuid;
        }

        public static string Encode(Guid guid)
        {
            // This code is copied from Mads Kristensen's blog at
            // http://madskristensen.net/post/a-shorter-and-url-friendly-guid
            string encodedGuid = Convert
                .ToBase64String(guid.ToByteArray())
                .Replace("/", "_")
                .Replace("+", "-");

            return encodedGuid.Substring(0, 22);
        }
    }
}