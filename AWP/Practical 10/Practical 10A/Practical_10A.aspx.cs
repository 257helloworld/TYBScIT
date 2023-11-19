using System;
using System.Xml;

namespace Practical_10A
{
    public partial class Practical_10A : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            XmlWriterSettings s = new XmlWriterSettings();
            s.Indent = true;
            XmlWriter xw = XmlWriter.Create(@"FullPathOfXMLFile", s);
            xw.WriteStartDocument();
            xw.WriteStartElement("College");
            xw.WriteStartElement("Student");

            xw.WriteStartElement("RollNo");
            xw.WriteString("1");
            xw.WriteEndElement();
            xw.WriteStartElement("Name");
            xw.WriteString("ABC");
            xw.WriteEndElement();
            xw.WriteStartElement("City");
            xw.WriteString("Mumbai");
            xw.WriteEndElement();

            xw.WriteEndElement();
            xw.WriteEndElement();
            xw.WriteEndDocument();
            xw.Close();
            Result1.Text = "Data written";
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            XmlReader xr = XmlReader.Create(@"full path of xml file here");
            Result2.Text = "";
            while (xr.Read())
            {
                if (xr.NodeType.Equals(XmlNodeType.Text))
                {
                    Result2.Text += xr.Value + " ";
                }
            }
            xr.Close();
        }

    }
}