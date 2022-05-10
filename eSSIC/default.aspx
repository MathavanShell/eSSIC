<%@ Page Title="" Language="C#" MasterPageFile="~/template/Default.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="eSSIC.Default" %>

<%@ MasterType VirtualPath="~/template/Default.Master" %>

<asp:Content ID="headerSection" ContentPlaceHolderID="HeaderContent" runat="server"></asp:Content>
<asp:Content ID="mainSection" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
        <!-- 'Request info section -->
        <asp:UpdatePanel ID="reqPanelUP" runat="server">
            <ContentTemplate>
                <asp:Panel ID="topInfo" runat="server" Height="50" Style="position: relative">
                </asp:Panel>
                <asp:Panel ID="mosInfo" runat="server" Style="position: relative">
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <asp:Label ID="updateTime" runat="server" CssClass="syncColTitle" Style="color: #999999; font-weight: normal; position: absolute; right: 5px; top: -20px" ToolTip="Last Update" />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <div class="tagTitleRoot" style="margin-top: 15px;">
                        <div class="tagTitleTab">
                            <asp:Image runat="server" ImageUrl="~/App_Themes/baseObjects/icon_summaryTitle.png" Height="16" />
                        </div>
                    </div>
                    <div class="w3-row">
                        <div class="w3-col s12 m9 l9">
                            <div style="height: 50px; padding-top: 5px;">
                                <asp:UpdatePanel ID="statusUP" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
                                    <ContentTemplate>
                                        <asp:CheckBox ID="autoCollapse" runat="server" CssClass="w3-text-grey" Text="Auto Collapse" TextAlign="right" Checked="true" Style="float: left; margin: 10px 0px 0px 5px;" />
                                        <asp:CheckBox ID="autoRefresh" runat="server" onchange="autoRefreshTable();" CssClass="w3-text-grey" Text="Auto Refresh" TextAlign="right" Checked="false" Style="float: left; margin: 10px 0px 0px 30px;" />
                                        <div style="float: right;">
                                            <asp:Table runat="server">
                                                <asp:TableRow>
                                                    <asp:TableCell HorizontalAlign="Right" VerticalAlign="Middle">
                                                        <asp:Label runat="server" Enabled="false" Visible="false" CssClass="w3-text-grey" Text="Show" Style="font-size: 13px; float: right; margin: 10px 10px 0px 0px" />
                                                        <asp:DropDownList ID="pageSizeSelect" runat="server" Enabled="true" CssClass="dashDropDown" SelectedValue='<%# mosGV.PageSize %>' OnSelectedIndexChanged="SetPagerSize" AccessKey="1" AutoPostBack="true" EnableViewState="true">
                                                            <asp:ListItem Text="10" Value="10" />
                                                            <asp:ListItem Text="20" Value="20" />
                                                            <asp:ListItem Text="50" Value="50" />
                                                            <asp:ListItem Text="100" Value="100" />
                                                        </asp:DropDownList>
                                                    </asp:TableCell>
                                                    <asp:TableCell>
                                                        <asp:DropDownList ID="showHub" runat="server" DataSourceId="hubListDS" DataTextField="hubName" DataValueField="hubName" CssClass="dashDropDown" Style="float:right;margin-left:5px;" AutoPostBack="true" Appenddatabounditems="true" EnableViewState="true">
                                                            <asp:ListItem Text="All Hub" Value=""/>                 
                                                        </asp:DropDownList> 
                                                    </asp:TableCell>
                                                    <asp:TableCell>
                                                        <asp:Button ID="collapseTags" runat="server" Enabled="false" Visible="false" OnClientClick="expandCollapse('0');return false;" AccessKey="1" CssClass="material-icons expander" Text="format_line_spacing" Style="float: right; font-size: 28px; margin: 3px 2px 0px 5px;" />
                                                        <asp:DropDownList ID="showStatus" runat="server" DataSourceID="tagStatusDS" DataTextField="statusDesc" DataValueField="statusCode" CssClass="dashDropDown" Style="float: right; margin:0px 5px;" Enabled="true" AutoPostBack="true" AppendDataBoundItems="true" EnableViewState="true">
                                                            <asp:ListItem Text="All Status" Value="" />
                                                        </asp:DropDownList>
                                                    </asp:TableCell>
                                                    <asp:TableCell>
                                                        <div class="dashMode" style="position: relative; padding: 0px">
                                                            <asp:LinkButton ID="refreshTable" runat="server" OnClick="RefreshTable" CssClass="material-icons" Text="cached" Style="position: absolute; top: 3px; left: 3px; text-decoration: none;" />
                                                        </div>
                                                        <asp:Button ID="autoRefreshBtn" runat="server" OnClick="RefreshTable" CausesValidation="false" Text="Auto" Style="display: none" />
                                                    </asp:TableCell>
                                                </asp:TableRow>
                                            </asp:Table>
                                        </div>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                            <asp:GridView ID="mosGV" runat="server" Width="100%" CellPadding="0" CellSpacing="0" AutoGenerateColumns="false" ShowHeader="false" EnableViewState="false" DataSourceID="mosDS" DataKeyNames="formId"
                                AllowSorting="false" EnableSortingAndPagingCallbacks="true" AllowPaging="true" PagerSettings-Mode="NumericFirstLast" PageSize="10" PagerSettings-Position="Bottom" PagerSettings-PageButtonCount="5">
                                <RowStyle CssClass="dashboardRow" />
                                <AlternatingRowStyle CssClass="dashboardRowAlt" />
                                <EmptyDataTemplate>
                                    <asp:Table runat="server">
                                        <asp:TableRow Style="height: 50px; color: #666666; background-color: #FCFCFC;">
                                            <asp:TableCell Style="padding-left: 20px"><asp:Label runat="server" Text="No request found or matches filter criteria"/></asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </EmptyDataTemplate>
                                <PagerTemplate>
                                    <asp:Table runat="server" HorizontalAlign="Center" Height="37" Style="margin-top: 5px">
                                        <asp:TableRow>
                                            <asp:TableCell HorizontalAlign="Left" VerticalAlign="Middle" Style="padding: 0px 0px 2px 0px;">
                                                <asp:LinkButton ID="prevPg" runat="server" CssClass="fa fa-arrow-left w3-hover-text-red" Style="color: #999999; font-size: 20px; text-decoration: none; margin: 0px 10px;" ToolTip="Previous Page" CommandName="Page" CommandArgument="Prev" />
                                                <asp:LinkButton ID="nextPg" runat="server" CssClass="fa fa-arrow-right w3-hover-text-red" Style="color: #999999; font-size: 20px; text-decoration: none;" ToolTip="Next Page" CommandName="Page" CommandArgument="Next" />
                                            </asp:TableCell>
                                            <asp:TableCell Style="padding: 0px 5px 1px 0px;">
                                            
                                            </asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </PagerTemplate>
                                <Columns>
                                    <asp:TemplateField ItemStyle-Wrap="true" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="false" ShowHeader="false" Visible="true">
                                        <ItemTemplate>
                                            <ajax:CollapsiblePanelExtender ID="mosRequestCPE" runat="server" TargetControlID="content" CollapsedSize="0" ExpandControlID="expander" CollapseControlID="expander" Collapsed="true" AutoCollapse="False" ExpandedText="Hide Details" />
                                            <asp:Panel ID="header" runat="server" CssClass="flowHeader">
                                                <asp:Table runat="server" Height="50">
                                                    <asp:TableRow>
                                                        <asp:TableCell Style="width: 5px; min-width: 5px;" BackColor="WhiteSmoke"></asp:TableCell>
                                                        <asp:TableCell Width="130" VerticalAlign="Top" Style="position: relative; min-width: 100px">
                                                        <asp:Label runat="server" CssClass="syncColTitle" Text="MOS Request" Style="position:absolute;left:10px;top:0px" />
                                                        <asp:LinkButton runat="server" OnClientClick=<%# "openReport('"+ Eval("formId") +"','form','DSB','BLANK');return false;" %> CssClass="flowLink" Text='<%# Eval("hub","{0}-") + Eval("mosId","{0:D5}") %>' Style="position:absolute;left:10px;top:15px" ToolTip="Details" />
                                                        </asp:TableCell>
                                                        <asp:TableCell HorizontalAlign="Center" Style="padding: 0px 30px 0px 20px">

                                                            <asp:Table ID="newMode" runat="server" Visible='<%# Convert.ToInt32(Eval("curMode")) == 1 ? true : false %>' CellPadding="0" CellSpacing="0" Style="min-width: 140px">
                                                                <asp:TableRow>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle" CssClass="flowCellNode">
                                                                    <div class='<%# (Convert.ToInt32(Eval("nextRole")) == 1) ? "flowNodeActive" : (Convert.ToInt32(Eval("curState")) >= 1 ? "flowNodeComplete" : "flowNodePending") %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle">
                                                                    <div class='<%# (Convert.ToInt32(Eval("curState")) >= 1) ? "flowBarRoot flowBarComCom" : "flowBarRoot flowBarPndPnd" %>'></div>                                                        
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle" CssClass="flowCellNode">
                                                                    <div class='<%# (Convert.ToInt32(Eval("nextRole")) == 2) ? "flowNodeActive" : (Convert.ToInt32(Eval("curState")) >= 2 ? "flowNodeComplete" : "flowNodePending") %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle">
                                                                    <div class='<%# (Convert.ToInt32(Eval("curState")) >= 2) ? "flowBarRoot flowBarComCom" : "flowBarRoot flowBarPndPnd" %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle" CssClass="flowCellNode">
                                                                    <div class='<%# (Convert.ToInt32(Eval("nextRole")) == 3) ? "flowNodeActive" :(Convert.ToInt32(Eval("curState")) >= 3 ? "flowNodeComplete" : "flowNodePending") %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle">
                                                                    <div class='<%# (Convert.ToInt32(Eval("curState")) >= 3) ? "flowBarRoot flowBarComCom" : "flowBarRoot flowBarPndPnd" %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle" CssClass="flowCellNode">
                                                                    <div class='<%# (Convert.ToInt32(Eval("nextRole")) == 4) ? "flowNodeActive" : (Convert.ToInt32(Eval("curState")) >= 4 ? "flowNodeComplete" : "flowNodePending") %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle">
                                                                    <div class='<%# (Convert.ToInt32(Eval("curState")) >= 5) ? "flowBarRoot flowBarComCom" : "flowBarRoot flowBarPndPnd" %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle" CssClass="flowCellNode">
                                                                    <div class='<%# (Convert.ToInt32(Eval("nextRole")) == 5) ? "flowNodeActive" : (Convert.ToInt32(Eval("curState")) >= 5 ? "flowNodeComplete" : "flowNodePending") %>'></div>
                                                                    </asp:TableCell>
                                                                </asp:TableRow>
                                                                <asp:TableRow Height="18">
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Bottom" CssClass="flowCellNode">
                                                                    <asp:Label runat="server" Text="OT" CssClass='<%# (Convert.ToInt32(Eval("nextRole")) == 1) ? "flowTextActive" : (Convert.ToInt32(Eval("curState")) >= 1 ? "flowTextComplete" : "flowTextPending") %>' />
                                                                    </asp:TableCell>
                                                                    <asp:TableCell></asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Bottom" CssClass="flowCellNode">
                                                                    <asp:Label runat="server" Text="SOTI" CssClass='<%# (Convert.ToInt32(Eval("nextRole")) == 2) ? "flowTextActive" : (Convert.ToInt32(Eval("curState")) >= 2 ? "flowTextComplete" : "flowTextPending") %>' />
                                                                    </asp:TableCell>
                                                                    <asp:TableCell></asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Bottom" CssClass="flowCellNode">
                                                                    <asp:Label runat="server" Text="OIM" CssClass='<%# (Convert.ToInt32(Eval("nextRole")) == 3) ? "flowTextActive" : (Convert.ToInt32(Eval("curState")) >= 3 ? "flowTextComplete" : "flowTextPending") %>' />
                                                                    </asp:TableCell>
                                                                    <asp:TableCell></asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Bottom" CssClass="flowCellNode">
                                                                    <asp:Label runat="server" Text="PS" CssClass='<%# (Convert.ToInt32(Eval("nextRole")) == 4) ? "flowTextActive" : (Convert.ToInt32(Eval("curState")) >= 4 ? "flowTextComplete" : "flowTextPending") %>' />
                                                                    </asp:TableCell>
                                                                    <asp:TableCell></asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Bottom" CssClass="flowCellNode">
                                                                    <asp:Label runat="server" Text="CRO" CssClass='<%# (Convert.ToInt32(Eval("nextRole")) == 5) ? "flowTextActive" : (Convert.ToInt32(Eval("curState")) >= 5 ? "flowTextComplete" : "flowTextPending") %>' />
                                                                    </asp:TableCell>
                                                                </asp:TableRow>
                                                            </asp:Table>

                                                            <asp:Table ID="extendMode" runat="server" Visible='<%# Convert.ToInt32(Eval("curMode")) == 2 ? true : false %>' CellPadding="0" CellSpacing="0" Style="min-width: 140px">
                                                                <asp:TableRow>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle" CssClass="flowCellNode">
                                                                    <div class='<%# (Convert.ToInt32(Eval("nextRole")) == 5) ? "flowNodeActive" : (Convert.ToInt32(Eval("curState")) <= 8 ? "flowNodeComplete" : "flowNodePending") %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle">
                                                                    <div class='<%# (Convert.ToInt32(Eval("curState")) <= 8) ? "flowBarRoot flowBarComCom" : "flowBarRoot flowBarPndPnd" %>'></div>                                                        
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle" CssClass="flowCellNode">
                                                                    <div class='<%# (Convert.ToInt32(Eval("nextRole")) == 1) ? "flowNodeActive" : (Convert.ToInt32(Eval("curState")) <= 7 ? "flowNodeComplete" : "flowNodePending") %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle">
                                                                    <div class='<%# (Convert.ToInt32(Eval("curState")) <= 7) ? "flowBarRoot flowBarComCom" : "flowBarRoot flowBarPndPnd" %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle" CssClass="flowCellNode">
                                                                    <div class='<%# (Convert.ToInt32(Eval("nextRole")) == 2) ? "flowNodeActive" :((Convert.ToInt32(Eval("curState")) >= 2 && Convert.ToInt32(Eval("curState")) < 7) ? "flowNodeComplete" : "flowNodePending") %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle">
                                                                    <div class='<%# (Convert.ToInt32(Eval("curState")) >= 2 && Convert.ToInt32(Eval("curState")) < 7) ? "flowBarRoot flowBarComCom" : "flowBarRoot flowBarPndPnd" %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle" CssClass="flowCellNode">
                                                                    <div class='<%# (Convert.ToInt32(Eval("nextRole")) == 3) ? "flowNodeActive" : ((Convert.ToInt32(Eval("curState")) >= 3 && Convert.ToInt32(Eval("curState")) < 7) ? "flowNodeComplete" : "flowNodePending") %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle">
                                                                    <div class='<%# (Convert.ToInt32(Eval("curState")) >= 3 && Convert.ToInt32(Eval("curState")) < 7) ? "flowBarRoot flowBarComCom" : "flowBarRoot flowBarPndPnd" %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle" CssClass="flowCellNode">
                                                                    <div class='<%# (Convert.ToInt32(Eval("nextRole")) == 4) ? "flowNodeActive" : ((Convert.ToInt32(Eval("curState")) >= 4 && Convert.ToInt32(Eval("curState")) < 7) ? "flowNodeComplete" : "flowNodePending") %>'></div>
                                                                    </asp:TableCell>
                                                                </asp:TableRow>
                                                                <asp:TableRow Height="18">
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Bottom" CssClass="flowCellNode">
                                                                    <asp:Label runat="server" Text="CRO" CssClass='<%# (Convert.ToInt32(Eval("nextRole")) == 5) ? "flowTextActive" : (Convert.ToInt32(Eval("curState")) <= 8 ? "flowTextComplete" : "flowTextPending") %>' />
                                                                    </asp:TableCell>
                                                                    <asp:TableCell></asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Bottom" CssClass="flowCellNode">
                                                                    <asp:Label runat="server" Text="OT" CssClass='<%# (Convert.ToInt32(Eval("nextRole")) == 1) ? "flowTextActive" : (Convert.ToInt32(Eval("curState")) <= 7 ? "flowTextComplete" : "flowTextPending") %>' />
                                                                    </asp:TableCell>
                                                                    <asp:TableCell></asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Bottom" CssClass="flowCellNode">
                                                                    <asp:Label runat="server" Text="SOTI" CssClass='<%# (Convert.ToInt32(Eval("nextRole")) == 2) ? "flowTextActive" : ((Convert.ToInt32(Eval("curState")) >= 2 && Convert.ToInt32(Eval("curState")) < 7) ? "flowTextComplete" : "flowTextPending") %>' />
                                                                    </asp:TableCell>
                                                                    <asp:TableCell></asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Bottom" CssClass="flowCellNode">
                                                                    <asp:Label runat="server" Text="OIM" CssClass='<%# (Convert.ToInt32(Eval("nextRole")) == 3) ? "flowTextActive" : ((Convert.ToInt32(Eval("curState")) >= 3 && Convert.ToInt32(Eval("curState")) < 7) ? "flowTextComplete" : "flowTextPending") %>' />
                                                                    </asp:TableCell>
                                                                    <asp:TableCell></asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Bottom" CssClass="flowCellNode">
                                                                    <asp:Label runat="server" Text="PS" CssClass='<%# (Convert.ToInt32(Eval("nextRole")) == 4) ? "flowTextActive" : ((Convert.ToInt32(Eval("curState")) >= 4 && Convert.ToInt32(Eval("curState")) < 7) ? "flowTextComplete" : "flowTextPending") %>' />
                                                                    </asp:TableCell>
                                                                </asp:TableRow>
                                                            </asp:Table>

                                                            <asp:Table ID="closeMode" runat="server" Visible='<%# Convert.ToInt32(Eval("curMode")) == 3 ? true : false %>' CellPadding="0" CellSpacing="0" Style="min-width: 140px">
                                                                <asp:TableRow>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle" CssClass="flowCellNode">
                                                                    <div class='<%# (Convert.ToInt32(Eval("nextRole")) == 5) ? "flowNodeActive" : (Convert.ToInt32(Eval("curState")) <= 11 ? "flowNodeComplete" : "flowNodePending") %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle">
                                                                    <div class='<%# (Convert.ToInt32(Eval("curState")) <= 11) ? "flowBarRoot flowBarComCom" : "flowBarRoot flowBarPndPnd" %>'></div>                                                        
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle" CssClass="flowCellNode">
                                                                    <div class='<%# (Convert.ToInt32(Eval("nextRole")) == 2) ? "flowNodeActive" : ((Convert.ToInt32(Eval("curState")) >= 2 && Convert.ToInt32(Eval("curState")) != 9) ? "flowNodeComplete" : "flowNodePending") %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle">
                                                                    <div class='<%# ((Convert.ToInt32(Eval("curState")) >= 2 && Convert.ToInt32(Eval("curState")) != 9) ? "flowBarRoot flowBarComCom" : "flowBarRoot flowBarPndPnd") %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle" CssClass="flowCellNode">
                                                                    <div class='<%# (Convert.ToInt32(Eval("nextRole")) == 4) ? "flowNodeActive" :((Convert.ToInt32(Eval("curState")) >= 4 && Convert.ToInt32(Eval("curState")) != 9) ? "flowNodeComplete" : "flowNodePending") %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle">
                                                                    <div class='<%# ((Convert.ToInt32(Eval("curState")) >= 4 && Convert.ToInt32(Eval("curState")) != 9) ? "flowBarRoot flowBarComCom" : "flowBarRoot flowBarPndPnd") %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle" CssClass="flowCellNode">
                                                                    <div class='<%# (Convert.ToInt32(Eval("nextRole")) == 1) ? "flowNodeActive" : ((Convert.ToInt32(Eval("curState")) >= 6 && Convert.ToInt32(Eval("curState")) != 9) ? "flowNodeComplete" : "flowNodePending") %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle">
                                                                    <div class='<%# ((Convert.ToInt32(Eval("curState")) >= 6 && Convert.ToInt32(Eval("curState")) != 9) ? "flowBarRoot flowBarComCom" : "flowBarRoot flowBarPndPnd") %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle" CssClass="flowCellNode">
                                                                    <div class='<%# (Convert.ToInt32(Eval("nextRole")) == 3 && Convert.ToInt32(Eval("curState")) < 11) ? "flowNodeActive" : (Convert.ToInt32(Eval("curState")) == 11 ? "flowNodeComplete" : "flowNodePending") %>'></div>
                                                                    </asp:TableCell>
                                                                </asp:TableRow>
                                                                <asp:TableRow Height="18">
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Bottom" CssClass="flowCellNode">
                                                                    <asp:Label runat="server" Text="CRO" CssClass='<%# (Convert.ToInt32(Eval("nextRole")) == 5) ? "flowTextActive" : (Convert.ToInt32(Eval("curState")) <= 11 ? "flowTextComplete" : "flowTextPending") %>' />
                                                                    </asp:TableCell>
                                                                    <asp:TableCell></asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Bottom" CssClass="flowCellNode">
                                                                    <asp:Label runat="server" Text="SOTI" CssClass='<%# (Convert.ToInt32(Eval("nextRole")) == 2) ? "flowTextActive" : ((Convert.ToInt32(Eval("curState")) >= 2 && Convert.ToInt32(Eval("curState")) != 9) ? "flowTextComplete" : "flowTextPending") %>' />
                                                                    </asp:TableCell>
                                                                    <asp:TableCell></asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Bottom" CssClass="flowCellNode">
                                                                    <asp:Label runat="server" Text="PS" CssClass='<%# (Convert.ToInt32(Eval("nextRole")) == 4) ? "flowTextActive" : ((Convert.ToInt32(Eval("curState")) >= 4 && Convert.ToInt32(Eval("curState")) != 9) ? "flowTextComplete" : "flowTextPending") %>' />
                                                                    </asp:TableCell>
                                                                    <asp:TableCell></asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Bottom" CssClass="flowCellNode">
                                                                    <asp:Label runat="server" Text="OT" CssClass='<%# (Convert.ToInt32(Eval("nextRole")) == 1) ? "flowTextActive" : ((Convert.ToInt32(Eval("curState")) >= 6 && Convert.ToInt32(Eval("curState")) != 9) ? "flowTextComplete" : "flowTextPending") %>' />
                                                                    </asp:TableCell>
                                                                    <asp:TableCell></asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Bottom" CssClass="flowCellNode">
                                                                    <asp:Label runat="server" Text="OIM" CssClass='<%# (Convert.ToInt32(Eval("nextRole")) == 3 && Convert.ToInt32(Eval("curState")) < 11) ? "flowTextActive" : (Convert.ToInt32(Eval("curState")) == 11 ? "flowTextComplete" : "flowTextPending") %>' />
                                                                    </asp:TableCell>
                                                                </asp:TableRow>
                                                            </asp:Table>

                                                            <asp:Table ID="rejectMode" runat="server" Visible='<%# Convert.ToInt32(Eval("curMode")) == 4 ? true : false %>' CellPadding="0" CellSpacing="0" Style="min-width: 140px">
                                                                <asp:TableRow>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle" CssClass="flowCellNode">
                                                                    <div class='<%# (Convert.ToInt32(Eval("nextRole")) == 1) ? "flowNodeReject" : "flowNodePending" %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle">
                                                                    <div class='<%# "flowBarRoot flowBarPndPnd" %>'></div>                                                       
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle" CssClass="flowCellNode">
                                                                    <div class='<%# (Convert.ToInt32(Eval("nextRole")) == 2) ? "flowNodeReject" : "flowNodePending" %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle">
                                                                    <div class='<%# "flowBarRoot flowBarPndPnd" %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle" CssClass="flowCellNode">
                                                                    <div class='<%# (Convert.ToInt32(Eval("nextRole")) == 3) ? "flowNodeReject" : "flowNodePending" %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle">
                                                                    <div class='<%# "flowBarRoot flowBarPndPnd" %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle" CssClass="flowCellNode">
                                                                    <div class='<%# (Convert.ToInt32(Eval("nextRole")) == 4) ? "flowNodeReject" : "flowNodePending" %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle">
                                                                    <div class='<%# "flowBarRoot flowBarPndPnd" %>'></div>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Middle" CssClass="flowCellNode">
                                                                    <div class='<%# (Convert.ToInt32(Eval("nextRole")) == 5) ? "flowNodeReject" : "flowNodePending" %>'></div>
                                                                    </asp:TableCell>
                                                                </asp:TableRow>
                                                                <asp:TableRow Height="18">
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Bottom" CssClass="flowCellNode">
                                                                    <asp:Label runat="server" Text="OT" CssClass='<%# (Convert.ToInt32(Eval("nextRole")) == 1) ? "flowTextReject" : "flowTextPending" %>' />
                                                                    </asp:TableCell>
                                                                    <asp:TableCell></asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Bottom" CssClass="flowCellNode">
                                                                    <asp:Label runat="server" Text="SOTI" CssClass='<%# (Convert.ToInt32(Eval("nextRole")) == 2) ? "flowTextReject" : "flowTextPending" %>' />
                                                                    </asp:TableCell>
                                                                    <asp:TableCell></asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Bottom" CssClass="flowCellNode">
                                                                    <asp:Label runat="server" Text="OIM" CssClass='<%# (Convert.ToInt32(Eval("nextRole")) == 3) ? "flowTextReject" : "flowTextPending" %>' />
                                                                    </asp:TableCell>
                                                                    <asp:TableCell></asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Bottom" CssClass="flowCellNode">
                                                                    <asp:Label runat="server" Text="PS" CssClass='<%# (Convert.ToInt32(Eval("nextRole")) == 4) ? "flowTextReject" : "flowTextPending" %>' />
                                                                    </asp:TableCell>
                                                                    <asp:TableCell></asp:TableCell>
                                                                    <asp:TableCell HorizontalAlign="Center" VerticalAlign="Bottom" CssClass="flowCellNode">
                                                                    <asp:Label runat="server" Text="CRO" CssClass='<%# (Convert.ToInt32(Eval("nextRole")) == 5) ? "flowTextReject" : "flowTextPending" %>' />
                                                                    </asp:TableCell>
                                                                </asp:TableRow>

                                                            </asp:Table>

                                                        </asp:TableCell>
                                                        <asp:TableCell Width="150" VerticalAlign="Middle" HorizontalAlign="Center" CssClass="w3-hide-small">                                                        
                                                        <div class="flowStatus">
                                                            <asp:Label runat="server" Text='<%# Eval("statusDesc") %>' />
                                                        </div>
                                                        </asp:TableCell>
                                                        <asp:TableCell Width="1%" VerticalAlign="Middle" HorizontalAlign="right" onclick=<%# "setOpenTagId('"+Container.DataItemIndex.ToString()+"','1');" %>>
                                                            <asp:Button ID="expander" runat="server" CssClass="material-icons flowExpander" Text="arrow_drop_down" AccessKey="1" ToolTip="Expand" OnClientClick="return false;" />
                                                        </asp:TableCell>
                                                    </asp:TableRow>
                                                </asp:Table>
                                            </asp:Panel>

                                            <asp:Panel ID="content" runat="server" CssClass="flowContent" Style="padding: 5px 20px 15px 20px">
                                                <div class="w3-row">
                                                    <div class="w3-col s12 m4 l4">
                                                        <asp:Table runat="server" CssClass="w3-text-grey" CellPadding="4">
                                                            <asp:TableRow>
                                                                <asp:TableCell Wrap="false" Width="90" CssClass="syncColTitle">Field</asp:TableCell>
                                                                <asp:TableCell Wrap="false"><asp:Label runat="server" Text='<%# Eval("field") %>' /></asp:TableCell>
                                                            </asp:TableRow>
                                                            <asp:TableRow>
                                                                <asp:TableCell Wrap="false" CssClass="syncColTitle">PTW #</asp:TableCell>
                                                                <asp:TableCell Wrap="false"><asp:Label runat="server" Text='<%# Eval("ptwId") %>' /></asp:TableCell>
                                                            </asp:TableRow>
                                                            <asp:TableRow>
                                                                <asp:TableCell ColumnSpan="2" Height="10"></asp:TableCell></asp:TableRow>
                                                            <asp:TableRow>
                                                                <asp:TableCell Wrap="false" CssClass="syncColTitle">Requester</asp:TableCell>
                                                                <asp:TableCell><asp:Label runat="server" Text='<%# Eval("reqId") %>' /></asp:TableCell>
                                                            </asp:TableRow>
                                                            <asp:TableRow>
                                                                <asp:TableCell Wrap="false" CssClass="syncColTitle">Submitted</asp:TableCell>
                                                                <asp:TableCell><asp:Label runat="server" Text='<%# Eval("reqTimestamp","{0:dd-MMM-yyyy hh:mm tt}") %>' /></asp:TableCell>
                                                            </asp:TableRow>
                                                            <asp:TableRow CssClass="w3-hide-medium w3-hide-large">
                                                                <asp:TableCell ColumnSpan="2" Height="10"></asp:TableCell></asp:TableRow>
                                                        </asp:Table>
                                                    </div>
                                                    <div class="w3-col s12 m8 l8">
                                                        <asp:Table runat="server" CssClass="w3-text-grey" CellPadding="4">
                                                            <asp:TableRow>
                                                                <asp:TableCell Wrap="false" Width="90" CssClass="syncColTitle">Process</asp:TableCell>
                                                                <asp:TableCell><asp:Label runat="server" Text='<%# Eval("processSystem") %>' /></asp:TableCell>
                                                            </asp:TableRow>
                                                            <asp:TableRow>
                                                                <asp:TableCell Wrap="false" CssClass="syncColTitle">Control</asp:TableCell>
                                                                <asp:TableCell><asp:Label runat="server" Text='<%# Eval("controlSystem") %>' /></asp:TableCell>
                                                            </asp:TableRow>
                                                            <asp:TableRow>
                                                                <asp:TableCell ColumnSpan="2" Height="10"></asp:TableCell></asp:TableRow>
                                                            <asp:TableRow>
                                                                <asp:TableCell Wrap="false" CssClass="syncColTitle">Risk</asp:TableCell>
                                                                <asp:TableCell><asp:Label runat="server" Text='<%# Eval("riskRating") + " - " + Eval("riskRemarks") %>' /></asp:TableCell>
                                                            </asp:TableRow>
                                                            <asp:TableRow>
                                                                <asp:TableCell Wrap="false" CssClass="syncColTitle">Mitigation</asp:TableCell>
                                                                <asp:TableCell><asp:Label runat="server" Text='<%# Eval("mitigateMethod") %>' /></asp:TableCell>
                                                            </asp:TableRow>
                                                            <asp:TableRow>
                                                                <asp:TableCell ColumnSpan="2" Height="10"></asp:TableCell></asp:TableRow>
                                                            <asp:TableRow>
                                                                <asp:TableCell Wrap="false" CssClass="syncColTitle">Start</asp:TableCell>
                                                                <asp:TableCell><asp:Label runat="server" Text='<%# String.IsNullOrEmpty(Eval("planStart").ToString().Trim()) ? (Eval("curState").ToString().Trim() == "10" ? "N/A" : "TBA") : Eval("planStart", "{0:dd-MMM-yyyy hh:mm tt}") %>' /></asp:TableCell>
                                                            </asp:TableRow>
                                                            <asp:TableRow>
                                                                <asp:TableCell Wrap="false" CssClass="syncColTitle">End</asp:TableCell>
                                                                <asp:TableCell><asp:Label runat="server" Text='<%# String.IsNullOrEmpty(Eval("planStart").ToString().Trim()) ? (Eval("curState").ToString().Trim() == "10" ? "N/A" : "TBA") : Eval("planEnd", "{0:dd-MMM-yyyy hh:mm tt}") %>' /></asp:TableCell>
                                                            </asp:TableRow>
                                                            <asp:TableRow></asp:TableRow>
                                                        </asp:Table>
                                                    </div>
                                                </div>
                                            </asp:Panel>

                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                        <div class="w3-col s12 m3 l3 w3-hide-small">
                            <asp:GridView ID="todayGV" runat="server" Width="100%" CellPadding="0" CellSpacing="0" AutoGenerateColumns="false" ShowHeader="false" EnableViewState="true">
                                <EmptyDataTemplate>
                                    <asp:Table runat="server">
                                        <asp:TableRow Style="height: 50px; color: #666666; background-color: #FCFCFC;">
                                            <asp:TableCell Style="padding-left: 20px"><asp:Label runat="server" Text="No request has been submitted"/></asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </EmptyDataTemplate>
                                <Columns>
                                    <asp:TemplateField ItemStyle-Wrap="true" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="false" ShowHeader="false" Visible="true">
                                        <ItemTemplate>
                                            <asp:Table runat="server">
                                                <asp:TableRow VerticalAlign="Top">
                                                    <asp:TableCell CssClass="w3-hide-small" Width="30"></asp:TableCell>
                                                    <asp:TableCell>
                                                        <asp:Panel runat="server" CssClass="subItemPanel" Style="border-radius:0px;margin:5px 0px">
                                                            <asp:Table runat="server">
                                                                <asp:TableRow>
                                                                    <asp:TableCell RowSpan="2" Style="width:10px;min-width:10px;background-color: rgba(220, 224, 231, 0.30)"></asp:TableCell>
                                                                    <asp:TableCell CssClass="subItemHeader" Style="width:45px;min-width:45px"><asp:Label runat="server" Text=<%# Eval("hub") %> /></asp:TableCell>
                                                                    <asp:TableCell Wrap="false" CssClass="subItemHeader"><asp:Label runat="server" Text="Total Request" Style="font-size:11px"/></asp:TableCell>
                                                                    <asp:TableCell CssClass="subItemHeader"><asp:Label runat="server" Text='<%# Eval("total") %>' Style="float:right;margin-right:17px" /></asp:TableCell>                                                                    
                                                                </asp:TableRow>
                                                                <asp:TableRow Visible=<%# Convert.ToInt32(Eval("total")) > 0 ? true : false %>>
                                                                    <asp:TableCell ColumnSpan="3" Style="padding:10px">
                                                                        <asp:Table runat="server"  CssClass="w3-text-grey" CellPadding="3" CellSpacing="0">
                                                                            <asp:TableRow>                                                                    
                                                                                <asp:TableCell>Submitted</asp:TableCell>
                                                                                <asp:TableCell HorizontalAlign="Center"><asp:Label runat="server" Text=<%# Eval("submitted") %> Style="float:right;margin-right:5px" /></asp:TableCell>
                                                                            </asp:TableRow>
                                                                            <asp:TableRow Style="border-top:1px dashed #E4EAF0;border-bottom:1px dashed #E4EAF0">
                                                                                <asp:TableCell>Endorsed</asp:TableCell>
                                                                                <asp:TableCell HorizontalAlign="Center"><asp:Label runat="server" Text=<%# Eval("endorsed") %> Style="float:right;margin-right:5px" /></asp:TableCell>
                                                                            </asp:TableRow>
                                                                            <asp:TableRow>
                                                                                <asp:TableCell>Authorized</asp:TableCell>
                                                                                <asp:TableCell HorizontalAlign="Center"><asp:Label runat="server" Text=<%# Eval("authorized") %> Style="float:right;margin-right:5px" /></asp:TableCell>
                                                                            </asp:TableRow>
                                                                            <asp:TableRow Style="border-top:1px dashed #E4EAF0;border-bottom:1px dashed #E4EAF0">
                                                                                <asp:TableCell>Approved</asp:TableCell>
                                                                                <asp:TableCell HorizontalAlign="Center"><asp:Label runat="server" Text=<%# Eval("approved") %> Style="float:right;margin-right:5px" /></asp:TableCell>
                                                                            </asp:TableRow>
                                                                            <asp:TableRow>
                                                                                <asp:TableCell>Executed</asp:TableCell>
                                                                                <asp:TableCell HorizontalAlign="Center"><asp:Label runat="server" Text=<%# Eval("executed") %> Style="float:right;margin-right:5px" /></asp:TableCell>
                                                                            </asp:TableRow>
                                                                            <asp:TableRow Style="border-top:1px dashed #E4EAF0;border-bottom:1px dashed #E4EAF0">
                                                                                <asp:TableCell>Closed</asp:TableCell>
                                                                                <asp:TableCell HorizontalAlign="Center"><asp:Label runat="server" Text=<%# Eval("closed") %> Style="float:right;margin-right:5px" /></asp:TableCell>
                                                                            </asp:TableRow>
                                                                            <asp:TableRow>
                                                                                <asp:TableCell>Rejected</asp:TableCell>
                                                                                <asp:TableCell HorizontalAlign="Center"><asp:Label runat="server" Text=<%# Eval("rejected") %> Style="float:right;margin-right:5px" /></asp:TableCell>
                                                                            </asp:TableRow>
                                                                        </asp:Table>
                                                                    </asp:TableCell>
                                                                </asp:TableRow>
                                                            </asp:Table>
                                                        </asp:Panel>
                                                    </asp:TableCell>                                                    
                                                </asp:TableRow>
                                            </asp:Table>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>

                </asp:Panel>

                <!-- ------------------------- -->

                <asp:HiddenField ID="totalTagSection" runat="server" Value="1" />
                <asp:TextBox ID="openTags" runat="server" Style="display: none" />
                <asp:TextBox ID="totalRows" runat="server" Style="display: none" />

                <!-- ------------------------- -->

            </ContentTemplate>
        </asp:UpdatePanel>

    </div>

    <!-- 'main data source section -->
    <asp:SqlDataSource ID="hubListDS" runat="server" DataSourceMode="DataSet"
        SelectCommand="SELECT * FROM adm_list_hub ORDER BY hubName"
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>"></asp:SqlDataSource>
    <asp:SqlDataSource ID="roleListDS" runat="server" DataSourceMode="DataSet"
        SelectCommand="SELECT * FROM adm_list_role WHERE roleCode NOT IN (0) ORDER BY roleCode"
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>"></asp:SqlDataSource>
    <asp:SqlDataSource ID="tagStatusDS" runat="server" DataSourceMode="DataSet"
        SelectCommand="SELECT * FROM adm_list_status WHERE statusCode NOT IN (0,12) ORDER BY statusCode"
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>"></asp:SqlDataSource>
    <asp:SqlDataSource ID="mosDS" runat="server" DataSourceMode="DataSet"
        SelectCommand="SELECT a.*, b.statusDesc,c.planStart,c.planEnd FROM form_mos a LEFT OUTER JOIN adm_list_status b ON b.statusCode=a.curState LEFT OUTER JOIN form_mos_ext c ON c.formId=a.formId AND c.extCount=a.extCount WHERE reqStatus=1 ORDER BY formId DESC"
        FilterExpression="(ISNULL(Convert(mosId,'System.String'),'') LIKE '%{0}%' OR ISNULL(ptwId,'') LIKE '%{0}%' OR ISNULL(hub,'') LIKE '%{0}%' OR ISNULL(field,'') LIKE '%{0}%' OR ISNULL(processSystem,'') LIKE '%{0}%' OR ISNULL(controlSystem,'') LIKE '%{0}%' OR ISNULL(isolateFunction,'') LIKE '%{0}%' OR ISNULL(isolateMethod,'') LIKE '%{0}%' OR ISNULL(isolatePurpose,'') LIKE '%{0}%' OR ISNULL(isolateEffect,'') LIKE '%{0}%' OR ISNULL(altSafetySystem,'') LIKE '%{0}%' OR ISNULL(riskRemarks,'') LIKE '%{0}%' OR ISNULL(riskRating,'') LIKE '%{0}%' OR ISNULL(mitigateMethod,'') LIKE '%{0}%') AND ISNULL(Convert(curState,'System.String'),'') LIKE '{1}' AND ISNULL(hub,'') LIKE '{3}'"
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
        <FilterParameters>
            <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="%" PropertyName="Text" ControlID="search" />
            <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="%" PropertyName="SelectedValue" ControlID="showStatus" />
            <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="%" PropertyName="Text" ControlID="mobileSearch" />
            <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="%" PropertyName="SelectedValue" ControlID="showHub" />
        </FilterParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="todayMosDS" runat="server" DataSourceMode="DataSet"
        SelectCommand="SELECT hub,curState FROM form_mos WHERE reqStatus=1"
        FilterExpression="ISNULL(hub,'') LIKE '{0}'"
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
        <FilterParameters>
            <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="%" PropertyName="SelectedValue" ControlID="showHub" />
        </FilterParameters>
    </asp:SqlDataSource>
</asp:Content>
