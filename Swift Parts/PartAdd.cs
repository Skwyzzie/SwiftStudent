using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Info;
using Session;

namespace Swift_Student
{
    public partial class PartAdd : Form
    {
        //Declarations
        Database d = new Database();
        Boolean Continue = false;
        int totalEmpty = 0;
        //init
        public PartAdd()
        {
            InitializeComponent();
        }
        //Check for empty fields then add data to db
        private void addPart_Click(object sender, EventArgs e)
        {
            validateFields();
            if (Continue != true)
            {
                return;
            }
            Student s = new Student();
            s.SID = ISID.Text;
            s.SName = ISN.Text;
            s.SSending = ISSC.Text;
            s.SShop = ISS.Text;
            s.SPhoto = OpenPic.FileName;
            s.SGrade = ISG.Text;
            d.Insert(s);

            clearForm();
        }
        //Close
        private void cancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Change picture
        private void browseBTN_Click(object sender, EventArgs e)
        {
            OpenPic.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (OpenPic.ShowDialog() == DialogResult.OK)
            {
                StudentPhoto.Image = Image.FromFile(OpenPic.FileName);
            }
        }
        //Convert image to byte array 
        //I don't think this is used. Can't remember right now
        public byte[] ImageToByte(Image img)
        {
            Bitmap BmpImage = new Bitmap(img);
            BmpImage.Save(Application.StartupPath + @"\unmodified.png", System.Drawing.Imaging.ImageFormat.Png);
            MemoryStream mStream = new MemoryStream();
            StudentPhoto.Image.Save(mStream, System.Drawing.Imaging.ImageFormat.Png);
            byte[] imgAsByte = mStream.ToArray();
            return imgAsByte;
        }
        //Clear Form
        public void clearForm()
        {
            foreach (Control con in PartInfoGroup.Controls)
            {
                if (con is TextBox)
                {
                    TextBox textBox = con as TextBox;
                    textBox.Text = "";
                }
            }
            StudentPhoto.Image = null;
        }
        //Test for empty fields
        public void validateFields()
        {
            totalEmpty = 0;
            if (StudentPhoto.Image == null)
            {
                totalEmpty += 1;
            }
            foreach (Control con in PartInfoGroup.Controls)
            {
                if (con is TextBox)
                {
                    TextBox textBox = con as TextBox;
                    if (textBox.Text.Length == 0)
                    {
                        totalEmpty += 1;
                    }
                }
            }
            if (totalEmpty > 0)
            {
                MessageBox.Show("Please fix " + totalEmpty + " errors before continuing.");
                Continue = false;
            } 
            else 
            {
                Continue = true;
            }
        }
    }
}
