using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class insert_update : System.Web.UI.Page
{
    Class1 Myclass = new Class1();
    SqlDataReader objreader;
    protected void Page_Load(object sender, EventArgs e)
    {       

        if(!IsPostBack)
        {
            BindGrid();
        }
    }

    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
		try
        {
            //===== Show Grid =======//
            BindGrid();

        }
		catch (Exception ex)
		{

		}
    }

    //Bind Gridview =========//
    public void BindGrid() // MethodName 
    {
        try
        {
            GrdDataView.DataSource = Myclass.UspTblCompanyRegistrationSelectAll();
            GrdDataView.DataBind();
        }
        catch (Exception ex)
        {

        }
    }

    protected void GrdDataView_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Download")
        {
            // Get the file path from the CommandArgument
            string filePath = e.CommandArgument.ToString();

            // Trigger download of the file
            DownloadFile(filePath);


        }
    }

    private void DownloadFile(string filePath)
    {
        

    }

    protected void btnDownload_Click(object sender, EventArgs e)
    {
        string filePath = (sender as Button).CommandArgument;
        Response.ContentType = ContentType;
        Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(filePath));
        Response.Clear();
        Response.WriteFile(filePath);
        Response.End();
        Response.Close();
    }
}
