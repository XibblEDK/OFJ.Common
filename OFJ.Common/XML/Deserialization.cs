﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OFJ.Common.XML
{
    public static class Deserialization
    {
        public static T DeserializeXML<T>(string fileName) where T : class
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StreamReader stream = new StreamReader(fileName);

            T? result = serializer.Deserialize(stream) as T;
            stream.Close();
            return result;
        }

        public static IEnumerable<T> DeserializeXML<T>(string fileName, Predicate<T> predicate) where T : class
        {
            return DeserializeXML<List<T>>(fileName).Where(t => predicate(t));
        }
    }
}
