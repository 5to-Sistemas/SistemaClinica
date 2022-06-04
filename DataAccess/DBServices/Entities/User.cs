using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccess.DBServices.Entities
{
    public class User
    {//Las entidades tienen los mismos campos de la tabla de la base de datos,
     //además esto te permite  cambiar facilmente a Entity Framework.

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }
        ConnectionToSql cx;
        public User()
        {
            cx = new ConnectionToSql();
        }

        public DataSet SelectAll()
        {
            cx.con = new SqlConnection(cx.cadenaConexion);
            cx.adpt = new SqlDataAdapter("select * from Users" +
                "", cx.con);
            DataSet ds = new DataSet();
            cx.adpt.Fill(ds);
            return ds;

        }
    }
}