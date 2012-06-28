using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace IniFiles.Tests
{
    [TestFixture]
    public class ReadWriteTest
    {
        [Test]
        public void Read_Empty_IniFIle()
        {
            string emptyFile = Mother.EmptyIniFile();
            var cats = IniReader.GetCategories(emptyFile);
            Assert.IsTrue(cats.Count == 0);
        }
        [Test]
        public void Read_Populated_IniFIle()
        {
            string popFile = Mother.PopulatedIniFile();
            var cats = IniReader.GetCategories(popFile);
            Assert.IsTrue(cats.Count == 2);
        }
        [Test]
        public void Read_Populated_IniFIle_Configuration()
        {
            string popFile = Mother.PopulatedIniFile();
            var keys = IniReader.GetKeys(popFile, "Configuration");
            Assert.IsTrue(keys.Count == 2);
        }

        
        [Test]
        public void Read_Populated_IniFile_Keys()
        {
            string popFile = Mother.PopulatedIniFile();
            var cats = IniReader.GetCategories(popFile);
            var keys = IniReader.GetKeys(popFile, cats[0]);
            Assert.IsTrue(keys.Count == 2);
        }


        [Test]
        public void Write_IniFile_Keys()
        {
            string newFile = Mother.EmptyIniFile();
            IniWriter.WriteKey(newFile, "Category", "KEY", "VALUE");
            IniWriter.WriteKey(newFile, "Category", "KEY1", "VALUE");

            var cats = IniReader.GetCategories(newFile);
            Assert.IsTrue(cats.Count == 1);
            var keys = IniReader.GetKeys(newFile, cats[0]);
            Assert.IsTrue(keys.Count == 2);

        }

    }
}
