<%@ Control Language="C#" AutoEventWireup="true" CodeFile="resource_ctrl.ascx.cs" Inherits="controls_resource_ctrl" %>

<asp:UpdatePanel ID="up_col2_row3" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
        <fieldset>
            <legend>Useful Resource</legend>
            <div style="font-size: .75em;">
                <asp:Literal ID="lit_resource" runat="server" />
            </div>
        </fieldset>
    </ContentTemplate>
</asp:UpdatePanel>