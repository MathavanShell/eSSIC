<%@ Page Title="" Language="C#" MasterPageFile="~/template/Default.Master" AutoEventWireup="true" CodeBehind="manage.aspx.cs" Inherits="eSSIC.MOS.Manage" %>
<%@ MasterType VirtualPath="~/template/Default.Master" %>

<asp:Content ID="headerSection" ContentPlaceHolderID="HeaderContent" runat="server"></asp:Content>
<asp:Content ID="mainSection" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
        <!-- 'Request info section -->
        <asp:UpdatePanel ID="managePanelUP" runat="server"><ContentTemplate>
            <asp:Panel ID="topInfo" runat="server" Height="50" Style="position:relative">
                <asp:Button ID="newMosRequest" runat="server" OnClientClick="window.open('request.aspx','_self');return false" CssClass="altButton" Text="New Request" Style="position:absolute;right:0;bottom:0" Visible="true" Enabled="false" />
            </asp:Panel>
            <asp:Panel ID="mosRequest" runat="server">

                <div class="tagTitleRoot" style="margin-top:15px;">
                    <div class="tagTitleTab">
            	        <asp:Image runat="server" ImageUrl="~/App_Themes/baseObjects/icon_requestTitle.png" Height="16"/>
                    </div>
                </div>
                <div class="w3-row">
                    <div class="w3-col s12 m8 l8">
                        <div style="height:30px;padding-top:5px;">

                        </div>
                    </div>
                    <div class="w3-col s12 m4 l4"></div>
                </div>

                <asp:Panel ID="pendingActionPanel" runat="server" CssClass="altSumRootHeader">
                    <asp:Table runat="server" Height="40">
                        <asp:TableRow>
                            <asp:TableCell Width="10" style="background-color:rgba(220, 224, 231, 0.25)"></asp:TableCell>
                            <asp:TableCell Style="position:relative">
                                <asp:Label runat="server" CssClass="material-icons altSumRootHeaderIcon" Text="inbox"/>
                                <asp:Label runat="server" CssClass="altSumRootHeaderLabel" Text="Pending Action"/>
                            </asp:TableCell>                            
                        </asp:TableRow>
                    </asp:Table>
                    <asp:Panel ID="mosPendingPanel" runat="server" Style="padding-top:10px">
                        <asp:GridView id="mosPendingGV" runat="server" width="100%" CssClass="altSumRoot" AutoGenerateColumns="false" DataSourceID="mosPendingDS" DataKeyNames="formId" 
                            AllowSorting="true" EnableSortingAndPagingCallbacks="true" EnableViewState="true" AllowPaging="true" PagerSettings-Mode="NumericFirstLast" PageSize="10" PagerSettings-Position="Bottom" PagerSettings-PageButtonCount="5">
                            <RowStyle Wrap="True" CssClass="altSumRow" />
                            <AlternatingRowStyle CssClass="altSumRowAlt" />
                            <HeaderStyle CssClass="altSumRowHeader" />
                            <SortedAscendingHeaderStyle CssClass="altSumAscHeader"/>
                            <SortedDescendingHeaderStyle CssClass="altSumDscHeader" />
                            <EmptyDataTemplate>
                                <asp:Table runat="server" style="padding:2px;">
                                    <asp:TableRow CssClass="summaryItemHeader" Height="30">
                                        <asp:TableCell>
                                            <asp:Label runat="server" Text="QUERY RESULT" Style="padding-left:10px;" />
                                            <asp:Image runat="server" ImageAlign="absmiddle" ImageUrl="~/App_Themes/baseObjects/btnImg_filler.png" style="float:right;margin:3px 10px 0px 0px;"/>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow Height="80">
                                        <asp:TableCell>
                                            <asp:Label runat="server" CssClass="w3-text-grey" Text="No request found pending your action" Style="margin-left:40px" />
                                        </asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                            </EmptyDataTemplate>
                            <PagerTemplate>
                                <asp:Table runat="server" HorizontalAlign="Center">
                                    <asp:TableRow>
                                        <asp:TableCell HorizontalAlign="Left" VerticalAlign="Top" Style="padding:22px 0px 0px 0px;">
                                            <asp:LinkButton ID="prevPg" runat="server" CssClass="fa fa-arrow-left w3-hover-text-red" Style="color:#999999;font-size:20px;text-decoration:none;margin:0px 10px;" ToolTip="Previous Page" CommandName="Page" CommandArgument="Prev"/>
                                            <asp:LinkButton ID="nextPg" runat="server" CssClass="fa fa-arrow-right w3-hover-text-red" Style="color:#999999;font-size:20px;text-decoration:none;" ToolTip="Next Page" CommandName="Page" CommandArgument="Next"/>
                                        </asp:TableCell>
                                        <asp:TableCell HorizontalAlign="Right" VerticalAlign="Bottom" style="padding:15px 5px 2px 0px;">
                                            <asp:Label runat="server" Text="Showing" CssClass="w3-text-grey" Style="margin:0px 15px;" Visible="false" />
                                            <asp:DropDownList ID="pageSizeSelect" runat="server" selectedvalue='<%# mosPendingGV.PageSize %>' OnSelectedIndexChanged="SetPagerSize" AccessKey="1" AutoPostBack="true" EnableViewState="true" CssClass="dashDropDown" Enabled="true"> 
                                                <asp:ListItem Text="10" Value="10"/>
                                                <asp:ListItem Text="20" Value="20"/>
                                                <asp:ListItem Text="50" Value="50"/>                                        
                                                <asp:ListItem Text="100" Value="100"/>                                       
                                            </asp:DropDownList>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                            </PagerTemplate>
                            <Columns>                        
                                <asp:templatefield SortExpression="reqDate" HeaderText="Date" ItemStyle-Width="1%" ItemStyle-Wrap="false" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="false">
                                    <HeaderStyle CssClass="altSumItmHeader" />
                                    <ItemStyle CssClass="altSumItmRow altSumItmRowLeftOveride"/>
                                    <itemtemplate>
                                        <asp:Label ID="rptDateFull" runat="server" Text='<%# Bind("reqDate","{0:dd-MMM-yyyy}")%>' CssClass="w3-hide-small w3-hide-medium"/>
                                        <div align="Center">
                                        <asp:Panel ID="rptDateCompact" runat="server" CssClass="compactCalRoot mobilePopUpCalShow w3-hide-large">
                        	                <div align="center" class="compactCalMonth"><asp:Label runat="server" Text='<%# Eval("reqDate","{0:MMM}")%>' /></div>
                                            <div align="center" class="compactCalDate"><asp:Label runat="server" Text='<%# Eval("reqDate","{0:dd}")%>' /></div>
							                <asp:Table runat="server" CssClass="mobilePopUpPanel">
                                                <asp:TableRow>
                                                    <asp:TableCell CssClass="mobilePopUpLabel" style="padding-right:10px;">Date</asp:TableCell>
                                                    <asp:TableCell><%# Eval("reqDate","{0:dd-MMM-yyyy}") %></asp:TableCell>
                                                </asp:TableRow>
                                                <asp:TableRow>
                                                    <asp:TableCell CssClass="mobilePopUpLabel" style="padding-right:10px;">Time</asp:TableCell>
                                                    <asp:TableCell><%# Eval("reqTime","{0:hh:mm tt}") %></asp:TableCell>
                                                </asp:TableRow>
                                                <asp:TableRow style="position:relative;">
                                                    <asp:TableCell ColumnSpan="2"><asp:Image runat="server" ImageUrl="~/App_Themes/baseObjects/bubblePointerSm_e2.png" style="line-height:1.5em;width:19px;position:absolute;bottom:-6px;left:10px;"/></asp:TableCell>
                                                </asp:TableRow>
                                            </asp:Table>
                                        </asp:Panel>
                                        </div>
                                    </itemtemplate>
                                </asp:templatefield>
                                <asp:BoundField DataField="reqTime" SortExpression="reqTime" Headertext="Time" ItemStyle-Width="1%" ItemStyle-Wrap="false" DataFormatString="{0:hh:mm:ss tt}" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" ReadOnly="True" ShowHeader="True">
                                    <HeaderStyle CssClass="altSumItmHeader w3-hide-small w3-hide-medium" />
                                    <ItemStyle CssClass="altSumItmRow w3-hide-small w3-hide-medium"/>
                                </asp:BoundField>  
                                <asp:BoundField DataField="hub" Headertext="Hub" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                                    <HeaderStyle CssClass="altSumItmHeader altSumItmHeaderOveride"/>
                                    <ItemStyle CssClass="altSumItmRow"/>
                                </asp:BoundField>
                                <asp:BoundField DataField="field" SortExpression="field" Headertext="Platform" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                                    <HeaderStyle CssClass="altSumItmHeader" />
                                    <ItemStyle CssClass="altSumItmRow"/>
                                </asp:BoundField>
                                <asp:BoundField DataField="ptwId" SortExpression="ptwId" Headertext="PTW #" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                                    <HeaderStyle CssClass="altSumItmHeader" />
                                    <ItemStyle CssClass="altSumItmRow"/>
                                </asp:BoundField>
                                <asp:BoundField DataField="processSystem" SortExpression="processSystem" Headertext="Process System" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                                    <HeaderStyle CssClass="altSumItmHeader w3-hide-small" />
                                    <ItemStyle CssClass="altSumItmRow w3-hide-small"/>
                                </asp:BoundField>
                                <asp:BoundField DataField="controlSystem" SortExpression="controlSystem" Headertext="Control System" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                                    <HeaderStyle CssClass="altSumItmHeader w3-hide-small" />
                                    <ItemStyle CssClass="altSumItmRow w3-hide-small"/>
                                </asp:BoundField>
                                <asp:BoundField DataField="riskRating" SortExpression="riskRating" Headertext="Risk Rating" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                                    <HeaderStyle CssClass="altSumItmHeader w3-hide-small" />
                                    <ItemStyle CssClass="altSumItmRow w3-hide-small"/>
                                </asp:BoundField>
                                <asp:templatefield SortExpression="statusDesc" HeaderText="Last Status" ItemStyle-Wrap="false" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="false">
                                    <HeaderStyle CssClass="altSumItmHeader w3-hide-small" />
                                    <ItemStyle CssClass="altSumItmRow w3-hide-small"/>
                                    <itemtemplate>
                                        <div style="position:relative">
                                            <asp:Label runat="server" Text='<%# Eval("statusDesc") %>' />
                                            <asp:Label runat="server" CssClass="statusIndText" Style="float:right" Text="NEW" Visible='<%# Convert.ToInt32(Eval("curMode")) < 3 && Convert.ToInt32(Eval("extCount")) == 0 ? true : false %>' />
                                            <asp:Label runat="server" CssClass="statusIndText" Style="float:right" Text="CMPL" Visible='<%# Convert.ToInt32(Eval("curMode")) == 3 ? true : false %>' />                                            
                                            <asp:Label runat="server" CssClass="statusIndText" Style="float:right" Text='<%# "EXT " + Eval("extCount") %>' Visible='<%# Convert.ToInt32(Eval("curMode")) == 2 && Convert.ToInt32(Eval("extCount")) > 0 ? true : false %>' />
                                        </div>
                                    </itemtemplate>
                                </asp:templatefield>
                                <asp:templatefield ItemStyle-Width="1%" ItemStyle-Wrap="false" ConvertEmptyStringToNull="false" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                                    <HeaderStyle CssClass="summaryBtnHeader"/>
                                    <ItemStyle CssClass="altSumItmRow altSumItmRowRightOveride"/>
                                    <HeaderTemplate>
                                        <asp:linkbutton ID="refreshTable" runat="server" OnClick="RefreshTable" CommandArgument="2" CssClass="material-icons mainRefreshBtn" Text="cached" />
                                    </HeaderTemplate>
                                    <itemtemplate>
                                        <asp:Label runat="server" CssClass="material-icons iconBtnBlue" Text="list_alt" Style="font-size:32px;overflow:hidden; padding:1px 0px 0px 1px" OnClick=<%# "openReport('"+ Eval("formId") +"','form','MOS','SELF');return false;" %>/>
                                    </itemtemplate>
                                </asp:templatefield>
                                <asp:CommandField ShowEditButton="True" ShowSelectButton="False" ShowDeleteButton="False" ShowCancelButton="False" EditText="edit" buttontype="Link" HeaderImageUrl="~/App_Themes/baseObjects/btnImg_filler.png" ItemStyle-HorizontalAlign="Center">
                                    <HeaderStyle CssClass="hiddenColumn" />            
                                    <itemstyle CssClass="hiddenColumn"/>
                                </asp:CommandField>
                            </Columns>
                        </asp:GridView>
                    </asp:Panel>
                </asp:Panel>

                <div class="tagTitleRoot" style="margin:30px 0px;"></div>

                <ajax:CollapsiblePanelExtender ID="mosInProgressCPE" runat="server" TargetControlID="mosProgressPanel" CollapsedSize="0" ExpandControlID="progressHeader" CollapseControlID="progressHeader" Collapsed="false" AutoCollapse="False" ExpandedText="Hide Details"  />
                <asp:Panel ID="inProgressPanel" runat="server" CssClass="altSumRootHeaderAlt">
                    <asp:Table ID="progressHeader" runat="server" Height="40" onclick="panelIndicator('REQ','0');">
                        <asp:TableRow>
                            <asp:TableCell Width="10" style="background-color:rgba(220, 224, 231, 0.30)"></asp:TableCell>
                            <asp:TableCell Style="position:relative">
                                <asp:Label runat="server" CssClass="material-icons altSumRootHeaderIcon" Text="all_inbox"/>
                                <asp:Label runat="server" CssClass="altSumRootHeaderLabel" Text="In Progress"/>
                                <asp:Label ID="mosPassCnt" runat="server" CssClass="syncColTitle" Style="position:absolute;left:181px;top:14px" />
                            </asp:TableCell>
                            <asp:TableCell Width="1%"><asp:Button ID="inProgressExpander" runat="server" CssClass="material-icons flowExpander" Text="arrow_drop_up" AccessKey="0" ToolTip="Expand" OnClientClick="return false;" /></asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <asp:Panel ID="mosProgressPanel" runat="server" Style="padding-top:10px">
                        <asp:GridView id="mosProgressGV" runat="server" width="100%" CssClass="altSumRoot" AutoGenerateColumns="false" DataSourceID="mosPassDS" DataKeyNames="formId" 
                            AllowSorting="true" EnableSortingAndPagingCallbacks="true" EnableViewState="true" AllowPaging="true" PagerSettings-Mode="NumericFirstLast" PageSize="10" PagerSettings-Position="Bottom" PagerSettings-PageButtonCount="5">
                            <RowStyle Wrap="True" CssClass="altSumRow" />
                            <AlternatingRowStyle CssClass="altSumRowAlt" />
                            <HeaderStyle CssClass="altSumRowHeader" />
                            <SortedAscendingHeaderStyle CssClass="altSumAscHeader"/>
                            <SortedDescendingHeaderStyle CssClass="altSumDscHeader" />
                            <EmptyDataTemplate>
                                <asp:Table runat="server" style="padding:2px;">
                                    <asp:TableRow CssClass="summaryItemHeader" Height="30">
                                        <asp:TableCell>
                                            <asp:Label runat="server" Text="QUERY RESULT" Style="padding-left:10px;" />
                                            <asp:Image runat="server" ImageAlign="absmiddle" ImageUrl="~/App_Themes/baseObjects/btnImg_filler.png" style="float:right;margin:3px 10px 0px 0px;"/>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow Height="80">
                                        <asp:TableCell>
                                            <asp:Label runat="server" CssClass="w3-text-grey" Text="No active request currently available" Style="margin-left:40px" />
                                        </asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                            </EmptyDataTemplate>
                            <PagerTemplate>
                                <asp:Table runat="server" HorizontalAlign="Center">
                                    <asp:TableRow>
                                        <asp:TableCell HorizontalAlign="Left" VerticalAlign="Top" Style="padding:22px 0px 0px 0px;">
                                            <asp:LinkButton ID="prevPg" runat="server" CssClass="fa fa-arrow-left w3-hover-text-red" Style="color:#999999;font-size:20px;text-decoration:none;margin:0px 10px;" ToolTip="Previous Page" CommandName="Page" CommandArgument="Prev"/>
                                            <asp:LinkButton ID="nextPg" runat="server" CssClass="fa fa-arrow-right w3-hover-text-red" Style="color:#999999;font-size:20px;text-decoration:none;" ToolTip="Next Page" CommandName="Page" CommandArgument="Next"/>
                                        </asp:TableCell>
                                        <asp:TableCell HorizontalAlign="Right" VerticalAlign="Top" style="padding:15px 5px 2px 0px;">
                                            <asp:Label runat="server" Text="Showing" CssClass="w3-text-grey" Style="margin:0px 15px;" Visible="false" />
                                            <asp:DropDownList ID="pageSizeSelect" runat="server" selectedvalue='<%# mosProgressGV.PageSize %>' OnSelectedIndexChanged="SetPagerSize" AccessKey="2" AutoPostBack="true" EnableViewState="true" CssClass="dashDropDown" Enabled="true"> 
                                                <asp:ListItem Text="10" Value="10"/>
                                                <asp:ListItem Text="20" Value="20"/>
                                                <asp:ListItem Text="50" Value="50"/>                                        
                                                <asp:ListItem Text="100" Value="100"/>                                       
                                            </asp:DropDownList>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                            </PagerTemplate>
                            <Columns>                        
                                <asp:templatefield SortExpression="reqDate" HeaderText="Date" ItemStyle-Width="1%" ItemStyle-Wrap="false" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="false">
                                    <HeaderStyle CssClass="altSumItmHeader" />
                                    <ItemStyle CssClass="altSumItmRow altSumItmRowLeftOveride"/>
                                    <itemtemplate>
                                        <asp:Label ID="rptDateFull" runat="server" Text='<%# Bind("reqDate","{0:dd-MMM-yyyy}")%>' CssClass="w3-hide-small w3-hide-medium"/>
                                        <div align="Center">
                                        <asp:Panel ID="rptDateCompact" runat="server" CssClass="compactCalRoot mobilePopUpCalShow w3-hide-large">
                        	                <div align="center" class="compactCalMonth"><asp:Label runat="server" Text='<%# Eval("reqDate","{0:MMM}")%>' /></div>
                                            <div align="center" class="compactCalDate"><asp:Label runat="server" Text='<%# Eval("reqDate","{0:dd}")%>' /></div>
							                <asp:Table runat="server" CssClass="mobilePopUpPanel">
                                                <asp:TableRow>
                                                    <asp:TableCell CssClass="mobilePopUpLabel" style="padding-right:10px;">Date</asp:TableCell>
                                                    <asp:TableCell><%# Eval("reqDate","{0:dd-MMM-yyyy}") %></asp:TableCell>
                                                </asp:TableRow>
                                                <asp:TableRow>
                                                    <asp:TableCell CssClass="mobilePopUpLabel" style="padding-right:10px;">Time</asp:TableCell>
                                                    <asp:TableCell><%# Eval("reqTime","{0:hh:mm tt}") %></asp:TableCell>
                                                </asp:TableRow>
                                                <asp:TableRow style="position:relative;">
                                                    <asp:TableCell ColumnSpan="2"><asp:Image runat="server" ImageUrl="~/App_Themes/baseObjects/bubblePointerSm_e2.png" style="line-height:1.5em;width:19px;position:absolute;bottom:-6px;left:10px;"/></asp:TableCell>
                                                </asp:TableRow>
                                            </asp:Table>
                                        </asp:Panel>
                                        </div>
                                    </itemtemplate>
                                </asp:templatefield>
                                <asp:BoundField DataField="reqTime" SortExpression="reqTime" Headertext="Time" ItemStyle-Width="1%" ItemStyle-Wrap="false" DataFormatString="{0:hh:mm:ss tt}" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" ReadOnly="True" ShowHeader="True">
                                    <HeaderStyle CssClass="altSumItmHeader w3-hide-small w3-hide-medium" />
                                    <ItemStyle CssClass="altSumItmRow w3-hide-small w3-hide-medium"/>
                                </asp:BoundField>  
                                <asp:BoundField DataField="hub" Headertext="Hub" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                                    <HeaderStyle CssClass="altSumItmHeader altSumItmHeaderOveride"/>
                                    <ItemStyle CssClass="altSumItmRow"/>
                                </asp:BoundField>
                                <asp:BoundField DataField="field" SortExpression="field" Headertext="Platform" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                                    <HeaderStyle CssClass="altSumItmHeader" />
                                    <ItemStyle CssClass="altSumItmRow"/>
                                </asp:BoundField>
                                <asp:BoundField DataField="ptwId" SortExpression="ptwId" Headertext="PTW #" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                                    <HeaderStyle CssClass="altSumItmHeader" />
                                    <ItemStyle CssClass="altSumItmRow"/>
                                </asp:BoundField>
                                <asp:BoundField DataField="processSystem" SortExpression="processSystem" Headertext="Process System" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                                    <HeaderStyle CssClass="altSumItmHeader w3-hide-small" />
                                    <ItemStyle CssClass="altSumItmRow w3-hide-small"/>
                                </asp:BoundField>
                                <asp:BoundField DataField="controlSystem" SortExpression="controlSystem" Headertext="Control System" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                                    <HeaderStyle CssClass="altSumItmHeader w3-hide-small" />
                                    <ItemStyle CssClass="altSumItmRow w3-hide-small"/>
                                </asp:BoundField>
                                <asp:BoundField DataField="riskRating" SortExpression="riskRating" Headertext="Risk Rating" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                                    <HeaderStyle CssClass="altSumItmHeader w3-hide-small" />
                                    <ItemStyle CssClass="altSumItmRow w3-hide-small"/>
                                </asp:BoundField>
                                <asp:templatefield SortExpression="statusDesc" HeaderText="Last Status" ItemStyle-Wrap="false" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="false">
                                    <HeaderStyle CssClass="altSumItmHeader w3-hide-small" />
                                    <ItemStyle CssClass="altSumItmRow w3-hide-small"/>
                                    <itemtemplate>
                                        <div style="position:relative">
                                            <asp:Label runat="server" Text='<%# Eval("statusDesc") %>' />
                                            <asp:Label runat="server" CssClass="statusIndText" Style="float:right" Text="NEW" Visible='<%# Convert.ToInt32(Eval("curMode")) < 3 && Convert.ToInt32(Eval("extCount")) == 0 ? true : false %>' />
                                            <asp:Label runat="server" CssClass="statusIndText" Style="float:right" Text="CMPL" Visible='<%# Convert.ToInt32(Eval("curMode")) == 3 ? true : false %>' />                                            
                                            <asp:Label runat="server" CssClass="statusIndText" Style="float:right" Text='<%# "EXT " + Eval("extCount") %>' Visible='<%# Convert.ToInt32(Eval("curMode")) == 2 && Convert.ToInt32(Eval("extCount")) > 0 ? true : false %>' />
                                        </div>
                                    </itemtemplate>
                                </asp:templatefield>
                                <asp:templatefield ItemStyle-Width="1%" ItemStyle-Wrap="false" ConvertEmptyStringToNull="false" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                                    <HeaderStyle CssClass="summaryBtnHeader"/>
                                    <ItemStyle CssClass="altSumItmRow altSumItmRowRightOveride"/>
                                    <HeaderTemplate>
                                        <asp:linkbutton ID="refreshTable" runat="server" OnClick="RefreshTable" CommandArgument="2" CssClass="material-icons mainRefreshBtn" Text="cached" />
                                    </HeaderTemplate>
                                    <itemtemplate>
                                        <asp:Label runat="server" CssClass="material-icons iconBtnBlue" Text="list_alt" Style="font-size:32px;overflow:hidden; padding:1px 0px 0px 1px" OnClick=<%# "openReport('"+ Eval("formId") +"','form','MOS','BLANK');return false;" %>/>
                                    </itemtemplate>
                                </asp:templatefield>
                                <asp:CommandField ShowEditButton="True" ShowSelectButton="False" ShowDeleteButton="False" ShowCancelButton="False" EditText="edit" buttontype="Link" HeaderImageUrl="~/App_Themes/baseObjects/btnImg_filler.png" ItemStyle-HorizontalAlign="Center">
                                    <HeaderStyle CssClass="hiddenColumn" />            
                                    <itemstyle CssClass="hiddenColumn"/>
                                </asp:CommandField>
                            </Columns>
                        </asp:GridView>
                    </asp:Panel>
                </asp:Panel>                

                <ajax:CollapsiblePanelExtender ID="mosArchiveCPE" runat="server" TargetControlID="mosArchivePanel" CollapsedSize="0" ExpandControlID="archiveHeader" CollapseControlID="archiveHeader" Collapsed="true" AutoCollapse="False" ExpandedText="Hide Details"  />
                <asp:Panel ID="archivePanel" runat="server" CssClass="altSumRootHeaderAlt" Style="margin-top:20px">
                    <asp:Table ID="archiveHeader" runat="server" Height="40" onclick="panelIndicator('ARC','0');">
                        <asp:TableRow>
                            <asp:TableCell Width="10" style="background-color:rgba(220, 224, 231, 0.30)"></asp:TableCell>
                            <asp:TableCell Style="position:relative">
                                <asp:Label runat="server" CssClass="material-icons altSumRootHeaderIcon" Text="all_inbox"/>
                                <asp:Label runat="server" CssClass="altSumRootHeaderLabel" Text="Archived"/>
                                <asp:Label ID="mosArchiveCnt" runat="server" CssClass="syncColTitle" Style="position:absolute;left:152px;top:14px" />
                            </asp:TableCell>
                            <asp:TableCell Width="1%"><asp:Button ID="archiveExpander" runat="server" CssClass="material-icons flowExpander" Text="arrow_drop_down" AccessKey="1" ToolTip="Expand" OnClientClick="return false;" /></asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <asp:Panel ID="mosArchivePanel" runat="server" Style="padding-top:10px">
                        <asp:GridView id="mosArchiveGV" runat="server" width="100%" CssClass="altSumRoot" AutoGenerateColumns="false" DataSourceID="mosArchiveDS" DataKeyNames="formId" 
                            AllowSorting="true" EnableSortingAndPagingCallbacks="true" EnableViewState="true" AllowPaging="true" PagerSettings-Mode="NumericFirstLast" PageSize="10" PagerSettings-Position="Bottom" PagerSettings-PageButtonCount="5">
                            <RowStyle Wrap="True" CssClass="altSumRow" />
                            <AlternatingRowStyle CssClass="altSumRowAlt" />
                            <HeaderStyle CssClass="altSumRowHeader" />
                            <SortedAscendingHeaderStyle CssClass="altSumAscHeader"/>
                            <SortedDescendingHeaderStyle CssClass="altSumDscHeader" />
                            <EmptyDataTemplate>
                                <asp:Table runat="server" style="padding:2px;">
                                    <asp:TableRow CssClass="summaryItemHeader" Height="30">
                                        <asp:TableCell>
                                            <asp:Label runat="server" Text="QUERY RESULT" Style="padding-left:10px;" />
                                            <asp:Image runat="server" ImageAlign="absmiddle" ImageUrl="~/App_Themes/baseObjects/btnImg_filler.png" style="float:right;margin:3px 10px 0px 0px;"/>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow Height="80">
                                        <asp:TableCell>
                                            <asp:Label runat="server" CssClass="w3-text-grey" Text="No archive request currently available" Style="margin-left:40px" />
                                        </asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                            </EmptyDataTemplate>
                            <PagerTemplate>
                                <asp:Table runat="server" HorizontalAlign="Center">
                                    <asp:TableRow>
                                        <asp:TableCell HorizontalAlign="Left" VerticalAlign="Top" Style="padding:22px 0px 0px 0px;">
                                            <asp:LinkButton ID="prevPg" runat="server" CssClass="fa fa-arrow-left w3-hover-text-red" Style="color:#999999;font-size:20px;text-decoration:none;margin:0px 10px;" ToolTip="Previous Page" CommandName="Page" CommandArgument="Prev"/>
                                            <asp:LinkButton ID="nextPg" runat="server" CssClass="fa fa-arrow-right w3-hover-text-red" Style="color:#999999;font-size:20px;text-decoration:none;" ToolTip="Next Page" CommandName="Page" CommandArgument="Next"/>
                                        </asp:TableCell>
                                        <asp:TableCell HorizontalAlign="Right" VerticalAlign="Top" style="padding:15px 5px 2px 0px;">
                                            <asp:Label runat="server" Text="Showing" CssClass="w3-text-grey" Style="margin:0px 15px;" Visible="false" />
                                            <asp:DropDownList ID="pageSizeSelect" runat="server" selectedvalue='<%# mosArchiveGV.PageSize %>' OnSelectedIndexChanged="SetPagerSize" AccessKey="3" AutoPostBack="true" EnableViewState="true" CssClass="dashDropDown" Enabled="true"> 
                                                <asp:ListItem Text="10" Value="10"/>
                                                <asp:ListItem Text="20" Value="20"/>
                                                <asp:ListItem Text="50" Value="50"/>                                        
                                                <asp:ListItem Text="100" Value="100"/>                                       
                                            </asp:DropDownList>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                            </PagerTemplate>
                            <Columns>                        
                                <asp:templatefield SortExpression="reqDate" HeaderText="Date" ItemStyle-Width="1%" ItemStyle-Wrap="false" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="false">
                                    <HeaderStyle CssClass="altSumItmHeader" />
                                    <ItemStyle CssClass="altSumItmRow altSumItmRowLeftOveride"/>
                                    <itemtemplate>
                                        <asp:Label ID="rptDateFull" runat="server" Text='<%# Bind("reqDate","{0:dd-MMM-yyyy}")%>' CssClass="w3-hide-small w3-hide-medium"/>
                                        <div align="Center">
                                        <asp:Panel ID="rptDateCompact" runat="server" CssClass="compactCalRoot mobilePopUpCalShow w3-hide-large">
                        	                <div align="center" class="compactCalMonth"><asp:Label runat="server" Text='<%# Eval("reqDate","{0:MMM}")%>' /></div>
                                            <div align="center" class="compactCalDate"><asp:Label runat="server" Text='<%# Eval("reqDate","{0:dd}")%>' /></div>
							                <asp:Table runat="server" CssClass="mobilePopUpPanel">
                                                <asp:TableRow>
                                                    <asp:TableCell CssClass="mobilePopUpLabel" style="padding-right:10px;">Date</asp:TableCell>
                                                    <asp:TableCell><%# Eval("reqDate","{0:dd-MMM-yyyy}") %></asp:TableCell>
                                                </asp:TableRow>
                                                <asp:TableRow>
                                                    <asp:TableCell CssClass="mobilePopUpLabel" style="padding-right:10px;">Time</asp:TableCell>
                                                    <asp:TableCell><%# Eval("reqTime","{0:hh:mm tt}") %></asp:TableCell>
                                                </asp:TableRow>
                                                <asp:TableRow style="position:relative;">
                                                    <asp:TableCell ColumnSpan="2"><asp:Image runat="server" ImageUrl="~/App_Themes/baseObjects/bubblePointerSm_e2.png" style="line-height:1.5em;width:19px;position:absolute;bottom:-6px;left:10px;"/></asp:TableCell>
                                                </asp:TableRow>
                                            </asp:Table>
                                        </asp:Panel>
                                        </div>
                                    </itemtemplate>
                                </asp:templatefield>
                                <asp:BoundField DataField="reqTime" SortExpression="reqTime" Headertext="Time" ItemStyle-Width="1%" ItemStyle-Wrap="false" DataFormatString="{0:hh:mm:ss tt}" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" ReadOnly="True" ShowHeader="True">
                                    <HeaderStyle CssClass="altSumItmHeader w3-hide-small w3-hide-medium" />
                                    <ItemStyle CssClass="altSumItmRow w3-hide-small w3-hide-medium"/>
                                </asp:BoundField>  
                                <asp:BoundField DataField="hub" Headertext="Hub" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                                    <HeaderStyle CssClass="altSumItmHeader altSumItmHeaderOveride"/>
                                    <ItemStyle CssClass="altSumItmRow"/>
                                </asp:BoundField>
                                <asp:BoundField DataField="field" SortExpression="field" Headertext="Platform" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                                    <HeaderStyle CssClass="altSumItmHeader" />
                                    <ItemStyle CssClass="altSumItmRow"/>
                                </asp:BoundField>
                                <asp:BoundField DataField="ptwId" SortExpression="ptwId" Headertext="PTW #" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                                    <HeaderStyle CssClass="altSumItmHeader" />
                                    <ItemStyle CssClass="altSumItmRow"/>
                                </asp:BoundField>
                                <asp:BoundField DataField="processSystem" SortExpression="processSystem" Headertext="Process System" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                                    <HeaderStyle CssClass="altSumItmHeader w3-hide-small" />
                                    <ItemStyle CssClass="altSumItmRow w3-hide-small"/>
                                </asp:BoundField>
                                <asp:BoundField DataField="controlSystem" SortExpression="controlSystem" Headertext="Control System" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                                    <HeaderStyle CssClass="altSumItmHeader w3-hide-small" />
                                    <ItemStyle CssClass="altSumItmRow w3-hide-small"/>
                                </asp:BoundField>
                                <asp:BoundField DataField="riskRating" SortExpression="riskRating" Headertext="Risk Rating" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                                    <HeaderStyle CssClass="altSumItmHeader w3-hide-small" />
                                    <ItemStyle CssClass="altSumItmRow w3-hide-small"/>
                                </asp:BoundField>
                                <asp:BoundField DataField="statusDesc" SortExpression="statusDesc" Headertext="Last Status" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                                    <HeaderStyle CssClass="altSumItmHeader w3-hide-small" />
                                    <ItemStyle CssClass="altSumItmRow w3-hide-small"/>
                                </asp:BoundField>
                                <asp:templatefield ItemStyle-Width="1%" ItemStyle-Wrap="false" ConvertEmptyStringToNull="false" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                                    <HeaderStyle CssClass="summaryBtnHeader"/>
                                    <ItemStyle CssClass="altSumItmRow altSumItmRowRightOveride"/>
                                    <HeaderTemplate>
                                        <asp:linkbutton ID="refreshTable" runat="server" OnClick="RefreshTable" CommandArgument="2" CssClass="material-icons mainRefreshBtn" Text="cached" />
                                    </HeaderTemplate>
                                    <itemtemplate>
                                        <asp:Label runat="server" CssClass="material-icons iconBtnBlue" Text="list_alt" Style="font-size:32px;overflow:hidden; padding:1px 0px 0px 1px" OnClick=<%# "openReport('"+ Eval("formId") +"','form','MOS','BLANK');return false;" %>/>
                                    </itemtemplate>
                                </asp:templatefield>
                                <asp:CommandField ShowEditButton="True" ShowSelectButton="False" ShowDeleteButton="False" ShowCancelButton="False" EditText="edit" buttontype="Link" HeaderImageUrl="~/App_Themes/baseObjects/btnImg_filler.png" ItemStyle-HorizontalAlign="Center">
                                    <HeaderStyle CssClass="hiddenColumn" />            
                                    <itemstyle CssClass="hiddenColumn"/>
                                </asp:CommandField>
                            </Columns>
                        </asp:GridView>
                    </asp:Panel>
                </asp:Panel>

            </asp:Panel>

            <!-- ------------------------- -->

            <asp:HiddenField ID="userRole" runat="server"/>
            <asp:HiddenField ID="userHub" runat="server"/>
            <asp:HiddenField ID="reqFormId" runat="server"/>
            
            <!-- ------------------------- -->

        </ContentTemplate>
        </asp:UpdatePanel>
    </div>

    <!-- 'main data source section -->
    <asp:SqlDataSource id="mosPendingDS" runat="server" DataSourceMode="DataSet" 
        SelectCommand="SELECT a.*, CAST(a.reqTimestamp as date) as reqDate, CAST(a.reqTimestamp as smalldatetime) as reqTime, b.statusDesc FROM form_mos a LEFT OUTER JOIN adm_list_status b ON b.statusCode=a.curState WHERE reqStatus=1 AND nextRole=@userRole AND hub=@userHub AND curState NOT IN (10,11) ORDER BY curState,reqDate DESC" 
        FilterExpression="(ISNULL(ptwId,'') LIKE '%{0}%' OR ISNULL(hub,'') LIKE '%{0}%' OR ISNULL(field,'') LIKE '%{0}%' OR ISNULL(processSystem,'') LIKE '%{0}%' OR ISNULL(controlSystem,'') LIKE '%{0}%' OR ISNULL(isolateFunction,'') LIKE '%{0}%' OR ISNULL(isolateMethod,'') LIKE '%{0}%' OR ISNULL(isolatePurpose,'') LIKE '%{0}%' OR ISNULL(isolateEffect,'') LIKE '%{0}%' OR ISNULL(altSafetySystem,'') LIKE '%{0}%' OR ISNULL(riskRemarks,'') LIKE '%{0}%' OR ISNULL(riskRating,'') LIKE '%{0}%' OR ISNULL(mitigateMethod,'') LIKE '%{0}%')" 
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
        <FilterParameters>
            <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="%" PropertyName="Text" ControlID="search" />
            <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="%" PropertyName="Text" ControlID="mobileSearch" />
        </FilterParameters>
        <SelectParameters>
            <asp:ControlParameter ConvertEmptyStringToNull="False" DefaultValue="0" PropertyName="Value" Name="userRole" ControlID="userRole" />
            <asp:ControlParameter ConvertEmptyStringToNull="False" DefaultValue="0" PropertyName="Value" Name="userHub" ControlID="userHub" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource id="mosPassDS" runat="server" DataSourceMode="DataSet" 
        SelectCommand="SELECT a.*, CAST(a.reqTimestamp as date) as reqDate, CAST(a.reqTimestamp as smalldatetime) as reqTime, b.statusDesc FROM form_mos a LEFT OUTER JOIN adm_list_status b ON b.statusCode=a.curState WHERE reqStatus=1 AND NOT (nextRole=@userRole) AND hub=@userHub AND curState NOT IN (10,11) ORDER BY curState,reqDate DESC" 
        FilterExpression="(ISNULL(ptwId,'') LIKE '%{0}%' OR ISNULL(hub,'') LIKE '%{0}%' OR ISNULL(field,'') LIKE '%{0}%' OR ISNULL(processSystem,'') LIKE '%{0}%' OR ISNULL(controlSystem,'') LIKE '%{0}%' OR ISNULL(isolateFunction,'') LIKE '%{0}%' OR ISNULL(isolateMethod,'') LIKE '%{0}%' OR ISNULL(isolatePurpose,'') LIKE '%{0}%' OR ISNULL(isolateEffect,'') LIKE '%{0}%' OR ISNULL(altSafetySystem,'') LIKE '%{0}%' OR ISNULL(riskRemarks,'') LIKE '%{0}%' OR ISNULL(riskRating,'') LIKE '%{0}%' OR ISNULL(mitigateMethod,'') LIKE '%{0}%')" 
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
        <FilterParameters>
            <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="%" PropertyName="Text" ControlID="search" />
            <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="%" PropertyName="Text" ControlID="mobileSearch" />
        </FilterParameters>
        <SelectParameters>
            <asp:ControlParameter ConvertEmptyStringToNull="False" DefaultValue="0" PropertyName="Value" Name="userRole" ControlID="userRole" />
            <asp:ControlParameter ConvertEmptyStringToNull="False" DefaultValue="0" PropertyName="Value" Name="userHub" ControlID="userHub" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource id="mosArchiveDS" runat="server" DataSourceMode="DataSet" 
        SelectCommand="SELECT a.*, CAST(a.reqTimestamp as date) as reqDate, CAST(a.reqTimestamp as smalldatetime) as reqTime, b.statusDesc FROM form_mos a LEFT OUTER JOIN adm_list_status b ON b.statusCode=a.curState WHERE reqStatus=1 AND curState IN (10,11) AND hub=@userHub ORDER BY curState,reqDate DESC" 
        FilterExpression="(ISNULL(ptwId,'') LIKE '%{0}%' OR ISNULL(hub,'') LIKE '%{0}%' OR ISNULL(field,'') LIKE '%{0}%' OR ISNULL(processSystem,'') LIKE '%{0}%' OR ISNULL(controlSystem,'') LIKE '%{0}%' OR ISNULL(isolateFunction,'') LIKE '%{0}%' OR ISNULL(isolateMethod,'') LIKE '%{0}%' OR ISNULL(isolatePurpose,'') LIKE '%{0}%' OR ISNULL(isolateEffect,'') LIKE '%{0}%' OR ISNULL(altSafetySystem,'') LIKE '%{0}%' OR ISNULL(riskRemarks,'') LIKE '%{0}%' OR ISNULL(riskRating,'') LIKE '%{0}%' OR ISNULL(mitigateMethod,'') LIKE '%{0}%')" 
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
        <FilterParameters>
            <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="%" PropertyName="Text" ControlID="search" />
            <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="%" PropertyName="Text" ControlID="mobileSearch" />
        </FilterParameters>
        <SelectParameters>
            <asp:ControlParameter ConvertEmptyStringToNull="False" DefaultValue="0" PropertyName="Value" Name="userRole" ControlID="userRole" />
            <asp:ControlParameter ConvertEmptyStringToNull="False" DefaultValue="0" PropertyName="Value" Name="userHub" ControlID="userHub" />
        </SelectParameters>
    </asp:SqlDataSource>

</asp:Content>