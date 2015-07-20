using System;
using System.Windows.Forms;

namespace GuidGenerator
{
    public partial class MainForm : Form
    {
        private Guid guid;

        public MainForm()
        {
            InitializeComponent();

            GenerateNewGuid();
        }

        #region Event Handlers

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            CopyToClipboard();
        }

        private void buttonNewGuid_Click(object sender, EventArgs e)
        {
            GenerateNewGuid();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButtonGuidFormat_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                UpdateResult();
            }
        }

        #endregion

        private void CopyToClipboard()
        {
            Clipboard.SetText(labelResult.Text);
        }

        private void GenerateNewGuid()
        {
            guid = Guid.NewGuid();
            UpdateResult();
        }

        private void UpdateResult()
        {
            string result;

            if (radioButtonOleCreateFormat.Checked)
            {
                result = GuidFormats.OleCreateFormat(guid);
            }
            else if (radioButtonDefineFormat.Checked)
            {
                result = GuidFormats.DefineFormat(guid);
            }
            else if (radioButtonConstFormat.Checked)
            {
                result = GuidFormats.ConstFormat(guid);
            }
            else if (radioButtonRegistryFormat.Checked)
            {
                result = GuidFormats.RegistryFormat(guid);
            }
            else if (radioButtonAttributeFormat.Checked)
            {
                result = GuidFormats.AttributeFormat(guid);
            }
            else if (radioButtonTagFormat.Checked)
            {
                result = GuidFormats.TagFormat(guid);
            }
            else if (radioButtonShortFormat.Checked)
            {
                result = GuidFormats.ShortFormat(guid);
            }
            else
            {
                throw new InvalidOperationException("Unsupported GUID format selected.");
            }

            labelResult.Text = result;
        }
    }
}