<%@ Page Title="" Language="C#" MasterPageFile="~/template/Default.Master" AutoEventWireup="true" CodeBehind="request.aspx.cs" Inherits="eSSIC.MOS.Request" %>
<%@ MasterType VirtualPath="~/template/Default.Master" %>

<asp:Content ID="headerSection" ContentPlaceHolderID="HeaderContent" runat="server"></asp:Content>
<asp:Content ID="mainSection" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
        <!-- 'Request info section -->
        <asp:UpdatePanel ID="reqPanelUP" runat="server" UpdateMode="Conditional"><ContentTemplate>
            <asp:Panel ID="topInfo" runat="server" CssClass="w3-hide-small" Height="20" Style="position:relative">

            </asp:Panel>
            <asp:Panel ID="mosDetails" runat="server" CssClass="reportContent" Enabled="true">            
                <asp:FormView ID="mosRequestFV" runat="server" EnableViewState="true" DefaultMode="ReadOnly" Width="100%" DataSourceID="requestDS" DataKeyNames="formId" >
                    <EmptyDataTemplate>
                        <asp:Table runat="server">
                            <asp:TableRow>
                                <asp:TableCell CssClass="w3-text-grey" style="padding:20px 0px 50px 0px;position:relative">
                                    <asp:Label runat="server" CssClass="material-icons" style="position:absolute;left:15px;top:10px;" Text="error"/>
                                    <asp:Label runat="server" Style="font-size:13px;font-weight:bold;position:absolute;left:50px;top:14px;" Text="Please select a valid report from the Summary Page" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </EmptyDataTemplate>
                    <InsertItemTemplate>
                        <asp:Table runat="server">                        
                            <asp:TableRow CssClass="w3-row">
                                <asp:TableCell CssClass="w3-col s12 m6 l6">
                                    <asp:Table runat="server" CellPadding="4" Style="margin-bottom:5px">                                        
                                        <asp:TableRow>
                                            <asp:TableCell VerticalAlign="Top" Width="112">Override</asp:TableCell>
                                            <asp:TableCell VerticalAlign="Top">
                                                <asp:RadioButtonList ID="newLongTerm" runat="server" AutoPostBack="false" TextAlign="Right" RepeatLayout="Table" RepeatColumns="2" Width="220" onchange="toggleMocField($('#'+ this.id +' input:radio:checked').val(),1);" >
                                                    <asp:ListItem Text="Short Term" Value="False" Selected="True"/>
                                                    <asp:ListItem Text="Long Term" Value="True"/>                                                    
                                                </asp:RadioButtonList>
                                            </asp:TableCell>
                                            <asp:TableCell Width="15" CssClass="w3-hide-small"></asp:TableCell>
                                        </asp:TableRow>                                       
                                    </asp:Table>
                                </asp:TableCell>
                                <asp:TableCell CssClass="w3-col s12 m6 l6">
                                    
                                </asp:TableCell>
                            </asp:TableRow>  
                            <asp:TableRow CssClass="w3-row">
                                <asp:TableCell CssClass="w3-col s12 m6 l6">
                                    <asp:Table runat="server" CellPadding="4">
                                        <asp:TableRow ID="mocRow" style="display:none">
                                            <asp:TableCell>MOC #</asp:TableCell>
                                            <asp:TableCell>
                                                <asp:TextBox ID="newMocId" runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField" Text="" ToolTip="" Placeholder=" Management of Change"/>
                                            </asp:TableCell>
                                            <asp:TableCell Width="15" CssClass="w3-hide-small"></asp:TableCell>
                                        </asp:TableRow> 
                                        <asp:TableRow>
                                            <asp:TableCell Width="120">PTW #</asp:TableCell>
                                            <asp:TableCell><asp:TextBox ID="newPtwId" runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField" Text="" ToolTip="" Placeholder=" Permit to Work" required=""/></asp:TableCell>
                                            <asp:TableCell Width="15" CssClass="w3-hide-small"></asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </asp:TableCell>
                                <asp:TableCell CssClass="w3-col s12 m6 l6">

                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow CssClass="w3-row">
                                <asp:TableCell CssClass="w3-col s12 m6 l6">
                                    <asp:UpdatePanel ID="hubFieldSelection" runat="server"><ContentTemplate>
                                        <asp:Table runat="server" CellPadding="4" Style="margin-bottom:15px">
                                            <asp:TableRow>
                                                <asp:TableCell Width="120">Hub</asp:TableCell>
                                                <asp:TableCell>
                                                    <asp:DropDownList ID="newHubList" runat="server" Width="100%" CssClass="normalDropDown" Enabled="true" EnableViewState="false" AutoPostBack="true" DataSourceId="hubListDS" DataTextField="hubName" DataValueField="hubName" Appenddatabounditems="true" required="">
                                                        <asp:ListItem Text="" Value=""/>                   
                                                    </asp:DropDownList>
                                                </asp:TableCell>
                                                <asp:TableCell RowSpan="3" Width="15" CssClass="w3-hide-small"></asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow>
                                                <asp:TableCell>Field</asp:TableCell>
                                                <asp:TableCell>
                                                    <asp:DropDownList ID="newFieldList" runat="server" Width="100%" CssClass="normalDropDown" Enabled="true" EnableViewState="false" DataSourceId="fieldListDS" DataTextField="fieldName" DataValueField="fieldName" Appenddatabounditems="true" required="">
                                                        <asp:ListItem Text="" Value=""/>                     
                                                    </asp:DropDownList>
                                                </asp:TableCell>
                                            </asp:TableRow>
                                            
                                        </asp:Table>
                                    </ContentTemplate></asp:UpdatePanel>
                                </asp:TableCell>
                                <asp:TableCell CssClass="w3-col s12 m6 l6">

                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow CssClass="w3-row">
                                <asp:TableCell CssClass="w3-col s12 m12 l12">
                                    <asp:Panel runat="server" CssClass="subItemPanel" Style="padding-bottom:15px;margin-bottom:15px;border-radius:5px">
                                        <asp:Table runat="server" CellPadding="4">
                                            <asp:TableRow>
                                                <asp:TableCell ColumnSpan="4" CssClass="subItemHeader">System</asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow>
                                                <asp:TableCell RowSpan="4" Width="10"></asp:TableCell>
                                                <asp:TableCell ColumnSpan="2" Height="5"></asp:TableCell>
                                                <asp:TableCell RowSpan="4" Width="10"></asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow>
                                                <asp:TableCell Width="110">Process</asp:TableCell>
                                                <asp:TableCell><asp:TextBox ID="newProcessSystem" runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField syncTextAddOn" Text="" ToolTip="" Placeholder=" e.g. Pressure Manifold" required="" /></asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow>
                                                <asp:TableCell>Control</asp:TableCell>
                                                <asp:TableCell><asp:TextBox ID="newControlSystem" runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField syncTextAddOn" Text="" ToolTip="" Placeholder=" e.g. Control Valve" required=""/></asp:TableCell>
                                            </asp:TableRow>
                                        </asp:Table>
                                    </asp:Panel>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow CssClass="w3-row">
                                <asp:TableCell CssClass="w3-col s12 m6 l6" Height="305" Style="margin-bottom:15px">
                                    <asp:Table runat="server" Height="100%">
                                        <asp:TableRow Height="100%">
                                            <asp:TableCell>
                                                <asp:Panel runat="server" CssClass="subItemPanel" Height="100%" Style="border-radius:5px">
                                                    <asp:Table runat="server" CellPadding="4">
                                                        <asp:TableRow>
                                                            <asp:TableCell ColumnSpan="4" CssClass="subItemHeader">Isolation</asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell RowSpan="7" Width="10"></asp:TableCell>
                                                            <asp:TableCell ColumnSpan="2" Height="5"></asp:TableCell>
                                                            <asp:TableCell RowSpan="7" Width="10"></asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell Width="110">Function</asp:TableCell>
                                                            <asp:TableCell><asp:TextBox ID="newIsolateFunction" runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField" Text="" ToolTip="" Placeholder="" required=""/></asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell>Method</asp:TableCell>
                                                            <asp:TableCell><asp:TextBox ID="newIsolateMethod" runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField" Text="" ToolTip="" Placeholder="" required=""/></asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell>Purpose</asp:TableCell>
                                                            <asp:TableCell><asp:TextBox ID="newIsolatePurpose" runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField" Text="" ToolTip="" Placeholder="" required="" /></asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell>Effect</asp:TableCell>
                                                            <asp:TableCell><asp:TextBox ID="newIsolateEffect" runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField" Text="" ToolTip="" Placeholder="" required="" /></asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow><asp:TableCell ColumnSpan="2" Height="15"></asp:TableCell></asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell VerticalAlign="Top">Active Safety</asp:TableCell>
                                                            <asp:TableCell><asp:TextBox ID="newAltSafetySystem" runat="server" Width="100%" MaxLength="300" TextMode="MultiLine" Rows="4" CssClass="watermarkTextField" Text="" ToolTip="" Placeholder=" e.g. Other system in place" required="" /></asp:TableCell>
                                                        </asp:TableRow>
                                                    </asp:Table>
                                                </asp:Panel>
                                            </asp:TableCell>
                                            <asp:TableCell RowSpan="2" Width="15" CssClass="w3-hide-small"></asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </asp:TableCell>
                                <asp:TableCell CssClass="w3-col s12 m6 l6" Height="305" Style="margin-bottom:15px">
                                    <asp:Table runat="server" Style="height:100%">
                                        <asp:TableRow VerticalAlign="Top">
                                            <asp:TableCell>
                                                <asp:Panel runat="server" CssClass="subItemPanel" Style="padding-bottom:10px;border-radius:5px;">
                                                    <asp:Table runat="server" CellPadding="4">
                                                        <asp:TableRow>
                                                            <asp:TableCell ColumnSpan="4" CssClass="subItemHeader">Risk</asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell RowSpan="3" Width="10"></asp:TableCell>
                                                            <asp:TableCell ColumnSpan="2" Height="5"></asp:TableCell>
                                                            <asp:TableCell RowSpan="3" Width="10"></asp:TableCell>
                                                        </asp:TableRow>        
                                                        <asp:TableRow>
                                                            <asp:TableCell Width="110">Risk Rating</asp:TableCell>
                                                            <asp:TableCell><asp:TextBox ID="newRiskRating" runat="server" Width="100%" MaxLength="50" CssClass="watermarkTextField" Placeholder=" e.g. P.2A" required="" /></asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell Style="padding-top:5px" VerticalAlign="Top">Description</asp:TableCell>
                                                            <asp:TableCell><asp:TextBox ID="newRiskRemarks" runat="server" Width="100%" TextMode="MultiLine" Rows="3" CssClass="watermarkTextField" Text="" ToolTip="" Placeholder="" required="" /></asp:TableCell>
                                                        </asp:TableRow>
                                                    </asp:Table>
                                                </asp:Panel>
                                            </asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow VerticalAlign="Bottom">
                                            <asp:TableCell>
                                                <asp:Panel runat="server" CssClass="subItemPanel" Style="padding-bottom:10px;border-radius:5px">
                                                    <asp:Table runat="server" CellPadding="4">
                                                        <asp:TableRow>
                                                            <asp:TableCell ColumnSpan="4" CssClass="subItemHeader">Mitigation</asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell RowSpan="3" Width="10"></asp:TableCell>
                                                            <asp:TableCell Height="5"></asp:TableCell>
                                                            <asp:TableCell RowSpan="3" Width="10"></asp:TableCell>
                                                        </asp:TableRow>                                               
                                                        <asp:TableRow>
                                                            <asp:TableCell><asp:TextBox ID="newMitigateMethod" runat="server" Width="100%" TextMode="MultiLine" Rows="3" CssClass="watermarkTextField" Text="" ToolTip="" Placeholder=" Description" required="" /></asp:TableCell>
                                                        </asp:TableRow>
                                                    </asp:Table>
                                                </asp:Panel>
                                            </asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow CssClass="w3-row">
                                <asp:TableCell CssClass="w3-col s12 m12 l12">
                                    <asp:Panel runat="server" CssClass="subItemPanel" Style="padding-bottom:15px;margin-bottom:15px;border-radius:5px">
                                        <asp:Table runat="server" CellPadding="0">
                                            <asp:TableRow>
                                                <asp:TableCell ColumnSpan="4" CssClass="subItemHeader">MOS</asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow>
                                                <asp:TableCell RowSpan="2" Width="10"></asp:TableCell>
                                                <asp:TableCell ColumnSpan="2" Height="10"></asp:TableCell>
                                                <asp:TableCell RowSpan="2" Width="10"></asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow>
                                                <asp:TableCell ColumnSpan="2">
                                                    <div class="w3-row">
                                                        <div class="w3-col s12 m6 l6">
                                                            <asp:Table runat="server" CellPadding="4">
                                                                <asp:TableRow>
                                                                    <asp:TableCell Width="110">Find Tag</asp:TableCell>
                                                                    <asp:TableCell Style="position:relative;padding-right:35px">                                                    
                                                                        <asp:TextBox ID="newTag" runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField syncTextAddOn" Style="text-transform:uppercase" Text="" ToolTip="" Placeholder=" PXT-201.MOS" />
                                                                        <asp:LinkButton ID="findTagBtn" runat="server" OnClientClick="mosTagLookup();return false;" CssClass="material-icons iconBtnGrey syncIconAddOn" style="position:absolute;right:3px;font-size:24px" Text="search" ToolTip="Search" /> 
                                                                        <asp:Image ID="findTagProgress" runat="server" ImageUrl="~/App_Themes/baseObjects/processing.gif" Style="position:absolute;right:9px;top:9px;display:none"/>
                                                                        <asp:HiddenField ID="tagCombo" runat="server" Value=""  />
                                                                    </asp:TableCell>
                                                                    <asp:TableCell RowSpan="3" Width="20" CssClass="w3-hide-small"></asp:TableCell>
                                                                </asp:TableRow>
                                                                <asp:TableRow>
                                                                    <asp:TableCell RowSpan="2" Width="110"></asp:TableCell>
                                                                    <asp:TableCell style="position:relative;padding:10px 10px;">
                                                                        <asp:Panel runat="server" ScrollBars="Auto" Style="max-height:300px">
                                                                            <table id="tagList" style="position:relative"></table> 
                                                                        </asp:Panel>                                                               
                                                                    </asp:TableCell>
                                                                </asp:TableRow>
                                                                <asp:TableRow>
                                                                    <asp:TableCell>
                                                                        <asp:Button ID="tagListAdd" runat="server" OnClientClick="mosTagSelect(1);return false;" CssClass="tagFnBtnAlt" Text="Add Selection" Style="float:left;margin:2px 3px" disabled />                                                                            
                                                                        <asp:Button ID="tagTagAdd" runat="server" OnClientClick="mosTagSelect(2);return false;" CssClass="tagFnBtnAlt" Text="Add Tag" Style="float:left;margin:2px 3px" />                                                                                                                                                    
                                                                    </asp:TableCell>
                                                                </asp:TableRow>
                                                            </asp:Table>
                                                        </div>
                                                        <div class="w3-col s12 m6 l6">
                                                            <asp:UpdatePanel ID="tagProposedUP" runat="server"><ContentTemplate>
                                                                <asp:Table runat="server" CellPadding="0">
                                                                    <asp:TableRow CssClass="w3-hide-large w3-hide-medium"><asp:TableCell ColumnSpan="2" Height="10"></asp:TableCell></asp:TableRow>
                                                                    <asp:TableRow>
                                                                        <asp:TableCell Width="110" CssClass="w3-hide-large w3-hide-medium"></asp:TableCell>
                                                                        <asp:TableCell style="padding:0px 5px 0px 2px">
                                                                            <asp:Panel runat="server" CssClass="subItemPanel" Style="padding-bottom:13px;border-radius:5px">
                                                                                <asp:Table runat="server" >
                                                                                    <asp:TableRow>
                                                                                        <asp:TableCell ColumnSpan="3" CssClass="subItemHeader">Override List
                                                                                            <asp:LinkButton ID="tagListReset" runat="server" OnClientClick="mosTagReset(5);return false;" CssClass="textFnLink" style="position:absolute;top:9px;right:12px;" Text="Clear List" />                                                                                            
                                                                                        </asp:TableCell>
                                                                                    </asp:TableRow>                                                                                
                                                                                    <asp:TableRow>
                                                                                        <asp:TableCell RowSpan="2" Width="10"></asp:TableCell>
                                                                                        <asp:TableCell Height="5"></asp:TableCell>
                                                                                        <asp:TableCell RowSpan="2" Width="10"></asp:TableCell>
                                                                                    </asp:TableRow>
                                                                                    <asp:TableRow>
                                                                                        <asp:TableCell>
                                                                                            <table id="tagTable" style="position:relative;" >
                                                                                                <tr><td><input id="reqHolder" onkeypress="return false" class="watermarkTextField syncTextAddOn" style="width:100%;float:left;margin-bottom:3px;margin-top:2px;text-transform:uppercase" required="" type="text"></td></tr>                                                                                                
                                                                                            </table>
                                                                                        </asp:TableCell>
                                                                                    </asp:TableRow>
                                                                                </asp:Table>
                                                                            </asp:Panel>
                                                                        </asp:TableCell>
                                                                    </asp:TableRow>
                                                                </asp:Table>
                                                            </ContentTemplate></asp:UpdatePanel>
                                                        </div>
                                                     </div>                                                    
                                                </asp:TableCell>                                                        
                                            </asp:TableRow>
                                        </asp:Table>                                        
                                    </asp:Panel>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:UpdatePanel ID="optionUP" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="true"><ContentTemplate>
                            <div class="tagTitleRoot"></div>
                            <asp:Table runat="server" style="margin:15px 0px 10px 0px">
                                <asp:TableRow>
                                    <asp:TableCell VerticalAlign="Top" Width="1%" Wrap="false" style="padding-right:20px">
                                        <input id="reqResetBtn" type="reset" title="Reset" OnClick="mosTagReset(5);" class="altButton w3-hide-small" Style="margin:0px 5px" />
                                    </asp:TableCell>
                                    <asp:TableCell VerticalAlign="Top" Style="max-width:300px">
                                        <asp:CheckBox ID="submitConfirmChk" runat="server" OnClick="setConfirmBtn(this.checked,'REQ');" CssClass="w3-text-grey" Text="Confirm all information is correct" TextAlign="right" Enabled="true" Style="float:left;margin:7px 0px 0px 5px" />                                        
                                    </asp:TableCell>
                                    <asp:TableCell VerticalAlign="Top" Style="min-width:220px">                                        
                                        <asp:Button ID="reqSubmitBtn" runat="server" OnClientClick="setConfirmPrompt('1')" CssClass="altButton" Text="Submit" Style="float:right;margin:0px 5px 10px 5px" Disabled="disabled"/>                                    
                                        <asp:UpdateProgress runat="server" AssociatedUpdatePanelID="optionUP" DisplayAfter="0"><ProgressTemplate><asp:Image runat="server" ImageUrl="~/App_Themes/baseObjects/processing.gif" Style="float:right;margin:6px 10px 0px 0px;"/></ProgressTemplate></asp:UpdateProgress>
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </ContentTemplate></asp:UpdatePanel>

                        <asp:SqlDataSource id="hubListDS" runat="server" DataSourceMode="DataSet" 
                            SelectCommand="SELECT * FROM adm_list_hub ORDER BY hubName"
                            ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
                        </asp:SqlDataSource> 
                        <asp:SqlDataSource id="fieldListDS" runat="server" DataSourceMode="DataSet" 
                            SelectCommand="SELECT * FROM adm_list_field ORDER BY fieldName"
                            FilterExpression="fieldHub LIKE '%{0}%'" 
                            ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
                            <FilterParameters>
                                <asp:ControlParameter ConvertEmptyStringToNull="False" DefaultValue="%" PropertyName="SelectedValue" ControlID="newHubList" />
                            </FilterParameters>
                        </asp:SqlDataSource>
                    </InsertItemTemplate>

                    <EditItemTemplate>
                        <asp:Table runat="server"> 
                            <asp:TableRow CssClass="w3-row">
                                <asp:TableCell CssClass="w3-col s12 m6 l6">
                                    <asp:Table runat="server" CellPadding="4" Style="margin-bottom:5px">                                        
                                        <asp:TableRow>
                                            <asp:TableCell VerticalAlign="Top" Width="112">Override</asp:TableCell>
                                            <asp:TableCell VerticalAlign="Top">
                                                <asp:RadioButtonList ID="longTerm" runat="server" AutoPostBack="false" TextAlign="Right" RepeatLayout="Table" RepeatColumns="2" Width="220" SelectedValue='<%# Eval("longTerm") %>' onchange="toggleMocField($('#'+ this.id +' input:radio:checked').val(),2);" >
                                                    <asp:ListItem Text="Short Term" Value="False"/>
                                                    <asp:ListItem Text="Long Term" Value="True"/>                                                    
                                                </asp:RadioButtonList>
                                                <asp:HiddenField ID="longTermHid" runat="server" Value='<%# Eval("longTerm") %>' />
                                            </asp:TableCell>
                                            <asp:TableCell Width="15" CssClass="w3-hide-small"></asp:TableCell>
                                        </asp:TableRow>                                       
                                    </asp:Table>
                                </asp:TableCell>
                                <asp:TableCell CssClass="w3-col s12 m6 l6">
                                    
                                </asp:TableCell>
                            </asp:TableRow>  
                            <asp:TableRow CssClass="w3-row">
                                <asp:TableCell CssClass="w3-col s12 m6 l6">
                                    <asp:Table runat="server" CellPadding="4">
                                        <asp:TableRow ID="mocRow" style=<%# (Boolean.Parse(Eval("longTerm").ToString()) ? "" : "display:none") %>>
                                            <asp:TableCell>MOC #</asp:TableCell>
                                            <asp:TableCell>
                                                <asp:TextBox ID="mocId" runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField" Text='<%# Eval("mocId") %>' Placeholder=" Management of Change"/>
                                            </asp:TableCell>
                                            <asp:TableCell Width="15" CssClass="w3-hide-small"></asp:TableCell>
                                        </asp:TableRow> 
                                        <asp:TableRow>
                                            <asp:TableCell Width="120">PTW #</asp:TableCell>
                                            <asp:TableCell>
                                                <asp:TextBox ID="ptwId" runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField" Text='<%# Eval("ptwId") %>' Placeholder=" Permit to Work" required=""/>
                                                <asp:HiddenField ID="ptwIdHid" runat="server" Value='<%# Eval("ptwId") %>' />
                                                <asp:HiddenField ID="mocIdHid" runat="server" Value='<%# Eval("mocId") %>' />
                                            </asp:TableCell>
                                            <asp:TableCell Width="15" CssClass="w3-hide-small"></asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </asp:TableCell>
                                <asp:TableCell CssClass="w3-col s12 m6 l6">
                                    <asp:Table runat="server" CellPadding="3" Style="margin-bottom:10px" Visible="false">
                                        <asp:TableRow>
                                            <asp:TableCell Width="120">MOS Request</asp:TableCell>
                                            <asp:TableCell><asp:TextBox runat="server" Width="100%" CssClass="watermarkTextField" Text='<%# Eval("hub","{0}-") + Eval("formId","{0:D5}") %>' ToolTip='<%# Eval("hub","{0}-") + Eval("formId","{0:D5}") %>' Enabled="false" /></asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>                                
                                </asp:TableCell>
                            </asp:TableRow>                        
                            <asp:TableRow CssClass="w3-row">
                                <asp:TableCell CssClass="w3-col s12 m6 l6">
                                    <asp:UpdatePanel ID="hubFieldSelection" runat="server"><ContentTemplate>
                                        <asp:Table runat="server" CellPadding="4" Style="margin-bottom:15px">                                    
                                            <asp:TableRow>
                                                <asp:TableCell Width="120">Hub</asp:TableCell>
                                                <asp:TableCell>
                                                    <asp:DropDownList ID="hub" runat="server" Width="100%" CssClass="normalDropDown" Enabled="true" EnableViewState="false" AutoPostBack="true" DataSourceId="hubListDS" DataTextField="hubName" DataValueField="hubName" Appenddatabounditems="true" required="">
                                                        <asp:ListItem Text="" Value=""/>                   
                                                    </asp:DropDownList>
                                                    <asp:HiddenField ID="hubHid" runat="server" Value='<%# Eval("hub") %>' />
                                                </asp:TableCell>
                                                <asp:TableCell RowSpan="2" Width="15" CssClass="w3-hide-small"></asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow>
                                                <asp:TableCell>Field</asp:TableCell>
                                                <asp:TableCell>
                                                    <asp:DropDownList ID="field" runat="server" Width="100%" CssClass="normalDropDown" Enabled="true" EnableViewState="false" DataSourceId="fieldListDS" DataTextField="fieldName" DataValueField="fieldName" Appenddatabounditems="true" required="">
                                                        <asp:ListItem Text="" Value=""/>                     
                                                    </asp:DropDownList>
                                                    <asp:HiddenField ID="fieldHid" runat="server" Value='<%# Eval("field") %>' />
                                                </asp:TableCell>
                                            </asp:TableRow>
                                        </asp:Table>
                                    </ContentTemplate></asp:UpdatePanel>
                                </asp:TableCell>
                                <asp:TableCell CssClass="w3-col s12 m6 l6">

                                </asp:TableCell>
                            </asp:TableRow>                        
                            <asp:TableRow CssClass="w3-row">
                                <asp:TableCell CssClass="w3-col s12 m12 l12">
                                    <asp:Panel runat="server" CssClass="subItemPanel" Style="padding-bottom:15px;margin-bottom:15px;border-radius:5px">
                                        <asp:Table runat="server" CellPadding="4">
                                            <asp:TableRow>
                                                <asp:TableCell ColumnSpan="4" CssClass="subItemHeader">System</asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow>
                                                <asp:TableCell RowSpan="4" Width="10"></asp:TableCell>
                                                <asp:TableCell ColumnSpan="2" Height="5"></asp:TableCell>
                                                <asp:TableCell RowSpan="4" Width="10"></asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow>
                                                <asp:TableCell Width="110">Process</asp:TableCell>
                                                <asp:TableCell>
                                                    <asp:TextBox ID="processSystem" runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField syncTextAddOn" Text='<%# Eval("processSystem") %>' Placeholder=" e.g. Pressure Manifold" required="" />
                                                    <asp:HiddenField ID="processSystemHid" runat="server" Value='<%# Eval("processSystem") %>' />
                                                </asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow>
                                                <asp:TableCell>Control</asp:TableCell>
                                                <asp:TableCell>
                                                    <asp:TextBox ID="controlSystem" runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField syncTextAddOn" Text='<%# Eval("controlSystem") %>' Placeholder=" e.g. Control Valve" required="" />
                                                    <asp:HiddenField ID="controlSystemHid" runat="server" Value='<%# Eval("controlSystem") %>' />
                                                </asp:TableCell>
                                            </asp:TableRow>
                                        </asp:Table>
                                    </asp:Panel>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow CssClass="w3-row">
                                <asp:TableCell CssClass="w3-col s12 m6 l6" Height="305" Style="margin-bottom:15px">
                                    <asp:Table runat="server" Height="100%">
                                        <asp:TableRow Height="100%">
                                            <asp:TableCell>
                                                <asp:Panel runat="server" CssClass="subItemPanel" Height="100%" Style="border-radius:5px">
                                                    <asp:Table runat="server" CellPadding="4">
                                                        <asp:TableRow>
                                                            <asp:TableCell ColumnSpan="4" CssClass="subItemHeader">Isolation</asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell RowSpan="7" Width="10"></asp:TableCell>
                                                            <asp:TableCell ColumnSpan="2" Height="5"></asp:TableCell>
                                                            <asp:TableCell RowSpan="7" Width="10"></asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell Width="110">Function</asp:TableCell>
                                                            <asp:TableCell>
                                                                <asp:TextBox ID="isolateFunction" runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField" Text='<%# Eval("isolateFunction") %>' Placeholder="" required="" />
                                                                <asp:HiddenField ID="isolateFunctionHid" runat="server" Value='<%# Eval("isolateFunction") %>' />
                                                            </asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell>Method</asp:TableCell>
                                                            <asp:TableCell>
                                                                <asp:TextBox ID="isolateMethod" runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField" Text='<%# Eval("isolateMethod") %>' Placeholder="" required="" />
                                                                <asp:HiddenField ID="isolateMethodHid" runat="server" Value='<%# Eval("isolateMethod") %>' />
                                                            </asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell>Purpose</asp:TableCell>
                                                            <asp:TableCell>
                                                                <asp:TextBox ID="isolatePurpose" runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField" Text='<%# Eval("isolatePurpose") %>' Placeholder="" required="" />
                                                                <asp:HiddenField ID="isolatePurposeHid" runat="server" Value='<%# Eval("isolatePurpose") %>' />
                                                            </asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell>Effect</asp:TableCell>
                                                            <asp:TableCell>
                                                                <asp:TextBox ID="isolateEffect" runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField" Text='<%# Eval("isolateEffect") %>' Placeholder="" required="" />
                                                                <asp:HiddenField ID="isolateEffectHid" runat="server" Value='<%# Eval("isolateEffect") %>' />
                                                            </asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow><asp:TableCell ColumnSpan="2" Height="15"></asp:TableCell></asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell VerticalAlign="Top">Active Safety</asp:TableCell>
                                                            <asp:TableCell>
                                                                <asp:TextBox ID="altSafetySystem" runat="server" Width="100%" MaxLength="300" TextMode="MultiLine" Rows="4" CssClass="watermarkTextField" Text='<%# Eval("altSafetySystem") %>' Placeholder=" e.g. Other system in place" required="" />
                                                                <asp:HiddenField ID="altSafetySystemHid" runat="server" Value='<%# Eval("altSafetySystem") %>' />
                                                            </asp:TableCell>
                                                        </asp:TableRow>
                                                    </asp:Table>
                                                </asp:Panel>
                                            </asp:TableCell>
                                            <asp:TableCell RowSpan="2" Width="15" CssClass="w3-hide-small"></asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </asp:TableCell>
                                <asp:TableCell CssClass="w3-col s12 m6 l6" Height="305" Style="margin-bottom:15px">
                                    <asp:Table runat="server" Style="height:100%">
                                        <asp:TableRow VerticalAlign="Top">
                                            <asp:TableCell>
                                                <asp:Panel runat="server" CssClass="subItemPanel" Style="padding-bottom:10px;border-radius:5px;">
                                                    <asp:Table runat="server" CellPadding="4">
                                                        <asp:TableRow>
                                                            <asp:TableCell ColumnSpan="4" CssClass="subItemHeader">Risk</asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell RowSpan="3" Width="10"></asp:TableCell>
                                                            <asp:TableCell ColumnSpan="2" Height="5"></asp:TableCell>
                                                            <asp:TableCell RowSpan="3" Width="10"></asp:TableCell>
                                                        </asp:TableRow>        
                                                        <asp:TableRow>
                                                            <asp:TableCell Width="110">Risk Rating</asp:TableCell>
                                                            <asp:TableCell>
                                                                <asp:TextBox ID="riskRating" runat="server" Width="100%" MaxLength="50" CssClass="watermarkTextField" Text='<%# Eval("riskRating") %>' Placeholder=" e.g. P.2A" required="" />
                                                                <asp:HiddenField ID="riskRatingHid" runat="server" Value='<%# Eval("riskRating") %>' />
                                                            </asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell Style="padding-top:5px" VerticalAlign="Top">Description</asp:TableCell>
                                                            <asp:TableCell>
                                                                <asp:TextBox ID="riskRemarks" runat="server" Width="100%" TextMode="MultiLine" Rows="3" CssClass="watermarkTextField" Text='<%# Eval("riskRemarks") %>' Placeholder="" required="" />
                                                                <asp:HiddenField ID="riskRemarksHid" runat="server" Value='<%# Eval("riskRemarks") %>' />
                                                            </asp:TableCell>
                                                        </asp:TableRow>
                                                    </asp:Table>
                                                </asp:Panel>
                                            </asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow VerticalAlign="Bottom">
                                            <asp:TableCell>
                                                <asp:Panel runat="server" CssClass="subItemPanel" Style="padding-bottom:10px;border-radius:5px">
                                                    <asp:Table runat="server" CellPadding="4">
                                                        <asp:TableRow>
                                                            <asp:TableCell ColumnSpan="4" CssClass="subItemHeader">Mitigation</asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell RowSpan="3" Width="10"></asp:TableCell>
                                                            <asp:TableCell Height="5"></asp:TableCell>
                                                            <asp:TableCell RowSpan="3" Width="10"></asp:TableCell>
                                                        </asp:TableRow>                                               
                                                        <asp:TableRow>
                                                            <asp:TableCell>
                                                                <asp:TextBox ID="mitigateMethod" runat="server" Width="100%" TextMode="MultiLine" Rows="3" CssClass="watermarkTextField" Text='<%# Eval("mitigateMethod") %>' Placeholder=" Description" required="" />
                                                                <asp:HiddenField ID="mitigateMethodHid" runat="server" Value='<%# Eval("mitigateMethod") %>' />
                                                            </asp:TableCell>
                                                        </asp:TableRow>
                                                    </asp:Table>
                                                </asp:Panel>
                                            </asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow CssClass="w3-row">
                                <asp:TableCell CssClass="w3-col s12 m12 l12">
                                    <asp:Panel runat="server" CssClass="subItemPanel" Style="padding-bottom:20px;margin-bottom:15px;border-radius:5px">
                                        <asp:Table runat="server" CellPadding="0">
                                            <asp:TableRow>
                                                <asp:TableCell ColumnSpan="4" CssClass="subItemHeader">MOS</asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow>
                                                <asp:TableCell RowSpan="2" Width="10"></asp:TableCell>
                                                <asp:TableCell ColumnSpan="2" Height="10"></asp:TableCell>
                                                <asp:TableCell RowSpan="2" Width="10"></asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow>
                                                <asp:TableCell ColumnSpan="2">
                                                    <div class="w3-row">
                                                        <div class="w3-col s12 m6 l6">
                                                            <asp:Table runat="server" CellPadding="4">
                                                                <asp:TableRow>
                                                                    <asp:TableCell Width="110">Find Tag</asp:TableCell>
                                                                    <asp:TableCell Style="position:relative;padding-right:35px">                                                    
                                                                        <asp:TextBox ID="newTag" runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField syncTextAddOn" Style="text-transform:uppercase" Text="" ToolTip="" Placeholder=" PXT-201.MOS" />
                                                                        <asp:LinkButton ID="findTagBtn" runat="server" OnClientClick="mosTagLookup();return false;" CssClass="material-icons iconBtnGrey syncIconAddOn" style="position:absolute;right:3px;font-size:24px" Text="search" ToolTip="Search" /> 
                                                                        <asp:Image ID="findTagProgress" runat="server" ImageUrl="~/App_Themes/baseObjects/processing.gif" Style="position:absolute;right:9px;top:9px;display:none"/>
                                                                        <asp:HiddenField ID="tagCombo" runat="server" Value=""  />
                                                                    </asp:TableCell>
                                                                    <asp:TableCell RowSpan="3" Width="20" CssClass="w3-hide-small"></asp:TableCell>
                                                                </asp:TableRow>
                                                                <asp:TableRow>
                                                                    <asp:TableCell RowSpan="2" Width="110"></asp:TableCell>
                                                                    <asp:TableCell style="position:relative;padding:10px 10px;">
                                                                        <asp:Panel runat="server" ScrollBars="Auto" Style="max-height:300px">
                                                                            <table id="tagList" style="position:relative"></table> 
                                                                        </asp:Panel>                                                               
                                                                    </asp:TableCell>
                                                                </asp:TableRow>
                                                                <asp:TableRow>
                                                                    <asp:TableCell>
                                                                        <asp:Button ID="tagListAdd" runat="server" OnClick="MosTagAdd" OnClientClick="if(!mosTagSelect(3)){return false;}" CssClass="tagFnBtnAlt" Text="Add Selection" Style="float:left;margin:2px 3px" disabled /> 
                                                                        <asp:Button ID="tagTagAdd" runat="server" OnClick="MosTagAdd" OnClientClick="if(!mosTagSelect(4)){return false;}" CssClass="tagFnBtnAlt" Text="Add Tag" Style="float:left;margin:2px 3px" />
                                                                    </asp:TableCell>
                                                                </asp:TableRow>
                                                            </asp:Table>
                                                        </div>
                                                        <div class="w3-col s12 m6 l6">
                                                            <asp:Table runat="server" CellPadding="0">
                                                                <asp:TableRow CssClass="w3-hide-large w3-hide-medium"><asp:TableCell ColumnSpan="2" Height="10"></asp:TableCell></asp:TableRow>
                                                                <asp:TableRow>
                                                                    <asp:TableCell Width="110" CssClass="w3-hide-large w3-hide-medium"></asp:TableCell>
                                                                    <asp:TableCell style="padding:0px 5px 0px 2px">
                                                                        <asp:Panel runat="server" CssClass="subItemPanel" Style="padding-bottom:13px;border-radius:5px">
                                                                            <asp:Table runat="server" >
                                                                                <asp:TableRow>
                                                                                    <asp:TableCell ColumnSpan="3" CssClass="subItemHeader">Override List</asp:TableCell>
                                                                                </asp:TableRow>                                                                                
                                                                                <asp:TableRow>
                                                                                    <asp:TableCell RowSpan="2" Width="10"></asp:TableCell>
                                                                                    <asp:TableCell Height="5"></asp:TableCell>
                                                                                    <asp:TableCell RowSpan="2" Width="10"></asp:TableCell>
                                                                                </asp:TableRow>
                                                                                <asp:TableRow>
                                                                                    <asp:TableCell >                                                                                        
                                                                                        <asp:GridView id="mosTagGV" runat="server" width="100%" CellPadding="2" CellSpacing="0" AutoGenerateColumns="false" ShowHeader="false" EnableViewState="true" DataSourceID="mosTagDS" DataKeyNames="tagId" OnRowDeleted="MosTagDeleted">
                                                                                            <Columns>
                                                                                                <asp:BoundField DataField="tagName" ItemStyle-CssClass="hiddenColumn"/>
                                                                                                <asp:BoundField DataField="tagId" ItemStyle-CssClass="hiddenColumn"/>
                                                                                                <asp:TemplateField>
                                                                                                    <ItemTemplate>
                                                                                                        <asp:Table runat="server" Width="100%">
                                                                                                            <asp:TableRow>
                                                                                                                <asp:TableCell Style="position:relative">
                                                                                                                    <asp:TextBox ID="tagName" runat="server" onkeypress="return false" Width="100%" MaxLength="300" CssClass="watermarkTextField syncTextAddOn" Style="text-transform:uppercase" Text='<%# Eval("tagName") %>' />                                                                                                    
                                                                                                                    <asp:LinkButton runat="server" CommandName="Delete" CssClass="material-icons delBtnGrey" style="position:absolute;right:3px;top:4px;" Text="close" ToolTip="Delete" />
                                                                                                                </asp:TableCell>
                                                                                                            </asp:TableRow>
                                                                                                        </asp:Table>                                                                                    
                                                                                                    </ItemTemplate>
                                                                                                </asp:TemplateField>
                                                                                            </Columns>
                                                                                        </asp:GridView>
                                                                                    </asp:TableCell>
                                                                                </asp:TableRow>
                                                                            </asp:Table>
                                                                        </asp:Panel>
                                                                    </asp:TableCell>
                                                                </asp:TableRow>
                                                            </asp:Table>
                                                        </div>
                                                     </div>
                                                </asp:TableCell>                                                        
                                            </asp:TableRow>
                                        </asp:Table>                                        
                                    </asp:Panel>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow CssClass="w3-row">
                                <asp:TableCell CssClass="w3-col s12 m12 l12">
                                    <asp:Panel runat="server" CssClass="subItemPanel" Style="padding-bottom:15px;margin-bottom:15px">
                                        <asp:Table runat="server" CellPadding="0" CellSpacing="0">
                                            <asp:TableRow>
                                                <asp:TableCell ColumnSpan="5" CssClass="subItemHeader">Activation</asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow CssClass="w3-row">
                                                <asp:TableCell CssClass="w3-col s12 m12 l6">
                                                    <asp:Table ID="activatePanel" runat="server" CellPadding="4" Enabled="false">
                                                        <asp:TableRow>
                                                            <asp:TableCell RowSpan="3" Width="10"></asp:TableCell>
                                                            <asp:TableCell ColumnSpan="4" Height="5"></asp:TableCell>
                                                            <asp:TableCell RowSpan="3" Width="10"></asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell Width="110" Style="min-width:110px">Plan Start</asp:TableCell>
                                                            <asp:TableCell Width="1%" Style="position:relative">
                                                                <asp:TextBox ID="planStartDate" runat="server" Width="180" CssClass="watermarkTextField" Style="float:left" Text='<%# Eval("planStart", "{0:dd-MMM-yyyy}") %>' placeholder="DD-MMM-YYYY" required="" />
                                                                <asp:Label ID="planStartImg" runat="server" CssClass="material-icons iconBtnBlue" Text="date_range" style="position:absolute;top:6px;left:158px;background-color:#FFFFFF;" />
                                                                <ajax:CalendarExtender ID="planStartDateCE" runat="server" Enabled="false" TargetControlID="planStartDate" PopupButtonID="planStartImg" Format="dd-MMM-yyyy" PopupPosition="BottomLeft" CssClass="ajax__calendar_xp" />
                                                            </asp:TableCell>
                                                            <asp:TableCell Width="1%" VerticalAlign="Top">
                                                                <asp:DropDownList ID="planStartTime" runat="server" Width="70" Height="28" CssClass="normalDropDown" Style="padding-right:22px" EnableViewState="false" SelectedValue='<%# Eval("planStart", "{0:hh:mm}") %>' required="">
                                                                    <asp:ListItem Text="" Value="" disabled Selected />
                                                                    <asp:ListItem Text="12:00" Value="12:00"/>
                                                                    <asp:ListItem Text="12:30" Value="12:30"/>
                                                                    <asp:ListItem Text="1:00" Value="01:00"/>
                                                                    <asp:ListItem Text="1:30" Value="01:30"/>
                                                                    <asp:ListItem Text="2:00" Value="02:00"/>
                                                                    <asp:ListItem Text="2:30" Value="02:30"/>
                                                                    <asp:ListItem Text="3:00" Value="03:00"/>
                                                                    <asp:ListItem Text="3:30" Value="03:30"/>
                                                                    <asp:ListItem Text="4:00" Value="04:00"/>
                                                                    <asp:ListItem Text="4:30" Value="04:30"/>
                                                                    <asp:ListItem Text="5:00" Value="05:00"/>
                                                                    <asp:ListItem Text="5:30" Value="05:30"/>
                                                                    <asp:ListItem Text="6:00" Value="06:00"/>
                                                                    <asp:ListItem Text="6:30" Value="06:30"/>
                                                                    <asp:ListItem Text="7:00" Value="07:00"/>
                                                                    <asp:ListItem Text="7:30" Value="07:30"/>
                                                                    <asp:ListItem Text="8:00" Value="08:00"/>
                                                                    <asp:ListItem Text="8:30" Value="08:30"/>
                                                                    <asp:ListItem Text="9:00" Value="09:00"/>
                                                                    <asp:ListItem Text="9:30" Value="09:30"/>
                                                                    <asp:ListItem Text="10:00" Value="10:00"/>
                                                                    <asp:ListItem Text="10:30" Value="10:30"/>
                                                                    <asp:ListItem Text="11:00" Value="11:00"/>
                                                                    <asp:ListItem Text="11:30" Value="11:30"/>
                                                                </asp:DropDownList>
                                                            </asp:TableCell>                                                            
                                                            <asp:TableCell VerticalAlign="Top">
                                                                <asp:DropDownList ID="planStartTimeInd" runat="server" Width="55" Height="28" CssClass="normalDropDown" Style="padding-right:22px" EnableViewState="false" SelectedValue='<%# Eval("planStart", "{0:tt}") %>' required="">
                                                                    <asp:ListItem Text="" Value="" disabled Selected />
                                                                    <asp:ListItem Text="AM" Value="AM"/>
                                                                    <asp:ListItem Text="PM" Value="PM"/>
                                                                </asp:DropDownList>
                                                            </asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell Width="110" Style="min-width:110px">Plan End</asp:TableCell>
                                                            <asp:TableCell Width="1%" Style="position:relative">
                                                                <asp:TextBox ID="planEndDate" runat="server" Width="180" CssClass="watermarkTextField" Style="float:left" Text='<%# Eval("planEnd", "{0:dd-MMM-yyyy}") %>' placeholder="DD-MMM-YYYY" required="" />
                                                                <asp:Label ID="planEndImg" runat="server" CssClass="material-icons iconBtnBlue" Text="date_range" style="position:absolute;top:6px;left:158px;background-color:#FFFFFF;" />
                                                                <ajax:CalendarExtender ID="planEndDateCE" runat="server" Enabled="false" TargetControlID="planEndDate" PopupButtonID="planEndImg" Format="dd-MMM-yyyy" PopupPosition="BottomLeft" CssClass="ajax__calendar_xp" />
                                                            </asp:TableCell>
                                                            <asp:TableCell Width="1%" VerticalAlign="Top">
                                                                <asp:DropDownList ID="planEndTime" runat="server" Width="70" Height="28" CssClass="normalDropDown" Style="padding-right:22px" EnableViewState="false" SelectedValue='<%# Eval("planEnd", "{0:hh:mm}") %>' required="">
                                                                    <asp:ListItem Text="" Value="" disabled Selected />
                                                                    <asp:ListItem Text="12:00" Value="12:00"/>
                                                                    <asp:ListItem Text="12:30" Value="12:30"/>
                                                                    <asp:ListItem Text="1:00" Value="01:00"/>
                                                                    <asp:ListItem Text="1:30" Value="01:30"/>
                                                                    <asp:ListItem Text="2:00" Value="02:00"/>
                                                                    <asp:ListItem Text="2:30" Value="02:30"/>
                                                                    <asp:ListItem Text="3:00" Value="03:00"/>
                                                                    <asp:ListItem Text="3:30" Value="03:30"/>
                                                                    <asp:ListItem Text="4:00" Value="04:00"/>
                                                                    <asp:ListItem Text="4:30" Value="04:30"/>
                                                                    <asp:ListItem Text="5:00" Value="05:00"/>
                                                                    <asp:ListItem Text="5:30" Value="05:30"/>
                                                                    <asp:ListItem Text="6:00" Value="06:00"/>
                                                                    <asp:ListItem Text="6:30" Value="06:30"/>
                                                                    <asp:ListItem Text="7:00" Value="07:00"/>
                                                                    <asp:ListItem Text="7:30" Value="07:30"/>
                                                                    <asp:ListItem Text="8:00" Value="08:00"/>
                                                                    <asp:ListItem Text="8:30" Value="08:30"/>
                                                                    <asp:ListItem Text="9:00" Value="09:00"/>
                                                                    <asp:ListItem Text="9:30" Value="09:30"/>
                                                                    <asp:ListItem Text="10:00" Value="10:00"/>
                                                                    <asp:ListItem Text="10:30" Value="10:30"/>
                                                                    <asp:ListItem Text="11:00" Value="11:00"/>
                                                                    <asp:ListItem Text="11:30" Value="11:30"/>
                                                                </asp:DropDownList>
                                                            </asp:TableCell>                                                            
                                                            <asp:TableCell VerticalAlign="Top">
                                                                <asp:DropDownList ID="planEndTimeInd" runat="server" Width="55" Height="28" CssClass="normalDropDown" Style="padding-right:22px" EnableViewState="false" SelectedValue='<%# Eval("planEnd", "{0:tt}") %>' required="">
                                                                    <asp:ListItem Text="" Value="" disabled Selected />
                                                                    <asp:ListItem Text="AM" Value="AM"/>
                                                                    <asp:ListItem Text="PM" Value="PM"/>
                                                                </asp:DropDownList>
                                                            </asp:TableCell>
                                                        </asp:TableRow>
                                                    </asp:Table>
                                                </asp:TableCell>
                                                <asp:TableCell CssClass="w3-col s12 m12 l6">
                                                    <asp:Table runat="server" CellPadding="4">
                                                        <asp:TableRow>
                                                            <asp:TableCell RowSpan="3" Width="10"></asp:TableCell>
                                                            <asp:TableCell ColumnSpan="2" Height="5"></asp:TableCell>
                                                            <asp:TableCell RowSpan="3" Width="10"></asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell Width="110" Style="min-width:110px;font-weight:bold;color:#999999">Status</asp:TableCell>
                                                            <asp:TableCell Style="padding-top:8px">
                                                                <asp:CheckBoxList ID="mosExtension" runat="server" CssClass="w3-text-grey" TextAlign="Right" RepeatDirection="Horizontal" RepeatLayout="Table" Width="230" Enabled="false">
                                                                    <asp:ListItem Text="Extension 1" Value="1" />
                                                                    <asp:ListItem Text="Extension 2" Value="2" />
                                                                </asp:CheckBoxList>                                                                
                                                            </asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell>
                                                                <asp:Label runat="server" Width="100%" CssClass="logSumLabel" Style="font-size:11px;padding-left:2px;padding-bottom:3px" Text="Initial" />
                                                                <asp:Label runat="server" Width="100%" CssClass="logSumLabel" Style="font-size:11px;padding-left:2px" Text="Previous" />                                                                
                                                            </asp:TableCell>
                                                            <asp:TableCell>
                                                                <asp:Label runat="server" Width="100%" CssClass="logSumLabel" Style="font-size:11px;padding-bottom:3px" Text='<%# (Convert.ToInt32(Eval("extCount")) > 0) ? (String.IsNullOrEmpty(Eval("initStart").ToString().Trim()) ? "..." : (Eval("initStart","{0:dd-MMM-yyyy hh:mm tt}").ToString().Trim() + " to " + Eval("initEnd","{0:dd-MMM-yyyy hh:mm tt}").ToString().Trim())) : "..."  %>' />
                                                                <asp:Label runat="server" Width="100%" CssClass="logSumLabel" Style="font-size:11px" Text='<%# (Convert.ToInt32(Eval("extCount")) > 1) ? (String.IsNullOrEmpty(Eval("prevStart").ToString().Trim()) ? "..." : (Eval("prevStart","{0:dd-MMM-yyyy hh:mm tt}").ToString().Trim() + " to " + Eval("prevEnd","{0:dd-MMM-yyyy hh:mm tt}").ToString().Trim())) : "..."  %>' />                                                                
                                                            </asp:TableCell>
                                                        </asp:TableRow>
                                                    </asp:Table>
                                                </asp:TableCell>

                                            </asp:TableRow>

                                        </asp:Table>
                                    </asp:Panel>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow CssClass="w3-row">
                                <asp:TableCell CssClass="w3-col s12 m12 l12">
                                    <asp:Panel runat="server" CssClass="subItemPanel" Style="padding:15px 15px 10px 15px;border-radius:0px;">
                                        <asp:Table ID="activateChecklist" runat="server" CellPadding="4" Enabled="false">
                                            <asp:TableRow CssClass="w3-row">
                                                <asp:TableCell CssClass="w3-col s12 m6 l3"><asp:CheckBox ID="allTagIdentify" runat="server" Checked='<%# Eval("allTagIdentify") %>' CssClass="w3-text-grey" TextAlign="Right" Text="All Isolation Tagged and Identified" /></asp:TableCell>
                                                <asp:TableCell CssClass="w3-col s12 m6 l3"><asp:CheckBox ID="allKeyNotify" runat="server" Checked='<%# Eval("allKeyNotify") %>' CssClass="w3-text-grey" TextAlign="Right" Text="All Key Personnel Informed" /></asp:TableCell>
                                                <asp:TableCell CssClass="w3-col s12 m6 l3"><asp:CheckBox ID="isolateCertDisplay" runat="server" Checked='<%# Eval("isolateCertDisplay") %>' CssClass="w3-text-grey" TextAlign="Right" Text="E-SSIC Attached with PTW" /></asp:TableCell>
                                                <asp:TableCell CssClass="w3-col s12 m6 l3"><asp:CheckBox ID="logBookEntry" runat="server" Checked='<%# Eval("logBookEntry") %>' CssClass="w3-text-grey" TextAlign="Right" Text="Activated E-SSIC Documented in CCR" /></asp:TableCell>
                                            </asp:TableRow>
                                        </asp:Table>
                                    </asp:Panel>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:UpdatePanel ID="optionUP" runat="server"><ContentTemplate>
                            <asp:Panel ID="flowRemarksPanel" runat="server">
                                <div class="tagTitleRoot"></div>
                                <asp:Table runat="server" style="margin-top:20px">
                                    <asp:TableRow>
                                        <asp:TableCell CssClass="subItemPanel" Style="padding-bottom:15px;border-radius:0px;">
                                            <asp:Table runat="server" CellPadding="4">
                                                <asp:TableRow>
                                                    <asp:TableCell ColumnSpan="4" CssClass="subItemHeader"><asp:label ID="flowTitle" runat="server"/></asp:TableCell>
                                                </asp:TableRow>
                                                <asp:TableRow>
                                                    <asp:TableCell RowSpan="3" Width="10"></asp:TableCell>
                                                    <asp:TableCell ColumnSpan="2" Height="5"></asp:TableCell>
                                                    <asp:TableCell RowSpan="3" Width="10"></asp:TableCell>
                                                </asp:TableRow>
                                                <asp:TableRow>
                                                    <asp:TableCell Width="110" VerticalAlign="Top">Remarks</asp:TableCell>
                                                    <asp:TableCell>
                                                        <asp:TextBox ID="agrRemarks" runat="server" ValidateRequestMode="Disabled" Visible="false" Width="100%" MaxLength="300" TextMode="MultiLine" Rows="3" CssClass="watermarkTextField" Text='<%# Server.HtmlDecode(Eval("agrRemarks").ToString()) %>' Placeholder=" Optional Comments Here" />
                                                        <asp:TextBox ID="edsRemarks" runat="server" ValidateRequestMode="Disabled" Visible="false" Width="100%" MaxLength="300" TextMode="MultiLine" Rows="3" CssClass="watermarkTextField" Text='<%# Server.HtmlDecode(Eval("edsRemarks").ToString()) %>' Placeholder=" Optional Comments Here" />
                                                        <asp:TextBox ID="autRemarks" runat="server" ValidateRequestMode="Disabled" Visible="false" Width="100%" MaxLength="300" TextMode="MultiLine" Rows="3" CssClass="watermarkTextField" Text='<%# Server.HtmlDecode(Eval("autRemarks").ToString()) %>' Placeholder=" Optional Comments Here" />
                                                        <asp:TextBox ID="apvRemarks" runat="server" ValidateRequestMode="Disabled" Visible="false" Width="100%" MaxLength="300" TextMode="MultiLine" Rows="3" CssClass="watermarkTextField" Text='<%# Server.HtmlDecode(Eval("apvRemarks").ToString()) %>' Placeholder=" Optional Comments Here" />
                                                        <asp:HiddenField ID="agrRemarksHid" runat="server" Value='<%# Eval("agrRemarks") %>' />
                                                        <asp:HiddenField ID="edsRemarksHid" runat="server" Value='<%# Eval("edsRemarks") %>' />
                                                        <asp:HiddenField ID="autRemarksHid" runat="server" Value='<%# Eval("autRemarks") %>' />
                                                        <asp:HiddenField ID="apvRemarksHid" runat="server" Value='<%# Eval("apvRemarks") %>' />
                                                    </asp:TableCell>
                                                </asp:TableRow>
                                            </asp:Table>
                                        </asp:TableCell>
                                    </asp:TableRow>                                    
                                </asp:Table>
                            </asp:Panel>

                            <div class="tagTitleRoot"></div>
                            <asp:Table runat="server" style="margin:15px 0px 10px 0px">
                                <asp:TableRow>
                                    <asp:TableCell VerticalAlign="Top" Width="1%" Wrap="false" style="padding-right:20px">                                        
                                        <asp:Button runat="server" OnClientClick="$find('MainContent_historyMPE').show();return false;" CssClass="altButton" Text="Change Log" Enabled="true" Visible="true" Style="margin:0px 5px" />
                                        <input id="resetBtn" type="reset" title="Reset" OnClick="mosTagReset(6)" class="altButton w3-hide-small" />                                        
                                    </asp:TableCell>
                                    <asp:TableCell VerticalAlign="Top" Style="max-width:300px">                                        
                                        <asp:CheckBox ID="editConfirmChk" runat="server" OnClick="setConfirmBtn(this.checked,'SAVE');" CssClass="w3-text-grey" Text="Confirm all information is correct" TextAlign="right" Enabled="true" Style="float:left;margin:7px 0px 0px 5px" />                                        
                                    </asp:TableCell>
                                    <asp:TableCell CssClass="w3-hide-large" Style="min-width:40px"></asp:TableCell>
                                    <asp:TableCell VerticalAlign="Top" HorizontalAlign="Right" Style="min-width:200px">
                                        <span style="position:relative">                                            
                                            <asp:UpdateProgress runat="server" AssociatedUpdatePanelID="optionUP" DisplayAfter="0"><ProgressTemplate><asp:Image runat="server" ImageUrl="~/App_Themes/baseObjects/processing.gif" Style="position:absolute;top:0px;left:-25px" /></ProgressTemplate></asp:UpdateProgress>
                                            <asp:Button ID="editFn1Btn" runat="server" OnClientClick="setConfirmPrompt('1')" CssClass="altButton" Style="margin:0px 5px 10px 5px" Disabled="disabled"/>
                                            <asp:Button ID="editFn2Btn" runat="server" OnClientClick="setConfirmPrompt('2')" CssClass="altButton" Style="margin:0px 5px 10px 5px" Disabled="disabled"/>
                                        </span>
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                            
                        </ContentTemplate></asp:UpdatePanel>

                        <asp:SqlDataSource id="hubListDS" runat="server" DataSourceMode="DataSet" 
                            SelectCommand="SELECT * FROM adm_list_hub ORDER BY hubName"
                            ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
                        </asp:SqlDataSource> 
                        <asp:SqlDataSource id="fieldListDS" runat="server" DataSourceMode="DataSet" 
                            SelectCommand="SELECT * FROM adm_list_field ORDER BY fieldName"
                            FilterExpression="fieldHub LIKE '%{0}%'" 
                            ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
                            <FilterParameters>
                                <asp:ControlParameter ConvertEmptyStringToNull="False" DefaultValue="%" PropertyName="SelectedValue" ControlID="hub" />
                            </FilterParameters>
                        </asp:SqlDataSource>
                    </EditItemTemplate>

                    <ItemTemplate>
                        <asp:Table runat="server">
                            <asp:TableRow CssClass="w3-row">
                                <asp:TableCell CssClass="w3-col s12 m6 l6">
                                    <asp:Table runat="server" CellPadding="4" Style="margin-bottom:5px">                                        
                                        <asp:TableRow>
                                            <asp:TableCell VerticalAlign="Top" Width="112">Override</asp:TableCell>
                                            <asp:TableCell VerticalAlign="Top">
                                                <asp:RadioButtonList runat="server" AutoPostBack="false" TextAlign="Right" RepeatLayout="Table" RepeatColumns="2" Width="220" SelectedValue='<%# Eval("longTerm") %>' Enabled="false">
                                                    <asp:ListItem Text="Short Term" Value="False"/>
                                                    <asp:ListItem Text="Long Term" Value="True"/>                                                    
                                                </asp:RadioButtonList>
                                            </asp:TableCell>
                                            <asp:TableCell Width="15" CssClass="w3-hide-small"></asp:TableCell>
                                        </asp:TableRow>                                       
                                    </asp:Table>
                                </asp:TableCell>
                                <asp:TableCell CssClass="w3-col s12 m6 l6">
                                    
                                </asp:TableCell>
                            </asp:TableRow>  
                            <asp:TableRow CssClass="w3-row">
                                <asp:TableCell CssClass="w3-col s12 m6 l6">
                                    <asp:Table runat="server" CellPadding="4">
                                        <asp:TableRow Visible='<%# Eval("longTerm") %>'>
                                            <asp:TableCell>MOC #</asp:TableCell>
                                            <asp:TableCell><asp:TextBox runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField" Text='<%# Eval("mocId") %>' ToolTip='<%# Eval("mocId") %>' Enabled="false"/></asp:TableCell>
                                            <asp:TableCell Width="15" CssClass="w3-hide-small"></asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow>
                                            <asp:TableCell Width="120">PTW #</asp:TableCell>
                                            <asp:TableCell><asp:TextBox runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField" Text='<%# Eval("ptwId") %>' ToolTip='<%# Eval("ptwId") %>' Enabled="false"/></asp:TableCell>
                                            <asp:TableCell Width="15" CssClass="w3-hide-small"></asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </asp:TableCell>
                                <asp:TableCell CssClass="w3-col s12 m6 l6">
                                    <asp:Table runat="server" CellPadding="3" Style="margin-bottom:10px" Visible="false">
                                        <asp:TableRow>
                                            <asp:TableCell Width="120">MOS Request</asp:TableCell>
                                            <asp:TableCell><asp:TextBox runat="server" Width="100%" CssClass="watermarkTextField" Text='<%# Eval("hub","{0}-") + Eval("formId","{0:D5}") %>' ToolTip='<%# Eval("hub","{0}-") + Eval("formId","{0:D5}") %>' Enabled="false" /></asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </asp:TableCell>
                            </asp:TableRow>                        
                            <asp:TableRow CssClass="w3-row">
                                <asp:TableCell CssClass="w3-col s12 m6 l6">
                                    <asp:Table runat="server" CellPadding="4" Style="margin-bottom:15px">
                                        <asp:TableRow>
                                            <asp:TableCell Width="120">Hub</asp:TableCell>
                                            <asp:TableCell><asp:TextBox runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField" Text='<%# Eval("hub") %>' ToolTip='<%# Eval("hub") %>' Enabled="false"/></asp:TableCell>
                                            <asp:TableCell RowSpan="2" Width="15" CssClass="w3-hide-small"></asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow>
                                            <asp:TableCell>Field</asp:TableCell>
                                            <asp:TableCell><asp:TextBox runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField" Text='<%# Eval("field") %>' ToolTip='<%# Eval("field") %>' Enabled="false"/></asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </asp:TableCell>
                                <asp:TableCell CssClass="w3-col s12 m6 l6">                                    

                                </asp:TableCell>
                            </asp:TableRow>                        
                            <asp:TableRow CssClass="w3-row">
                                <asp:TableCell CssClass="w3-col s12 m12 l12">
                                    <asp:Panel runat="server" CssClass="subItemPanel" Style="padding-bottom:15px;margin-bottom:15px;border-radius:5px">
                                        <asp:Table runat="server" CellPadding="4">
                                            <asp:TableRow>
                                                <asp:TableCell ColumnSpan="4" CssClass="subItemHeader">System</asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow>
                                                <asp:TableCell RowSpan="4" Width="10"></asp:TableCell>
                                                <asp:TableCell ColumnSpan="2" Height="5"></asp:TableCell>
                                                <asp:TableCell RowSpan="4" Width="10"></asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow>
                                                <asp:TableCell Width="110">Process</asp:TableCell>
                                                <asp:TableCell style="position:relative"><asp:TextBox runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField syncTextAddOn" Text='<%# Eval("processSystem") %>' ToolTip='<%# Eval("processSystem") %>' Enabled="false" /></asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow>
                                                <asp:TableCell>Control</asp:TableCell>
                                                <asp:TableCell style="position:relative"><asp:TextBox runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField syncTextAddOn" Text='<%# Eval("controlSystem") %>' ToolTip='<%# Eval("controlSystem") %>' Enabled="false" /></asp:TableCell>
                                            </asp:TableRow>
                                        </asp:Table>
                                    </asp:Panel>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow CssClass="w3-row">
                                <asp:TableCell CssClass="w3-col s12 m6 l6" Height="305" Style="margin-bottom:15px">
                                    <asp:Table runat="server" Height="100%">
                                        <asp:TableRow Height="100%">
                                            <asp:TableCell>
                                                <asp:Panel runat="server" CssClass="subItemPanel" Height="100%" Style="border-radius:5px">
                                                    <asp:Table runat="server" CellPadding="4">
                                                        <asp:TableRow>
                                                            <asp:TableCell ColumnSpan="4" CssClass="subItemHeader">Isolation</asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell RowSpan="7" Width="10"></asp:TableCell>
                                                            <asp:TableCell ColumnSpan="2" Height="5"></asp:TableCell>
                                                            <asp:TableCell RowSpan="7" Width="10"></asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell Width="110">Function</asp:TableCell>
                                                            <asp:TableCell style="position:relative"><asp:TextBox runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField" Text='<%# Eval("isolateFunction") %>' ToolTip='<%# Eval("isolateFunction") %>' Enabled="false" /></asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell>Method</asp:TableCell>
                                                            <asp:TableCell style="position:relative"><asp:TextBox runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField" Text='<%# Eval("isolateMethod") %>' ToolTip='<%# Eval("isolateMethod") %>' Enabled="false" /></asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell>Purpose</asp:TableCell>
                                                            <asp:TableCell style="position:relative"><asp:TextBox runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField" Text='<%# Eval("isolatePurpose") %>' ToolTip='<%# Eval("isolatePurpose") %>' Enabled="false" /></asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell>Effect</asp:TableCell>
                                                            <asp:TableCell style="position:relative"><asp:TextBox runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField" Text='<%# Eval("isolateEffect") %>' ToolTip='<%# Eval("isolateEffect") %>' Enabled="false" /></asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow><asp:TableCell ColumnSpan="2" Height="15"></asp:TableCell></asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell VerticalAlign="Top">Active Safety</asp:TableCell>
                                                            <asp:TableCell Style="position:relative"><asp:TextBox runat="server" Width="100%" MaxLength="300" TextMode="MultiLine" Rows="4" CssClass="watermarkTextField" Text='<%# Eval("altSafetySystem") %>' ToolTip='<%# Eval("altSafetySystem") %>' Enabled="false" /></asp:TableCell>
                                                        </asp:TableRow>
                                                    </asp:Table>
                                                </asp:Panel>
                                            </asp:TableCell>
                                            <asp:TableCell RowSpan="2" Width="15" CssClass="w3-hide-small"></asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </asp:TableCell>
                                <asp:TableCell CssClass="w3-col s12 m6 l6" Height="305" Style="margin-bottom:15px">
                                    <asp:Table runat="server" Style="height:100%">
                                        <asp:TableRow VerticalAlign="Top">
                                            <asp:TableCell>
                                                <asp:Panel runat="server" CssClass="subItemPanel" Style="padding-bottom:10px;border-radius:5px;">
                                                    <asp:Table runat="server" CellPadding="4">
                                                        <asp:TableRow>
                                                            <asp:TableCell ColumnSpan="4" CssClass="subItemHeader">Risk</asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell RowSpan="3" Width="10"></asp:TableCell>
                                                            <asp:TableCell ColumnSpan="2" Height="5"></asp:TableCell>
                                                            <asp:TableCell RowSpan="3" Width="10"></asp:TableCell>
                                                        </asp:TableRow>        
                                                        <asp:TableRow>
                                                            <asp:TableCell Width="110">Risk Rating</asp:TableCell>
                                                            <asp:TableCell style="position:relative"><asp:TextBox runat="server" Width="100%" MaxLength="50" CssClass="watermarkTextField" Text='<%# Eval("riskRating") %>' ToolTip='<%# Eval("riskRating") %>' Enabled="false" /></asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell Style="padding-top:5px" VerticalAlign="Top">Description</asp:TableCell>
                                                            <asp:TableCell style="position:relative"><asp:TextBox runat="server" Width="100%" TextMode="MultiLine" Rows="3" CssClass="watermarkTextField" Text='<%# Eval("riskRemarks") %>' ToolTip='<%# Eval("riskRemarks") %>' Enabled="false" /></asp:TableCell>
                                                        </asp:TableRow>
                                                    </asp:Table>
                                                </asp:Panel>
                                            </asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow VerticalAlign="Bottom">
                                            <asp:TableCell>
                                                <asp:Panel runat="server" CssClass="subItemPanel" Style="padding-bottom:10px;border-radius:5px">
                                                    <asp:Table runat="server" CellPadding="4">
                                                        <asp:TableRow>
                                                            <asp:TableCell ColumnSpan="4" CssClass="subItemHeader">Mitigation</asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell RowSpan="3" Width="10"></asp:TableCell>
                                                            <asp:TableCell Height="5"></asp:TableCell>
                                                            <asp:TableCell RowSpan="3" Width="10"></asp:TableCell>
                                                        </asp:TableRow>                                               
                                                        <asp:TableRow>
                                                            <asp:TableCell style="position:relative"><asp:TextBox runat="server" Width="100%" TextMode="MultiLine" Rows="3" CssClass="watermarkTextField" Text='<%# Eval("mitigateMethod") %>' ToolTip='<%# Eval("mitigateMethod") %>' Enabled="false" /></asp:TableCell>
                                                        </asp:TableRow>
                                                    </asp:Table>
                                                </asp:Panel>
                                            </asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow CssClass="w3-row">
                                <asp:TableCell CssClass="w3-col s12 m12 l12">
                                    <asp:Panel runat="server" CssClass="subItemPanel" Style="padding-bottom:20px;margin-bottom:15px;border-radius:5px">
                                        <asp:Table runat="server" CellPadding="0">
                                            <asp:TableRow>
                                                <asp:TableCell ColumnSpan="4" CssClass="subItemHeader">MOS</asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow>
                                                <asp:TableCell RowSpan="2" Width="10"></asp:TableCell>
                                                <asp:TableCell ColumnSpan="2" Height="10"></asp:TableCell>
                                                <asp:TableCell RowSpan="2" Width="10"></asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow>
                                                <asp:TableCell ColumnSpan="2">
                                                    <div class="w3-row">
                                                        <div class="w3-col s12 m6 l6">
                                                            <asp:Table runat="server" CellPadding="4">
                                                                <asp:TableRow>
                                                                    <asp:TableCell Width="110">Find Tag</asp:TableCell>
                                                                    <asp:TableCell Style="position:relative;padding-right:35px">                                                    
                                                                        <asp:TextBox runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField syncTextAddOn" Style="text-transform:uppercase" Text="" ToolTip="" Placeholder=" PXT-201.MOS" Enabled="false" />
                                                                        <asp:Label runat="server" CssClass="material-icons iconBtnGreyPlaceholder syncIconAddOn" style="position:absolute;right:3px;font-size:24px" Text="search" Enabled="false"/>
                                                                    </asp:TableCell>
                                                                    <asp:TableCell RowSpan="3" Width="20" CssClass="w3-hide-small"></asp:TableCell>
                                                                </asp:TableRow>
                                                                <asp:TableRow>
                                                                    <asp:TableCell RowSpan="2" Width="110"></asp:TableCell>
                                                                    <asp:TableCell style="position:relative;padding:10px 10px;">
                                                                        <asp:Panel runat="server" ScrollBars="Auto" Style="max-height:300px">
                                                                            <table id="tagList" style="position:relative"></table> 
                                                                        </asp:Panel>                                                               
                                                                    </asp:TableCell>
                                                                </asp:TableRow>
                                                                <asp:TableRow>
                                                                    <asp:TableCell>
                                                                        <asp:Button runat="server" CssClass="tagFnBtnAlt" Text="Add Selection" Style="float:left;margin:2px 3px" Enabled="false" />                                                                            
                                                                        <asp:Button runat="server" CssClass="tagFnBtnAlt" Text="Add Tag" Style="float:left;margin:2px 3px" Enabled="false" />                                                                       
                                                                    </asp:TableCell>
                                                                </asp:TableRow>
                                                            </asp:Table>
                                                        </div>
                                                        <div class="w3-col s12 m6 l6">
                                                            <asp:Table runat="server" CellPadding="0">
                                                                <asp:TableRow CssClass="w3-hide-large w3-hide-medium"><asp:TableCell ColumnSpan="2" Height="10"></asp:TableCell></asp:TableRow>
                                                                <asp:TableRow>
                                                                    <asp:TableCell Width="110" CssClass="w3-hide-large w3-hide-medium"></asp:TableCell>
                                                                    <asp:TableCell style="padding:0px 5px 0px 2px">
                                                                        <asp:Panel runat="server" CssClass="subItemPanel" Style="padding-bottom:13px;border-radius:5px">
                                                                            <asp:Table runat="server" >
                                                                                <asp:TableRow>
                                                                                    <asp:TableCell ColumnSpan="3" CssClass="subItemHeader">Override List</asp:TableCell>
                                                                                </asp:TableRow>                                                                                
                                                                                <asp:TableRow>
                                                                                    <asp:TableCell RowSpan="2" Width="10"></asp:TableCell>
                                                                                    <asp:TableCell Height="5"></asp:TableCell>
                                                                                    <asp:TableCell RowSpan="2" Width="10"></asp:TableCell>
                                                                                </asp:TableRow>
                                                                                <asp:TableRow>
                                                                                    <asp:TableCell >                                                                                        
                                                                                        <asp:GridView id="mosTagReadGV" runat="server" width="100%" CellPadding="2" CellSpacing="0" AutoGenerateColumns="false" ShowHeader="false" EnableViewState="true" DataSourceID="mosTagDS" DataKeyNames="tagId">
                                                                                            <Columns>
                                                                                                <asp:TemplateField>
                                                                                                    <ItemTemplate>
                                                                                                        <asp:Table runat="server" Width="100%">
                                                                                                            <asp:TableRow>
                                                                                                                <asp:TableCell Style="position:relative">
                                                                                                                    <asp:TextBox ID="tagName" runat="server" Width="100%" MaxLength="300" CssClass="watermarkTextField syncTextAddOn" Style="text-transform:uppercase" Text='<%# Eval("tagName") %>' Enabled="false" />
                                                                                                                </asp:TableCell>
                                                                                                            </asp:TableRow>
                                                                                                        </asp:Table>
                                                                                                    </ItemTemplate>
                                                                                                </asp:TemplateField>
                                                                                            </Columns>
                                                                                        </asp:GridView>
                                                                                    </asp:TableCell>
                                                                                </asp:TableRow>
                                                                            </asp:Table>
                                                                        </asp:Panel>
                                                                    </asp:TableCell>
                                                                </asp:TableRow>
                                                            </asp:Table>
                                                        </div>
                                                     </div>                                                    
                                                </asp:TableCell>                                                        
                                            </asp:TableRow>
                                        </asp:Table>                                        
                                    </asp:Panel>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow CssClass="w3-row">
                                <asp:TableCell CssClass="w3-col s12 m12 l12">
                                    <asp:Panel runat="server" CssClass="subItemPanel" Style="padding-bottom:15px;margin-bottom:15px">
                                        <asp:Table runat="server" CellPadding="0" CellSpacing="0">
                                            <asp:TableRow>
                                                <asp:TableCell ColumnSpan="5" CssClass="subItemHeader">Activation</asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow CssClass="w3-row">
                                                <asp:TableCell CssClass="w3-col s12 m12 l6">
                                                    <asp:Table runat="server" CellPadding="4">
                                                        <asp:TableRow>
                                                            <asp:TableCell RowSpan="3" Width="10"></asp:TableCell>
                                                            <asp:TableCell ColumnSpan="4" Height="5"></asp:TableCell>
                                                            <asp:TableCell RowSpan="3" Width="10"></asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell Width="110" Style="min-width:110px">Plan Start</asp:TableCell>
                                                            <asp:TableCell Width="1%" Style="position:relative">
                                                                <asp:TextBox runat="server" Width="180" CssClass="watermarkTextField" Style="float:left" Text='<%# Eval("planStart", "{0:dd-MMM-yyyy}") %>' ToolTip='<%# Eval("planStart", "{0:dd-MMM-yyyy}") %>' Enabled="false" />
                                                            </asp:TableCell>
                                                            <asp:TableCell Width="1%" VerticalAlign="Top">
                                                                <asp:TextBox runat="server" Width="70" CssClass="watermarkTextField" Style="float:left;text-align:center" Text='<%# Eval("planStart", "{0:hh:mm}") %>' ToolTip='<%# Eval("planStart", "{0:hh:mm}") %>' Enabled="false" />                                                                
                                                            </asp:TableCell>                                                            
                                                            <asp:TableCell VerticalAlign="Top">
                                                                <asp:TextBox runat="server" Width="55" CssClass="watermarkTextField" Style="float:left;text-align:center" Text='<%# Eval("planStart", "{0:tt}") %>' ToolTip='<%# Eval("planStart", "{0:tt}") %>' Enabled="false" />                                                                
                                                            </asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell Width="110" Style="min-width:110px">Plan End</asp:TableCell>
                                                            <asp:TableCell Width="1%" Style="position:relative">
                                                                <asp:TextBox runat="server" Width="180" CssClass="watermarkTextField" Style="float:left" Text='<%# Eval("planEnd", "{0:dd-MMM-yyyy}") %>' ToolTip='<%# Eval("planEnd", "{0:dd-MMM-yyyy}") %>' Enabled="false" />
                                                            </asp:TableCell>
                                                            <asp:TableCell Width="1%" VerticalAlign="Top">
                                                                <asp:TextBox runat="server" Width="70" CssClass="watermarkTextField" Style="float:left;text-align:center" Text='<%# Eval("planEnd", "{0:hh:mm}") %>' ToolTip='<%# Eval("planEnd", "{0:hh:mm}") %>' Enabled="false" />                                                                
                                                            </asp:TableCell>                                                            
                                                            <asp:TableCell VerticalAlign="Top">
                                                                <asp:TextBox runat="server" Width="55" CssClass="watermarkTextField" Style="float:left;text-align:center" Text='<%# Eval("planEnd", "{0:tt}") %>' ToolTip='<%# Eval("planEnd", "{0:tt}") %>' Enabled="false" />
                                                            </asp:TableCell>
                                                        </asp:TableRow>
                                                    </asp:Table>
                                                </asp:TableCell>
                                                <asp:TableCell CssClass="w3-col s12 m12 l6">
                                                    <asp:Table runat="server" CellPadding="4">
                                                        <asp:TableRow>
                                                            <asp:TableCell RowSpan="3" Width="10"></asp:TableCell>
                                                            <asp:TableCell ColumnSpan="2" Height="5"></asp:TableCell>
                                                            <asp:TableCell RowSpan="3" Width="10"></asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell Width="110" Style="min-width:110px;font-weight:bold;color:#999999">Status</asp:TableCell>
                                                            <asp:TableCell Style="padding-top:8px">
                                                                <asp:CheckBoxList ID="mosExtension" runat="server" CssClass="w3-text-grey" TextAlign="Right" RepeatDirection="Horizontal" RepeatLayout="Table" Width="230" Enabled="false">
                                                                    <asp:ListItem Text="Extension 1" Value="1" />
                                                                    <asp:ListItem Text="Extension 2" Value="2" />
                                                                </asp:CheckBoxList>                                                                
                                                            </asp:TableCell>
                                                        </asp:TableRow>
                                                        <asp:TableRow>
                                                            <asp:TableCell>
                                                                <asp:Label runat="server" Width="100%" CssClass="logSumLabel" Style="font-size:11px;padding-left:2px;padding-bottom:3px" Text="Initial" />
                                                                <asp:Label runat="server" Width="100%" CssClass="logSumLabel" Style="font-size:11px;padding-left:2px" Text="Previous" />                                                           
                                                            </asp:TableCell>
                                                            <asp:TableCell>
                                                                <asp:Label runat="server" Width="100%" CssClass="logSumLabel" Style="font-size:11px;padding-bottom:3px" Text='<%# (Convert.ToInt32(Eval("extCount")) > 0) ? (String.IsNullOrEmpty(Eval("initStart").ToString().Trim()) ? "..." : (Eval("initStart","{0:dd-MMM-yyyy hh:mm tt}").ToString().Trim() + " to " + Eval("initEnd","{0:dd-MMM-yyyy hh:mm tt}").ToString().Trim())) : "..."  %>' />
                                                                <asp:Label runat="server" Width="100%" CssClass="logSumLabel" Style="font-size:11px" Text='<%# (Convert.ToInt32(Eval("extCount")) > 1) ? (String.IsNullOrEmpty(Eval("prevStart").ToString().Trim()) ? "..." : (Eval("prevStart","{0:dd-MMM-yyyy hh:mm tt}").ToString().Trim() + " to " + Eval("prevEnd","{0:dd-MMM-yyyy hh:mm tt}").ToString().Trim())) : "..."  %>' />                                                                
                                                            </asp:TableCell>
                                                        </asp:TableRow>
                                                    </asp:Table>
                                                </asp:TableCell>
                                            </asp:TableRow>                                            
                                        </asp:Table>
                                    </asp:Panel>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow CssClass="w3-row">
                                <asp:TableCell CssClass="w3-col s12 m12 l12">
                                    <asp:Panel runat="server" CssClass="subItemPanel" Style="padding:15px 15px 10px 15px;border-radius:0px;">
                                        <asp:Table runat="server" CellPadding="4" Enabled="false">
                                            <asp:TableRow CssClass="w3-row">
                                                <asp:TableCell CssClass="w3-col s12 m6 l3"><asp:CheckBox runat="server" Checked='<%# Eval("allTagIdentify") %>' CssClass="w3-text-grey" TextAlign="Right" Text="All Isolation Tagged and Identified" /></asp:TableCell>
                                                <asp:TableCell CssClass="w3-col s12 m6 l3"><asp:CheckBox runat="server" Checked='<%# Eval("allKeyNotify") %>' CssClass="w3-text-grey" TextAlign="Right" Text="All Key Personnel Informed" /></asp:TableCell>
                                                <asp:TableCell CssClass="w3-col s12 m6 l3"><asp:CheckBox runat="server" Checked='<%# Eval("isolateCertDisplay") %>' CssClass="w3-text-grey" TextAlign="Right" Text="E-SSIC Attached with PTW" /></asp:TableCell>
                                                <asp:TableCell CssClass="w3-col s12 m6 l3"><asp:CheckBox runat="server" Checked='<%# Eval("logBookEntry") %>' CssClass="w3-text-grey" TextAlign="Right" Text="Activated E-SSIC Documented in CCR" /></asp:TableCell>
                                            </asp:TableRow>
                                        </asp:Table>
                                    </asp:Panel>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                        <asp:UpdatePanel ID="optionUP" runat="server"><ContentTemplate>
                            <div class="tagTitleRoot"></div>
                            <asp:Table runat="server" style="margin:15px 0px 10px 0px">
                                <asp:TableRow>
                                    <asp:TableCell VerticalAlign="Top" Width="1%" Wrap="false" style="padding-right:20px">
                                        <asp:Button runat="server" OnClientClick="$find('MainContent_historyMPE').show();return false;" CssClass="altButton" Text="Change Log" Enabled="true" Visible="true" Style="margin:0px 5px" />
                                    </asp:TableCell>
                                    <asp:TableCell VerticalAlign="Top" Style="max-width:300px">
                                        <asp:CheckBox ID="readConfirm2Chk" runat="server" OnClick="setConfirmBtn(this.checked,'ACKNOWLEDGE');" CssClass="w3-text-grey" Text="Confirm all information is correct" TextAlign="right" Enabled="true" Visible="false" Style="float:left;margin:7px 0px 0px 5px" />
                                        <asp:CheckBox ID="readConfirm1Chk" runat="server" OnClick="setConfirmBtn(this.checked,'ACCEPT');" CssClass="w3-text-grey" Text="Confirm all information is correct" TextAlign="right" Enabled="true" Visible="false" Style="float:left;margin:7px 0px 0px 5px" />                              
                                    </asp:TableCell>
                                    <asp:TableCell CssClass="w3-hide-large" Style="min-width:40px"></asp:TableCell>
                                    <asp:TableCell VerticalAlign="Top" HorizontalAlign="Right" Style="min-width:170px">
                                        <span style="position:relative">
                                            <asp:UpdateProgress runat="server" AssociatedUpdatePanelID="optionUP" DisplayAfter="0"><ProgressTemplate><asp:Image runat="server" ImageUrl="~/App_Themes/baseObjects/processing.gif" Style="position:absolute;top:0px;left:-25px" /></ProgressTemplate></asp:UpdateProgress>                                            
                                            <asp:Button ID="readFn1Btn" runat="server" OnClientClick="setConfirmPrompt('1')" CssClass="altButton" Visible="false" Style="margin:0px 5px 10px 5px" Disabled="disabled"/>
                                            <asp:Button ID="readFn2Btn" runat="server" OnClientClick="setConfirmPrompt('2')" CssClass="altButton" Visible="false" Style="margin:0px 5px 10px 5px" Disabled="disabled"/>   
                                            <asp:Button ID="closeBtn" runat="server" OnClientClick="closeWindow();return false;" CssClass="altButton" Text="Close" Style="margin:0px 5px 10px 5px" />
                                        </span>                                        
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                            
                        </ContentTemplate></asp:UpdatePanel>
                    </ItemTemplate>
                </asp:FormView>

                <ajax:ModalPopupExtender ID="historyMPE" runat="server" BackgroundCssClass="modalBackground" TargetControlID="historyBtnMPE" PopupControlID="historyPanel"/>
                <asp:Button ID="historyBtnMPE" runat="server" style="display:none" />
                <asp:Panel ID="historyPanel" runat="server" Style="min-height:100vh;min-width:100vw" >
                    <asp:Panel runat="server" CssClass="logSumRoot">
                        <asp:Table runat="server" CellSpacing="0" CellPadding="0">
                            <asp:TableRow>
                                <asp:TableCell CssClass="logSumTitle">
                                    <asp:Label runat="server" CssClass="ratingTitle" Style="font-size:18px;position:absolute;top:0px;left:0px" Text="Change Log"/>
                                    <asp:Label runat="server" CssClass="closeWindow" style="font-size:32px;position:absolute;top:-8px;right:-5px" Text="&times;" onclick="$find('MainContent_historyMPE').hide();" />
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:Panel runat="server" ScrollBars="auto">
                                        <asp:GridView id="historyGV" runat="server" width="100%" CellPadding="0" CellSpacing="0" AutoGenerateColumns="false" ShowHeader="true" EnableViewState="true" DataSourceID="historyDS" DataKeyNames="chgId" Enabled="false">
                                            <RowStyle CssClass="logSumRow" />
                                            <EmptyDataTemplate>
                                                <asp:Table runat="server">
                                                    <asp:TableRow Style="height:50px;color:#666666;background-color:#FCFCFC;">
                                                        <asp:TableCell style="padding-left:15px"><asp:Label runat="server" Text="No changes has been made"/></asp:TableCell>
                                                    </asp:TableRow>
                                                </asp:Table>
                                            </EmptyDataTemplate>
                                            <Columns>
                                                <asp:templatefield ItemStyle-Wrap="true" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="false">
                                                    <HeaderTemplate>
                                                        <asp:Table runat="server" CellSpacing="0" CellPadding="0">
                                                            <asp:TableRow>                                                                        
                                                                <asp:TableCell CssClass="logSumHeader" Style="min-width:100px">Field</asp:TableCell>                                                                        
                                                                <asp:TableCell CssClass="logSumHeader" Width="22%">OT</asp:TableCell>
                                                                <asp:TableCell CssClass="logSumHeader" Width="22%">SOTI</asp:TableCell>
                                                                <asp:TableCell CssClass="logSumHeader" Width="22%">OIM</asp:TableCell>
                                                                <asp:TableCell CssClass="logSumHeader" Width="22%">PS</asp:TableCell>                                                                        
                                                            </asp:TableRow>
                                                        </asp:Table>
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Table runat="server" CellSpacing="0" CellPadding="0">
                                                            <asp:TableRow>
                                                                <asp:TableCell CssClass="logSumItemRow" VerticalAlign="Top">
                                                                    <asp:DropDownList runat="server" CssClass="labelDropDown" SelectedValue='<%# Eval("field") %>' Enabled="false">
                                                                        <asp:ListItem Text="" Value="" disabled Selected />
                                                                        <asp:ListItem Text="Long-Term Override" Value="longTerm"/>
                                                                        <asp:ListItem Text="Management of Change" Value="mocId"/>
                                                                        <asp:ListItem Text="Permit to Work" Value="ptwId"/>
                                                                        <asp:ListItem Text="Hub" Value="hub"/>
                                                                        <asp:ListItem Text="Field" Value="field"/>
                                                                        <asp:ListItem Text="Process System" Value="processSystem"/>
                                                                        <asp:ListItem Text="Control System" Value="controlSystem"/>
                                                                        <asp:ListItem Text="Isolation Function" Value="isolateFunction"/>
                                                                        <asp:ListItem Text="Isolation Method" Value="isolateMethod"/>
                                                                        <asp:ListItem Text="Isolation Purpose" Value="isolatePurpose"/>
                                                                        <asp:ListItem Text="Isolation Effect" Value="isolateEffect"/>
                                                                        <asp:ListItem Text="Active Safety System" Value="altSafetySystem"/>
                                                                        <asp:ListItem Text="Risk Remarks" Value="riskRemarks"/>
                                                                        <asp:ListItem Text="Risk Rating" Value="riskRating"/>
                                                                        <asp:ListItem Text="Mitigation Method" Value="mitigateMethod"/>
                                                                    </asp:DropDownList>
                                                                </asp:TableCell>                                                                        
                                                                <asp:TableCell CssClass="logSumItemRow" Width="22%" VerticalAlign="Top">
                                                                    <div class="w3-row">
                                                                        <div class="w3-col s12 m12 l12 logSumSubItemRow"><asp:Label runat="server" CssClass='<%# String.IsNullOrEmpty(Eval("entryRole1").ToString()) ? "logSumBlank" : "logSumValue" %>' Text='<%# String.IsNullOrEmpty(Eval("entryRole1").ToString()) ? "No Changes" : Eval("entryRole1") %>' /></div>
                                                                        <div class="w3-col s12 m12 l12"><asp:Label runat="server" CssClass="logSumLabel" Text='<%# Eval("timeRole1","Time: {0:dd-MMM-yyyy hh:mm tt}") %>' /></div>
                                                                        <div class="w3-col s12 m12 l12"><asp:Label runat="server" CssClass="logSumLabel" Text='<%# Eval("uidRole1","By: {0}") %>' /></div>                                                                                
                                                                    </div>
                                                                </asp:TableCell>
                                                                <asp:TableCell CssClass="logSumItemRow" Width="22%" VerticalAlign="Top">
                                                                    <div class="w3-row">
                                                                        <div class="w3-col s12 m12 l12 logSumSubItemRow"><asp:Label runat="server" CssClass='<%# String.IsNullOrEmpty(Eval("entryRole2").ToString()) ? "logSumBlank" : "logSumValue" %>' Text='<%# String.IsNullOrEmpty(Eval("entryRole2").ToString()) ? "No Changes" : Eval("entryRole2") %>' /></div>
                                                                        <div class="w3-col s12 m12 l12"><asp:Label runat="server" CssClass="logSumLabel" Text='<%# Eval("timeRole2","Time: {0:dd-MMM-yyyy hh:mm tt}") %>' /></div>
                                                                        <div class="w3-col s12 m12 l12"><asp:Label runat="server" CssClass="logSumLabel" Text='<%# Eval("uidRole2","By: {0}") %>' /></div>                                                                                
                                                                    </div>
                                                                </asp:TableCell>
                                                                <asp:TableCell CssClass="logSumItemRow" Width="22%" VerticalAlign="Top">
                                                                    <div class="w3-row">
                                                                        <div class="w3-col s12 m12 l12 logSumSubItemRow"><asp:Label runat="server" CssClass='<%# String.IsNullOrEmpty(Eval("entryRole3").ToString()) ? "logSumBlank" : "logSumValue" %>' Text='<%# String.IsNullOrEmpty(Eval("entryRole3").ToString()) ? "No Changes" : Eval("entryRole3") %>' /></div>
                                                                        <div class="w3-col s12 m12 l12"><asp:Label runat="server" CssClass="logSumLabel" Text='<%# Eval("timeRole3","Time: {0:dd-MMM-yyyy hh:mm tt}") %>' /></div>
                                                                        <div class="w3-col s12 m12 l12"><asp:Label runat="server" CssClass="logSumLabel" Text='<%# Eval("uidRole3","By: {0}") %>' /></div>                                                                                
                                                                    </div>
                                                                </asp:TableCell>
                                                                <asp:TableCell CssClass="logSumItemRow" Width="22%" VerticalAlign="Top">
                                                                    <div class="w3-row">
                                                                        <div class="w3-col s12 m12 l12 logSumSubItemRow"><asp:Label runat="server" CssClass='<%# String.IsNullOrEmpty(Eval("entryRole4").ToString()) ? "logSumBlank" : "logSumValue" %>' Text='<%# String.IsNullOrEmpty(Eval("entryRole4").ToString()) ? "No Changes" : Eval("entryRole4") %>' /></div>
                                                                        <div class="w3-col s12 m12 l12"><asp:Label runat="server" CssClass="logSumLabel" Text='<%# Eval("timeRole4","Time: {0:dd-MMM-yyyy hh:mm tt}") %>' /></div>
                                                                        <div class="w3-col s12 m12 l12"><asp:Label runat="server" CssClass="logSumLabel" Text='<%# Eval("uidRole4","By: {0}") %>' /></div>                                                                                
                                                                    </div>
                                                                </asp:TableCell>
                                                            </asp:TableRow>
                                                        </asp:Table>
                                                    </ItemTemplate>
                                                </asp:templatefield>
                                            </Columns>
                                        </asp:GridView>
                                    </asp:Panel>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:Panel>
                </asp:Panel>

            </asp:Panel>

            <!-- ------------------------- -->
            
            <asp:HiddenField ID="reqFormId" runat="server"/>
            <asp:HiddenField ID="reqFormHub" runat="server"/>
            <asp:HiddenField ID="reqFormField" runat="server"/>

            <asp:HiddenField ID="reqTime" runat="server" />
            <asp:HiddenField ID="reqId" runat="server" />

            <asp:HiddenField ID="reqCurRole" runat="server"/>
            <asp:HiddenField ID="reqCurState" runat="server"/>            
            <asp:HiddenField ID="reqExtCount" runat="server"/>

            <asp:HiddenField ID="reqCurMode" runat="server"/>
            <asp:HiddenField ID="reqCurModeAlt" runat="server"/>

            <asp:HiddenField ID="reqNextRole" runat="server"/>
            <asp:HiddenField ID="reqNextRoleAlt" runat="server"/>
            
            <asp:HiddenField ID="fnBtnArgs1" runat="server"/>
            <asp:HiddenField ID="fnBtnArgs2" runat="server"/>
            <asp:HiddenField ID="fnBtnArgs3" runat="server" />

            <!-- ------------------------- -->
            
            <div id="confirmPrompt" class="w3-modal">
                <asp:Table runat="server" Width="370" Height="70" HorizontalAlign="Center" CssClass=" w3-card-8 w3-round-large w3-modal-content" style="background-color:#FBFAF7;min-width:350px;margin-top:calc(100vh / 2 - 135px)">                   
                    <asp:TableRow>
                        <asp:TableCell Width="65" HorizontalAlign="Center"><asp:Label runat="server" CssClass="material-icons" Text="pan_tool" Style="font-size:40px;color:#808080" /></asp:TableCell>
                        <asp:TableCell Height="30" Style="padding:0px 0px 0px 6px"><asp:Label runat="server" Text="Are you sure ?" CssClass="w3-medium w3-text-grey" Style="font-weight:bold;float:left"/></asp:TableCell>
                        <asp:TableCell Style="padding:2px 20px 0px 0px">
                            <asp:Button ID="noBtn" runat="server" CssClass="altButton" Text="No" Style="float:right;margin:2px;width:60px" OnClientClick="return clearConfirmPrompt();" />
                            <asp:Button ID="yesBtn" runat="server" OnClick="UpdateSelection" CssClass="altButton" Text="Yes" Style="float:right;margin:2px;width:60px"/> 
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>                
            </div>

        </ContentTemplate></asp:UpdatePanel>
    </div>

    <!-- 'main data source section -->
    <asp:SqlDataSource id="requestDS" runat="server" DataSourceMode="DataSet" 
        SelectCommand="SELECT a.*,b.planStart,b.planEnd,c.planStart as initStart,c.planEnd as initEnd,d.planStart as prevStart,d.planEnd as prevEnd FROM form_mos a LEFT OUTER JOIN form_mos_ext b ON b.formId=a.formId AND b.extCount=a.extCount LEFT OUTER JOIN form_mos_ext c ON c.formId=a.formId AND c.extCount=0 LEFT OUTER JOIN form_mos_ext d ON d.formId=a.formId AND d.extCount=1 WHERE a.formId=@formId" 
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
        <SelectParameters>
            <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="0" PropertyName="Value" Name="formId" ControlID="reqFormId" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource id="mosTagDS" runat="server" DataSourceMode="DataSet" 
        SelectCommand="SELECT * FROM form_mos_tag WHERE formId=@formId" 
        DeleteCommand="DELETE FROM form_mos_tag WHERE tagId=@tagId"
        ConnectionString="<%$ ConnectionStrings:dataWriteStr%>" ProviderName="<%$ ConnectionStrings:dataWriteStr.ProviderName%>">
        <SelectParameters>
            <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="0" PropertyName="Value" Name="formId" ControlID="reqFormId" />
        </SelectParameters>
        <DeleteParameters>
            <asp:Parameter Name="tagId" Type="Int32" />
        </DeleteParameters>
    </asp:SqlDataSource>
    
    <asp:SqlDataSource id="roleListDS" runat="server" DataSourceMode="DataSet" 
        SelectCommand="SELECT userRole,roleCode FROM adm_list_role ORDER BY roleCode"
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
    </asp:SqlDataSource>
    <asp:SqlDataSource id="fnListDS" runat="server" DataSourceMode="DataSet" 
        SelectCommand="SELECT fnDesc,fnCode FROM adm_list_fn ORDER BY fnCode"
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
    </asp:SqlDataSource>

    <asp:SqlDataSource id="historyDS" runat="server" DataSourceMode="DataSet" 
        SelectCommand="SELECT a.chgId,a.formId,a.field,a.uid AS uidRole1,a.timestamp AS timeRole1,value AS entryRole1,b.uidRole2,b.timeRole2,b.entryRole2,c.uidRole3,c.timeRole3,c.entryRole3,d.uidRole4,d.timeRole4,d.entryRole4 FROM form_mos_chg a LEFT OUTER JOIN (SELECT formId,field,uid AS uidRole2,timestamp AS timeRole2,value AS entryRole2 FROM form_mos_chg WHERE formId=@formId AND role=2) b ON b.formId=a.formId AND b.field=a.field LEFT OUTER JOIN (SELECT formId,field,uid AS uidRole3,timestamp AS timeRole3,value AS entryRole3 FROM form_mos_chg WHERE formId=@formId AND role=3) c ON c.formId=a.formId AND c.field=a.field LEFT OUTER JOIN (SELECT formId,field,uid AS uidRole4,timestamp AS timeRole4,value AS entryRole4 FROM form_mos_chg WHERE formId=@formId AND role=4) d ON d.formId=a.formId AND d.field=a.field WHERE a.formId=@formId AND a.role=1" 
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
        <SelectParameters>
            <asp:ControlParameter ConvertEmptyStringToNull="True" DefaultValue="0" PropertyName="Value" Name="formId" ControlID="reqFormId" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>

