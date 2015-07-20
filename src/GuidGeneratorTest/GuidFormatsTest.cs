using System;
using GuidGenerator;
using NUnit.Framework;

namespace GuidGeneratorTest
{
    [TestFixture]
    public class GuidFormatsTest
    {
        private readonly Guid guid = new Guid("9015CCB1-06A1-4198-A01A-B7404F2944B6");
        
        [Test]
        public void OleCreateFormat()
        {
            // ARRANGE
            string expected =
                "// {9015CCB1-06A1-4198-A01A-B7404F2944B6}" + Environment.NewLine +
                "IMPLEMENT_OLECREATE(<<class>>, <<external_name>>, " + Environment.NewLine +
                "0x9015ccb1, 0x6a1, 0x4198, 0xa0, 0x1a, 0xb7, 0x40, 0x4f, 0x29, 0x44, 0xb6);";

            // ACT
            string actual = GuidFormats.OleCreate(guid);

            // ASSERT
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void DefineFormat()
        {
            // ARRANGE
            string expected =
                "// {9015CCB1-06A1-4198-A01A-B7404F2944B6}" + Environment.NewLine +
                "DEFINE_GUID(<<name>>, " + Environment.NewLine +
                "0x9015ccb1, 0x6a1, 0x4198, 0xa0, 0x1a, 0xb7, 0x40, 0x4f, 0x29, 0x44, 0xb6);";

            // ACT
            string actual = GuidFormats.Define(guid);

            // ASSERT
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ConstFormat()
        {
            // ARRANGE
            string expected =
                "// {9015CCB1-06A1-4198-A01A-B7404F2944B6}" + Environment.NewLine +
                "static const GUID <<name>> = " + Environment.NewLine +
                "{ 0x9015ccb1, 0x6a1, 0x4198, { 0xa0, 0x1a, 0xb7, 0x40, 0x4f, 0x29, 0x44, 0xb6 } };";
            
            // ACT
            string actual = GuidFormats.Const(guid);

            // ASSERT
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void RegistryFormat()
        {
            // ARRANGE
            string expected = "{9015CCB1-06A1-4198-A01A-B7404F2944B6}";

            // ACT
            string actual = GuidFormats.Registry(guid);

            // ASSERT
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AttributeFormat()
        {
            // ARRANGE
            string expected = "[Guid(\"9015CCB1-06A1-4198-A01A-B7404F2944B6\")]";

            // ACT
            string actual = GuidFormats.Attribute(guid);

            // ASSERT
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TagFormat()
        {
            // ARRANGE
            string expected = "<Guid(\"9015CCB1-06A1-4198-A01A-B7404F2944B6\")>";

            // ACT
            string actual = GuidFormats.Tag(guid);

            // ASSERT
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ShortFormat()
        {
            // ARRANGE
            string expected = "scwVkKEGmEGgGrdATylEtg";

            // ACT
            string actual = GuidFormats.Short(guid);

            // ASSERT
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}