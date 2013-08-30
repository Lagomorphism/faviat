<%@ Page Title="" Language="C#" MasterPageFile="~/masters/site.master" AutoEventWireup="true" CodeFile="profile.aspx.cs" Inherits="profile" %>
<%@ Register Src="~/controls/profile_ctrl.ascx" TagPrefix="pc" TagName="ProfileCtrl" %>
<%@ Register Src="~/controls/search_ctrl.ascx" TagPrefix="shc" TagName="SearchCtrl" %>
<%@ Register Src="~/controls/news_ctrl.ascx" TagPrefix="nwc" TagName="NewsCtrl" %>
<%@ Register Src="~/controls/status_ctrl.ascx" TagPrefix="sc" TagName="StatusCtrl" %>
<%@ Register Src="~/controls/resource_ctrl.ascx" TagPrefix="rsc" TagName="ResourceCtrl" %>
<%@ Register Src="~/controls/notice_ctrl.ascx" TagPrefix="nc" TagName="NoticeCtrl" %>
<%@ Register Src="~/controls/quick_link_ctrl.ascx" TagPrefix="qlc" TagName="QuickLinkCtrl" %>
<%@ Register Src="~/controls/resume_ctrl.ascx" TagPrefix="rc" TagName="ResumeCtrl" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <div class="profile">
        <h2 class="italic">My Faviat</h2>
        <table class="table_profile">
            <tbody class="tbody_profile">
                <tr class="tr_profile">
                    <td class="td_profile">
                        <asp:UpdatePanel ID="up_col1" runat="server" UpdateMode="Always">
                            <ContentTemplate>
                                <div class="row">
                                    <pc:ProfileCtrl ID="ProfileCtrl" runat="server" />
                                </div>
                                <div class="row">
                                    <shc:SearchCtrl ID="SearchCtrl" runat="server" />
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                    <td class="td_profile">
                        <asp:UpdatePanel ID="up_col2" runat="server" UpdateMode="Always">
                            <ContentTemplate>
                                <div class="row">
                                    <nwc:NewsCtrl ID="NewsCtrl" runat="server" />
                                </div>
                                <div class="row">
                                    <sc:StatusCtrl ID="StatusCtrl" runat="server" />
                                </div>
                                <div class="row">
                                    <rsc:ResourceCtrl ID="ResourceCtrl" runat="server" />
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                    <td class="td_profile">
                        <asp:UpdatePanel ID="up_col3" runat="server" UpdateMode="Always">
                            <ContentTemplate>
                                <div class="row">
                                    <nc:NoticeCtrl ID="NoticeCtrl" runat="server" />
                                </div>
                                <div class="row">
                                    <qlc:QuickLinkCtrl ID="QuickLinkCtrl" runat="server" />
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
            </tbody>
        </table>
        <table class="table_resume">
            <tbody class="tbody_resume">
                <tr class="tr_resume">
                    <td class="td_resume">
                        <asp:UpdatePanel ID="up_col4" runat="server" UpdateMode="Always">
                            <ContentTemplate>
                                <div class="row">
                                    <rc:ResumeCtrl ID="ResumeCtrl" runat="server" />
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</asp:Content>

