<%@ Control Language="C#" AutoEventWireup="true" CodeFile="status_ctrl.ascx.cs" Inherits="controls_status_ctrl" %>

<asp:UpdatePanel ID="up_col2_row2" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
        <fieldset>
            <legend>Status</legend>
            <div style="font-size: .75em;">
                <asp:Literal ID="lit_status" runat="server" />
            </div>
            <div class="clear"></div>
            <div style="margin-top: 2%; margin-left: 59.5%">
                <asp:Button ID="btn_status" runat="server" CssClass="login_button" Text="Status Detail" OnClick="btn_Click" />
            </div>
        </fieldset>
    </ContentTemplate>
</asp:UpdatePanel>