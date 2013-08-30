<%@ Control Language="C#" AutoEventWireup="true" CodeFile="search_ctrl.ascx.cs" Inherits="controls_search_ctrl" %>

<asp:UpdatePanel ID="up_col2_row3" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
        <fieldset>
            <legend>Search</legend>
            <asp:TextBox ID="txt_search" runat="server" CssClass="textbox w_5" />
            <ajax:TextBoxWatermarkExtender ID="wm_txt_search" runat="server" TargetControlID="txt_search" WatermarkCssClass="watermark w_5 italic" WatermarkText="Enter your keyword" />
            <div class="clear"></div>
            <div style="margin-top: 2%; margin-left: 75%;">
                <asp:Button ID="btn_search" runat="server" CssClass="login_button" Text="Search" OnClick="btn_Click" />
            </div>
        </fieldset>
    </ContentTemplate>
</asp:UpdatePanel>