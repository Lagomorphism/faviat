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
                            <asp:ValidationSummary ID="val_summary_join" runat="server" ValidationGroup="val_join" CssClass="val_summary_style" />
                        </tr>
                    </tbody>
                </table>

                <table class="tbl_signup left">
                    <tbody>
                        <tr>
                            <td class="bold italic text_right">
                                <span class="required">*</span>
                                First Name:
                            </td>
                            <td>
                                <asp:TextBox ID="txt_fname" runat="server" CssClass="textbox w_1"></asp:TextBox>
                                <ajax:TextBoxWatermarkExtender ID="wm_txt_fname" runat="server" TargetControlID="txt_fname" WatermarkCssClass="watermark w_1" WatermarkText="First Name" />
                                <asp:RequiredFieldValidator ID="req_txt_fname" runat="server" ControlToValidate="txt_fname" SetFocusOnError="true" Display="None" ErrorMessage="Please enter your first name" ValidationGroup="val_join" />
                            </td>
                        </tr>
                        <tr>
                            <td class="bold italic text_right">
                                <span class="required">*</span>
                                Last Name:
                            </td>
                            <td>
                                <asp:TextBox ID="txt_lname" runat="server" CssClass="textbox w_1"></asp:TextBox>
                                <ajax:TextBoxWatermarkExtender ID="wm_txt_lname" runat="server" TargetControlID="txt_lname" WatermarkCssClass="watermark w_1" WatermarkText="Last Name" />
                                <asp:RequiredFieldValidator ID="req_txt_lname" runat="server" ControlToValidate="txt_lname" SetFocusOnError="true" Display="None" ErrorMessage="Please enter your last name" ValidationGroup="val_join" />
                            </td>
                        </tr>
                        <tr>
                            <td class="bold italic text_right">
                                <span class="required">*</span>
                                Email Address:
                            </td>
                            <td>
                                <asp:TextBox ID="txt_email" runat="server" CssClass="textbox w_4"></asp:TextBox>
                                <ajax:TextBoxWatermarkExtender ID="wm_txt_email" runat="server" TargetControlID="txt_email" WatermarkCssClass="watermark w_4" WatermarkText="Email" />
                                <asp:RequiredFieldValidator ID="req_txt_email" runat="server" ControlToValidate="txt_email" SetFocusOnError="true" Display="None" ErrorMessage="Please enter your email address" ValidationGroup="val_join" />
                            </td>
                        </tr>
                        <tr>
                            <td class="bold italic text_right">
                                <span class="required">*</span>
                                Password:
                            </td>
                            <td>
                                <asp:TextBox ID="txt_password" runat="server" CssClass="textbox w_4" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="req_txt_password" runat="server" ControlToValidate="txt_password" SetFocusOnError="true" Display="None" ErrorMessage="Please enter your password" ValidationGroup="val_join" />
                            </td>
                            <td>
                                <ajax:PasswordStrength ID="ps_password" runat="server" DisplayPosition="RightSide" StrengthIndicatorType="BarIndicator" PreferredPasswordLength="10" PrefixText="Strength:" MinimumNumericCharacters="1" MinimumSymbolCharacters="1" RequiresUpperAndLowerCaseCharacters="true" TargetControlID="txt_password" TextStrengthDescriptions="VeryPoor; Weak; Average; Excellent; Strong;" CalculationWeightings="25;25;15;35" BarBorderCssClass="BarBorder" BarIndicatorCssClass="BarIndicator" HelpStatusLabelID="lbl_status" HelpHandlePosition="AboveLeft" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                <asp:Label ID="lbl_status" runat="server" CssClass="italic bold f_3 required"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="bold italic text_right">
                                <span class="required">*</span>
                                Confirm Password:
                            </td>
                            <td>
                                <asp:Textbox ID="txt_confirm_password" runat="server" CssClass="textbox w_4" TextMode="Password"></asp:Textbox>
                                <asp:RequiredFieldValidator ID="req_txt_confirm_password" runat="server" ControlToValidate="txt_confirm_password" SetFocusOnError="true" Display="None" ErrorMessage="Please re-enter your password" ValidationGroup="val_join" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                            <td>
                                <asp:CompareValidator ID="comp_txt_confirm_password" runat="server" ControlToCompare="txt_password" ControlToValidate="txt_confirm_password" ErrorMessage="Your password does not match" Display="Dynamic" CssClass="italic bold f_3 required" />
                            </td>
                        </tr>
                        <tr>
                            <td class="bold italic text_right">
                                <span class="required">*</span>
                                Account Type:
                            </td>
                            <td>
                                <asp:DropDownList ID="ddl_account_type" runat="server" CssClass="dropdown"></asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                            <td>
                                <asp:Button ID="btn_join" runat="server" CssClass="login_button" Text="Join" OnClick="btn_Click" ValidationGroup="val_join" />
                                <asp:Button ID="btn_cancel" runat="server" CssClass="login_button" Text="Cancel" OnClick="btn_Click" />
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

