using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementDBMS
{
    internal class User
    {
        MY_DB mydb = new MY_DB();
        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
        // Thêm user mới vào database
        public bool insertUser(string username, string pass, string fullName, string mail, int age, string phone, string address)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Login (username, pass, fullName, mail, age, phone, address) VALUES (@usrn, @pas, @fuln, @mail, @age, @phn, @add)", mydb.getConnection);

            command.Parameters.Add("@usrn", SqlDbType.NChar, 10).Value = username;
            command.Parameters.Add("@pas", SqlDbType.NChar, 10).Value = pass;
            command.Parameters.Add("@fuln", SqlDbType.NChar, 10).Value = fullName;
            command.Parameters.Add("@mail", SqlDbType.NChar, 10).Value = mail;
            command.Parameters.Add("@age", SqlDbType.Int, 10).Value = age;
            command.Parameters.Add("@phn", SqlDbType.NChar, 10).Value = phone;
            command.Parameters.Add("@add", SqlDbType.NChar, 10).Value = address;

            mydb.openConnection();
            bool success = command.ExecuteNonQuery() == 1;
            mydb.closeConnection();

            return success;
        }
    }
}
