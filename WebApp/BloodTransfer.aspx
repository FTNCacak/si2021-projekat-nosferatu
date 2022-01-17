<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BloodTransfer.aspx.cs" Inherits="WebApp.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header>
        <div class="container">
            <h1 class="text-center my-5">Blood Transfer</h1>
        </div>
    </header>


        <div class="container my-5 text-center">
            <div class="row py-3 border border-2">
            <div class="col-md-4 col-sm-12 mb-4">
                <div class="form">

                    <div class="group mt-4">
                        <div>
                    <asp:Label Text="Patient ID" runat="server" />
                        </div>

                        <div>
                    <asp:dropdownlist runat="server" id="DropDownListPatientId"> 
                            <asp:listitem text="TODO" value="1"></asp:listitem>
                            <asp:listitem text="TODO" value="2"></asp:listitem>
                    </asp:dropdownlist>
                        </div>

                    </div>

                </div>
            </div>
            <div class="col-md-4 col-sm-12 mb-4">
                <div class="form">

                    <div class="group mt-4">
                        <div>
                    <asp:Label Text="PatientName" runat="server"/>
                        </div>

                        <div>
                    <asp:TextBox ID="TextBoxTransferPatientName" runat="server"></asp:TextBox>
                        </div>
                    </div>


                </div>
            </div>
            <div class="col-md-4 col-sm-12 mb-4">
                <div class="form">


                    <div class="group mt-4">
                        <div>
                    <asp:Label Text="Blood Group" runat="server"/>
                        </div>

                        <div>
                    <asp:TextBox ID="TextBoxTransferBloodGroup" runat="server"></asp:TextBox>
                        </div>
                    </div>

                </div>
            </div>
            </div>

            <div class="container py-5">
                <button id="buttonPatient" type="button" class="btn btn-danger text-center">Transfer</button>
            </div>
        </div>

</asp:Content>
