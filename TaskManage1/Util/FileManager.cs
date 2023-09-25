using KT_TaskManage.Data;
using System.Text;
using System.Xml.Serialization;

namespace KT_TaskManage.Util
{
    public static class FileManager
    {
        public static bool XmlSerialize(string fileName, MasterData writeData)
        {
            var xmlSerializer = new XmlSerializer(typeof(MasterData));
            using (var streamWriter = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                xmlSerializer.Serialize(streamWriter, writeData);
                streamWriter.Flush();
            }

            return true;
        }

        public static bool XmlDeSerialize(string fileName, out MasterData readData)
        {
            var xmlSerializer = new XmlSerializer(typeof(MasterData));
            var xmlSettings = new System.Xml.XmlReaderSettings()
            {
                CheckCharacters = false,
            };

            using (var streamReader = new StreamReader(fileName, Encoding.UTF8))
            using (var xmlReader = System.Xml.XmlReader.Create(streamReader, xmlSettings))
            {
                readData = (MasterData)(xmlSerializer.Deserialize(xmlReader) ?? new MasterData());
            }

            return true;
        }
    }
}
