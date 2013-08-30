<%@ Control Language="C#" AutoEventWireup="true" CodeFile="notice_ctrl.ascx.cs" Inherits="controls_notice_ctrl" %>

<asp:UpdatePanel ID="up_col3_row1" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
        <fieldset>
            <legend>Notice / Reminder</legend>
            <div style="font-size: .75em;">
                <asp:Literal ID="lit_notice" runat="server" />
            </div>
        </fieldset>
    </ContentTemplate>
</asp:UpdatePanel>