<%@ Page Title="" Language="C#" MasterPageFile="~/masters/site.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <div class="login">
        <fieldset>
            <legend>Member Login</legend>
            <table>
                <tbody>
                    <asp:Literal ID="lit_error" runat="server" />
                    <asp:ValidationSummary ID="val_login_summary" runat="server" ValidationGroup="val_login" CssClass="val_summary_style" />
                </tbody>
            </table>
            <table>
                <tbody>
                    <tr>
                        <td>
                            <asp:TextBox ID="txt_username" runat="server" CssClass="textbox w_1"></asp:TextBox>
                            <ajax:TextBoxWatermarkExtender ID="wm_txt_username" runat="server" TargetControlID="txt_username" WatermarkCssClass="watermark w_1" WatermarkText="Email Address" />
                            <asp:RequiredFieldValidator ID="req_txt_username" runat="server" ControlToValidate="txt_username" SetFocusOnError="true" Display="None" ErrorMessage="Please enter your email address" ValidationGroup="val_login" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="jump_2"></div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txt_password" runat="server" CssClass="textbox w_1"></asp:TextBox>
                            <ajax:TextBoxWatermarkExtender ID="wx_txt_password" runat="server" TargetControlID="txt_password" WatermarkCssClass="watermark w_1" WatermarkText="Password" />
                            <asp:RequiredFieldValidator ID="req_txt_password" runat="server" ControlToValidate="txt_password" SetFocusOnError="true" Display="None" ErrorMessage="Please enter your password" ValidationGroup="val_login" />
                        </td>
                        <td>
                            <asp:Button ID="btn_login" runat="server" CssClass="login_button" Text="Login" OnClick="btn_Click" ValidationGroup="val_login" />
                        </td>
                    </tr>
                </tbody>
            </table>
            <table>
                <tbody>
                    <tr>
                        <td>
                            <asp:Button ID="btn_forget_password" runat="server" CssClass="link_button" Text="Forgot Password?" OnClick="btn_Click" />
                        </td>
                    </tr>
                </tbody>
            </table>
        </fieldset>
    </div>
</asp:Content>

