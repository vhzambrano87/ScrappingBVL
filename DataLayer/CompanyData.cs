using Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DataLayer
{
    public class CompanyData
    {
        private DbConnect db = new DbConnect();
        public List<Company> GetAll()
        {
            List<Company> result = new List<Company>();
            Company objCompany = new Company();
            string querySP = "GetAllCompany";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(db.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(querySP, conn))
                    {
                        cmd.Connection.Open();
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                objCompany = new Company();
                                objCompany.Id = Convert.ToInt32(rd["id"]);
                                objCompany.Name = rd["name"].ToString();
                                objCompany.Nemonico = rd["nemonico"].ToString();
                                objCompany.CategoryId = Convert.ToInt32(rd["categoryId"]);
                                objCompany.Active = Convert.ToBoolean(rd["active"]);
                                result.Add(objCompany);

                            }
                        }
                        cmd.Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public bool Insert(Company objCompany)
        {
            bool result = false;
            string querySP = "InsertCompany";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(db.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(querySP, conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@_name", objCompany.Name);
                        cmd.Parameters.AddWithValue("@_nemonico", objCompany.Nemonico);
                        cmd.Parameters.AddWithValue("@_categoryId", objCompany.CategoryId);
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                    }
                }
                result = true;
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public bool Update(Company objCompany)
        {
            bool result = false;
            string querySP = "UpdateCompany";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(db.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(querySP, conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@_id", objCompany.Id);
                        cmd.Parameters.AddWithValue("@_name", objCompany.Name);
                        cmd.Parameters.AddWithValue("@_nemonico", objCompany.Nemonico);
                        cmd.Parameters.AddWithValue("@_categoryId", objCompany.CategoryId);
                        cmd.Parameters.AddWithValue("@_active", objCompany.Active);
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                    }
                }
                result = true;
            }
            catch (Exception ex)
            {

            }
            return result;
        }

    }
}
