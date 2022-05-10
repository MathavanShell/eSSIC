<%@ Page Title="" Language="C#" MasterPageFile="~/template/Default.Master" AutoEventWireup="true" CodeBehind="overview.aspx.cs" Inherits="eSSIC.admin.Overview" %>
<%@ MasterType VirtualPath="~/template/Default.Master" %>

<asp:Content ID="headerSection" ContentPlaceHolderID="HeaderContent" runat="server"></asp:Content>
<asp:Content ID="mainSection" ContentPlaceHolderID="MainContent" runat="server">
    <!-- 'Data configuration section -->
    <asp:UpdatePanel ID="sysStatusUP" runat="server" ChildrenAsTriggers="true" UpdateMode="Conditional">
        <ContentTemplate>
            <div class="w3-row" style="margin-top:10px">
                <div class="w3-col s12 m7 l4">
                    <asp:Table runat="server" CellPadding="3">
                        <asp:TableRow VerticalAlign="Top">
                            <asp:TableCell Width="130"></asp:TableCell>
                            <asp:TableCell CssClass="w3-text-blue-grey" Style="font-weight:bold;padding-bottom:10px;">System Status</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow VerticalAlign="Top">
                            <asp:TableCell Style="position:relative;"><asp:Label runat="server" Text="Database" Style="float:left; margin-top:12px" /></asp:TableCell>
                            <asp:TableCell CssClass="w3-text-dark-grey" Style="position:relative;">
                                <asp:Button runat="server" CssClass="material-icons syncToggleOff" Text="toggle_off" Enabled="false"/>
                                <asp:Label runat="server" Style="float:left;margin-top:12px;margin-left:10px" Text="Function Disabled" />
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow VerticalAlign="Top">
                            <asp:TableCell Style="position:relative;"><asp:Label runat="server" Text="Workflow" Style="float:left; margin-top:12px" /></asp:TableCell>
                            <asp:TableCell CssClass="w3-text-dark-grey" Style="position:relative;">
                                <asp:Button runat="server" CssClass="material-icons syncToggleOff" Text="toggle_off" Enabled="false"/>
                                <asp:Label runat="server" Style="float:left;margin-top:12px;margin-left:10px" Text="Function Disabled" />
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
                <div class="w3-col s12 m5 l8 syncStatusRoot" style="min-height:120px;">
                    <asp:Table runat="server">
                        <asp:TableRow VerticalAlign="Middle">
                            <asp:TableCell Width="60"><asp:Label runat="server" CssClass="material-icons w3-text-grey" Style="font-size:40px;float:left;margin-top:5px;opacity:0.3" Text="info_outline"/></asp:TableCell>
                            <asp:TableCell>
                                <div class="syncStatusLog" style="min-height:0px"><span class="w3-text-dark-grey"></span>Development in progress</div>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
            </div>
            <!-- 'Tab header section -->
            <asp:Table runat="server" CssClass="syncTabRoot">
                <asp:TableRow VerticalAlign="Bottom" HorizontalAlign="left">
                    <asp:TableCell>
                        <asp:Button ID="tabBtn1" runat="server" CssClass="syncTab" Text="Overview" OnClick="SwitchTab" CommandArgument="0" Visible="true" />
                        <asp:Button ID="tabBtn2" runat="server" CssClass="syncTabActive" Text="Manage Profile" OnClick="SwitchTab" CommandArgument="1" Visible="true" />
                        <asp:Button ID="tabBtn3" runat="server" CssClass="syncTab" Text="Profile Tools" OnClick="SwitchTab" CommandArgument="2" Visible="false" Enabled="false" />
                        <asp:Button ID="tabBtn4" runat="server" CssClass="syncTab" Text="Notification" OnClick="SwitchTab" CommandArgument="3" Visible="false" Enabled="false" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <!-- 'Tab content section -->
            <asp:MultiView ID="syncTab" runat="server" ActiveViewIndex="1">
                <asp:View ID="tab1" runat="server">
                    <!-- 'Placeholder -->
                </asp:View>
                <asp:View ID="tab2" runat="server">
                    <div class="w3-row">
                        <div class="w3-col s12 m12 l4">
                            <asp:UpdatePanel ID="addUserUP" runat="server" ChildrenAsTriggers="true"><ContentTemplate>
                                <asp:Table runat="server" CellPadding="3">
                                    <asp:TableRow VerticalAlign="Top">
                                        <asp:TableCell Width="130" RowSpan="12">New User</asp:TableCell>
                                        <asp:TableCell ColumnSpan="3" Style="font-size:11px;font-weight:bold;color:#999999">Search ID</asp:TableCell>
                                        <asp:TableCell Width="25" RowSpan="13" CssClass="w3-hide-small"></asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell ColumnSpan="3" Style="padding:10px 0px 20px 0px;position:relative">
                                            <asp:TextBox ID="usrAddGid" runat="server" Width="100%" CssClass="watermarkTextField syncTextAddOn" Placeholder=" e.g. MYJDSC or John.Doe"/>
                                            <asp:Button ID="usrAddFind" runat="server" OnClick="FindUser" CssClass="altButton" Text="Find" Style="position:absolute;right:0px;top:0px" />
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell ColumnSpan="3" CssClass="syncColTitle">User GID</asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell ColumnSpan="3" Style="padding:6px 0px 10px 0px">
                                            <asp:TextBox ID="usrAddUid" runat="server" Width="100%" CssClass="watermarkTextField syncTextAddOn" Placeholder="John.Doe" Enabled="false"/>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell ColumnSpan="3" CssClass="syncColTitle">Display Name</asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell ColumnSpan="3" Style="padding:6px 0px 10px 0px">
                                            <asp:TextBox ID="usrAddName" runat="server" Width="100%" CssClass="watermarkTextField syncTextAddOn" Placeholder="Doe, John OU-DEPT" Enabled="false"/>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell ColumnSpan="3" CssClass="syncColTitle">Email</asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell ColumnSpan="3" Style="padding:6px 0px 15px 0px">
                                            <asp:TextBox ID="usrAddEmail" runat="server" Width="100%" CssClass="watermarkTextField syncTextAddOn" Placeholder="John.Doe@shell.com" Enabled="false"/>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell CssClass="syncColTitle">Role</asp:TableCell>
                                        <asp:TableCell Width="90" CssClass="syncColTitle">Hub</asp:TableCell>
                                        <asp:TableCell Width="90" CssClass="syncColTitle" Style="padding-left:6px">OU</asp:TableCell>                                    
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="padding:6px 5px 10px 0px">
                                            <asp:DropDownList ID="usrAddRole" runat="server" Width="100%" DataSourceID="roleListDS" DataTextField="userFn" DataValueField="roleCode" CssClass="normalDropDown" AutoPostBack="false" EnableViewState="true" Enabled="false" Appenddatabounditems="true">
                                                <asp:ListItem Text="" Value="0" Disabled Selected/>
                                            </asp:DropDownList>
                                        </asp:TableCell>
                                        <asp:TableCell Style="padding:6px 5px 10px 0px">
                                            <asp:DropDownList ID="usrAddHub" runat="server" Width="100%" DataSourceID="hubListDS" DataTextField="hubName" DataValueField="hubCode" CssClass="normalDropDown" AutoPostBack="false" EnableViewState="true" Enabled="false" Appenddatabounditems="true">
                                                <asp:ListItem Text="" Value="0" Disabled Selected/>
                                            </asp:DropDownList>
                                        </asp:TableCell>
                                        <asp:TableCell Style="padding:6px 0px 10px 0px">
                                            <asp:DropDownList ID="usrAddOu" runat="server" Width="100%" CssClass="normalDropDown" AutoPostBack="false" EnableViewState="true" Enabled="false">
                                                <asp:ListItem Text="SMEP" Value="SMEP" Selected/>
                                            </asp:DropDownList>
                                        </asp:TableCell>                                    
                                    </asp:TableRow>                                
                                    <asp:TableRow Height="25">
                                        <asp:TableCell ColumnSpan="2" Style="padding:0px 0px 10px 6px">
                                            <asp:Label ID="usrAddMsg" runat="server" Style="font-size:11px;color:red;"/>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow HorizontalAlign="left">
                                        <asp:TableCell ColumnSpan="2" Style="position:relative;">
                                            <asp:Button ID="usrAddReset" runat="server" OnClick="ResetAddField" CssClass="altButton" Text="Reset" Style="margin-right:6px" Enabled="false" />
                                            <asp:Button ID="usrAddSave" runat="server" OnClick="InsertNew" CommandArgument="USR" OnClientClick="if(!checkEmptyField('ACC')){return false;}" CssClass="altButton" Text="Add User" Enabled="false" />
                                            <asp:UpdateProgress runat="server" AssociatedUpdatePanelID="addUserUP" DisplayAfter="0"><ProgressTemplate><asp:Image runat="server" ImageUrl="~/App_Themes/baseObjects/processing.gif" Style="position:absolute;top:9px;left:180px;"/></ProgressTemplate></asp:UpdateProgress>
                                        </asp:TableCell>
                                    </asp:TableRow>                            
                                </asp:Table>
                            </ContentTemplate></asp:UpdatePanel>
                        </div>
                        <div class="w3-col s12 m12 l8">
                            <asp:UpdatePanel ID="userListUP" runat="server" ChildrenAsTriggers="true"><ContentTemplate>
                                <div style="height:20px" class="w3-hide-large"></div>
                                <asp:Table runat="server" CssClass="subItemPanel">
                                    <asp:TableRow VerticalAlign="Top">
                                        <asp:TableCell VerticalAlign="Middle" CssClass="subItemHeader" Style="padding:0px 5px;height:50px;position:relative">
                                            <asp:Button ID="schUserBtn" runat="server" CssClass="material-icons altFunctionIcon" Style="position:absolute;left:5px" Text="search" ToolTip="Search"/>
                                            <div class="altSearchBar " style="width:calc(100% - 52px);margin-right:12px;">
                                                <asp:TextBox ID="schUser" runat="server" Width="100%" CssClass="altSearchField" AutoPostBack="true" Placeholder="Search"/>
                                            </div>
                                            <asp:LinkButton ID="rstUser" runat="server" OnClick="ResetUsrList" CssClass="material-icons closeWindow" style="font-size:24px;position:absolute;top:14px;right:14px;background-color:#FCFCFC" Text="close" ToolTip="Reset" />
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow VerticalAlign="Top">
                                        <asp:TableCell Style="padding:0px 10px 10px 10px">
                                            <asp:Panel runat="server" ScrollBars="auto" Style="min-height:390px">
                                                <asp:GridView id="mosProfileGV" runat="server" ShowHeader="false" AllowSorting="false" EnableSortingAndPagingCallbacks="true" EnableViewState="true" AutoGenerateColumns="false" DataSourceID="mosProfileDS" DataKeyNames="uid" OnRowUpdated="LogRowUpdate" 
                                                    AllowPaging="true" PagerSettings-Mode="NumericFirstLast" PageSize="10" PagerSettings-Position="Bottom" PagerSettings-PageButtonCount="5">
                                                    <RowStyle Wrap="True" CssClass="altSumRow" />
                                                    <AlternatingRowStyle CssClass="altSumRowAlt" />
                                                    <EmptyDataTemplate>
                                                        <asp:Table runat="server">
                                                            <asp:TableRow>
                                                                <asp:TableCell Style="padding:20px 40px"><asp:Label runat="server" CssClass="w3-text-grey" Text="No user found or matches search criteria" /></asp:TableCell>
                                                            </asp:TableRow>
                                                        </asp:Table>                            
                                                    </EmptyDataTemplate>
                                                    <PagerTemplate>
                                                        <asp:Table runat="server">
                                                            <asp:TableRow Height="37">
                                                                <asp:TableCell HorizontalAlign="Left" VerticalAlign="Bottom" Style="padding-bottom:3px">
                                                                    <asp:LinkButton ID="prevPg" runat="server" CssClass="fa fa-arrow-left w3-hover-text-red" Style="color:#999999;font-size:20px;text-decoration:none;margin-left:2px" ToolTip="Previous Page" CommandName="Page" CommandArgument="Prev"/>
                                                                    <asp:LinkButton ID="nextPg" runat="server" CssClass="fa fa-arrow-right w3-hover-text-red" Style="color:#999999;font-size:20px;text-decoration:none;margin-left:10px;" ToolTip="Next Page" CommandName="Page" CommandArgument="Next"/>
                                                                </asp:TableCell>
                                                                <asp:TableCell HorizontalAlign="Right" VerticalAlign="Bottom">
                                                                    <asp:Label runat="server" Text="Showing" CssClass="w3-text-grey" Style="margin:0px 10px;" />
                                                                    <asp:DropDownList ID="pageSizeSelect" runat="server" selectedvalue='<%# mosProfileGV.PageSize %>' OnSelectedIndexChanged="SetPagerSize" AutoPostBack="true" EnableViewState="true" CssClass="normalDropDown" Enabled="true"> 
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
                                                        <asp:TemplateField ItemStyle-Width="1%" ItemStyle-Wrap="false" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle" ConvertEmptyStringToNull="false" HeaderImageUrl="../App_Themes/baseObjects/btnImg_filler.png">
                                                            <HeaderStyle CssClass="altSumItmHeader" />
                                                            <ItemStyle CssClass="altSumItmRow" />
                                                            <ItemTemplate>
                                                                <asp:CheckBox runat="server" AutoPostBack="false" Enabled="false" Checked='<%# Eval("status") %>' ToolTip="Account Status" /> 
                                                            </ItemTemplate>
                                                            <EditItemTemplate>
                                                                <asp:CheckBox ID="actStatus" runat="server" AutoPostBack="false" Enabled="true" Checked='<%# Bind("status") %>' ToolTip="Account Status" />                                                    
                                                            </EditItemTemplate>
                                                        </asp:TemplateField>

                                                        <asp:TemplateField SortExpression="fn" HeaderText="Role" ItemStyle-Width="120" ItemStyle-Wrap="false" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="false">
                                                            <HeaderStyle CssClass="altSumItmHeader" />
                                                            <ItemStyle CssClass="altSumItmRow" />
                                                            <ItemTemplate>
                                                                <asp:DropDownList runat="server" DataSourceID="roleListDS" DataTextField="userFn" DataValueField="roleCode" selectedvalue='<%# Eval("role") %>' Width="100%" CssClass="labelDropDown" Style="min-width:90px;padding-left:5px;margin-left:5px" Enabled="false" Appenddatabounditems="true">
                                                                    <asp:ListItem Text="" Value="0"/>
                                                                </asp:DropDownList>
                                                            </ItemTemplate>
                                                            <EditItemTemplate>
                                                                <asp:DropDownList ID="role" runat="server" DataSourceID="roleListDS" DataTextField="userFn" DataValueField="roleCode" selectedvalue='<%# Bind("role") %>' Width="100%" CssClass="normalDropDown syncDropAddOnAlt" Style="font-weight:bold;padding:5px 0px 5px 5px;margin-left:5px" Enabled="true" Appenddatabounditems="true">
                                                                    <asp:ListItem Text="" Value="0" Disabled Selected/>
                                                                    <asp:ListItem Text="-NA-" Value="0"/>
                                                                </asp:DropDownList>
                                                            </EditItemTemplate>
                                                        </asp:TemplateField>      
                                                        
                                                        <asp:TemplateField SortExpression="hub" HeaderText="Hub" ItemStyle-Width="65" ItemStyle-Wrap="false" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="false">
                                                            <HeaderStyle CssClass="altSumItmHeader" />
                                                            <ItemStyle CssClass="altSumItmRow" />
                                                            <ItemTemplate>
                                                                <asp:DropDownList runat="server" DataSourceID="hubListDS" DataTextField="hubName" DataValueField="hubCode" selectedvalue='<%# Eval("hub") %>' Width="100%" CssClass="labelDropDown" Style="min-width:65px;padding-left:5px" Enabled="false" Appenddatabounditems="true">
                                                                    <asp:ListItem Text="" Value=""/>
                                                                </asp:DropDownList>
                                                            </ItemTemplate>
                                                            <EditItemTemplate>
                                                                <asp:DropDownList ID="hub" runat="server" DataSourceID="hubListDS" DataTextField="hubName" DataValueField="hubCode" selectedvalue='<%# Bind("hub") %>' Width="100%" CssClass="normalDropDown syncDropAddOnAlt" Style="font-weight:bold;min-width:65px;padding:5px 0px 5px 5px" Enabled="true" Appenddatabounditems="true">
                                                                    <asp:ListItem Text="" Value="" Disabled Selected/>
                                                                    <asp:ListItem Text="-NA-" Value=""/>
                                                                </asp:DropDownList>
                                                            </EditItemTemplate>
                                                        </asp:TemplateField>

                                                        <asp:TemplateField SortExpression="name" HeaderText="Name" ItemStyle-Wrap="true" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="false">
                                                            <HeaderStyle CssClass="altSumItmHeader" />
                                                            <ItemStyle CssClass="altSumItmRow" />
                                                            <ItemTemplate>
                                                                <asp:Label Text='<%# String.IsNullOrEmpty(Eval("name").ToString()) ? "-": Eval("name") %>' style="word-break:break-all;" runat="server"/>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        
                                                        <asp:TemplateField SortExpression="email" HeaderText="Email Address" ItemStyle-Wrap="false" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="false">
                                                            <HeaderStyle CssClass="altSumItmHeader" />
                                                            <ItemStyle CssClass="altSumItmRow" />
                                                            <ItemTemplate>
                                                                <asp:Label Text='<%# String.IsNullOrEmpty(Eval("email").ToString()) ? "-": Eval("email") %>' style="word-break:break-all;" runat="server"/>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>    
                                                        
                                                        <asp:TemplateField ItemStyle-Width="1%" HeaderText="Reset Password" ItemStyle-Wrap="false" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="false">
                                                            <HeaderStyle CssClass="altSumItmHeader" />
                                                            <ItemStyle CssClass="altSumItmRow" />
                                                            <ItemTemplate>
                                                                <asp:Label runat="server" CssClass="material-icons iconBtnBlueDisabled syncIconAddOn" Text="fiber_pin" ToolTip="Reset Password"/>
                                                            </ItemTemplate>
                                                            <EditItemTemplate>
                                                                <asp:LinkButton runat="server" OnClick="ResetPin" OnClientClick=<%# "$(this).hide();$('#MainContent_mosProfileGV_resetProgress_" + Container.DataItemIndex.ToString() + "').show();" %> CommandArgument='<%# Eval("email") %>' CssClass="material-icons iconBtnBlue syncIconAddOn" Text="fiber_pin" ToolTip="Reset Password" />
                                                                <asp:Image ID="resetProgress" runat="server" ImageUrl="~/App_Themes/baseObjects/processing.gif" Style="padding:0px 0px 2px 4px;display:none"/>
                                                            </EditItemTemplate>
                                                        </asp:TemplateField>

                                                        <asp:templatefield ItemStyle-Width="1%" ConvertEmptyStringToNull="false" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" HeaderImageUrl="../App_Themes/baseObjects/btnImg_filler.png">
                                                            <HeaderStyle CssClass="summaryBtnHeader"/>
                                                            <ItemStyle CssClass="altSumItmRow"/>
                                                            <ItemTemplate>
                                                                <asp:LinkButton ID="edit" runat="server" CommandName="Edit" CssClass="material-icons iconBtnBlue syncIconAddOn" Text="more_horiz" ToolTip="Edit" />
                                                            </ItemTemplate>
                                                            <EditItemTemplate>
                                                                <asp:LinkButton ID="save" runat="server" CommandName="Update" CssClass="material-icons iconBtnBlue syncIconAddOn" Text="exit_to_app" ToolTip="Save" />
                                                            </EditItemTemplate>
                                                        </asp:templatefield>
                                                    </Columns>
                                                </asp:GridView>
                                            </asp:Panel>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                            </ContentTemplate></asp:UpdatePanel>
                        </div>
                    </div>
                </asp:View>
                <asp:View ID="tab3" runat="server">
                    <!-- 'Placeholder -->
                    <div class="w3-row">
                        <div class="w3-col s12 m12 l4">
                            <asp:UpdatePanel ID="hasherUP" runat="server" ChildrenAsTriggers="true"><ContentTemplate>
                                <asp:HiddenField ID="ud" runat="server" />
                                <asp:Table runat="server" CellPadding="3">
                                    <asp:TableRow VerticalAlign="Top">
                                        <asp:TableCell Width="130" RowSpan="8">Hasher</asp:TableCell>
                                        <asp:TableCell Style="font-size:11px;font-weight:bold;color:#999999">Password</asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell ColumnSpan="2" Style="padding:10px 0px 20px 0px;position:relative">
                                            <asp:TextBox ID="passField" runat="server" Width="100%" CssClass="watermarkTextField syncTextAddOn" Placeholder=" Enter Value Here" />
                                            <asp:UpdateProgress runat="server" AssociatedUpdatePanelID="hasherUP" DisplayAfter="0"><ProgressTemplate><asp:Image runat="server" ImageUrl="~/App_Themes/baseObjects/processing.gif" Style="position:absolute;top:10px;right:5px;"/></ProgressTemplate></asp:UpdateProgress>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell ColumnSpan="2" CssClass="syncColTitle">Hash</asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell ColumnSpan="2" Style="padding:6px 0px 10px 0px">
                                            <asp:TextBox ID="hashField" runat="server" Width="100%" CssClass="watermarkTextField syncDropAddOnAlt" Style="padding-left:5px;" Placeholder="" TextMode="MultiLine" Rows="2" Wrap="true" ReadOnly="true"/>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell ColumnSpan="2" CssClass="syncColTitle">Salt</asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell ColumnSpan="2" Style="padding:6px 0px 10px 0px">
                                            <asp:TextBox ID="saltField" runat="server" Width="100%" CssClass="watermarkTextField syncDropAddOnAlt" Style="padding-left:5px;" Placeholder="" ReadOnly="true"/>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow Height="25">
                                        <asp:TableCell ColumnSpan="2" Style="padding:0px 0px 10px 6px">
                                            <asp:Label ID="hashStatus" runat="server" Style="font-size:11px;color:red;"/>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell ColumnSpan="2">
                                            <asp:Button ID="hashRs" runat="server" OnClick="ResetHashField" CssClass="altButton" Text="Reset" Enabled="false" Style="margin-right:6px;" />
                                            <asp:Button ID="hashFn" runat="server" OnClick="HashField" OnClientClick="encryptField(1,true,'MainContent_mk','MainContent_en','MainContent_passField','MainContent_cp');" CssClass="altButton" Text="Create Hash" Enabled="false" Style="margin-right:6px;"/>
                                            <asp:Button ID="hashFx" runat="server" OnClick="FixPasscode" CssClass="altButton" Text="Harmonize DB" Enabled="false" Style="float:right" />
                                        </asp:TableCell>
                                    </asp:TableRow> 
                                </asp:Table>
                                <asp:HiddenField ID="mk" runat="server" /><asp:HiddenField ID="en" runat="server" /><asp:HiddenField ID="cp" runat="server" />
                            </ContentTemplate></asp:UpdatePanel>
                        </div>
                    </div>
                </asp:View>
                <asp:View ID="tab4" runat="server">
                    <!-- 'Placeholder -->
                </asp:View>
                <!-- 'template -->
                <asp:View ID="tabx" runat="server">
                    <div class="w3-row">
                        <div class="w3-col s12 m7 l5">
                            <asp:Table runat="server" CellPadding="3" Style="padding-right:20px">
                                <asp:TableRow VerticalAlign="Top">
                                    <asp:TableCell Width="130">Title</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:Table runat="server">
                                            <asp:TableRow CssClass="syncColTitle">
                                                <asp:TableCell>ColumnHeader</asp:TableCell>
                                            </asp:TableRow>
                                        </asp:Table>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow><asp:TableCell></asp:TableCell></asp:TableRow>
                            </asp:Table>
                        </div>
                        <div class="w3-col s12 m5 l7 syncStatusRoot"></div>
                    </div>
                </asp:View>
            </asp:MultiView>

        </ContentTemplate>
    </asp:UpdatePanel>

    <!-- 'main data source section -->
    <asp:SqlDataSource id="roleListDS" runat="server" DataSourceMode="DataSet" 
        SelectCommand="SELECT * FROM adm_list_role WHERE roleCode NOT IN (0) ORDER BY roleCode"
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
    </asp:SqlDataSource>
    <asp:SqlDataSource id="hubListDS" runat="server" DataSourceMode="DataSet" 
        SelectCommand="SELECT * FROM adm_list_hub ORDER BY hubCode"
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
    </asp:SqlDataSource>
    <asp:SqlDataSource id="mosProfileDS" runat="server" DataSourceMode="DataSet" 
        SelectCommand="SELECT a.* FROM (SELECT *,(SELECT userFn FROM adm_list_role WHERE roleCode=role) As fn,(SELECT userRole FROM adm_list_role WHERE roleCode=role) As title FROM adm_sys_user WHERE role NOT IN (0) ORDER BY role,name OFFSET 0 ROWS) a UNION SELECT b.* FROM (SELECT *,(SELECT userFn FROM adm_list_role WHERE roleCode=role) As fn,(SELECT userRole FROM adm_list_role WHERE roleCode=role) As title FROM adm_sys_user WHERE role IN (0) ORDER BY name OFFSET 0 ROWS) b" 
        FilterExpression="ISNULL(uid,'') LIKE '%{0}%' OR ISNULL(name,'') LIKE '%{0}%' OR ISNULL(email,'') LIKE '%{0}%' OR ISNULL(fn,'') LIKE '%{0}%' OR ISNULL(hub,'') LIKE '%{0}%' OR ISNULL(title,'') LIKE '%{0}%'" 
        UpdateCommand="UPDATE adm_sys_user SET role=@role,hub=@hub,status=@status WHERE uid=@uid"
        ConnectionString="<%$ ConnectionStrings:dataWriteStr%>" ProviderName="<%$ ConnectionStrings:dataWriteStr.ProviderName%>">
        <FilterParameters>
            <asp:ControlParameter ConvertEmptyStringToNull="true" DefaultValue="%" PropertyName="Text" ControlID="schUser" />
        </FilterParameters>
        <UpdateParameters>
            <asp:Parameter Name="uid" Type="String"/>
            <asp:Parameter Name="role" Type="String"/>
            <asp:Parameter Name="hub" Type="String"/>
            <asp:Parameter Name="Status" Type="String"/>                    
        </UpdateParameters>
    </asp:SqlDataSource>

</asp:Content>
