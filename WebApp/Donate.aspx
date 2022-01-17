<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Donate.aspx.cs" Inherits="WebApp.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header>
        <div class="container">
            <h1 class="text-center my-5">Donate Blood</h1>
        </div>
    </header>
    <div class="container">
        <div class="row">

            <div class="col-md-6 col-sm-12">
                <h2 class="text-center">Blood Stock</h2>
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
            </div>

            <div class="col-md-6 col-sm-12">
                <h2 class="text-center">Donors List //TODO</h2>
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
            </div>
        </div>
    </div>

    <div class="container">
        <div class="row py-2 mb-4">

            <div class="col-md-6 col-sm-12">
                <div class="group mt-4 text-center">
                        <div>
                    <asp:Label Text="Name" runat="server"/>
                        </div>
                        <div>
                    <asp:TextBox ID="TextBoxDonateDonorName" runat="server"></asp:TextBox>
                        </div>
                    </div>
            </div>

            <div class="col-md-6 col-sm-12">
                <div class="group mt-4 text-center">
                        <div>
                    <asp:Label Text="Blood Group" runat="server"/>
                        </div>
                        <div>
                    <asp:TextBox ID="TextBoxDonateBloodGroup" runat="server"></asp:TextBox>
                        </div>
                    </div>
            </div>
        </div>

            <div class="container py-3 mb-5 text-center">
                <button id="buttonDonate" type="button" class="btn btn-danger text-center">Donate</button>
            </div>
    </div>
</asp:Content>
