using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using TagLib;

namespace XML_Playlist_Generator
{
    /// <summary>
    /// XML-Playlist
    /// </summary>
    public class Playlist
    {
        /// <summary>
        /// Root folder containing album folders
        /// </summary>
        private string rootFolder;

        /// <summary>
        /// Name for the xml playlistfile
        /// </summary>
        private string filename;

        /// <summary>
        /// Creates a new Playlist
        /// </summary>
        /// <param name="rootfolder">Root folder containing album folders</param>
        /// <param name="filename">Name for the xml playlistfile</param>
        public Playlist(string rootfolder, string filename)
        {
            this.rootFolder = rootfolder;
            this.filename = filename;
        }

        public void Scan()
        {
            DirectoryInfo[] albums = null;
            DirectoryInfo root = new DirectoryInfo(this.rootFolder);
            albums = root.GetDirectories();

            //Object, that writes the output file
            XmlTextWriter textWriter = new XmlTextWriter(this.filename, null);
            textWriter.Formatting = Formatting.Indented;
            textWriter.WriteStartElement("featureset");
            foreach (DirectoryInfo d in albums)
            {
                FileInfo[] files = d.GetFiles();

                //Writing new album tag
                textWriter.WriteStartElement("album");
                textWriter.WriteStartAttribute("name");
                textWriter.WriteValue(d.Name);

                foreach (FileInfo file in files)
                {
                    if (file.Extension == ".mp3")
                    {
                        TagLib.File f = TagLib.File.Create(file.FullName);
                    }
                }
                textWriter.WriteEndAttribute();
                textWriter.WriteEndElement();
            }
            textWriter.WriteEndElement();
            textWriter.Close();
        }
    }
}
