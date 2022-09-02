using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionstore
{
    class category: IMethod
    {
        public int id { get; set; }
        public string name { get; set; }
        SqlConnection con = new SqlConnection(@"server=BHAVNAWKS651\SQLEXPRESS;database=fashion;Integrated Security=true;");
        public int Add()
        {
            int flag = 0;
            try
            {
                Console.WriteLine("Enter category name");
                name = Console.ReadLine();
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tblCategory values('" + name + "')", con);
                cmd.ExecuteNonQuery();
                flag = 1;
            }
            catch(Exception)
            {
                Console.WriteLine("Insertion Failed! Try Again");
                Console.WriteLine();
            }
            return flag;

        }

        public int Delete()
        {
            int flag = 0;
            try
            {
                Console.WriteLine("Enter the category id that you want to delete ");
                id = int.Parse(Console.ReadLine());
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from tblCategory where Id=" + id + "", con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("category with id:" + id);
                con.Close();
                flag = 1;
            }
            catch(Exception)
            {
                Console.WriteLine("Detetion Failed! Try Again");
                Console.WriteLine();
            }
            return flag;
        }

        public void Display()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblCategory", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Console.WriteLine("Category Id:" + sdr.GetValue(0) + "\n" + "category name:" + sdr.GetValue(1));
            }
            con.Close();
        }

        public int Update()
        {
            int flag = 0;
            try
            {
                Console.WriteLine("Enter the id that you want to update");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the value with which you want to update");
                name = Console.ReadLine();
                con.Open();
                SqlCommand cmd = new SqlCommand("update tblCategory set Name='" + name + "' where Id=" + id + "", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("category with id:" + id);
                flag = 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return flag;
        }
    }
}
