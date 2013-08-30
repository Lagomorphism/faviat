<%@ Control Language="C#" AutoEventWireup="true" CodeFile="quick_link_ctrl.ascx.cs" Inherits="controls_quick_link_ctrl" %>

<asp:UpdatePanel ID="up_col3_row2" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
        <fieldset>
            <legend>Quick Link</legend>
            <div class="text_center">
                <p>
                    <asp:Button ID="btn_register_question" runat="server" CssClass="login_button" Text="Register Your Question" OnClick="btn_Click" />
                </p>
                <p>
                    <asp:Button ID="btn_look_job" runat="server" CssClass="login_button" Text="Look for Job" OnClick="btn_Click" />
                </p>
                <p>
                    <asp:Button ID="btn_search_question" runat="server" CssClass="login_button" Text="Search Questions" OnClick="btn_Click" />
                </p>
                <p>
                    <asp:Button ID="btn_share_info" runat="server" CssClass="login_button" Text="Share your Interview" OnClick="btn_Click" />
                </p>
                <p>
                    <asp:Button ID="btn_rating_company" runat="server" CssClass="login_button" Text="Rating Company" OnClick="btn_Click" />
                </p>
            </div>
        </fieldset>
    </ContentTemplate>
</asp:UpdatePanel>