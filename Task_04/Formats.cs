using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task_04
{
    internal class Formats
    {
        public interface IDataTemplate
        {
            IDataTemplate Clone();
        }

        public class CsvDataTemplate : IDataTemplate
        {
            public string CsvData { get; set; }

            public IDataTemplate Clone()
            {
                return new CsvDataTemplate { CsvData = this.CsvData };
            }
        }

        public class XmlDataTemplate : IDataTemplate
        {
            public string XmlData { get; set; }

            public IDataTemplate Clone()
            {
                return new XmlDataTemplate { XmlData = this.XmlData };
            }
        }

        public class JsonDataTemplate : IDataTemplate
        {
            public string JsonData { get; set; }

            public IDataTemplate Clone()
            {
                return new JsonDataTemplate { JsonData = this.JsonData };
            }
        }

        public interface IDataAdapter
        {
            IDataTemplate Convert(IDataTemplate sourceData);
        }

        public class CsvToXmlAdapter : IDataAdapter
        {
            public IDataTemplate Convert(IDataTemplate sourceData)
            {
                if (sourceData is CsvDataTemplate csvDataTemplate)
                {
                    var xmlSerializer = new XmlSerializer(typeof(XmlDataTemplate));
                    using (StringReader reader = new StringReader($"<XmlDataTemplate><XmlData>{csvDataTemplate.CsvData}</XmlData></XmlDataTemplate>"))
                    {
                        return (XmlDataTemplate)xmlSerializer.Deserialize(reader);
                    }
                }

                return null; 
            }
        }

        public class JsonToXmlAdapter : IDataAdapter
        {
            public IDataTemplate Convert(IDataTemplate sourceData)
            {
                if (sourceData is JsonDataTemplate jsonDataTemplate)
                {
                    var xmlSerializer = new XmlSerializer(typeof(XmlDataTemplate));
                    using (StringReader reader = new StringReader($"<XmlDataTemplate><XmlData>{jsonDataTemplate.JsonData}</XmlData></XmlDataTemplate>"))
                    {
                        return (XmlDataTemplate)xmlSerializer.Deserialize(reader);
                    }
                }

                return null;
            }
        }
    }
}
