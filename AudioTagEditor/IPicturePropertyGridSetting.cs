using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;

namespace AudioTagEditor
{
    public class IPicturePropertyGridSetting
    {
        public PictureType pictureType { get; set; }
        public string MimeType { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return "IPictureInfo";
        }
    }
}
