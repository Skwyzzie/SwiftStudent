using System;
using System.Data;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using Info;

namespace Session
{
    public class Database
    {
        OleDbConnection connection;
        OleDbCommand command;
        public DataTable dt = new DataTable("PartInfo");
        /// <changes>
        String db_name = "Parts.mdb";
        String password = "MMUPartsDB";
        public String srcDir = Application.StartupPath + "\\"; //@"G:\Swift\";
        /// </changes>
        
        private void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + srcDir + db_name + ";Jet OLEDB:Database Password=" + password + ";");
            command = connection.CreateCommand();
        }

        public Database()
        {
            ConnectTo();
        }

        public void Insert(Student s)
        {
            try
            {
                command.CommandText = "Insert INTO PartInfo (StudentID, StudentName, StudentGrade, StudentShop, StudentSendingSchool, StudentPhoto) VALUES('@SID', '@SName', '@SGrade', '@SShop', '@SSendSchool', '@SPhoto')";
                command.CommandType = CommandType.Text;
                connection.Open();
                command.Parameters.AddWithValue("SID", s.SID);
                command.Parameters.AddWithValue("SName", s.SName);
                command.Parameters.AddWithValue("SGrade", s.SGrade);
                command.Parameters.AddWithValue("SShop", s.SShop);
                command.Parameters.AddWithValue("SSendSchool", s.SSending);
                command.Parameters.AddWithValue("SPhoto", s.SPhoto);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        //Query for student IDs
        public void selectStudentID(String id)
        {

            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                String query = "SELECT * FROM StudentInfo WHERE StudentID = @ID OR StudentID LIKE @ID";
                connection.Open();
                da.SelectCommand = new OleDbCommand(query, connection);
                da.SelectCommand.Parameters.AddWithValue("ID", id.ToUpper());
                da.Fill(dt);
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString(), "Error connecting to the database.");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        //Query for student names
        public void selectStudentName(String SN)
        {

            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                String query = "SELECT * FROM StudentInfo WHERE StudentName = @Name OR StudentName LIKE %@Name%";
                connection.Open();
                da.SelectCommand = new OleDbCommand(query, connection);
                da.SelectCommand.Parameters.AddWithValue("Name", SN.ToUpper());
                da.Fill(dt);
                da.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        //Query for machine serials
        /*
        public void selectMachineSerial(String MS)
        {

            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                String query = "SELECT * FROM MachineSerial WHERE Serial = " + "\"" + MS + "\"";
                connection.Open();
                da.SelectCommand = new OleDbCommand(query, connection);
                da.Fill(dt);
                da.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
        */

        public void loadMachineModelsToCLB(CheckedListBox control)
        {
            try
            {
                command.CommandText = "SELECT * FROM MachineModel";
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    control.Items.Add(reader["ModelName"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void loadMachineModelsToCB(ComboBox control)
        {
             try
            {
                command.CommandText = "SELECT * FROM MachineModel";
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    control.Items.Add(reader["ModelName"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
}
