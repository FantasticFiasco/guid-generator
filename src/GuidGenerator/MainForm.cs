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
                result = GuidFormats.OleCreate(guid);
            }
            else if (radioButtonDefineFormat.Checked)
            {
                result = GuidFormats.Define(guid);
            }
            else if (radioButtonConstFormat.Checked)
            {
                result = GuidFormats.Const(guid);
            }
            else if (radioButtonRegistryFormat.Checked)
            {
                result = GuidFormats.Registry(guid);
            }
            else if (radioButtonAttributeFormat.Checked)
            {
                result = GuidFormats.Attribute(guid);
            }
            else if (radioButtonTagFormat.Checked)
            {
                result = GuidFormats.Tag(guid);
            }
            else if (radioButtonShortFormat.Checked)
            {
                result = GuidFormats.Short(guid);
            }
            else
            {
                throw new InvalidOperationException("Unsupported GUID format selected.");
            }

            labelResult.Text = result;
        }
    }
}