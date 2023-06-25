<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddCorse.aspx.cs" Inherits="StudentManagement.AddCorse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    


<div class="col-md-4 offset-4 mt-5">

           <div class="form-group ml-5 mr-5">
              <label for="name">Corse Name</label>
                <asp:TextBox ID="TextBox1" runat="server" Class="form-control" placeholder="Corse Name" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
           </div>

           <div class="form-group ml-5 mr-5">
              <label for="city">Lecturer Name</label>
                <asp:TextBox ID="TextBox2" runat="server" Class="form-control" placeholder="Lecturer Name" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
           </div>

          <asp:Button ID="Button1" runat="server" Text="Register" class="btn btn-primary ml-5 mt-3" OnClick="Button1_Click" />


</div>

    <hr /><hr /><hr />

</asp:Content>
