<%@ Page Title="" Language="C#" MasterPageFile="~/masters/site.master" AutoEventWireup="true" CodeFile="signup.aspx.cs" Inherits="signup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <div class="signup">
        <fieldset>
            <legend>Be our family</legend>
            <asp:Panel ID="pnl_step1" runat="server">

                <table>
                    <tbody>
                        <tr>
                            <asp:Literal ID="lit_error" runat="server" />
                            <asp:ValidationSummary ID="val_summary_step1" runat="server" ValidationGroup="val_step1" CssClass="val_summary_style" />
                        </tr>
                    </tbody>
                </table>

                <table class="tbl_signup left">
                    <tbody>
                        <tr>
                            <td class="bold italic">
                                <span class="required">*</span>
                                First Name:
                            </td>
                            <td>
                                <asp:TextBox ID="txt_fname" runat="server" CssClass="textbox w_4"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="bold italic">
                                <span class="required">*</span>
                                Last Name:
                            </td>
                            <td>
                                <asp:TextBox ID="txt_lname" runat="server" CssClass="textbox w_4"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="bold italic">
                                <span class="required">*</span>
                                Email Address:
                            </td>
                            <td>
                                <asp:TextBox ID="txt_email" runat="server" CssClass="textbox w_4"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="bold italic">
                                <span class="required">*</span>
                                Password:
                            </td>
                            <td>
                                <asp:TextBox ID="txt_password" runat="server" CssClass="textbox w_4" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="bold italic">
                                <span class="required">*</span>
                                Confirm Password:
                            </td>
                            <td>
                                <asp:Textbox ID="txt_confirm_password" runat="server" CssClass="textbox w_4" TextMode="Password"></asp:Textbox>
                            </td>
                        </tr>
                    </tbody>
                </table>

                <table class="f_3 bold jump_1">
                    <tbody>
                        <tr>
                            <td>
                                Note: Fields marked by an <span class="required">*</span> are required.
                            </td>
                        </tr>
                    </tbody>
                </table>

            </asp:Panel>
            
        </fieldset>
    </div>
</asp:Content>

