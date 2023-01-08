using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace OFJ.Common.XML
{
    public static class Serialization
    {
        public static void SerializeToXML<T>(string fileName, T obj) where T : class
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StreamWriter writer = new StreamWriter(fileName);
            serializer.Serialize(writer, obj);
            writer.Close();
        }
    }
}
