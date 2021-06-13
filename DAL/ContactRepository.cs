using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Request;

namespace DAL
{
    public class ContactRepository : IContactRepository
    {
        public static string connectionString = @"server=(localdb)\MSSQLLocalDB; Integrated Security=true;";
        //private IConnectionFactory _connectionFactory;

        public int Insert(AddContactRequest contact)
        {
            var abc = @"Insert INTO ContactDB.dbo.Contact (ContactID,FirstName,LastName,Email,PhoneNumber,PhoneStatus) VALUES(contact.FirstName,contact.LastName,contact.Email,contact.PhoneNumber,contact.PhoneStatus)";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                var pqr = con.Query<Contact>(abc);
            }
            return contact.Contactid;
        }
        public int Update(UpdateContactRequest contact)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = con.CreateCommand())
                {
                    con.Open();
                    command.CommandText = "UPDATE Contact SET Contact (ContactID,FirstName,LastName,Email,PhoneNumber,PhoneStatus)VALUES(@ContId,@FName,@LName,@Email,@pNum,@pStatus)";

                    command.Parameters.AddWithValue("@FName", contact.FirstName);
                    command.Parameters.AddWithValue("@LName", contact.LastName);
                    command.Parameters.AddWithValue("@Email", contact.Email);
                    command.Parameters.AddWithValue("@pNum", contact.PhoneNumber);
                    command.Parameters.AddWithValue("@pStatus", contact.PhoneStatus);
                    command.ExecuteNonQuery();
                }
            }
            return contact.Contactid;
        }
        public List<Contact> GetContact()
        {
            var abc = @"SELECT * FROM ContactDB.dbo.Contact";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(abc, con);
                var pqr = con.Query<Contact>(abc).ToList();
                con.Close();
                return pqr; 
                
            }
        }

        public int Delete(DeleteContactRequest contact)
        {
            var abc = @"UPDATE ContactDB.dbo.Contact SET PhoneStatus=contact.PhoneStatus WHERE ContactID = contact.ContactID";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                var pqr = con.Query<Contact>(abc);
            }
            return contact.Contactid;
        }

        //using (SqlCommand command = con.CreateCommand())
        //{
        //    command.CommandText = "INSERT INTO Contact (ContactID,FirstName,LastName,Email,PhoneNumber,PhoneStatus)VALUES(@ContId,@FName,@LName,@Email,@pNum,@pStatus)";

        //    command.Parameters.AddWithValue("@ContId", contact.Contactid);
        //    command.Parameters.AddWithValue("@FName", contact.FirstName);
        //    command.Parameters.AddWithValue("@LName", contact.LastName);
        //    command.Parameters.AddWithValue("@Email", contact.Email);
        //    command.Parameters.AddWithValue("@pNum", contact.PhoneNumber);
        //    command.Parameters.AddWithValue("@pStatus", contact.PhoneStatus);
        //    con.Open();
        //    command.ExecuteNonQuery();
        //    con.Close();
        //}

    }
}
