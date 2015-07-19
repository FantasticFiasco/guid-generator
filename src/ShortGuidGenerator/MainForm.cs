using System;
using System.Text;
using System.Windows.Forms;

namespace ShortGuidGenerator
{
    public partial class MainForm : Form
    {
        private Guid guid;

        public MainForm()
        {
            InitializeComponent();

            GenerateNewShortGuid();
        }

        #region Event Handlers

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            CopyToClipboard();
        }

        private void buttonNewGuid_Click(object sender, EventArgs e)
        {
            GenerateNewShortGuid();
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

        private void GenerateNewShortGuid()
        {
            guid = Guid.NewGuid();
            UpdateResult();
        }

        private void UpdateResult()
        {
            string result;

            if (radioButtonOleCreateFormat.Checked)
            {
                result = EncodeOleCreate();
            }
            else if (radioButtonDefineFormat.Checked)
            {
                result = EncodeDefine();
            }
            else if (radioButtonConstFormat.Checked)
            {
                result = EncodeConst();
            }
            else if (radioButtonRegistryFormat.Checked)
            {
                result = RegistryEncode();
            }
            else if (radioButtonAttributeFormat.Checked)
            {
                result = AttributeEncode();
            }
            else if (radioButtonTagFormat.Checked)
            {
                result = TagEncode();
            }
            else if (radioButtonShortFormat.Checked)
            {
                result = ShortEncode();
            }
            else
            {
                throw new InvalidOperationException("Unsupported GUID format selected.");
            }

            labelResult.Text = result;
        }

        #region Encode

        private string EncodeOleCreate()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("// {{{0}}}{1}", guid.ToString().ToUpper(), Environment.NewLine);
            stringBuilder.AppendFormat("IMPLEMENT_OLECREATE(<<class>>, <<external_name>>, {0}", Environment.NewLine);
            stringBuilder.AppendFormat("{0});", string.Join(", ", SplitHex()));
            
            return stringBuilder.ToString();
        }

        private string EncodeDefine()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("// {{{0}}}{1}", guid.ToString().ToUpper(), Environment.NewLine);
            stringBuilder.AppendFormat("DEFINE_GUID(<<name>>, {0}", Environment.NewLine);
            stringBuilder.AppendFormat("{0});", string.Join(", ", SplitHex()));

            return stringBuilder.ToString();
        }

        private string EncodeConst()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("// {{{0}}}{1}", guid.ToString().ToUpper(), Environment.NewLine);
            stringBuilder.AppendFormat("static const GUID <<name>> = {0}", Environment.NewLine);

            string[] split = SplitHex();
            stringBuilder.AppendFormat(
                "{{ {0}, {1}, {2}, {{ {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10} }} }};",
                split[0],
                split[1],
                split[2],
                split[3],
                split[4],
                split[5],
                split[6],
                split[7],
                split[8],
                split[9],
                split[10]);

            return stringBuilder.ToString();
        }

        private string[] SplitHex()
        {
            string[] parts = guid.ToString().Split('-');
            return new[]
            {
                string.Format("0x{0}", parts[0]),
                string.Format("0x{0}", parts[1]),
                string.Format("0x{0}", parts[2]),
                string.Format("0x{0}", parts[3].Substring(0, 2)),
                string.Format("0x{0}", parts[3].Substring(2, 2)),
                string.Format("0x{0}", parts[4].Substring(0, 2)),
                string.Format("0x{0}", parts[4].Substring(2, 2)),
                string.Format("0x{0}", parts[4].Substring(4, 2)),
                string.Format("0x{0}", parts[4].Substring(6, 2)),
                string.Format("0x{0}", parts[4].Substring(8, 2)),
                string.Format("0x{0}", parts[4].Substring(10, 2))
            };
        }

        private string RegistryEncode()
        {
            return string.Format("{{{0}}}", guid.ToString().ToUpper());
        }

        private string AttributeEncode()
        {
            return string.Format("[Guid(\"{0}\")]", guid.ToString().ToUpper());
        }

        private string TagEncode()
        {
            return string.Format("<Guid(\"{0}\")>", guid.ToString().ToUpper());
        }

        private string ShortEncode()
        {
            // This code is copied from Mads Kristensen's blog at
            // http://madskristensen.net/post/a-shorter-and-url-friendly-guid
            string encodedGuid = Convert
                .ToBase64String(guid.ToByteArray())
                .Replace("/", "_")
                .Replace("+", "-");

            return encodedGuid.Substring(0, 22);
        }

        #endregion
    }
}