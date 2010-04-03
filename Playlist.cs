using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace XML_Playlist_Generator
{
    /// <summary>
    /// XML-Playlist
    /// </summary>
    public class Playlist
    {
        /// <summary>
        /// Playlist document
        /// </summary>
        private XmlDocument doc;

        /// <summary>
        /// Root-Element
        /// </summary>
        private XmlNode root;

        public Playlist(string name)
        {
            this.doc = new XmlDocument();
            //Creating Root - element
            this.root = this.doc.CreateElement(name);
        }


    }
}
