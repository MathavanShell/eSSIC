<%@ Page Title="" Language="C#" MasterPageFile="~/template/Default.Master" Async="true" AutoEventWireup="true" CodeBehind="monitor.aspx.cs" Inherits="eSSIC.Monitor" %>
<%@ MasterType VirtualPath="~/template/Default.Master" %>

<asp:Content ID="headerSection" ContentPlaceHolderID="HeaderContent" runat="server"></asp:Content>
<asp:Content ID="mainSection" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
        <!-- 'Active MOS info section -->        
        <asp:Panel ID="topInfo" runat="server" Height="50" Style="position:relative">               
            
        </asp:Panel>
        <asp:Panel ID="mosInfo" runat="server" CssClass="reportContent" Style="position:relative">
            <asp:UpdatePanel runat="server"><ContentTemplate>                
                <asp:Label ID="updateTime" runat="server" CssClass="syncColTitle" Style="color:#999999;font-weight:normal;position:absolute;right:5px;top:-20px" ToolTip="Last Update" />
            </ContentTemplate></asp:UpdatePanel>                
            <div class="tagTitleRoot" style="margin-top:15px;">
                <div class="tagTitleTab">
            	    <asp:Image runat="server" ImageUrl="~/App_Themes/baseObjects/icon_overrideTitle.png" Height="16"/>
                </div>
            </div>
            <div class="w3-row">
                <asp:UpdatePanel ID="mosPanelUP" runat="server" UpdateMode="Conditional"><ContentTemplate>
                    <div class="w3-col s12 m12 l7">
                        <div style="height:50px;padding-top:5px;">
                            <asp:CheckBox ID="autoRefresh" runat="server" onchange="autoRefreshTable();" CssClass="w3-text-grey" Text="Auto Refresh" TextAlign="right" Checked="false" Style="float:left;margin:10px 0px 0px 5px;"/>
                            <asp:UpdatePanel ID="hubSelectUP" runat="server" style="float:right">
                                <ContentTemplate>
                                    <asp:Table ID="mosOption" runat="server">
                                        <asp:TableRow>
                                            <asp:TableCell HorizontalAlign="Right" VerticalAlign="Middle">
                                                <asp:DropDownList ID="showHub" runat="server" DataSourceId="hubListDS" DataTextField="hubName" DataValueField="hubName" CssClass="dashDropDown" Style="float:right;margin:0px 5px;" AutoPostBack="true" Appenddatabounditems="true" EnableViewState="true">
                                                    <asp:ListItem Text="All Hub" Value=""/>                 
                                                </asp:DropDownList>                                                
                                            </asp:TableCell>
                                            <asp:TableCell>                                                
                                                <div class="dashMode" Style="position:relative;padding:0px">
                                                    <asp:LinkButton ID="refreshTable" runat="server" OnClick="RefreshTagTable" CssClass="material-icons" Text="cached" Style="position:absolute;top:3px;left:3px;text-decoration:none;"/>
                                                </div>
                                                <asp:Button ID="autoRefreshBtn" runat="server" OnClick="RefreshTagTable" CausesValidation="false" Text="Auto" style="display:none"/>
                                            </asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>                                    
                                </ContentTemplate>                                
                            </asp:UpdatePanel>                            
                        </div>
                        <ajax:CollapsiblePanelExtender ID="mosMsgCPE" runat="server" TargetControlID="mosMsg" CollapsedSize="0" Collapsed="True"/>
                        <asp:Panel ID="mosMsg" runat="server" CssClass="notificationAlert">
                            <asp:Label ID="statusIcon" runat="server" CssClass="material-icons processing" Text="toys" Style="position:absolute;left:12px;top:8px;"/>
                            <asp:Label ID="statusMsg" runat="server" Style="margin-left:40px" Text="Status update in Progress" />
                        </asp:Panel>   
                        <asp:GridView id="activeMosGV" runat="server" width="100%" CellPadding="0" CellSpacing="0" AutoGenerateColumns="false" ShowHeader="false" EnableViewState="true" DataSourceID="activeMosDS" DataKeyNames="formId" OnRowDataBound="SetTagTable" OnDataBound="RefreshTagStatus"
                            AllowSorting="false" EnableSortingAndPagingCallbacks="false" AllowPaging="false" PagerSettings-Mode="NumericFirstLast" PageSize="10" PagerSettings-Position="Bottom" PagerSettings-PageButtonCount="5">
                            <RowStyle CssClass="dashboardRow" />
                            <AlternatingRowStyle CssClass="dashboardRowAlt" />
                            <EmptyDataTemplate>
                                <asp:Table runat="server">
                                    <asp:TableRow Style="height:50px;color:#666666;background-color:#FCFCFC;">
                                        <asp:TableCell style="padding-left:20px"><asp:Label runat="server" Text="No request found or matches filter criteria"/></asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                            </EmptyDataTemplate>
                            <PagerTemplate>
                                <asp:Table runat="server" HorizontalAlign="Center" Height="37" Style="margin-top:5px">
                                    <asp:TableRow>
                                        <asp:TableCell HorizontalAlign="Left" VerticalAlign="Middle" Style="padding: 0px 0px 2px 0px;">
                                            <asp:LinkButton ID="prevPg" runat="server" CssClass="fa fa-arrow-left w3-hover-text-red" Style="color:#999999;font-size:20px;text-decoration:none;margin:0px 10px;" ToolTip="Previous Page" CommandName="Page" CommandArgument="Prev"/>
                                            <asp:LinkButton ID="nextPg" runat="server" CssClass="fa fa-arrow-right w3-hover-text-red" Style="color:#999999;font-size:20px;text-decoration:none;" ToolTip="Next Page" CommandName="Page" CommandArgument="Next"/>
                                        </asp:TableCell>
                                        <asp:TableCell style="padding:0px 5px 1px 0px;">
                                            
                                        </asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                            </PagerTemplate>
                            <Columns>                                
                                <asp:templatefield ItemStyle-Wrap="true" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="false" ShowHeader="false" Visible="true">
                                    <ItemTemplate>
                                        <asp:Panel ID="header" runat="server" CssClass="flowHeader">
                                            <asp:Table runat="server" Style="min-height:50px">
                                                <asp:TableRow>
                                                    <asp:TableCell Style="width:5px;min-width:5px;" BackColor="WhiteSmoke"></asp:TableCell>
                                                    <asp:TableCell Width="130" VerticalAlign="Top" Style="position:relative;min-width:100px">
                                                        <asp:Label runat="server" CssClass="syncColTitle" Text="MOS Request" Style="position:absolute;left:10px;top:0px" />
                                                        <asp:LinkButton runat="server" OnClientClick=<%# "openReport('"+ Eval("formId") +"','form','DSB','BLANK');return false;" %> CssClass="flowLink" Text='<%# Eval("hub","{0}-") + Eval("mosId","{0:D5}") %>' Style="position:absolute;left:10px;top:15px" ToolTip="Details" />
                                                    </asp:TableCell>
                                                    <asp:TableCell HorizontalAlign="Left" CssClass="w3-text-grey" Style="padding:0px 30px 0px 20px;">
                                                        <asp:HiddenField ID="tagList" runat="server" Value='<%# Eval("tags") %>' />
                                                        <asp:Table ID="tagTable" Width="100%" runat="server"/>
                                                    </asp:TableCell>
                                                </asp:TableRow>
                                            </asp:Table>
                                        </asp:Panel>
                                    </ItemTemplate>
                                </asp:templatefield>
                            </Columns>
                        </asp:GridView>                            
                    </div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="search" EventName="TextChanged" />
                        <asp:AsyncPostBackTrigger ControlID="showHub" EventName="SelectedIndexChanged" />
                        <asp:AsyncPostBackTrigger ControlID="refreshTable" EventName="Click" />
                    </Triggers>
                </asp:UpdatePanel>
                <div class="w3-col s12 m12 l5">
                    <div style="height:50px;padding-top:5px;">
                        <asp:Table runat="server">
                            <asp:TableRow>
                                <asp:TableCell CssClass="w3-hide-large" Width="8"></asp:TableCell>
                                <asp:TableCell CssClass="w3-hide-small w3-hide-medium" Width="30"></asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label runat="server" CssClass="material-icons" Text="error_outline" Style="color:#DA291C;font-size:32px;float:left;margin:0px 0px 0px 0px" />
                                    <asp:Label runat="server" Text="NON-AUTHORIZED TAG" Style="color:#DA291C;font-size:12px;font-weight:bold;float:left;margin:9px 0px 0px 13px" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                    <asp:UpdatePanel runat="server" UpdateMode="Conditional"><ContentTemplate>
                        <asp:Table runat="server">
                            <asp:TableRow VerticalAlign="Top">
                                <asp:TableCell RowSpan="2" CssClass="w3-hide-large" Width="8"></asp:TableCell>
                                <asp:TableCell RowSpan="2" CssClass="w3-hide-small w3-hide-medium" Width="30"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell Height="100%" CssClass="syncStatusRoot w3-text-red" VerticalAlign="Top" Style="padding:15px 15px 15px 17px">                                    
                                    <asp:Table ID="nonTagTable" Width="100%" runat="server">
                                        <asp:TableRow>
                                            <asp:TableCell style="color:#999999"><asp:Label runat="server" Text="Pending status update"/></asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </asp:TableCell>
                            </asp:TableRow>                            
                        </asp:Table>                        
                        </ContentTemplate>
                        <Triggers>                            
                            <asp:AsyncPostBackTrigger ControlID="refreshTable" EventName="Click" />
                        </Triggers>
                    </asp:UpdatePanel>
                </div>
            </div>
        </asp:Panel>
        
        <!-- ------------------------- -->
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <asp:HiddenField ID="totalTagSection" runat="server" Value="1"/>
                <asp:TextBox ID="openTags" runat="server" Style="display:none" />
                <asp:HiddenField ID="totalRows" runat="server" />
                <asp:HiddenField ID="filterRows" runat="server" />
            </ContentTemplate>
        </asp:UpdatePanel>            
        <!-- ------------------------- -->
        
    </div>
    <asp:SqlDataSource id="hubListDS" runat="server" DataSourceMode="DataSet" 
        SelectCommand="SELECT * FROM adm_list_hub ORDER BY hubName"
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
    </asp:SqlDataSource> 
    
    <asp:SqlDataSource id="activeMosDS" runat="server" DataSourceMode="DataSet"  
        SelectCommand="SELECT a.formId,a.hub,a.field,a.mosId,(STUFF((SELECT DISTINCT '|' + (tagName +'^'+ CAST(manual as nvarchar)) FROM form_mos_tag b WHERE b.formId=a.formId FOR XML PATH('')),1,1,'')) As tags FROM form_mos a WHERE reqStatus=1 AND curState=5 ORDER BY formId DESC" 
        FilterExpression="(ISNULL(Convert(mosId,'System.String'),'') LIKE '%{0}%' OR ISNULL(hub,'') LIKE '%{0}%' OR ISNULL(field,'') LIKE '%{0}%') AND ISNULL(hub,'') LIKE '{2}'" 
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">        
        <FilterParameters>
            <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="%" PropertyName="Text" ControlID="search" />
            <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="%" PropertyName="Text" ControlID="mobileSearch" />
            <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="%" PropertyName="SelectedValue" ControlID="showHub" />
        </FilterParameters>
    </asp:SqlDataSource>

    <asp:SqlDataSource id="mosTagsDS" runat="server" DataSourceMode="DataSet" 
        SelectCommand="SELECT (STUFF((SELECT DISTINCT ',' + tagName FROM form_mos_tag b WHERE b.formId IN (SELECT formId FROM form_mos a WHERE reqStatus=1 AND curState=5) FOR XML PATH('')),1,1,'')) As tags, (SELECT COUNT(formId) FROM form_mos WHERE reqStatus=1 AND curState=5) AS cnt"
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
    </asp:SqlDataSource> 
</asp:Content>
