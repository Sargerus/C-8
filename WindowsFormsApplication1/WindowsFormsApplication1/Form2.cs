using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
   
    public partial class Form2 : Form
    {
        IEnumerable<XElement> students;
        XElement xelement;
        List<Student> mainlist { get; set; }
        List<Student> buffer { get; set; }
        List<Student> toprint { get; set; }

        XDocument xd;

        Regex regex;

        string pattern;

        public Form2()
        {
            xd = XDocument.Load(@"e:\4 семестр\c#\8\1.xml");

            xelement = XElement.Load(@"e:\4 семестр\c#\8\1.xml");
            
            students = xelement.Elements();

            mainlist = new List<Student>();

            toprint = new List<Student>();
            
            mainlist = (from g in xd.Descendants("Student")
                        select new Student(g.Element("Name").Value, g.Element("Surname").Value, g.Element("LastName").Value,
                            g.Element("Age").Value, g.Element("Sex").Value, g.Element("Course").Value, g.Element("Proffesion").Value,
                            g.Element("Group").Value, g.Element("City").Value, g.Element("House").Value, g.Element("Street").Value,
                            g.Element("Index").Value, g.Element("Date").Value)).ToList();
                                
            
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            vivod.Clear();
            toprint.Clear();

            if (buffer == null) 
            {
                buffer = new List<Student>();
                buffer = mainlist;
                toprint.Clear();
            }
            
                bool flag = false;
                foreach (var g in buffer)
                    if (g.StudName == lname.Text)
                    {
                        flag = true;
                        toprint.Add(g);
                    }



                if (flag == false)
                {
                    pattern = @"\b(\S+" + lname.Text + @"\S+)\b";
                    regex = new Regex(pattern);
                    foreach (var g in buffer)
                        if (regex.IsMatch(g.StudName))
                            toprint.Add(g);
                }

                if (toprint.Count != 0)
                {
                    buffer = toprint;
                    foreach (var g in toprint)
                        vivod.AppendText(g.ToString());
                }
                
            
  

        }
            
        private void b2_Click(object sender, EventArgs e)
        {
            vivod.Clear();
            toprint.Clear();
            if (buffer == null)
            {
                buffer = new List<Student>();
                buffer = mainlist;
                toprint.Clear();
            }

            bool flag = false;
            foreach (var g in buffer)
                if (g.StudProffesion == prof.Text)
                {
                    flag = true;
                    toprint.Add(g);
                }



            if (flag == false)
            {
                pattern = @"\b(\S+" + prof.Text + @"\S+)\b";
                regex = new Regex(pattern);
                foreach (var g in buffer)
                    if (regex.IsMatch(g.StudProffesion))
                        toprint.Add(g);
            }

            if (toprint.Count != 0)
            {
                buffer = toprint;
                foreach (var g in toprint)
                    vivod.AppendText(g.ToString());
            }
            
            
        }

        private void b3_Click(object sender, EventArgs e)
        {
            vivod.Clear();
            toprint.Clear();
            if (buffer == null)
            {
                buffer = new List<Student>();
                buffer = mainlist;
                toprint.Clear();
            }

            bool flag = false;
            foreach (var g in buffer)
                if (g.StudCourse == course.Text)
                {
                    flag = true;
                    toprint.Add(g);
                }



            if (flag == false)
            {
                pattern = @"\b(\S+" + course.Text + @"\S+)\b";
                regex = new Regex(pattern);
                foreach (var g in buffer)
                    if (regex.IsMatch(g.StudCourse))
                        toprint.Add(g);
            }

            if (toprint.Count != 0)
            {
                buffer = toprint;
                foreach (var g in toprint)
                    vivod.AppendText(g.ToString());
            }
            
        }

        private void b4_Click(object sender, EventArgs e)
        {
            vivod.Clear();
            toprint.Clear();
            if (buffer == null)
            {
                buffer = new List<Student>();
                buffer = mainlist;
                toprint.Clear();
            }

            bool flag = false;
            foreach (var g in buffer)
                if (g.StudAge == age.Text)
                {
                    flag = true;
                    toprint.Add(g);
                }



            if (flag == false)
            {
                pattern = @"\b(\S+" + age.Text + @"\S+)\b";
                regex = new Regex(pattern);
                foreach (var g in buffer)
                    if (regex.IsMatch(g.StudAge))
                        toprint.Add(g);
            }

            if (toprint.Count != 0)
            {
                buffer = toprint;
                foreach (var g in toprint)
                    vivod.AppendText(g.ToString());
            }
            
        }

        private void lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buffer = new List<Student>();
            buffer = mainlist;

            toprint = new List<Student>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vivod.Clear();
            var buf = (from g in xd.Descendants("Student") orderby int.Parse(g.Element("Age").Value) ascending
                        select new Student(g.Element("Name").Value, g.Element("Surname").Value, g.Element("LastName").Value,
                            g.Element("Age").Value, g.Element("Sex").Value, g.Element("Course").Value, g.Element("Proffesion").Value,
                            g.Element("Group").Value, g.Element("City").Value, g.Element("House").Value, g.Element("Street").Value,
                            g.Element("Index").Value, g.Element("Date").Value)).ToList();

            foreach (var g in buf)
                vivod.AppendText(g.ToString());
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vivod.Clear();
            var buf = (from g in xd.Descendants("Student")
                       orderby g.Element("Name").Value ascending
                       select new Student(g.Element("Name").Value, g.Element("Surname").Value, g.Element("LastName").Value,
                           g.Element("Age").Value, g.Element("Sex").Value, g.Element("Course").Value, g.Element("Proffesion").Value,
                           g.Element("Group").Value, g.Element("City").Value, g.Element("House").Value, g.Element("Street").Value,
                           g.Element("Index").Value, g.Element("Date").Value)).ToList();

            foreach (var g in buf)
                vivod.AppendText(g.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vivod.Clear();
            var buf = (from g in xd.Descendants("Student")
                       orderby int.Parse(g.Element("Course").Value) ascending
                       select new Student(g.Element("Name").Value, g.Element("Surname").Value, g.Element("LastName").Value,
                           g.Element("Age").Value, g.Element("Sex").Value, g.Element("Course").Value, g.Element("Proffesion").Value,
                           g.Element("Group").Value, g.Element("City").Value, g.Element("House").Value, g.Element("Street").Value,
                           g.Element("Index").Value, g.Element("Date").Value)).ToList();

            foreach (var g in buf)
                vivod.AppendText(g.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("ser.xml", FileMode.OpenOrCreate);
            XmlSerializer formatter = new XmlSerializer(typeof(List<Student>));

           formatter.Serialize(fs,buffer);

            fs.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            vivod.Clear();
            vivod.AppendText("Это точно оно");
            FileStream fs = new FileStream("ser.xml", FileMode.OpenOrCreate);
            XmlSerializer formatter = new XmlSerializer(typeof(List<Student>));

            buffer = (List<Student>)formatter.Deserialize(fs);

            foreach (var g in buffer)
                vivod.AppendText(g.ToString());

            fs.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program v 1.0\r\n" + "Creator: Kulich Pavel");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button5_Click(sender,e);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            button6_Click(sender, e);
        }
    }

    [Serializable] public class Student
    {
        public string StudName { get; set; }
        public string StudSurname { get; set; }

        public string StudLastName { get; set; }

        public string StudAge { get; set; }

        public string StudSex { get; set; }

        public string StudCourse { get; set; }

        public string StudProffesion { get; set; }

        public string StudGroup { get; set; }

        public string StudCity { get; set; }

        public string StudHouse { get; set; }

        public string StudStreet { get; set; }

        public string StudIndex { get; set; }

        public string StudDate { get; set; }

        public Student(string s1, string s2, string s3, string s4, string s5, string s6, string s7, string s8, string s9,
            string s10, string s11, string s12, string s13)
        {
            StudName = s1;
            StudSurname = s2;
            StudLastName = s3;
            StudAge = s4;
            StudSex = s5;
            StudCourse = s6;
            StudProffesion = s7;
            StudGroup = s8;
            StudCity = s9;
            StudHouse = s10;
            StudStreet = s11;
            StudIndex = s12;
            StudDate = s13;
        }
        public Student()
            : this("", "", "", "", "", "", "", "", "", "", "", "", "")
        {

        }
        public Student(string s1) : this(s1, "", "", "", "", "", "", "", "", "", "", "", "") { }

        public override string ToString()
        {
            return "Фамилия: " + StudName + "\r\n" +
            "Имя: " + StudSurname + "\r\n" +
            "Отчество: " + StudLastName + "\r\n" +
            "Возраст: " + StudAge + "\r\n" +
            "Пол: " + StudSex + "\r\n" +
            "Курс: " + StudCourse + "\r\n" +
            "Специальность: " + StudProffesion + "\r\n" +
            "Группа: " + StudGroup + "\r\n" +
            "Город: " + StudCity + "\r\n" +
            "Дом: " + StudHouse + "\r\n" +
            "Улица: " + StudStreet + "\r\n" +
            "Индекс: " + StudIndex + "\r\n" +
            "Дата рождения: " + StudDate + "\r\n" +
            "\r\n";
        }
    }

}
