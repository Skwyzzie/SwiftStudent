using Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using Updater;

namespace Swift_Student
{
    public partial class Main : Form, IUpdater
    {
        Database d = new Database();
        private SharpUpdater updater;
        //init
        public Main()
        {
            InitializeComponent();
            updater = new SharpUpdater(this);
        }

        //Show AddPart form
        private void AddPartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartAdd pa = new PartAdd();
            pa.Show();
        }

        //Search the database for parts
        private void SearchBTN_Click(object sender, EventArgs e)
        {
            foreach (Control con in SearchGroup.Controls)
            {
                if (con is TextBox)
                {
                    TextBox textBox = con as TextBox;
                    if (textBox.Text.Length > 0)
                    {
                        if (textBox.Name == "SSID")
                        {
                            d.selectStudentID(textBox.Text);
                        } 
                        else if (textBox.Name == "SSN")
                        {
                            d.selectStudentName(textBox.Text);
                        }
                    }
                }
                else if(con is ComboBox)
                {
                    ComboBox comboBox = con as ComboBox;
                    if (comboBox.Text.Length > 0)
                    {
                        if (comboBox.Name == "SSG")
                        {

                        }
                    }
                }
            }
            StudentGrid.DataSource = d.dt;
            StudentGrid.Refresh();
            SSID.Text = "";
            SSN.Text = "";
            SSG.SelectedItem = null;
        }

        //Show info about part
        private void PartGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IID.Text = StudentGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            ISN.Text = StudentGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            IDESC.Text = StudentGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            ISG.Text = StudentGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            ISS.Text = StudentGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
            ISSC.Text = StudentGrid.Rows[e.RowIndex].Cells[8].Value.ToString();
            StudentPhoto.ImageLocation = StudentGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            updater.DoUpdate();
            d.loadMachineModelsToCB(SSG);
        }

        #region SharpUpdate
        public string ApplicationName
        {
            get { return "Swift Student"; }
        }

        public string ApplicationID
        {
            get { return "SwiftStudent"; }
        }

        public System.Reflection.Assembly ApplicationAssembly
        {
            get { return Assembly.GetExecutingAssembly(); }
        }

        public Icon ApplicationIcon
        {
            get { return this.Icon; }
        }

        public Uri UpdateXmlLocation
        {
            get { return new Uri("http://www.marsware.us/SwiftStudent/Update.xml"); }
        }

        public Form Context
        {
            get { return this; }
        }
        #endregion

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.marsware.us/swiftstudent.html");
        }
    }
}