using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FishDataSource {
    public static class DataSourceHelper {
        public static List<T> GetDataSouresFromXml<T>(string resName, string attribute) where T : class {
            using (Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resName)) {
                XmlSerializer s = new XmlSerializer(typeof(List<T>), new XmlRootAttribute(attribute));
                return (List<T>)s.Deserialize(stream);
            }
        }
    }
}
