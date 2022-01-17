<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewDonors.aspx.cs" Inherits="WebApp.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header>
        <div class="container">
            <h1 class="text-center my-5">Donor List</h1>
        </div>
    </header>
    
    <div class="container">
    <table class="table py-3">
      <thead>
        <tr class="bg-danger text-white">
          <th scope="col">Num</th>
          <th scope="col">Name</th>
          <th scope="col">Age</th>
          <th scope="col">Phone</th>
          <th scope="col">Gender</th>
          <th scope="col">Blood Group</th>
          <th scope="col">Address</th>
        </tr>
      </thead>
      <tbody>
    
      </tbody>
    </table>
    </div>

</asp:Content>
