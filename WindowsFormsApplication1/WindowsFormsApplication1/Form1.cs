using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private int i;
        public Form1()
        {
            i = 0;
            string path = @"e:\4 семестр\c#\7\1.xml";
            XmlTextWriter textwriter = new XmlTextWriter(path, Encoding.UTF8);
            
            textwriter.WriteStartDocument();
            textwriter.WriteStartElement("head");
            textwriter.WriteEndElement();
            textwriter.Close();

            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar);
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar);
        }

        private void surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar);
        }

        private void lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar);
        }

        private void writebutton_Click(object sender, EventArgs e)
        {
            string path = @"e:\4 семестр\c#\7\1.xml";
            XmlDocument xmldocument = new XmlDocument();
            

            xmldocument.Load(path);

            XmlNode element = xmldocument.CreateElement("Student");
            xmldocument.DocumentElement.AppendChild(element);
            XmlAttribute attribute = xmldocument.CreateAttribute("Number");
            attribute.Value = i.ToString();
            element.Attributes.Append(attribute);
//имя
            XmlNode subElement1 = xmldocument.CreateElement("Name"); 
            subElement1.InnerText = this.name.Text; 
            element.AppendChild(subElement1);
//фамилия
            subElement1 = xmldocument.CreateElement("Surname");
            subElement1.InnerText = this.surname.Text;
            element.AppendChild(subElement1);
           
//отчество
            subElement1 = xmldocument.CreateElement("LastName");
            subElement1.InnerText = this.lastname.Text;
            element.AppendChild(subElement1);

//возраст
            subElement1 = xmldocument.CreateElement("Age");
            subElement1.InnerText = this.age.Text;
            element.AppendChild(subElement1);

//Пол
            subElement1 = xmldocument.CreateElement("Sex");
            if (this.sexm.Checked)
                subElement1.InnerText = "Мужской";
            if (this.sexw.Checked)
                subElement1.InnerText = "Женский";
            element.AppendChild(subElement1);

//Курс
            subElement1 = xmldocument.CreateElement("Course");
            if (this.cr1.Checked)
                subElement1.InnerText = "1";
            if (this.cr2.Checked)
                subElement1.InnerText = "2";
            if (this.cr3.Checked)
                subElement1.InnerText = "3";
            if (this.cr4.Checked)
                subElement1.InnerText = "4";
            if (this.cr5.Checked)
                subElement1.InnerText = "5";
            element.AppendChild(subElement1);

//специальность
            subElement1 = xmldocument.CreateElement("Proffesion");
            subElement1.InnerText = (this.listBox1.SelectedItem).ToString(); 
            element.AppendChild(subElement1);

//группа
            subElement1 = xmldocument.CreateElement("Group");
            if (r1.Checked)
                subElement1.InnerText = "1";
            if (r2.Checked)
                subElement1.InnerText = "2";
            if (r3.Checked)
                subElement1.InnerText = "3";
            element.AppendChild(subElement1);

//город
            subElement1 = xmldocument.CreateElement("City");
            subElement1.InnerText = this.city.Text;
            element.AppendChild(subElement1);

//дом            
            subElement1 = xmldocument.CreateElement("House");
            subElement1.InnerText = this.house.Text;
            element.AppendChild(subElement1);

//улица
            subElement1 = xmldocument.CreateElement("Street");
            subElement1.InnerText = this.street.Text;
            element.AppendChild(subElement1);

//индекс
            subElement1 = xmldocument.CreateElement("Index");
            subElement1.InnerText = this.index.Text;
            element.AppendChild(subElement1);

//дата
            subElement1 = xmldocument.CreateElement("Date");
            subElement1.InnerText = (this.monthCalendar1.TodayDate).ToShortDateString();
            element.AppendChild(subElement1);

            xmldocument.Save(path);
            i++;
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.TodayDate = e.Start;
        }

        private void readbutton_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            string path = @"e:\4 семестр\c#\7\1.xml";
            XmlTextReader textreader = new XmlTextReader(path);
            while (textreader.Read())

                if (textreader.NodeType == XmlNodeType.Element)
                {
                    progressBar1.Value++;
                    if (textreader.Name == "Student")
                        this.info.AppendText("Номер: " + textreader.GetAttribute("Number") + "\r\n");

                    if (textreader.Name == "Name")
                        this.info.AppendText("Фамилия: " + textreader.ReadElementContentAsString() + "\r\n");

                    if (textreader.Name == "Surname")
                        this.info.AppendText("Фамилия: " + textreader.ReadElementContentAsString() + "\r\n");

                    if (textreader.Name == "LastName")
                        this.info.AppendText("Отчество: " + textreader.ReadElementContentAsString() + "\r\n");

                    if (textreader.Name == "Age")
                        this.info.AppendText("Возраст: " + textreader.ReadElementContentAsString() + "\r\n");

                    if (textreader.Name == "Sex")
                        this.info.AppendText("Пол: " + textreader.ReadElementContentAsString() + "\r\n");

                    if (textreader.Name == "Course")
                        this.info.AppendText("Курс: " + textreader.ReadElementContentAsString() + "\r\n");

                    if (textreader.Name == "Proffesion")
                        this.info.AppendText("Специальность: " + textreader.ReadElementContentAsString() + "\r\n");

                    if (textreader.Name == "Group")
                        this.info.AppendText("Группа: " + textreader.ReadElementContentAsString() + "\r\n" + "Адрес:\r\n");

                    if (textreader.Name == "City")
                        this.info.AppendText("Город: " + textreader.ReadElementContentAsString() + "\r\n");

                    if (textreader.Name == "House")
                        this.info.AppendText("Дом: " + textreader.ReadElementContentAsString() + "\r\n");

                    if (textreader.Name == "Street")
                        this.info.AppendText("Улица: " + textreader.ReadElementContentAsString() + "\r\n");

                    if (textreader.Name == "Index")
                        this.info.AppendText("Индекс: " + textreader.ReadElementContentAsString() + "\r\n");

                    if (textreader.Name == "Date")
                        this.info.AppendText("Дата: " + textreader.ReadElementContentAsString() + "\r\n");

                    
                }

        }
    }
}
