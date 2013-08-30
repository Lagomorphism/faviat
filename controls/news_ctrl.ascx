<%@ Control Language="C#" AutoEventWireup="true" CodeFile="news_ctrl.ascx.cs" Inherits="controls_news_ctrl" %>

<asp:UpdatePanel ID="up_col2_row1" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
        <fieldset>
            <legend>News</legend>
            <div style="font-size: .75em;">
                <asp:Literal ID="lit_news" runat="server" />
            </div>
            <div class="clear"></div>
            <div style="margin-top: 2%; margin-left: 57%">
                <asp:Button ID="btn_news" runat="server" CssClass="login_button" Text="View All News" OnClick="btn_Click" />
            </div>
        </fieldset>
    </ContentTemplate>
</asp:UpdatePanel>