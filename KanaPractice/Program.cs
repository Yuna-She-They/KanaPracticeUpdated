namespace KanaPractice {
    #region Using Directives
    using System;
    using System.Windows.Forms;
    #endregion Using Directives

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CfrmMain());
        }

        /*remove private void CreateKanaData(string fileName) {
            //create an instance of the XmlSerializer class
            //specify the type of object to serialize

            XmlSerializer serializer = new XmlSerializer(typeof(KanaData));
            TextWriter writer = new StreamWriter(fileName);
            KanaData kd = new KanaData();

            serializer.Serialize(writer, kd);
            writer.Close();
        }

        protected void ReadKanaData(string fileName) {
            //create instance of serializer class
            // specify the type of object to deserilize
            XmlSerializer serializer = new XmlSerializer(typeof(KanaData));

            // if Xml doc has altared with unknown nodes or attributes handle them with UnknownNode and UnknownAttribute events
            serializer.UnknownNode += new XmlNodeEventHandler(serializer_UnknownNode);
            serializer.UnknownAttribute += new XmlAttributeEventHandler(serializer_UnknownAttribute);

            //A file stream is needed to read the XML
            FileStream fs = new FileStream(fileName, FileMode.Open);

            //Declare an obj variable to be  deserialized.
            KanaData kd;
            kd = (KanaData)serializer.Deserialize(fs);
        }

        private void serializer_UnknownNode(object sender, XmlNodeEventArgs e) {
            MessageBox.Show($"{e.Name} {e.Text}", "Unknown Node", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void serializer_UnknownAttribute(object sender, XmlAttributeEventArgs e) {

        }*/
    }
}
