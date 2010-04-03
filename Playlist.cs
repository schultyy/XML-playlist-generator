using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace XML_Playlist_Generator
{
    public class Playlist
    {
        /// <summary>
        /// Playlistdokument
        /// </summary>
        private XmlDocument doc;

        /// <summary>
        /// Root-Element
        /// </summary>
        private XmlNode root;

        public Playlist(string name)
        {
            this.doc = new XmlDocument();
            //Root Knoten erzeugen
            this.root = this.doc.CreateElement(name);
        }
    }
}
