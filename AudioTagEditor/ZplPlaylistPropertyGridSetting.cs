using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioTagEditor
{
    public class ZplPlaylistPropertyGridSetting
    {
        public Head head { get; set; }
        public class Head
        {
            public string PlaylistTitle { get; set; }

            public List<Meta> Meta_List = new List<Meta>();
            public List<Meta> MetaList { get => Meta_List; set => Meta_List = value; }
            public class Meta
            {
                public string Name { get; set; }
                public string Context { get; set; }

                public override string ToString()
                {
                    return "Meta";
                }
            }

            public override string ToString()
            {
                return "Head";
            }
        }

        public Body body { get; set; }
        public class Body
        {
            public Seq seq { get; set; }
            public class Seq
            {
                public List<Media> Media_List = new List<Media>();
                public List<Media> MediaList { get => Media_List; set => Media_List = value; }
                public class Media
                {
                    public string Path { get; set; }
                    public string Album_Title { get; set; }
                    public string Album_Artist { get; set; }
                    public string Track_Title { get; set; }
                    public string Track_Artist { get; set; }
                    public uint Duration { get; set; }

                    public override string ToString()
                    {
                        return "Meta";
                    }
                }

                public override string ToString()
                {
                    return "Seq";
                }
            }

            public override string ToString()
            {
                return "Body";
            }
        }
    }
}
