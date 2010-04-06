using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace XML_Playlist_Generator
{
    public class Album
    {
        #region Fields
        private string author;

        private string imageurl;

        private string name;

        private string link;

        #endregion

        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }


        public string Imageurl
        {
            get { return imageurl; }
            set { imageurl = value; }
        }



        public string Link
        {
            get { return link; }
            set { link = value; }
        }
        #endregion

        public Album()
        {

        }


    }
}
