using System;
using System.Activities.Validation;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Xml.Linq;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
    string con_str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
    SqlCommand objCommand;
    SqlConnection objConnection;
    SqlDataAdapter objDataAdapter;
    SqlDataReader dataReader;
    DataSet objDataSet;
    public Class1()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string Country { get; set; }
    public string Image { get; set; }
    public string CompanyName { get; set; }
    public string ContactPerson { get; set; }
    public string MobileNo { get; set; }
    public string Email { get; set; }
    public string Sno { get; set; }
    public string Category { get; set; }
    public string Sector { get; set; }
    public string BusinessEntity { get; set; }
    public string EmployeesNo { get; set; }
    public string FullAddress { get; set; }
    public string StateName { get; set; }
    public string StateId { get; set; }
    public string DistrictName { get; set; }
    public string DistrictId { get; set; }
    public string EstablishedYear { get; set; }
    public string CompanyWebsite { get; set; }
    public string EnterPassword { get; set; }
    public string RetypePassword { get; set; }
    public string Reference { get; set; }
    public string Flag { get; set; }


    private string _SendFrom;
    public string SendFrom
    {
        get
        {
            return _SendFrom;
        }
        set
        {
            _SendFrom = value;
        }
    }

    public SqlDataReader UspTblEmployeeRecordsGetAll()
    {
        objConnection = new SqlConnection(con_str); // Connection String
        objConnection.ConnectionString = con_str;
        objConnection.Open(); // Connection Open from DB
        objCommand = new SqlCommand(); // Object of Sql Command
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "UspTblEmployeeRecordsGetAll";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader UspTblCountryNameListGetAll()
    {
        objConnection = new SqlConnection(con_str); // Connection String
        objConnection.ConnectionString = con_str;
        objConnection.Open(); // Connection Open from DB
        objCommand = new SqlCommand(); // Object of Sql Command
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "UspTblCountryNameListGetAll";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader UspTblCategoryListGetAll()
    {
        objConnection = new SqlConnection(con_str); // Connection String
        objConnection.ConnectionString = con_str;
        objConnection.Open(); // Connection Open from DB
        objCommand = new SqlCommand(); // Object of Sql Command
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "UspTblCategoryListGetAll";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }


    public SqlDataReader UspSectorNameListGetAll()
    {
        objConnection = new SqlConnection(con_str); // Connection String
        objConnection.ConnectionString = con_str;
        objConnection.Open(); // Connection Open from DB
        objCommand = new SqlCommand(); // Object of Sql Command
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "UspSectorNameListGetAll";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }


    public SqlDataReader UspTypeofBusinessListGetAll()
    {
        objConnection = new SqlConnection(con_str); // Connection String
        objConnection.ConnectionString = con_str;
        objConnection.Open(); // Connection Open from DB
        objCommand = new SqlCommand(); // Object of Sql Command
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "UspTypeofBusinessListGetAll";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }


    public SqlDataReader UspEmployeesNoListGetAll()
    {
        objConnection = new SqlConnection(con_str); // Connection String
        objConnection.ConnectionString = con_str;
        objConnection.Open(); // Connection Open from DB
        objCommand = new SqlCommand(); // Object of Sql Command
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "UspEmployeesNoListGetAll";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader UspReferenceGetAll()
    {
        objConnection = new SqlConnection(con_str); // Connection String
        objConnection.ConnectionString = con_str;
        objConnection.Open(); // Connection Open from DB
        objCommand = new SqlCommand(); // Object of Sql Command
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "UspReferenceGetAll";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }




    public string UspTblCompanyRegistrationInsertUpdate()
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "UspTblCompanyRegistrationInsertUpdate"; 
            objCommand.Parameters.AddWithValue("@Sno", Sno);
            objCommand.Parameters.AddWithValue("@Country", Country);
            objCommand.Parameters.AddWithValue("@CompanyName", CompanyName);
            objCommand.Parameters.AddWithValue("@ContactPerson", ContactPerson);
            objCommand.Parameters.AddWithValue("@MobileNo", MobileNo);
            objCommand.Parameters.AddWithValue("@Email", Email);
            objCommand.Parameters.AddWithValue("@Category", Category);
            objCommand.Parameters.AddWithValue("@Sector", Sector);
            objCommand.Parameters.AddWithValue("@BusinessEntity", BusinessEntity);
            objCommand.Parameters.AddWithValue("@EmployeesNo", EmployeesNo);
            objCommand.Parameters.AddWithValue("@FullAddress", FullAddress);
            objCommand.Parameters.AddWithValue("@StateName", StateName);
            objCommand.Parameters.AddWithValue("@StateId", StateId);
            objCommand.Parameters.AddWithValue("@DistrictName", DistrictName);
            objCommand.Parameters.AddWithValue("@DistrictId", DistrictId);
            objCommand.Parameters.AddWithValue("@EstablishedYear", EstablishedYear);
            objCommand.Parameters.AddWithValue("@CompanyWebsite", CompanyWebsite);
            objCommand.Parameters.AddWithValue("@EnterPassword", EnterPassword);
            objCommand.Parameters.AddWithValue("@RetypePassword", RetypePassword);
            objCommand.Parameters.AddWithValue("@Reference", Reference);
            objCommand.Parameters.AddWithValue("@Image", Image);
            objCommand.Parameters.AddWithValue("@Flag", Flag);
            dataReader = objCommand.ExecuteReader();
            string j = "0";
            if (dataReader.Read())
            {
                j = dataReader[0].ToString();
            }

            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            dataReader.Close();
            return j;
        }
    }

    public SqlDataReader UspTblCompanyRegistrationSelectAll()
    {
        objConnection = new SqlConnection(con_str); // Connection String
        objConnection.ConnectionString = con_str;
        objConnection.Open(); // Connection Open from DB
        objCommand = new SqlCommand(); // Object of Sql Command
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "UspTblCompanyRegistrationSelectAll";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader UspTblMyStateNameListGetAll()
    {
        objConnection = new SqlConnection(con_str); // Connection String
        objConnection.ConnectionString = con_str;
        objConnection.Open(); // Connection Open from DB
        objCommand = new SqlCommand(); // Object of Sql Command
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "UspTblMyStateNameListGetAll";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader UspTblMyStateNameListGetAllByState(String Sno)
    {
        objConnection = new SqlConnection(con_str); // Connection String
        objConnection.ConnectionString = con_str;
        objConnection.Open(); // Connection Open from DB
        objCommand = new SqlCommand(); // Object of Sql Command
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "UspTblMyStateNameListGetAllByState";
        objCommand.Parameters.AddWithValue("@StateName", StateName);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader UspSelectTblMyDistrictNameList(String Sno)
    {
        objConnection = new SqlConnection(con_str); // Connection String
        objConnection.ConnectionString = con_str;
        objConnection.Open(); // Connection Open from DB
        objCommand = new SqlCommand(); // Object of Sql Command
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "UspSelectTblMyDistrictNameList";
        objCommand.Parameters.AddWithValue("@Id", Sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader UspTblCompanyRegistrationBySno(String Sno)
    {
        objConnection = new SqlConnection(con_str); // Connection String
        objConnection.ConnectionString = con_str;
        objConnection.Open(); // Connection Open from DB
        objCommand = new SqlCommand(); // Object of Sql Command
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "UspTblCompanyRegistrationBySno";
        objCommand.Parameters.AddWithValue("@Sno", Sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
}