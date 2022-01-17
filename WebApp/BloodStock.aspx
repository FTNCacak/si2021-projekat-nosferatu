<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BloodStock.aspx.cs" Inherits="WebApp.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header>
        <div class="container">
            <h1 class="text-center my-5">Blood Stock</h1>
        </div>
    </header>

    
    <div class="container">
        <div class="px-5">
            <table class="table py-3">
              <thead>
                <tr class="bg-danger text-white">
                  <th scope="col">Blood group</th>
                  <th scope="col">Stock</th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <th scope="row">A+</th>
                  <td></td>
                </tr>
                <tr>
                  <th scope="row">A-</th>
                  <td></td>
                </tr>
                <tr>
                  <th scope="row">AB+</th>
                  <td></td>
                </tr>
                <tr>
                  <th scope="row">AB-</th>
                  <td></td>
                </tr>
                <tr>
                  <th scope="row">B+</th>
                  <td></td>
                </tr>
                <tr>
                  <th scope="row">B-</th>
                  <td></td>
                </tr> 
                <tr>
                  <th scope="row">O+</th>
                  <td></td>
                </tr> 
                <tr>
                  <th scope="row">O-</th>
                  <td></td>
                </tr>          
              </tbody>
            </table>
        </div>
    </div>

</asp:Content>
