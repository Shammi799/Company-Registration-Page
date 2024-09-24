using System;
using System.Data.SqlClient;
using System.IO;
using System.Web.UI.WebControls;

public partial class insert_update : System.Web.UI.Page
{
    Class1 Myclass = new Class1();
    SqlDataReader objreader,objreader1, objreader2 , objreader3, objreader4, objreader5 , objreader6, objreader7;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {

            BindCountryNameList();

            BindCategoryList();

            BindSectorList();

            BindBusinessList();

            BindEmployeesNoList();

            BindStateName();

            BindReferenceList();



            ViewState["flag"] = "I"; 

            if (Request.QueryString["Sno"]!=null)
          
            {
                Myclass.Sno = Convert.ToString(Request.QueryString["Sno"]);
                objreader = Myclass.UspTblCompanyRegistrationBySno(Myclass.Sno);
                if (objreader.Read())
                {

                    ddlstate.SelectedValue = Convert.ToString(objreader["StateId"]);
                    BindDistrictName(ddlstate.SelectedValue);

                    ddlcountry.SelectedValue = Convert.ToString(objreader["Country"]);
                    txtcompanyName.Text = Convert.ToString(objreader["CompanyName"]);
                    txtcontactPerson.Text = Convert.ToString(objreader["ContactPerson"]);
                    txtphone.Text = Convert.ToString(objreader["MobileNo"]);
                    txtemail.Text = Convert.ToString(objreader["Email"]);
                    ddlcategory.SelectedValue = Convert.ToString(objreader["Category"]);
                    ddlsector.SelectedValue = Convert.ToString(objreader["Sector"]);
                    ddlbusinessEntity.SelectedValue = Convert.ToString(objreader["BusinessEntity"]);
                    ddlemployees.SelectedValue = Convert.ToString(objreader["EmployeesNo"]);
                    txtaddress.Text = Convert.ToString(objreader["FullAddress"]);
                    ddlstate.SelectedValue = Convert.ToString(objreader["StateName"]);
                    ddldistrict.SelectedValue = Convert.ToString(objreader["DistrictId"]);
                    txtestablishedYear.Text = Convert.ToString(objreader["EstablishedYear"]);
                    txtwebsite.Text = Convert.ToString(objreader["CompanyWebsite"]);
                    txtpassword.Attributes["value"] = Convert.ToString(objreader["EnterPassword"]);
                    txtretypePassword.Attributes["value"] = Convert.ToString(objreader["RetypePassword"]);
                    ddlreference.SelectedValue = Convert.ToString(objreader["Reference"]);
                    lblfileimgfilename.Text = Convert.ToString(objreader["Image"]);

                }
                objreader.Close();

                ViewState["flag"] = "U";
            }
        }
        if(IsPostBack)
        {

        }
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        try
        {
            Myclass.Country = ddlcountry.SelectedValue;
            Myclass.CompanyName = txtcompanyName.Text;
            Myclass.ContactPerson = txtcontactPerson.Text;
            Myclass.MobileNo = txtphone.Text;
            Myclass.Email = txtemail.Text;
            Myclass.Category = ddlcategory.SelectedValue;
            Myclass.Sector = ddlsector.SelectedValue;
            Myclass.BusinessEntity = ddlbusinessEntity.SelectedValue;
            Myclass.EmployeesNo = ddlemployees.SelectedValue;
            Myclass.FullAddress = txtaddress.Text;
            Myclass.StateId = ddlstate.SelectedValue.ToString();
            Myclass.DistrictId = ddldistrict.SelectedValue.ToString();
            Myclass.StateName = ddlstate.SelectedItem.ToString();
            Myclass.DistrictName = ddldistrict.SelectedItem.ToString();
            Myclass.EstablishedYear = txtestablishedYear.Text;
            Myclass.CompanyWebsite = txtwebsite.Text;
            Myclass.EnterPassword = txtpassword.Text;
            Myclass.RetypePassword = txtretypePassword.Text;
            Myclass.Reference = ddlreference.SelectedValue;

            
        



            if (ViewState["flag"].ToString() == "I")
            {
                Myclass.Sno = "0";
                Myclass.Flag = "I";

                if (FileUpload1.PostedFile != null)
                {
                    try
                    {

                        string folderPath = Server.MapPath("~/images/");


                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }

                        // Get the uploaded file name
                        string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);

                        // Save the uploaded file to the specified folder
                        FileUpload1.SaveAs(Path.Combine(folderPath, fileName));
                        Myclass.Image = fileName;
                        //lblMessage.Text = "Image uploaded successfully!";
                    }
                    catch (Exception ex)
                    {
                        //lblMessage.Text = "Error: " + ex.Message;
                    }
                }
                else
                {
                    Myclass.Image = "";
                }

                //==== Procedure Name =======//
                Myclass.UspTblCompanyRegistrationInsertUpdate();
                Response.Redirect("~/view-and-data-bind.aspx");
            }
            if (ViewState["flag"].ToString() == "U")
            {
                Myclass.Sno = Convert.ToString(Request.QueryString["Sno"]);
                Myclass.Flag = "U";

                if (FileUpload1.PostedFile != null)
                {
                    try
                    {

                        string folderPath = Server.MapPath("~/images/");


                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }

                        // Get the uploaded file name
                        string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);

                        // Save the uploaded file to the specified folder
                        FileUpload1.SaveAs(Path.Combine(folderPath, fileName));
                        Myclass.Image = fileName;
                        //lblMessage.Text = "Image uploaded successfully!";
                    }
                    catch (Exception ex)
                    {
                        //lblMessage.Text = "Error: " + ex.Message;
                    }
                }
                else
                {
                    Myclass.Image = lblfileimgfilename.Text;
                }

                //==== Procedure Name =======//
                Myclass.UspTblCompanyRegistrationInsertUpdate();
                Response.Redirect("~/view-and-data-bind.aspx");
            }

        }
        catch (Exception ex)
        {

        }
    }

    public void BindCountryNameList()
    {
        objreader1 = Myclass.UspTblCountryNameListGetAll();
        ddlcountry.DataSource = objreader1;
        ddlcountry.DataTextField = "CountryName";
        ddlcountry.DataValueField = "CountryName";
        ddlcountry.DataBind();
        ddlcountry.Items.Insert(0, "Select Country");
        ddlcountry.Items[0].Value = "0";
        ddlcountry.SelectedIndex = 0;
        objreader1.Close();
    }

    public void BindSectorList()
    {
        objreader4 = Myclass.UspSectorNameListGetAll();
        ddlsector.DataSource = objreader4;
        ddlsector.DataTextField = "Sector";
        ddlsector.DataValueField = "Sector";
        ddlsector.DataBind();
        ddlsector.Items.Insert(0, "Select Sector");
        ddlsector.Items[0].Value = "0";
        ddlsector.SelectedIndex = 0;
        objreader4.Close();
    }


    public void BindCategoryList()
    {
        objreader3 = Myclass.UspTblCategoryListGetAll();
        ddlcategory.DataSource = objreader3;
        ddlcategory.DataTextField = "Category";
        ddlcategory.DataValueField = "Category";
        ddlcategory.DataBind();
        ddlcategory.Items.Insert(0, "Select Category");
        ddlcategory.Items[0].Value = "0";
        ddlcategory.SelectedIndex = 0;
        objreader3.Close();
    }

    public void BindBusinessList()
    {
        objreader5 = Myclass.UspTypeofBusinessListGetAll();
        ddlbusinessEntity.DataSource = objreader5;
        ddlbusinessEntity.DataTextField = "BusinessEntity";
        ddlbusinessEntity.DataValueField = "BusinessEntity";
        ddlbusinessEntity.DataBind();
        ddlbusinessEntity.Items.Insert(0, "Select BusinessList");
        ddlbusinessEntity.Items[0].Value = "0";
        ddlbusinessEntity.SelectedIndex = 0;
        objreader5.Close();
    }

    public void BindEmployeesNoList()
    {
        objreader6 = Myclass.UspEmployeesNoListGetAll();
        ddlemployees.DataSource = objreader6;
        ddlemployees.DataTextField = "EmployeesNo";
        ddlemployees.DataValueField = "EmployeesNo";
        ddlemployees.DataBind();
        ddlemployees.Items.Insert(0, "Select EmployeesNo");
        ddlemployees.Items[0].Value = "0";
        ddlemployees.SelectedIndex = 0;
        objreader6.Close();
    }

    public void BindReferenceList()
    {
        objreader7 = Myclass.UspReferenceGetAll();
        ddlreference.DataSource = objreader7;
        ddlreference.DataTextField = "Reference";
        ddlreference.DataValueField = "Reference";
        ddlreference.DataBind();
        ddlreference.Items.Insert(0, "Select Reference");
        ddlreference.Items[0].Value = "0";
        ddlreference.SelectedIndex = 0;
        objreader7.Close();
    }

    public void BindStateName()
    {
        objreader = Myclass.UspTblMyStateNameListGetAll();
        ddlstate.DataSource = objreader;
        ddlstate.DataTextField = "StateName";
        ddlstate.DataValueField = "Sno";
        ddlstate.DataBind();
        ddlstate.Items.Insert(0, "Select State");
        ddlstate.Items[0].Value = "0";
        ddlstate.SelectedIndex = 0;
        objreader.Close();
    }


    public void BindDistrictName(String Id)
    {
      
        objreader1 = Myclass.UspSelectTblMyDistrictNameList(Id);
        ddldistrict.DataSource = objreader1;
        ddldistrict.DataTextField = "DistrictName";
        ddldistrict.DataValueField = "Sno";
        ddldistrict.DataBind();
        ddldistrict.Items.Insert(0, "Select District");
        ddldistrict.Items[0].Value = "0";
        ddldistrict.SelectedIndex = 0;
        objreader1.Close();
    }

    protected void ddlstate_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindDistrictName(ddlstate.SelectedValue);
    }

}