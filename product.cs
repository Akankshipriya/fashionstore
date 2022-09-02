using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionstore
{
    class product:IMethod
    {
        public int p_id { get; set; }
        public string name { get; set; }

        public double price { get; set; }

        public int c_id { get; set; }

        SqlConnection con = new SqlConnection(@"server=BHAVNAWKS651\SQLEXPRESS;database=fashion;Integrated Security=true;");

        public int Add()
        {
            int flag = 0;
            try
            {
                Console.WriteLine("Enter Product name");
                name = Console.ReadLine();
                Console.WriteLine("Enter Product Price");
                price =double.Parse( Console.ReadLine());
                Console.WriteLine("Enter ctaegory Id");
                c_id = int.Parse(Console.ReadLine());
                con.Open();
                SqlCommand cmd = new SqlCommand($"insert into tblproduct values('{name}',{price},{c_id})", con);
                
                cmd.ExecuteNonQuery();
                flag = 1;
            }
            catch (Exception)
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
                Console.WriteLine("Enter the product id that you want to delete ");
                p_id = int.Parse(Console.ReadLine());
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from tblproduct where p_id=" + p_id + "", con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("product with id:" + p_id);
                con.Close();
                flag = 1;
            }
            catch (Exception)
            {
                Console.WriteLine("Detetion Failed! Try Again");
                Console.WriteLine();
            }
            return flag;
        }

        public void Display()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblproduct", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Console.WriteLine("Product Id:" + sdr.GetValue(0) + "\n" + "Product name:" + sdr.GetValue(1)+"\n"+"product price:"+sdr.GetValue(2)+"\n"+"Product Category"+sdr.GetValue(3));
            }
            con.Close();
        }

        public int Update()
        {
            int flag = 0;
            try
            {
                Console.WriteLine("Enter the id that you want to update");
                p_id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the new product name");
                name = Console.ReadLine();
                Console.WriteLine("Enter the new product price");
                price = int.Parse(Console.ReadLine());
                Console.WriteLine($"update tblproduct set name='{name}',price={price} where p_id={ p_id }");
                Console.ReadLine();
               
                SqlCommand cmd = new SqlCommand($"update tblproduct set name='{name}',price={price} where p_id={p_id}", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Product with id:" + p_id);
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
