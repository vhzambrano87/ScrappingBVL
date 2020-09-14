using Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DataLayer
{
    public class CategoryData
    {
        private DbConnect db = new DbConnect();
        public List<Category> GetAll()
        {
            List<Category> result = new List<Category>();
            Category objCategory = new Category();
            string querySP = "GetAllCategory";
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
                                objCategory = new Category();
                                objCategory.Id = Convert.ToInt32(rd["id"]);
                                objCategory.Name = rd["name"].ToString();
                                objCategory.Active = Convert.ToBoolean(rd["active"]);
                                result.Add(objCategory);

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

        public bool Insert(Category objCategory)
        {
            bool result = false;
            string querySP = "InsertCategory";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(db.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(querySP, conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@_name", objCategory.Name);
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

        public bool Update(Category objCategory)
        {
            bool result = false;
            string querySP = "UpdateCategory";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(db.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(querySP, conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@_id", objCategory.Id);
                        cmd.Parameters.AddWithValue("@_name", objCategory.Name);
                        cmd.Parameters.AddWithValue("@_active", objCategory.Active);
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
