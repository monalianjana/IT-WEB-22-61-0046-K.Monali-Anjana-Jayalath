<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="StudentManagement.AddStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
<div class="container-fluid">


            <div class="col-md-6 offset-3 mt-5">

                

                <div class="form-group ml-5 mr-5">
                   <label for="name">Student Name</label>
                    <asp:TextBox ID="TextBox2" runat="server" Class="form-control" placeholder="Student Name" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                </div>

                <div class="form-group ml-5 mr-5">
                   <label for="city">City</label>
                    <asp:TextBox ID="TextBox3" runat="server" Class="form-control" placeholder="City" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
                </div>

                <div class="form-group ml-5 mr-5">
                   <label for="city">Corse ID</label>
                    <asp:TextBox ID="TextBox4" runat="server" Class="form-control" placeholder="1-4 (SELECT THE CORSE ID IN THE TABLE)" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
                </div>

                <asp:Button ID="Button1" runat="server" Text="Register" class="btn btn-primary ml-5 mt-3" OnClick="Button1_Click " />

             </div>


</div>
        

         <table class="table table-striped mt-5">
          <thead class="thead-dark">
            <tr>
              <th scope="col">Corse Name</th>
              <th scope="col">Corse ID</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td>Web Development</td>
              <td>1</td>
            </tr>
            <tr>
              <td>Graphic Design</td>
              <td>2</td>
            </tr>
              <tr>
              <td>Mobile App Development</td>
              <td>3</td>
            </tr>
              <tr>
              <td>Java</td>
              <td>4</td>
            </tr>
          </tbody>
        </table>

<hr /><hr /><hr />

</asp:Content>
