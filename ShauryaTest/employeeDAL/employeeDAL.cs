using ShauryaTest.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ShauryaTest.employeeDAL
{
    public class employeeDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public employeeDAL()
        {
            con = new SqlConnection(Startup.ConnectionString);
        }
        public List<employee> Getemployee()
        {
            List<employee> elist = new List<employee>();

            string qry = "select*from employee";
            cmd = new SqlCommand(qry, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    employee emp = new employee();
                    emp.Eid = Convert.ToInt32(dr["Eid"]);
                    emp.Fname = dr["Fname"].ToString();
                    emp.Mname = dr["Mname"].ToString();
                    emp.Lname = dr["Lname"].ToString();
                    emp.Gender = dr["Gender"].ToString();
                    emp.DOB = dr["DOB"].ToString();
                    emp.Address = dr["Address"].ToString();
                    emp.City = dr["City"].ToString();
                    emp.Pcode = Convert.ToInt32(dr["Pcode"]);
                    emp.Mobile = Convert.ToInt64(dr["Mobile"]);
                    elist.Add(emp);
                }
            }
            con.Close();
            return elist;
        }
        public employee GetemployeebyId(int id)
        {
            employee emp = new employee();
            string qry = "select*from employee where Eid=@eid";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@eid", id);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    emp.Eid = Convert.ToInt32(dr["Eid"]);
                    emp.Fname = dr["Fname"].ToString();
                    emp.Mname = dr["Mname"].ToString();
                    emp.Lname = dr["Lname"].ToString();
                    emp.Gender = dr["Gender"].ToString();
                    emp.DOB = dr["DOB"].ToString();
                    emp.Address = dr["Address"].ToString();
                    emp.City = dr["City"].ToString();
                    emp.Pcode = Convert.ToInt32(dr["Pcode"]);
                    emp.Mobile = Convert.ToInt64(dr["Mobile"]);

                }
            }
            con.Close();
            return emp;
        }
        public int Addemployee(employee emp)
        {
            string qry = "insert into employee values(@fname,@mname,@lname,@gender,@dob,@address,@city,@pcode,@mobile)";
            cmd = new SqlCommand(qry, con);

            cmd.Parameters.AddWithValue("@fname", emp.Fname);
            cmd.Parameters.AddWithValue("@mname", emp.Mname);
            cmd.Parameters.AddWithValue("@lname", emp.Lname);
            cmd.Parameters.AddWithValue("@gender", emp.Gender);
            cmd.Parameters.AddWithValue("@dob", emp.DOB);
            cmd.Parameters.AddWithValue("@address", emp.Address);
            cmd.Parameters.AddWithValue("@city", emp.City);
            cmd.Parameters.AddWithValue("@pcode", emp.Pcode);
            cmd.Parameters.AddWithValue("@mobile", emp.Mobile);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public int Updateemployee(employee emp)
        {
            string qry = "update employee set  Fname=@fname,Mname=@mname,Lname=@lname,Gender=@gender,DOB=@dob,Address=@address,City=@city,Pcode=@pcode,Mobile=@mobile where Eid=@eid";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@eid", emp.Eid);
            cmd.Parameters.AddWithValue("@fname", emp.Fname);
            cmd.Parameters.AddWithValue("@mname", emp.Mname);
            cmd.Parameters.AddWithValue("@lname", emp.Lname);
            cmd.Parameters.AddWithValue("@gender", emp.Gender);
            cmd.Parameters.AddWithValue("@dob", emp.DOB);
            cmd.Parameters.AddWithValue("@address", emp.Address);
            cmd.Parameters.AddWithValue("@city", emp.City);
            cmd.Parameters.AddWithValue("@pcode", emp.Pcode);
            cmd.Parameters.AddWithValue("@mobile", emp.Mobile);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public int Deleteemployee(int id)
        {
            string qry = "delete from employee where Eid=@eid";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@eid", id);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;

        }
    }
}
