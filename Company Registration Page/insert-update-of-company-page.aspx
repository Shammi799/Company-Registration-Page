<%@ Page Language="C#" AutoEventWireup="true" CodeFile="insert-update-of-company-page.aspx.cs" Inherits="insert_update" %>

<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8" />
<meta name="viewport" content="width=device-width, initial-scale=1.0" />
<title>Company Registration</title>
<link href="css/StyleSheet.css" rel="stylesheet" />
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://ajax.aspnetcdn.com/ajax/jquery.validate/1.19.3/jquery.validate.min.js"></script>
<script src="scripts/script.js"></script>
</head>
<body>
<div class="container">
<header>
<h1>Company Registration</h1>
</header>

<section class="registration-section">
<form id="companyRegistrationForm" runat="server" enctype="multipart/form-data">
<div class="form-group">
<label for="ddlcountry">Country:</label>
<asp:DropDownList ID="ddlcountry" runat="server" CssClass="form-control">
<asp:ListItem Text="Select Country" Value="0" />   
</asp:DropDownList>
<asp:RequiredFieldValidator ID="RequiredCountryValidator" runat="server" 
ControlToValidate="ddlcountry"
InitialValue="0"
ErrorMessage="Please select a country."
CssClass="text-danger"
        
Display="Dynamic" ForeColor="Red">
</asp:RequiredFieldValidator>
</div>

<div class="form-group">
<label for="txtcompanyName">Company Name:</label>
<asp:TextBox ID="txtcompanyName" runat="server" CssClass="form-control" placeholder="Enter company name"></asp:TextBox>
<asp:RequiredFieldValidator runat="server" ControlToValidate="txtcompanyName" ErrorMessage="Company Name is required." CssClass="text-danger" ForeColor="Red" Display="Dynamic">  </asp:RequiredFieldValidator>
</div>

<div class="form-group">
<label for="txtcontactPerson">Contact Person:</label>
<asp:TextBox ID="txtcontactPerson" runat="server" CssClass="form-control" placeholder="Enter contact person's name"></asp:TextBox>
                     
<asp:RequiredFieldValidator runat="server" ControlToValidate="txtcontactPerson" ErrorMessage="Contact Person is required." CssClass="text-danger" ForeColor="Red" Display="Dynamic">  </asp:RequiredFieldValidator>
</div>

<div class="form-group">
<label for="txtphone">Mobile/Phone No:</label>
<asp:TextBox ID="txtphone" runat="server" CssClass="form-control" placeholder="Enter phone number"></asp:TextBox>
<asp:RequiredFieldValidator runat="server" ControlToValidate="txtphone" ErrorMessage="Mobile number is required." CssClass="text-danger" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
<asp:RegularExpressionValidator runat="server" ControlToValidate="txtphone" ErrorMessage="Please enter a valid 10-digit mobile number." ValidationExpression="^\d{10}$" CssClass="text-danger" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
</div>

<div class="form-group">
<label for="txtemail">Official Email ID:</label>
<asp:TextBox ID="txtemail" runat="server" CssClass="form-control" AutoCompleteType="Email"  placeholder="Enter official email"></asp:TextBox>
<asp:RequiredFieldValidator runat="server" ID="rfvEmail" ControlToValidate="txtemail" ErrorMessage="Email is required" CssClass="error" ForeColor="Red"></asp:RequiredFieldValidator>
<asp:RegularExpressionValidator runat="server" ID="revEmail" ControlToValidate="txtemail" ErrorMessage="Invalid email format" ForeColor="Red" CssClass="error" ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$"></asp:RegularExpressionValidator>
</div>

<div class="form-group">
<label for="ddlcategory">Category:</label>
<asp:DropDownList ID="ddlcategory" runat="server" CssClass="form-control">
<asp:ListItem Text="Select Category" Value="0" />                     
</asp:DropDownList>
<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
ControlToValidate="ddlcategory"
InitialValue="0"
ErrorMessage="Please select a Category."
CssClass="text-danger"
        
Display="Dynamic" ForeColor="Red">
</asp:RequiredFieldValidator>
</div>

<div class="form-group">
<label for="ddlsector">Sector:</label>
<asp:DropDownList ID="ddlsector" runat="server" CssClass="form-control">
<asp:ListItem Text="Select Sector" Value="0" />  
</asp:DropDownList>
<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
ControlToValidate="ddlsector"
InitialValue="0"
ErrorMessage="Please select a Sector."
CssClass="text-danger"
        
Display="Dynamic" ForeColor="Red">
</asp:RequiredFieldValidator>
</div>

<div class="form-group">
<label for="ddlbusinessEntity">Type of Business Entity:</label>
<asp:DropDownList ID="ddlbusinessEntity" runat="server" CssClass="form-control">
<asp:ListItem Text="Select Business Entity" Value="0" />  
                        
</asp:DropDownList>
<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
ControlToValidate="ddlbusinessEntity"
InitialValue="0"
ErrorMessage="Please select Business Entity."
CssClass="text-danger"
        
Display="Dynamic" ForeColor="Red">
</asp:RequiredFieldValidator>

</div>

<div class="form-group">
<label for="ddlemployees">No. of Employees:</label>
<asp:DropDownList ID="ddlemployees" runat="server" CssClass="form-control">
<asp:ListItem Text="Select No Of Employees" Value="0" />  
                        
</asp:DropDownList>
<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
ControlToValidate="ddlemployees"
InitialValue="0"
ErrorMessage="Please select a No of Employees."
CssClass="text-danger"
        
Display="Dynamic" ForeColor="Red">
</asp:RequiredFieldValidator>
</div>

<div class="form-group">
<label for="txtaddress">Full Address:</label>
<asp:TextBox ID="txtaddress" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="3" placeholder="Enter company address"></asp:TextBox>
<asp:RequiredFieldValidator runat="server" ControlToValidate="txtaddress" ErrorMessage="Full Address is required." CssClass="text-danger" ForeColor="Red" Display="Dynamic">  </asp:RequiredFieldValidator>
</div>

<div class="form-group">
<label for="ddlstate">State Name:</label>
<asp:DropDownList ID="ddlstate" runat="server" OnSelectedIndexChanged="ddlstate_SelectedIndexChanged" AutoPostBack="true" CssClass="form-control">
<asp:ListItem Text="Select State Name" Value="0" /> 
</asp:DropDownList>
<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
ControlToValidate="ddlstate"
InitialValue="0"
ErrorMessage="Please select State."
CssClass="text-danger"
        
Display="Dynamic" ForeColor="Red">
</asp:RequiredFieldValidator>
</div>

<div class="form-group">
<label for="ddldistrict">District:</label>
<asp:DropDownList ID="ddldistrict" runat="server" CssClass="form-control">
<asp:ListItem Text="Select District Name" Value="0" /> 
</asp:DropDownList>
<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
ControlToValidate="ddldistrict"
InitialValue="0"
ErrorMessage="Please select District."
CssClass="text-danger"
        
Display="Dynamic" ForeColor="Red">
</asp:RequiredFieldValidator>
</div>

<div class="form-group">
<label for="txtestablishedYear">Established Year:</label>
<asp:TextBox ID="txtestablishedYear" runat="server" CssClass="form-control" placeholder="Enter established year"></asp:TextBox>
<asp:RequiredFieldValidator runat="server" ControlToValidate="txtestablishedYear" ErrorMessage="Year is required." CssClass="text-danger" ForeColor="Red" Display="Dynamic">  </asp:RequiredFieldValidator>
                    
</div>

            

<div class="form-group">
<label for="txtwebsite">Company Website:</label>
<asp:TextBox ID="txtwebsite" runat="server" CssClass="form-control" placeholder="Enter company website"></asp:TextBox>
<asp:RequiredFieldValidator runat="server" ControlToValidate="txtwebsite" ErrorMessage="Website is required." CssClass="text-danger" ForeColor="Red" Display="Dynamic">  </asp:RequiredFieldValidator>
                    
</div>

<div class="form-group">
<label for="txtpassword">Password:</label>
<asp:TextBox ID="txtpassword" runat="server" CssClass="form-control" TextMode="Password" placeholder="Enter password"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
ControlToValidate="txtpassword" 
ErrorMessage="Password is required" 
CssClass="text-danger"
Display="Dynamic" ForeColor="Red">
</asp:RequiredFieldValidator>


<asp:RegularExpressionValidator ID="PasswordValidator" runat="server" 
ControlToValidate="txtpassword"
ErrorMessage="Password must be at least 8 characters, with 1 uppercase, 1 lowercase, 1 digit, and 1 special character."
ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$" 
CssClass="text-danger"
Display="Dynamic" ForeColor="Red">
</asp:RegularExpressionValidator>
</div>

<div class="form-group">
<label for="txtretypePassword">Retype Password:</label>
<asp:TextBox ID="txtretypePassword" runat="server" CssClass="form-control" TextMode="Password" placeholder="Retype password"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
ControlToValidate="txtretypePassword" 
ErrorMessage="Check Your Re-Password" 
CssClass="text-danger"
Display="Dynamic" ForeColor="Red">
</asp:RequiredFieldValidator>


<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
ControlToValidate="txtretypePassword"
ErrorMessage="Password must be at least 8 characters, with 1 uppercase, 1 lowercase, 1 digit, and 1 special character."
ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$" 
CssClass="text-danger"
Display="Dynamic" ForeColor="Red">
</asp:RegularExpressionValidator>
</div>

<div class="form-group">
<label for="ddlreference">Reference:</label>
<asp:DropDownList ID="ddlreference" runat="server" CssClass="form-control">
<asp:ListItem Text="Select Reference" Value="0" /> 
                       
</asp:DropDownList>
<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
ControlToValidate="ddlreference"
InitialValue="0"
ErrorMessage="Please select Reference."
CssClass="text-danger"
        
Display="Dynamic" ForeColor="Red">
</asp:RequiredFieldValidator>
</div>

<div class="form-group">
<label for="FileUpload1">Image:</label>
<asp:FileUpload ID="FileUpload1" runat="server"   CssClass="form-control">
    
         
</asp:FileUpload>
</div>
    <asp:Label runat="server" ID="lblfileimgfilename" Visible="false">

    </asp:Label>
                   

<div class="form-group">
<label>
<asp:CheckBox ID="declaration" runat="server"  /> 
I hereby declare that all the details provided are accurate.
</label>
</div>

<div class="form-group">
<asp:Button ID="submitButton" runat="server" Text="Submit" CssClass="btn-submit" OnClick="SubmitButton_Click" />
</div>
</form>
</section>

<footer>
<p>© 2024 Shammi Rai. All Rights Reserved.</p>
</footer>
</div>
</body>
</html>

