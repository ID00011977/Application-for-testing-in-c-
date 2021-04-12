using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW.DAL
{
    public class ApplicantManager : DbManager //Inheritance
    {
        //for creating new data(Applicant)
        public void Create(Applicant a)
        {
            var connection = Connection;
            try
            {
        //This sql satement connects the table with visual studio

                var sql = $@"
INSERT INTO ap_applicant (ap_name_11977, ap_score_11977, ap_test_taken_11977) 
VALUES('{a.Name}', {a.Score}, '{a.Test}')";
        //the command works for taking sql statement and connection and know 
                //how to execute the tool

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
        //For Updating
        public void Update(Applicant a)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
UPDATE ap_applicant SET 
    ap_name_11977 = '{a.Name}', 
    ap_score_11977 = {a.Score}, 
    ap_test_taken_11977 = '{a.Test}'
WHERE ap_id_11977 = {a.Id}";
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
        //For Deleting
        public void Delete(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $"DELETE FROM ap_applicant WHERE ap_id_11977 = {id}";
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
        
        public Applicant GetById(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
SELECT ap_id_11977, ap_name_11977, ap_score_11977, ap_test_taken_11977
FROM ap_applicant
WHERE ap_id_11977 = {id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var a = GetFromReader(reader);
                    return a;
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

        public List<Applicant> GetAll()
        {
            var connection = Connection;
            var result = new List<Applicant>();
            try
            {
                var sql = "SELECT ap_id_11977, ap_name_11977, ap_score_11977, ap_test_taken_11977 FROM ap_applicant";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var a = GetFromReader(reader);
                    result.Add(a);
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
        //This part will be called from take test
        public List<Applicant> GetAllNames()
        {
            var connection = Connection;
            var result = new List<Applicant>();
            try
            {
                var sql = "SELECT ap_id_11977, ap_name_11977, ap_score_11977, ap_test_taken_11977 FROM ap_applicant";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var a = GetFromReader(reader);
                    result.Add(a);
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
        //Get Reader from
        private Applicant GetFromReader(SqlCeDataReader reader)
        {
            var a = new Applicant
            {
                Id = Convert.ToInt32(reader.GetValue(0)),
                Name = reader.GetValue(1).ToString(),
                Score = Convert.ToInt32(reader.GetValue(2)),
                Test = reader.GetValue(3).ToString()
            };

            return a;
        }
    }
}
