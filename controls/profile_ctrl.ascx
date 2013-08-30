<%@ Control Language="C#" AutoEventWireup="true" CodeFile="profile_ctrl.ascx.cs" Inherits="controls_profile_ctrl" %>

<asp:UpdatePanel ID="up_col1_row1" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
        <fieldset>
            <legend>Profile</legend>
            <div class="profile_img">
                <img src="#" width="80" height="90" />
            </div>
            <div class="profile_desc">
                <table class="table_profile_desc">
                    <tbody class="tbody_profile_desc">
                        <tr class="tr_profile_desc">
                            <td class="td_left_profile_desc">
                                <b>Name:</b>
                            </td>
                            <td class="td_right_profile_desc">
                                <asp:Label ID="label_name" runat="server" />
                            </td>
                        </tr>
                        <tr class="tr_profile_desc">
                            <td class="td_left_profile_desc">
                                <b>Country:</b>
                            </td>
                            <td class="td_right_profile_desc">
                                <asp:Label ID="label_country" runat="server" />
                            </td>
                        </tr>
                        <tr class="tr_profile_desc">
                            <td class="td_left_profile_desc">
                                <b>Type:</b>
                            </td>
                            <td class="td_right_profile_desc">
                                <asp:Label ID="label_account_type" runat="server" />
                            </td>
                        </tr>
                        <tr class="tr_profile_desc">
                            <td class="td_left_profile_desc">
                                <b>Age:</b>
                            </td>
                            <td class="td_right_profile_desc">
                                <asp:Label ID="label_age" runat="server" />
                            </td>
                        </tr>
                        <tr class="tr_profile_desc">
                            <td class="td_left_profile_desc">
                                <b>Sex:</b>
                            </td>
                            <td class="td_right_profile_desc">
                                <asp:Label ID="label_sex" runat="server" />
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
            <div class="clear"></div>
            <div class="profile_complete">
                <div style="border: 3px solid #808080; background-color: #008000; width: 98%;">
                    <div style="background-color: #1C3F01; color: white; font-weight: bold; font-size: .8em; width: 65%; padding: 2%; ">
                        Profile Complete Bar Here
                    </div>
                </div>
            </div>
            <div style="margin-top: 2%; margin-left: 43%;">
                <asp:Button ID="btn_profile" runat="server" CssClass="login_button" Text="View & Update Info" OnClick="btn_Click" />
            </div>
        </fieldset>
    </ContentTemplate>
</asp:UpdatePanel>