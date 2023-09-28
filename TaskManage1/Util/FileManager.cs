using KT_TaskManage.Data;
using System.Diagnostics;
using System.Text;
using System.Xml.Serialization;

namespace KT_TaskManage.Util
{
    public static class FileManager
    {
        public static bool XmlSerialize(string fileName, MasterModel writeData)
        {
            var xmlSerializer = new XmlSerializer(typeof(MasterModel));
            using (var streamWriter = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                xmlSerializer.Serialize(streamWriter, writeData);
                streamWriter.Flush();
            }

            return true;
        }

        public static bool XmlDeSerialize(string fileName, out MasterModel readData)
        {
            var xmlSerializer = new XmlSerializer(typeof(MasterModel));
            var xmlSettings = new System.Xml.XmlReaderSettings()
            {
                CheckCharacters = false,
            };

            try
            {
                using (var streamReader = new StreamReader(fileName, Encoding.UTF8))
                using (var xmlReader = System.Xml.XmlReader.Create(streamReader, xmlSettings))
                {
                    readData = (MasterModel)(xmlSerializer.Deserialize(xmlReader) ?? new MasterModel());
                }
            }
            catch (FileNotFoundException ex)
            {
                Trace.TraceError(ex.Message);
                readData = new MasterModel();
            }

            return true;
        }
    }
}
