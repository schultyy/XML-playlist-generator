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
                textWriter.WriteEndAttribute();
                textWriter.WriteStartAttribute("author");
                textWriter.WriteValue(d.Name);
                textWriter.WriteEndAttribute(); 
                textWriter.WriteStartAttribute("imageUrl");
                textWriter.WriteValue("images\\" + d.Name + "\\" + d.Name + ".jpg");
                textWriter.WriteEndAttribute(); 
                textWriter.WriteStartAttribute("link");
                textWriter.WriteValue("#");
                textWriter.WriteEndAttribute(); 
                foreach (FileInfo file in files)
                {
                    if (file.Extension == ".mp3")
                    {
                        TagLib.File f = TagLib.File.Create(file.FullName);

                        //Writing Song-tag

                        textWriter.WriteStartElement("song");

                        //Writing name attribute
                        textWriter.WriteStartAttribute("name");
                        if (f.Tag.AlbumArtists.Length > 0 && f.Tag.Title != null)
                        {
                            textWriter.WriteValue(f.Tag.AlbumArtists[0] + " - " + f.Tag.Title);
                        }
                        else if (f.Tag.Title != null)
                        {
                            textWriter.WriteValue(f.Tag.Title);
                        }
                        else
                        {
                            textWriter.WriteValue("");
                        }
                        textWriter.WriteEndAttribute();
                        //----------------------------------

                        //writing duration attribute

                        textWriter.WriteStartAttribute("duration");
                        textWriter.WriteValue(f.Properties.Duration.Minutes.ToString() + " : " +
                            f.Properties.Duration.Seconds.ToString());
                        textWriter.WriteEndAttribute();
                        //-------------------------------------------------

                        //writing buy attribute
                        textWriter.WriteStartAttribute("buy");
                        textWriter.WriteValue("false");
                        textWriter.WriteEndAttribute();
                        //--------------------------------

                        //writing download attribute
                        textWriter.WriteStartAttribute("download");
                        textWriter.WriteValue(true);
                        textWriter.WriteEndAttribute();
                        //--------------------------------

                        //writing buyLink attribute
                        textWriter.WriteStartAttribute("buyLink");
                        textWriter.WriteValue("http://www.flabell.com");
                        textWriter.WriteEndAttribute();
                        //--------------------------------

                        //writing downloadSource attribute
                        textWriter.WriteStartAttribute("downloadSource");
                        textWriter.WriteValue("player/songs/" + file.Name);
                        textWriter.WriteEndAttribute();
                        //--------------------------------

                        textWriter.WriteValue("songs/" + file.Name);

                        textWriter.WriteEndElement();
                    }
                }
                //textWriter.WriteEndAttribute();
                textWriter.WriteEndElement();
            }
            textWriter.WriteEndElement();
            textWriter.Close();
        }
    }
}
