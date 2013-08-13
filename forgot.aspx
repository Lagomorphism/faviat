<%@ Page Title="" Language="C#" MasterPageFile="~/masters/site.master" AutoEventWireup="true" CodeFile="forgot.aspx.cs" Inherits="forgot" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <div class="forgot">
        <asp:UpdatePanel ID="up_forgot" runat="server" UpdateMode="Always">
            <ContentTemplate>

                <asp:Panel ID="pnl_email" runat="server" Visible="true">
                    <fieldset>
                        <legend>Reset password</legend>
                        <asp:Literal ID="lit_error" runat="server" />
                        <div class="left" style="margin-right: .5em;">
                            <asp:TextBox ID="txt_forgot_password" runat="server" CssClass="textbox w_1"></asp:TextBox>
                            <ajax:TextBoxWatermarkExtender ID="wm_txt_forgot_password" runat="server" TargetControlID="txt_forgot_password" WatermarkCssClass="watermark w_1" WatermarkText="Email Address" />
                        </div>
                        <div style="margin-top: -.1em;">
                            <asp:Button ID="btn_submit" runat="server" CssClass="login_button" Text="Submit" OnClick="btn_Click" />
                        </div>
                    </fieldset>
                </asp:Panel>

                <asp:Panel ID="pnl_question" runat="server" Visible="false">
                    <fieldset>
                        <legend>Security Questions</legend>
                        <table>
                            <tbody>
                                <tr>
                                    <asp:Literal ID="lit_question" runat="server" />
                                </tr>
                                <tr>
                                    <asp:Literal ID="lit_question_answer" runat="server" />
                                </tr>
                            </tbody>
                        </table>
                    </fieldset>
                </asp:Panel>

                <asp:Panel ID="pnl_confirm" runat="server" Visible="false">

                </asp:Panel>

            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btn_submit" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
                    
    </div>
</asp:Content>

