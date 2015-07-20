using System;
using System.Text;

namespace GuidGenerator
{
    public static class GuidFormats
    {
        public static string OleCreate(Guid guid)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("// {{{0}}}{1}", guid.ToString().ToUpper(), Environment.NewLine);
            stringBuilder.AppendFormat("IMPLEMENT_OLECREATE(<<class>>, <<external_name>>, {0}", Environment.NewLine);
            stringBuilder.AppendFormat("{0});", string.Join(", ", SplitHex(guid)));

            return stringBuilder.ToString();
        }

        public static string Define(Guid guid)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("// {{{0}}}{1}", guid.ToString().ToUpper(), Environment.NewLine);
            stringBuilder.AppendFormat("DEFINE_GUID(<<name>>, {0}", Environment.NewLine);
            stringBuilder.AppendFormat("{0});", string.Join(", ", SplitHex(guid)));

            return stringBuilder.ToString();
        }

        public static string Const(Guid guid)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("// {{{0}}}{1}", guid.ToString().ToUpper(), Environment.NewLine);
            stringBuilder.AppendFormat("static const GUID <<name>> = {0}", Environment.NewLine);

            string[] split = SplitHex(guid);
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

        public static string Registry(Guid guid)
        {
            return string.Format("{{{0}}}", guid.ToString().ToUpper());
        }
        
        public static string Attribute(Guid guid)
        {
            return string.Format("[Guid(\"{0}\")]", guid.ToString().ToUpper());
        }

        public static string Tag(Guid guid)
        {
            return string.Format("<Guid(\"{0}\")>", guid.ToString().ToUpper());
        }
        
        public static string Short(Guid guid)
        {
            // This code is copied from Mads Kristensen's blog at
            // http://madskristensen.net/post/a-shorter-and-url-friendly-guid
            string encodedGuid = Convert
                .ToBase64String(guid.ToByteArray())
                .Replace("/", "_")
                .Replace("+", "-");

            return encodedGuid.Substring(0, 22);
        }

        private static string[] SplitHex(Guid guid)
        {
            string[] parts = guid.ToString().Split('-');
            string [] hexParts =
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

            for (int i = 0; i < hexParts.Length; i++)
            {
                hexParts[i] = hexParts[i].Replace("0x0", "0x");
            }

            return hexParts;
        }
    }
}