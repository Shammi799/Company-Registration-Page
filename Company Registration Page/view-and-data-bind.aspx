<%@ Page Language="C#" AutoEventWireup="true" CodeFile="view-and-data-bind.aspx.cs" Inherits="insert_update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>:: View in Gridview ::</title>
<link href="css/HomeBootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="css/ViewStyleSheet.css" rel="stylesheet" />

    <!-- Google Fonts -->
<link rel="preconnect" href="https://fonts.googleapis.com" />
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
<link href="https://fonts.googleapis.com/css2?family=Inter:ital,opsz,wght@0,14..32,100..900;1,14..32,100..900&display=swap" rel="stylesheet" />
<link href="https://fonts.googleapis.com/css2?family=Figtree:ital,wght@0,300..900;1,300..900&display=swap" rel="stylesheet" />

</head>
<body>
<form id="form1" runat="server">
<div>

<div class="container">

<div class="my-form-header"> View Details : </div>
<div class="my-container">
<div class="row">
<div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
<div style="overflow-x:scroll"> 
<asp:GridView runat="server" ID="GrdDataView" AutoGenerateColumns="false"  OnRowCommand="GrdDataView_RowCommand" ShowFooter="false" CssClass="mGrid"
ShowHeaderWhenEmpty="true" EmptyDataText="No Data Found.">
<Columns>

<asp:TemplateField HeaderText="Edit">
<ItemTemplate>
<asp:HyperLink runat="server" ID="HypEdit" NavigateUrl='<%# Eval("Sno", "~/insert-update-of-company-page.aspx?Sno={0}") %>' Text="Click To Edit" style="color:#0094ff"></asp:HyperLink>
</ItemTemplate>
</asp:TemplateField>

<asp:TemplateField HeaderText="Sno">
<ItemTemplate>
<asp:Label runat="server" ID="lblSno" Text='<%#Eval("Sno")%>'></asp:Label>
</ItemTemplate>
</asp:TemplateField>

<asp:BoundField DataField="Sno" HeaderText="Sno" Visible="false" />
<asp:BoundField DataField="Country" HeaderText="Country" />
<asp:BoundField DataField="CompanyName" HeaderText="CompanyName" />
<asp:BoundField DataField="ContactPerson" HeaderText="ContactPerson" />
<asp:BoundField DataField="MobileNo" HeaderText="MobileNo" />
<asp:BoundField DataField="Email" HeaderText="Email" />
<asp:BoundField DataField="Category" HeaderText="Category" />
<asp:BoundField DataField="Sector" HeaderText="Sector" />
<asp:BoundField DataField="BusinessEntity" HeaderText="BusinessEntity" />
<asp:BoundField DataField="EmployeesNo" HeaderText="EmployeesNo" />
<asp:BoundField DataField="FullAddress" HeaderText="FullAddress" />
<asp:BoundField DataField="StateName" HeaderText="StateName" />
  
<asp:BoundField DataField="DistrictName" HeaderText="DistrictName" />

<asp:BoundField DataField="EstablishedYear" HeaderText="EstablishedYear" />
<asp:BoundField DataField="CompanyWebsite" HeaderText="CompanyWebsite" />
<asp:BoundField DataField="EnterPassword" HeaderText="EnterPassword" />
<asp:BoundField DataField="RetypePassword" HeaderText="RetypePassword" />
<asp:BoundField DataField="Reference" HeaderText="Reference" />
<asp:BoundField DataField="Image" HeaderText="Image" />


<asp:TemplateField HeaderText="Download">
<ItemTemplate>
      
<asp:Button  ID="btnDownload" runat="server" Text="Download"  CommandArgument='<%#"~/images/"+Eval("Image") %>' OnClick="btnDownload_Click" />
</ItemTemplate>
</asp:TemplateField>
            
<asp:BoundField DataField="CreatedOn" HeaderText="Registration Date" />

</Columns>
</asp:GridView>
    </div>

</div>
</div>

</div>
</div>

</div>

</form>
</body>
</html>
