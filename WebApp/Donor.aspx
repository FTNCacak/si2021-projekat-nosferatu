<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Donor.aspx.cs" Inherits="WebApp.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <header>
        <div class="container">
            <h1 class="text-center my-5">Donor</h1>
        </div>
    </header>


        <div class="container my-5 text-center">
            <div class="row py-3 border border-2">
            <div class="col-md-4 col-sm-12 mb-4">
                <div class="form">

                    <div class="group mt-4">
                        <div>
                    <asp:Label Text="Name" runat="server"/>
                        </div>
                        <div>
                    <asp:TextBox ID="TextBoxDonorName" runat="server"></asp:TextBox>
                        </div>
                    </div>

                    <div class="group mt-4">
                        <div>
                    <asp:Label Text="Phone" runat="server"/>
                        </div>

                        <div>
                    <asp:TextBox ID="TextBoxDonorPhone" runat="server"></asp:TextBox>
                        </div>
                    </div>

                </div>
            </div>
            <div class="col-md-4 col-sm-12 mb-4">
                <div class="form">

                    <div class="group mt-4">
                        <div>
                            <asp:Label Text="Age" runat="server"/>
                        </div>

                        <div>
                    <asp:TextBox ID="TextBoxDonorAge" runat="server"></asp:TextBox>
                        </div>
                    
                    </div>

                    <div class="group mt-4">

                        <div>
                    <asp:Label Text="Blood Group" runat="server" />
                        </div>

                        <div>
                    <asp:dropdownlist runat="server" id="DropDownListDonorBloodGroup"> 
                            <asp:listitem text="A+" value="1"></asp:listitem>
                            <asp:listitem text="A-" value="2"></asp:listitem>
                            <asp:listitem text="AB+" value="3"></asp:listitem>
                            <asp:listitem text="AB-" value="4"></asp:listitem>
                            <asp:listitem text="B+" value="5"></asp:listitem>
                            <asp:listitem text="B-" value="6"></asp:listitem>
                            <asp:listitem text="O+" value="7"></asp:listitem>
                            <asp:listitem text="O-" value="8"></asp:listitem>
                    </asp:dropdownlist>
                        </div>

                    </div>
                </div>
            </div>
            <div class="col-md-4 col-sm-12 mb-4">
                <div class="form">

                    <div class="group mt-4">
                        <div>
                    <asp:Label Text="Gender" runat="server" />
                        </div>

                        <div>
                    <asp:dropdownlist runat="server" id="DropDownListDonorGender"> 
                            <asp:listitem text="Male" value="1"></asp:listitem>
                            <asp:listitem text="Female" value="2"></asp:listitem>
                    </asp:dropdownlist>
                        </div>
                        
                    </div>

                    <div class="group mt-4">

                        <div>
                            <asp:Label Text="Address" runat="server"/>
                        </div>

                        <div>
                            <asp:TextBox ID="TextBoxDonorAddress" runat="server"></asp:TextBox>
                        </div>
                    
                    </div>

                </div>
            </div>
            </div>

            <div class="container py-5">
                <button id="buttonDonor" type="button" class="btn btn-danger text-center">Save</button>
            </div>
        </div>

       

</asp:Content>
