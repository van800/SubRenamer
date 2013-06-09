using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;
//using RND.XML;

namespace SubRenamer
{
    static class Program
    {
        //Set objShell = CreateObject("WScript.Shell");
        //Set colEnvironmentVariables = objShell.Environment("Volatile");

        //public static string QL = colEnvironmentVariables.Item("APPDATA") + @"\Microsoft\Internet Explorer\Quick Launch";
        static string fileName = "Extensions.xml";
        static ParentForm myForm;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ExtensionList videoExtensions = new ExtensionList();
            ExtensionList subExtensions = new ExtensionList();

            #region read from xml using RND.XML
            //XmlStorage myXmlStorage = new XmlStorage("Extensions", System.Convert.ToChar(" "));
            //try
            //{
            //    using (Stream fStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
            //    {
            //        //
            //        myXmlStorage.Load(fStream);
            //    }
            //}
            //catch (Exception)
            //{
            //}
            //videoExtensions = (ExtensionList)myXmlStorage.ReadEntry("VideoExt");
            //subExtensions = (ExtensionList)myXmlStorage.ReadEntry("SubExt");
            #endregion
            #region Read xml-file with user extensions using Standard XML
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<ExtensionList>), "Extensions");
            try
            {
                using (Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    try
                    {
                        List<ExtensionList> myList = (List<ExtensionList>)xmlFormat.Deserialize(fStream);
                        videoExtensions = myList[0];
                        subExtensions = myList[1];
                    }
                    catch (Exception)
                    {
                        Debug.WriteLine("xmlFormat.Deserialize(fStream) fails");
                    }
                    finally { fStream.Close(); }
                }
            }
            catch (Exception)
            {
                Debug.WriteLine("Fail to open xml file");
            }
            #endregion
            if (videoExtensions ==null ||videoExtensions.ToString() == "")
            {
                    videoExtensions = ExtensionList.Parse(".avi;.mkv;.ogm;.mpeg;.mpg;.vid;.xvid;"); 
            }

            if (subExtensions == null|| subExtensions.ToString() == "")
                subExtensions = ExtensionList.Parse(".srt;.ass;.ssa;.rt;.js;.sub;");

            //serialize into XML
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            
            //start App
            myForm = new ParentForm(videoExtensions, subExtensions, args);
            Application.Run(myForm);//Form1(LIST)
        }

        static void Application_ApplicationExit(object sender, EventArgs e)
        {
            // ocurs then application exit
            // TODO: add code to serialize into xml

            #region Read xml-file with user extensions using Standard XML
            //XmlStorage myXmlStorage = new XmlStorage("Extensions", System.Convert.ToChar(" "));
            ////string fileName = "Extensions.xml";

            //myXmlStorage.WriteEntry("VideoExt", myForm.VideoExtensions);
            //myXmlStorage.WriteEntry("SubExt", myForm.SubExtensions);
            //using (Stream fStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            //{
            //    myXmlStorage.Save(fStream);
            //}
            #endregion
            #region Write xml-file with user extensions using Standard XML serializer
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<ExtensionList>), "Extensions");
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                List<ExtensionList> myList = new List<ExtensionList>();
                myList.Add(myForm.VideoExtensions); myList.Add(myForm.SubExtensions);
                xmlFormat.Serialize(fStream, myList);
                fStream.Close();
            }
            #endregion
        }
    }
}
