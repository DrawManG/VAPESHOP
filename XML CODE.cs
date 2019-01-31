using System.IO;
using System.Xml.Serialization;

namespace VAPESHOP
{
   class XML_CODE
    {
        public static XML_CODE GetSetting()
        {
            XML_CODE XML_CODE = null;
            string FileXM = XML_CLOBAL.aftorizFile;

            if (File.Exists(FileXM))
            {
                using (FileStream aft = new FileStream(FileXM, FileMode.Open))
                {
                    XmlSerializer xmo = new XmlSerializer(typeof(XML_CODE));
                    XML_CODE = (XML_CODE)xmo.Deserialize(aft);
                    aft.Close();
                }

            }
            else
            {
                XML_CODE seto = new XML_CODE();
                return XML_CODE;
            }



            return XML_CODE;


        }
        public void save()
        {
            string filename = XML_CLOBAL.aftorizFile;

            if (File.Exists(filename)) File.Delete(filename);
            using (FileStream aft = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer goldxml = new XmlSerializer(typeof(XML_CODE));

                goldxml.Serialize(aft, this);
                aft.Close();
            }

        }
        public string savelog { get; set; }
        public string savepass { get; set; }


    }
}




