<%@ Page Title="" Language="C#" MasterPageFile="~/template/Default.Master" Async="true" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="eSSIC.Report" %>
<%@ MasterType VirtualPath="~/template/Default.Master" %>

<asp:Content ID="headerSection" ContentPlaceHolderID="HeaderContent" runat="server"></asp:Content>
<asp:Content ID="mainSection" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
      <asp:Panel ID="topInfo" runat="server" CssClass="w3-hide-small" Height="50" Style="position:center">               
            
        </asp:Panel>
        <asp:UpdatePanel runat="server">
        <ContentTemplate>
        <asp:Panel ID="filterMenu" runat="server" CssClass="reportContent" Enabled="true">
        <div class="w3-row">
            <div class="w3-col s12 m8 l8">
                <div class="w3-row">
                    <div class="w3-col s12 m8 l12">
                        <div class="w3-col s12 m12 l6">
                        <asp:Panel ID="dataFilter" runat="server" Enabled="true">
                            <asp:UpdatePanel runat="server" UpdateMode="Conditional" ChildrenAsTriggers="true"><ContentTemplate>
                                <asp:Table runat="server" CellPadding="3">                    
                                    <asp:TableRow>
                                        <asp:TableCell Width="110" Style="min-width:80px;">Hub</asp:TableCell>
                                        <asp:TableCell>
                                            <asp:DropDownList ID="hubList" runat="server" Width="200" CssClass="normalDropDown" Enabled="true" EnableViewState="false" AutoPostBack="true" DataSourceId="hubListDS" DataTextField="hubName" DataValueField="hubName" Appenddatabounditems="true">
                                                <asp:ListItem Text="" Value=""/>                   
                                            </asp:DropDownList>
                                        </asp:TableCell>
                                        <asp:TableCell Width="110" Style="min-width:80px;">PTW No.</asp:TableCell>
                                        <asp:TableCell>
                                            <asp:DropDownList ID="ptwlist" runat="server" Width="200" CssClass="normalDropDown" Enabled="true" EnableViewState="false" AutoPostBack="true" DataSourceId="ptwListDS" DataTextField="ptwId" DataValueField="ptwId" Appenddatabounditems="true">
                                                <asp:ListItem Text="" Value=""/>                   
                                            </asp:DropDownList>
                                        </asp:TableCell>
                                        <asp:TableCell Width="110" Style="min-width:80px;">SSIC Requester</asp:TableCell>
                                        <asp:TableCell>
                                        <asp:DropDownList ID="reqList" runat="server" Width="200" CssClass="normalDropDown" Enabled="true" EnableViewState="false" AutoPostBack="true" DataSourceId="reqListDS" DataTextField="reqId" DataValueField="reqId" Appenddatabounditems="true">
                                                <asp:ListItem Text="" Value=""/>                   
                                            </asp:DropDownList>
                                        </asp:TableCell>
                                           <asp:TableCell>Status</asp:TableCell>
                                        <asp:TableCell>
                                            <asp:DropDownList ID="statusList" runat="server" Width="200" CssClass="normalDropDown" Enabled="true" EnableViewState="false" AutoPostBack="true" DataSourceId="regStatusDS" DataTextField="statusDesc" DataValueField="statusDesc" Appenddatabounditems="true">
                                                <asp:ListItem Text="" Value=""/>                     
                                            </asp:DropDownList>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow> 
                                        <asp:TableCell>Moc No.</asp:TableCell>
                                        <asp:TableCell>
                                            <asp:TextBox ID="mocId" runat="server" Enabled="true" Width="200" />
                                        </asp:TableCell>
                                        <asp:TableCell>Override Tags</asp:TableCell>
                                        <asp:TableCell>
                                            <asp:TableCell>
                                            <asp:TextBox ID="tagsId" runat="server" Enabled="true" Width="200" />
                                        </asp:TableCell>
                                        </asp:TableCell>
                                           <asp:TableCell Width="110" Style="min-width:80px;" >MOS Request ID</asp:TableCell>
                                        <asp:TableCell>
                                            <asp:TextBox ID="mosreqidtxt" runat="server" Enabled="true" Width="200" />
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
                                                ControlToValidate="mosreqidtxt" runat="server"
                                                ErrorMessage="Only Numbers allowed"
                                                ValidationExpression="\d+">
                                            </asp:RegularExpressionValidator>
                                        </asp:TableCell>
                                         <asp:TableCell>Short/Long Term</asp:TableCell>
                                        <asp:TableCell>
                                            <asp:DropDownList ID="termList" runat="server" Width="200" CssClass="normalDropDown" Enabled="true" EnableViewState="false" AutoPostBack="true" DataSourceId="reqListDS2" DataTextField="terms" DataValueField="terms" Appenddatabounditems="true">
                                                <asp:ListItem Text="" Value=""/>                     
                                            </asp:DropDownList>
                                        </asp:TableCell>
                                    </asp:TableRow>  
                                     <asp:TableRow>
                                        <asp:TableCell Width="110" Style="min-width:80px;">Date From</asp:TableCell>
                                        <asp:TableCell Style="position:relative;">
                                            <asp:TextBox ID="searchStartDate" runat="server" Enabled="true" Width="200" CssClass="watermarkTextField" placeholder="DD/MM/YYYY" AutoPostBack="true"/>
                                            <asp:Label ID="searchStartImg" runat="server" CssClass="material-icons iconBtnBlue" Text="date_range" style="position:absolute;top:5px;left:178px;background-color:#FFFFFF;"/>
                                            <ajax:CalendarExtender ID="searchStartDateCE" runat="server" Enabled="true" TargetControlID="searchStartDate" PopupButtonID="searchStartImg" PopupPosition="BottomLeft" Format="dd/MM/yyyy" CssClass="ajax__calendar_xp"/>
                                        </asp:TableCell>
                                        <asp:TableCell Width="110" Style="min-width:80px;">Date To</asp:TableCell>
                                        <asp:TableCell Style="position:relative;">
                                            <asp:TextBox ID="searchEndDate" runat="server" Enabled="true" Width="200" CssClass="watermarkTextField" placeholder="DD/MM/YYYY" AutoPostBack="true"/>
                                            <asp:Label ID="searchEndImg" runat="server" CssClass="material-icons iconBtnBlue" Text="date_range" style="position:absolute;top:5px;left:178px;background-color:#FFFFFF;"/>
                                            <ajax:CalendarExtender ID="searchEndDateCE" runat="server" Enabled="true" TargetControlID="searchEndDate" PopupButtonID="searchEndImg" PopupPosition="BottomLeft" Format="dd/MM/yyyy" CssClass="ajax__calendar_xp"/>
                                        </asp:TableCell>                                        <asp:TableCell Width="110" Style="min-width: 80px;"></asp:TableCell>
                                        <asp:TableCell Width="110" Style="min-width: 80px;">
                                            <asp:Button ID="filterBtn" runat="server" CssClass="altButton w3-hide-medium" Text="Apply Filter" OnClick="GetRecordCount" Style="margin: 2px 3px;" />
                                        </asp:TableCell>
                                        <asp:TableCell>
                                            <asp:TableCell Width="110" Style="min-width: 80px;"></asp:TableCell>
                                            <asp:Button ID="resetBtn" runat="server" CssClass="altButton w3-hide-medium" Text="Reset" Enabled="false" OnClick="ResetField" Style="margin: 2px;" />
                                        </asp:TableCell>
                                         <asp:TableCell>
                                            <asp:TableCell Width="110" Style="min-width: 80px;"></asp:TableCell>
                                            <asp:Button ID="exportBtn" runat="server" CssClass="altButton w3-hide-medium" Text="Export" Enabled="false" OnClick="BtnExport_Click" AutoPostBack="False" Style="margin: 2px;" />
                                        </asp:TableCell>
                                         </asp:TableRow>  
                                    <asp:TableRow>
                                    </asp:TableRow>
                                    <asp:TableRow><asp:TableCell ColumnSpan="2" Height="10" CssClass="w3-hide-large"></asp:TableCell></asp:TableRow>
                                </asp:Table>
                            </ContentTemplate></asp:UpdatePanel>
                        </asp:Panel>
                        </div>
                        <div class="w3-col s12 m12 l6">
                            <asp:Panel ID="dateFilter" runat="server" Enabled="false">
                                <asp:Table runat="server" CellPadding="3">
                                    <asp:TableRow><asp:TableCell RowSpan="3" Width="10" CssClass="w3-hide-small w3-hide-medium"></asp:TableCell></asp:TableRow>
                                </asp:Table>
                            </asp:Panel>
                            <asp:Table runat="server" CellPadding="3">
                                <asp:TableRow><asp:TableCell RowSpan="4" Width="10" CssClass="w3-hide-small w3-hide-medium"></asp:TableCell></asp:TableRow>
                                <asp:TableRow><asp:TableCell ColumnSpan="2" Height="10" CssClass="w3-hide-small w3-hide-medium"></asp:TableCell></asp:TableRow>
                                <asp:TableRow>
                                
                                </asp:TableRow>
                                <asp:TableRow><asp:TableCell ColumnSpan="2" Height="10" CssClass="w3-hide-large"></asp:TableCell></asp:TableRow>
                            </asp:Table>
                        </div>
                    </div>
                    <div class="w3-col s12 m4 l12 w3-hide-small w3-hide-large">
                        <asp:Table runat="server" CellPadding="3">
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:Button ID="filterSecBtn" runat="server" CssClass="altButton" Text="Apply Filter" OnClick="GetRecordCount" Style="margin:2px 3px;" />
                                    <asp:Button ID="resetSecBtn" runat="server" CssClass="altButton" Text="Reset" OnClick="ResetField" Style="margin:2px 3px;"/>
                                     <asp:Button ID="exportSecBtn" runat="server" CssClass="altButton" Text="Export" OnClick="BtnExport_Click" Style="margin:2px 3px;"/>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        
                    </div>
                </div>                
            </div>
            
        </div>
        </asp:Panel>
        <asp:UpdatePanel runat="server" UpdateMode="Conditional" ChildrenAsTriggers="true"><ContentTemplate>
                <asp:Table ID="landing" runat="server" CssClass="summaryRootTable" style="padding:2px;">
                    <asp:TableRow CssClass="summaryItemHeader" Height="30">
                        <asp:TableCell>
                            <asp:Label runat="server" Text="Reporting" Style="padding-left:10px;" />
                            <asp:Image runat="server" ImageAlign="absmiddle" ImageUrl="~/App_Themes/baseObjects/btnImg_filler.png" style="float:right;margin:3px 10px 0px 0px;"/>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow CssClass="summaryItemRow" Height="80">
                        <asp:TableCell>
                            <asp:Label runat="server" CssClass="w3-text-grey" Text="Please select a Hub and Related Criteria" Style="margin-left:40px" />
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
                <asp:GridView id="reportGV" runat="server" Visible="False" width="100%" CssClass="summaryRootTable" AutoGenerateColumns="false" DataSourceID="reportDS" DataKeyNames="formId" 
                    AllowSorting="true" EnableSortingAndPagingCallbacks="true" EnableViewState="true" EmptyDataText="<br/>&emsp;<i>No selection made</i><br/><br/>" 
                    AllowPaging="true" PagerSettings-Mode="NumericFirstLast" PageSize="10" PagerSettings-Position="Bottom" PagerSettings-PageButtonCount="5">
                    <RowStyle Wrap="True" CssClass="summaryRow" />
                    <AlternatingRowStyle CssClass="summaryRowAlt" />
                    <SortedAscendingHeaderStyle CssClass="summaryAscHeader"/>
                    <SortedDescendingHeaderStyle CssClass="summaryDescHeader" />
                    <EmptyDataTemplate>
                        <asp:Table runat="server" style="padding:2px;">
                            <asp:TableRow CssClass="summaryItemHeader" Height="30">
                                <asp:TableCell>
                                    <asp:Label runat="server" Text="SEARCH RESULT" Style="padding-left:10px;" />
                                    <asp:Image runat="server" ImageAlign="absmiddle" ImageUrl="~/App_Themes/baseObjects/btnImg_filler.png" style="float:right;margin:3px 10px 0px 0px;"/>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow Height="80">
                                <asp:TableCell>
                                    <asp:Label runat="server" CssClass="w3-text-grey" Text="No report found or matching search criteria" Style="margin-left:40px" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </EmptyDataTemplate>
                    <PagerTemplate>
                        <asp:Table runat="server" HorizontalAlign="Center">
                            <asp:TableRow Height="37">
                                <asp:TableCell HorizontalAlign="Left" VerticalAlign="Middle" Style="padding: 0px 0px 2px 0px;">
                                    <asp:LinkButton ID="prevPg" runat="server" CssClass="fa fa-arrow-left w3-hover-text-red" Style="color:#999999;font-size:20px;text-decoration:none;margin:0px 10px;" ToolTip="Previous Page" CommandName="Page" CommandArgument="Prev"/>
                                    <asp:LinkButton ID="nextPg" runat="server" CssClass="fa fa-arrow-right w3-hover-text-red" Style="color:#999999;font-size:20px;text-decoration:none;" ToolTip="Next Page" CommandName="Page" CommandArgument="Next"/>
                                </asp:TableCell>
                                <asp:TableCell HorizontalAlign="Right" VerticalAlign="Middle" style="padding:0px 5px 1px 0px;">
                                    <asp:Label runat="server" Text="Showing" CssClass="w3-text-grey" Style="margin:0px 10px;" />
                                    <asp:DropDownList ID="pageSizeSelect" runat="server" selectedvalue='<%# reportGV.PageSize %>' OnSelectedIndexChanged="SetPagerSize" AutoPostBack="true" EnableViewState="true" CssClass="normalDropDown" Enabled="true"> 
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
                        <asp:BoundField DataField="hub" HeaderText="HUB" ItemStyle-Width="1%" ItemStyle-Wrap="false" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="false">
                            <HeaderStyle CssClass="summaryItemHeader"/>
                            <ItemStyle CssClass="summaryItemRow w3-hide-small"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="formID" Headertext="Mos Request ID" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                            <HeaderStyle CssClass="summaryItemHeader w3-hide-small" />
                            <ItemStyle CssClass="summaryItemRow w3-hide-small"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="reqId"  Headertext="Requester Name" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                            <HeaderStyle CssClass="summaryItemHeader w3-hide-small" />
                            <ItemStyle CssClass="summaryItemRow w3-hide-small"/>
                        </asp:BoundField>
                            <asp:BoundField DataField="ptwID"  Headertext="PTW No." HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                            <HeaderStyle CssClass="summaryItemHeader" />
                            <ItemStyle CssClass="summaryItemRow"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="tagNames" Headertext="Override Tags" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                            <HeaderStyle CssClass="summaryItemHeader" />
                            <ItemStyle CssClass="summaryItemRow"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="mocId"  Headertext="MOC No." HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                            <HeaderStyle CssClass="summaryItemHeader" />
                            <ItemStyle CssClass="summaryItemRow"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="longTerm"  Headertext="Long/Short Term" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                            <HeaderStyle CssClass="summaryItemHeader" />
                            <ItemStyle CssClass="summaryItemRow"/>
                        </asp:BoundField>
                         <asp:BoundField DataField="reqTimestamp"  Headertext="SSIC Request Date" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                            <HeaderStyle CssClass="summaryItemHeader" />
                            <ItemStyle CssClass="summaryItemRow"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="reqTimestamp" Headertext="SSIC Submitted Date" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                            <HeaderStyle CssClass="summaryItemHeader" />
                            <ItemStyle CssClass="summaryItemRow"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="ActivatedDate" Headertext="SSIC Activated Date" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                            <HeaderStyle CssClass="summaryItemHeader" />
                            <ItemStyle CssClass="summaryItemRow"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="extDate"  Headertext="SSIC Extended Date" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                            <HeaderStyle CssClass="summaryItemHeader" />
                            <ItemStyle CssClass="summaryItemRow"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="ClosingDate" Headertext="SSIC Closing DateTime" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                            <HeaderStyle CssClass="summaryItemHeader" />
                            <ItemStyle CssClass="summaryItemRow"/>
                        </asp:BoundField>
                         <asp:BoundField DataField="reqStatus" Headertext="SSIC Status"  HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="False" HtmlEncode="True" ReadOnly="True" ShowHeader="True">
                            <HeaderStyle CssClass="summaryItemHeader" />
                            <ItemStyle CssClass="summaryItemRow"/>
                        </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </ContentTemplate></asp:UpdatePanel>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="search"/>
                <asp:AsyncPostBackTrigger ControlID="mobileSearch"/>
                <asp:AsyncPostBackTrigger ControlID="filterBtn" EventName="Click"/>
                <asp:AsyncPostBackTrigger ControlID="filterSecBtn" EventName="Click"/>
                <asp:AsyncPostBackTrigger ControlID="resetBtn" EventName="Click"/>
                <asp:AsyncPostBackTrigger ControlID="resetSecBtn" EventName="Click"/>
                <asp:PostBackTrigger ControlID="exportBtn"/>
                <asp:PostBackTrigger ControlID="exportSecBtn"/>
                <asp:AsyncPostBackTrigger ControlID="searchBtn" EventName="Click"/>                    
                <asp:AsyncPostBackTrigger ControlID="mobileSearchBtn" EventName="Click"/>
                <asp:AsyncPostBackTrigger ControlID="reportGV" EventName="Sorted"/>
                <asp:AsyncPostBackTrigger ControlID="reportGV" EventName="PageIndexChanged"/>
            </Triggers>
      </asp:UpdatePanel>
    </div>
           <!-- 'main data source section -->
	<asp:SqlDataSource id="hubListDS" runat="server" DataSourceMode="DataSet" 
        SelectCommand="SELECT * FROM adm_list_hub ORDER BY hubName"
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
    </asp:SqlDataSource> 
    <asp:SqlDataSource id="ptwListDS" runat="server" DataSourceMode="DataSet" 
        SelectCommand="SELECT distinct(ptwId)  FROM form_mos ORDER BY ptwId"
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
      
    </asp:SqlDataSource>
    <asp:SqlDataSource id="reqListDS" runat="server" DataSourceMode="DataSet" 
        SelectCommand="SELECT distinct(reqId)  FROM form_mos ORDER BY reqId"
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
      
    </asp:SqlDataSource>
    <asp:SqlDataSource id="regStatusDS" runat="server" DataSourceMode="DataSet" 
        SelectCommand="select statusCode,statusDesc from adm_list_status"
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
      
    </asp:SqlDataSource>
    <asp:SqlDataSource id="reqListDS2" runat="server" DataSourceMode="DataSet" 
        SelectCommand="Select distinct(Case when (longTerm = 0) then 'Long' else 'Short' end) as terms from form_mos"
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
    </asp:SqlDataSource> 

    <asp:SqlDataSource id="reportDS" runat="server" DataSourceMode="DataSet" 
        SelectCommand="Select m.hub,m.hub + '-00'+ CAST(m.formId as nvarchar(5)) as formID,m.reqId,m.ptwId,t.tagNames,m.mocId,Case when (m.longTerm = 0) then 'Long' else 'Short' end as longTerm,convert(varchar,m.reqTimestamp ,103) as reqTimestamp,Case when (a.reqStatus = 'Activated') then a.updatedDate else null end as ActivatedDate,Case when (a.reqStatus = 'Extended') then a.updatedDate else null end as extDate,Case when (a.reqStatus = 'Closed') then a.updatedDate else null end as ClosingDate,a.reqStatus as reqStatus from form_mos m (nolock) left join (  SELECT formID,[tagNames]=STUFF ( ( SELECT DISTINCT ', ' + CAST(tagName AS VARCHAR(MAX))FROM [form_mos_tag] t2 WHERE t2.formID = t1.formID FOR XML PATH('') ),1,1,'' )  FROM [form_mos_tag] t1  GROUP BY formID  ) t on m.formId = t.formId  left join form_mos_ext e on m.formId = e.formId and e.extCount = 0 left join adm_list_status s on m.curState = s.statusCode left join adm_audit_trails a on m.formId = a.formId order by m.reqTimestamp"
        FilterExpression="hub LIKE '%{0}%' and ptwId LIKE '%{1}%' and reqId LIKE '%{2}%' and reqStatus LIKE '%{3}%' and mocId Like '%{4}%' and tagNames Like '%{5}%' and formID LIKE '%{6}%' and longTerm LIKE '%{7}%'" 
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
        <FilterParameters>
            <%--  --%>
            <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="%" PropertyName="SelectedValue" ControlID="hubList" />
            <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="%" PropertyName="SelectedValue" ControlID="ptwlist" />
           <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="%" PropertyName="SelectedValue" ControlID="reqList" />
            <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="%" PropertyName="SelectedValue" ControlID="statusList" />            
            <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="%" PropertyName="Text" ControlID="mocId" />
            <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="%" PropertyName="Text" ControlID="tagsId" />
            <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="%" PropertyName="Text" ControlID="mosreqidtxt" />
            <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="%" PropertyName="SelectedValue" ControlID="termList" />
            <%--<asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="%" PropertyName="Text" ControlID="termididtxt" />--%>
        </FilterParameters>
        <SelectParameters>
            <asp:ControlParameter ConvertEmptyStringToNull="true" DefaultValue="01/01/1970" ControlID="searchStartDate" Name="reportFrom" />
            <asp:ControlParameter ConvertEmptyStringToNull="true" DefaultValue="31/12/3000" ControlID="searchEndDate" Name="reportTo"/>
        </SelectParameters>
    </asp:SqlDataSource>

<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $('[id*=exportBtn]').on('click', function () {
                ExportToExcel('reportGV');
                location.reload();
            });
        });
        function ExportToExcel(obj) {
            var processRow = function (row) {
                var finalVal = '';
                for (var j = 0; j < row.cells.length; j++) {
                    if (j > 0) finalVal += ',';
                    finalVal += '"' + row.cells[j].innerText.replace('"', '\'').replace('"', '\'') + '"';
                }
                return finalVal + '\n';
            };

            var dt = document.getElementById(obj); // 'reportGV'
            if ((dt == undefined) || (dt == null)) {
                dt = document.getElementsByClassName('summaryRootTable')[0];
            }

            if ((dt != undefined) && (dt != null)) {
                if (navigator.msSaveBlob) { // IE 10+
                    var csvContent = ''; /*"data:text/csv;charset=utf-8;"; */
                    for (var i = 0; i < dt.rows.length; i++) {
                        csvContent += processRow(dt.rows[i]);
                    }
                    var blob = new Blob([csvContent], { type: 'text/csv;charset=utf-8;' });
                    navigator.msSaveBlob(blob, fname + '.csv');
                }
                else {  //Others
                    var html = dt.outerHTML;
                    window.open('data:application/vnd.ms-excel,' + encodeURIComponent(html));
                }
            }
            console.log(csvContent)
            /* var encodedUri = encodeURI(csvContent);
            window.open(encodedUri);	 */
            return false;
        }

    </script> 
</asp:Content>