using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlServerCe;


namespace CW.DAL
{
    public class TestManager : DbManager // Inheritance
    {
        public void Create(Test t)
        {
            var connection = Connection; // this smart Connection string works for coresponding with DbManager class. that connects with window forms in FunPro.CW.11977 project
            try
            {    //This sql statement looks for all the colums and inserts the data in them
                var sql = $"INSERT INTO ts_test (ts_name_11977, ts_q1_11977, ts_q1_answer_11977, ts_q2_11977, ts_q2_answer_11977, ts_q3_11977, ts_q3_answer_11977) VALUES ('{t.Name}', '{t.Quest1}', '{t.Answer1}', '{t.Quest2}', '{t.Answer2}', '{t.Quest3}', '{t.Answer3}')";
                //the command works for taking sql statement and connection and know how to execute the tool
                var command = new SqlCeCommand(sql, connection);
                //connection should be open before we knock on the database
                connection.Open();
                //this sentence works for not expecting any result back from, It works for not saving the data
                command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {//if there is smth it shows the message
                MessageBox.Show(ex.Message);
            }
            finally
            {// finnal will check if the 
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }

            }

        }
        //Update 
        public void Update(Test t)
        {
            var connection = Connection;
            try
            {
                var sql = $"UPDATE ts_test SET ts_name_11977 = '{t.Name}', ts_q1_11977 = '{t.Quest1}', ts_q1_answer_11977 = '{t.Answer1}', ts_q2_11977 = '{t.Quest2}', ts_q2_answer_11977 = '{t.Answer2}', ts_q3_11977 = '{t.Quest3}', ts_q3_answer_11977 = '{t.Answer3}' WHERE ts_id_11977 = {t.Id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // 
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        public void Delete(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $"DELETE FROM ts_test WHERE ts_id_11977 = {id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        public Test GetById(int id)
        {
            var connection = Connection;
            try
            {   
                var sql = $"SELECT ts_id_11977, ts_name_11977, ts_q1_11977, ts_q1_answer_11977, ts_q2_11977, ts_q2_answer_11977, ts_q3_11977, ts_q3_answer_11977 FROM Test WHERE ts_id_11977 = {id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var t = new Test
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        Name = Convert.ToString(reader.GetValue(1)),
                        Quest1 = Convert.ToString(reader.GetValue(2)),
                        Answer1 = Convert.ToString(reader.GetValue(3)),
                        Quest2 = Convert.ToString(reader.GetValue(4)),
                        Answer2 = Convert.ToString(reader.GetValue(5)),
                        Quest3 = Convert.ToString(reader.GetValue(6)),
                        Answer3 = Convert.ToString(reader.GetValue(7)),
                    };
                    return t;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }

            }

            // if we are here - something went wrong
            return null;
        }
        public Test GetByName(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $"SELECT ts_id_11977, ts_name_11977, ts_q1_11977, ts_q1_answer_11977, ts_q2_11977, ts_q2_answer_11977, ts_q3_11977, ts_q3_answer_11977 FROM Test WHERE ts_id_11977 = {id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var t = new Test
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        Name = Convert.ToString(reader.GetValue(1)),
                        Quest1 = Convert.ToString(reader.GetValue(2)),
                        Answer1 = Convert.ToString(reader.GetValue(3)),
                        Quest2 = Convert.ToString(reader.GetValue(4)),
                        Answer2 = Convert.ToString(reader.GetValue(5)),
                        Quest3 = Convert.ToString(reader.GetValue(6)),
                        Answer3 = Convert.ToString(reader.GetValue(7)),
                    };
                    return t;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }

            }

            // if we are here - something went wrong
            return null;
        }

        public List<string> GetAllNames()
        {
            var connection = Connection;
            var tests = new List<string>();
            try
            {
                var sql = "SELECT ts_id_11977, ts_name_11977, ts_q1_11977, ts_q1_answer_11977, ts_q2_11977, ts_q2_answer_11977, ts_q3_11977, ts_q3_answer_11977 FROM ts_test";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var t = new Test
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        Name = Convert.ToString(reader.GetValue(1)),
                        Quest1 = Convert.ToString(reader.GetValue(2)),
                        Answer1 = Convert.ToString(reader.GetValue(3)),
                        Quest2 = Convert.ToString(reader.GetValue(4)),
                        Answer2 = Convert.ToString(reader.GetValue(5)),
                        Quest3 = Convert.ToString(reader.GetValue(6)),
                        Answer3 = Convert.ToString(reader.GetValue(7)),
                    };
                    tests.Add(t.Name);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }

            }

            return tests;
        }

        public List<Test> GetAll()
        { // this part works for adding data contiously
            //List is connection, it works for growing of a ray in the table
            //this only acceptes aded tets
            var connection = Connection;
            var result = new List<Test>();
            try
            {
                var sql = "SELECT ts_id_11977, ts_name_11977, ts_q1_11977, ts_q1_answer_11977, ts_q2_11977, ts_q2_answer_11977, ts_q3_11977, ts_q3_answer_11977 FROM ts_test";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var t = new Test
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        Name = Convert.ToString(reader.GetValue(1)),
                        Quest1 = Convert.ToString(reader.GetValue(2)),
                        Answer1 = Convert.ToString(reader.GetValue(3)),
                        Quest2 = Convert.ToString(reader.GetValue(4)),
                        Answer2 = Convert.ToString(reader.GetValue(5)),
                        Quest3 = Convert.ToString(reader.GetValue(6)),
                        Answer3 = Convert.ToString(reader.GetValue(7)),
                    };
                    result.Add(t);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }

            }

            return result;
        }
        public List<string> GetByName()
        {
            var connection = Connection;
            var tests = new List<string>();
            try
            {
                var sql = "SELECT ts_id_11977, ts_name_11977, ts_q1_11977, ts_q1_answer_11977, ts_q2_11977, ts_q2_answer_11977, ts_q3_11977, ts_q3_answer_11977 FROM ts_test";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var t = new Test
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        Name = Convert.ToString(reader.GetValue(1)),
                        Quest1 = Convert.ToString(reader.GetValue(2)),
                        Answer1 = Convert.ToString(reader.GetValue(3)),
                        Quest2 = Convert.ToString(reader.GetValue(4)),
                        Answer2 = Convert.ToString(reader.GetValue(5)),
                        Quest3 = Convert.ToString(reader.GetValue(6)),
                        Answer3 = Convert.ToString(reader.GetValue(7)),
                    };
                    tests.Add(t.Name);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }

            }

            return tests;
        }

        
    }
}



