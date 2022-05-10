<%@ Page Title="" Language="C#" MasterPageFile="~/template/Default.Master" AutoEventWireup="true" CodeBehind="access.aspx.cs" Inherits="eSSIC.MOS.Access" %>
<%@ MasterType VirtualPath="~/template/Default.Master" %>

<asp:Content ID="headerSection" ContentPlaceHolderID="HeaderContent" runat="server"></asp:Content>
<asp:Content ID="mainSection" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
        <!-- 'Profile info section -->
        <asp:UpdatePanel ID="accessPanelUP" runat="server"><ContentTemplate>
            <asp:Panel ID="topInfo" runat="server" Height="50" Style="position:relative">               
            
            </asp:Panel>
            <asp:Panel ID="accessInfo" runat="server">
                <div class="tagTitleRoot" style="margin-top:15px;">
                    <div class="tagTitleTab">
            	        <asp:Image runat="server" ImageUrl="~/App_Themes/baseObjects/icon_profileTitle.png" Height="16"/>
                    </div>
                </div>
                <div class="w3-row">
                    <div class="w3-col s12 m12 l12">
                        <div style="height:30px;padding-top:5px;"></div>
                    </div>
                </div>
                <div class="w3-row">
                    <div class="w3-col s12 m12 l4">
                        <asp:UpdatePanel ID="addUserUP" runat="server" ChildrenAsTriggers="true"><ContentTemplate>
                            <div class="w3-row">
                                <div class="w3-col s12 m5 l12">
                                    <asp:Table runat="server" CellPadding="3" Style="padding:0px 10px">
                                        <asp:TableRow VerticalAlign="Top">
                                            <asp:TableCell ColumnSpan="3" Style="font-size:11px;font-weight:bold;color:#999999">Search ID</asp:TableCell>
                                            <asp:TableCell Width="20" RowSpan="7" CssClass="w3-hide-small w3-hide-medium"></asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow>
                                            <asp:TableCell ColumnSpan="3" Style="padding:10px 0px 10px 0px;position:relative">
                                                <asp:TextBox ID="usrAddGid" runat="server" Width="100%" CssClass="watermarkTextField syncTextAddOn" Placeholder=" e.g. MYJDSC or John.Doe"/>
                                                <asp:Button ID="usrAddFind" runat="server" OnClick="FindUser" CssClass="altButton" Text="Find" Style="position:absolute;right:0px;top:0px" />
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
                                            <asp:TableCell ColumnSpan="3" Style="padding:0px 0px 10px 6px">
                                                <asp:Label ID="usrAddMsg" runat="server" Style="font-size:11px;color:red;"/>
                                            </asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow HorizontalAlign="left">
                                            <asp:TableCell ColumnSpan="3" Style="position:relative;">
                                                <asp:Button ID="usrAddReset" runat="server" OnClick="ResetAddField" CssClass="altButton" Text="Reset" Style="margin-right:6px" Enabled="false" />
                                                <asp:Button ID="usrAddSave" runat="server" OnClick="InsertNew" CommandArgument="USR" OnClientClick="if(!checkEmptyField('ACC')){return false;}" CssClass="altButton" Text="Add User" Enabled="false" />
                                                <asp:UpdateProgress runat="server" AssociatedUpdatePanelID="addUserUP" DisplayAfter="0"><ProgressTemplate><asp:Image runat="server" ImageUrl="~/App_Themes/baseObjects/processing.gif" Style="position:absolute;top:9px;left:180px;"/></ProgressTemplate></asp:UpdateProgress>
                                            </asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow><asp:TableCell ColumnSpan="3" Height="20" CssClass="w3-hide-medium w3-large"></asp:TableCell></asp:TableRow>
                                    </asp:Table>
                                </div>
                                <div class="w3-col s12 m7 l12">
                                    <asp:Table runat="server" CellPadding="3" Style="padding:4px 10px 0px 10px">                                        
                                        <asp:TableRow>
                                            <asp:TableCell CssClass="syncColTitle">User GID</asp:TableCell>
                                            <asp:TableCell Width="20" RowSpan="6" CssClass="w3-hide-small w3-hide-medium"></asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow>
                                            <asp:TableCell Style="padding:6px 0px 10px 0px">
                                                <asp:TextBox ID="usrAddUid" runat="server" Width="100%" CssClass="watermarkTextField syncTextAddOn" Placeholder="John.Doe" Enabled="false"/>
                                            </asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow>
                                            <asp:TableCell CssClass="syncColTitle">Display Name</asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow>
                                            <asp:TableCell Style="padding:6px 0px 10px 0px">
                                                <asp:TextBox ID="usrAddName" runat="server" Width="100%" CssClass="watermarkTextField syncTextAddOn" Placeholder="Doe, John OU-DEPT" Enabled="false"/>
                                            </asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow>
                                            <asp:TableCell CssClass="syncColTitle">Email</asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow>
                                            <asp:TableCell Style="padding:6px 0px 15px 0px">
                                                <asp:TextBox ID="usrAddEmail" runat="server" Width="100%" CssClass="watermarkTextField syncTextAddOn" Placeholder="John.Doe@shell.com" Enabled="false"/>
                                            </asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </div>
                            </div>
                        </ContentTemplate></asp:UpdatePanel>
                    </div>
                    <div class="w3-col s12 m12 l8">
                        <div style="height:20px" class="w3-hide-large"></div>
                        <asp:Panel ID="accessPanel" runat="server" CssClass="altSumRootHeader" Style="cursor:default;border-radius:5px;">
                            <asp:Table runat="server" Height="40">
                                <asp:TableRow>
                                    <asp:TableCell Style="position:relative">
                                        <asp:Label runat="server" CssClass="material-icons altSumRootHeaderIcon" Text="verified_users" Style="color:#9AAFBA;left:8px"/>
                                        <asp:Label runat="server" CssClass="altSumRootHeaderLabel" Text="Domain Users" Style="color:#9AAFBA;left:60px;"/>
                                    </asp:TableCell>                            
                                </asp:TableRow>
                            </asp:Table>
                            
                                <asp:Panel ID="mosProfilePanel" runat="server" Style="padding-top:10px;min-height:320px;font-weight:normal">
                                    <asp:GridView id="mosProfileGV" runat="server" width="100%" CssClass="altSumRoot" AutoGenerateColumns="false" ShowHeader="false" DataSourceID="mosProfileDS" DataKeyNames="uid" OnRowUpdated="LogRowUpdate" 
                                        AllowSorting="false" EnableSortingAndPagingCallbacks="true" EnableViewState="true" AllowPaging="true" PagerSettings-Mode="NumericFirstLast" PageSize="10" PagerSettings-Position="Bottom" PagerSettings-PageButtonCount="5">
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
                                                <asp:TableRow Height="50">
                                                    <asp:TableCell HorizontalAlign="Left" VerticalAlign="Bottom" Style="padding-bottom:6px;padding-left:3px">
                                                        <asp:LinkButton ID="prevPg" runat="server" CssClass="fa fa-arrow-left w3-hover-text-red" Style="color:#999999;font-size:20px;text-decoration:none;margin-left:2px" ToolTip="Previous Page" CommandName="Page" CommandArgument="Prev"/>
                                                        <asp:LinkButton ID="nextPg" runat="server" CssClass="fa fa-arrow-right w3-hover-text-red" Style="color:#999999;font-size:20px;text-decoration:none;margin-left:10px;" ToolTip="Next Page" CommandName="Page" CommandArgument="Next"/>
                                                    </asp:TableCell>
                                                    <asp:TableCell HorizontalAlign="Right" VerticalAlign="Bottom">
                                                        <asp:Label runat="server" Text="Showing" CssClass="w3-text-grey" Style="margin:0px 10px;" Visible="false" Enabled="false" />
                                                        <asp:DropDownList ID="pageSizeSelect" runat="server" selectedvalue='<%# mosProfileGV.PageSize %>' OnSelectedIndexChanged="SetPagerSize" AutoPostBack="true" EnableViewState="true" CssClass="dashDropDown" Enabled="true"> 
                                                            <asp:ListItem Text="10" Value="10"/>
                                                            <asp:ListItem Text="20" Value="20"/>
                                                            <asp:ListItem Text="50" Value="50"/>                                   
                                                        </asp:DropDownList>
                                                    </asp:TableCell>
                                                </asp:TableRow>
                                            </asp:Table>
                                        </PagerTemplate>
                                        <Columns>
                                            <asp:TemplateField ItemStyle-Width="45" ItemStyle-Wrap="false" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ItemStyle-VerticalAlign="Middle" ConvertEmptyStringToNull="false" HeaderImageUrl="../App_Themes/baseObjects/btnImg_filler.png">
                                                <HeaderStyle CssClass="altSumItmHeader" />
                                                <ItemStyle CssClass="altSumItmRow" />
                                                <ItemTemplate>
                                                    <asp:Label runat="server" CssClass="material-icons syncToggleDisable" Text='<%# Convert.ToBoolean(Eval("status")) ? "check_circle" : "block" %>' ToolTip='<%# Convert.ToBoolean(Eval("status")) ? "" : "Account Disabled" %>'/>
                                                </ItemTemplate>
                                                <EditItemTemplate>
                                                    <asp:CheckBox ID="actStatus" runat="server" AutoPostBack="false" Enabled="true" Checked='<%# Bind("status") %>' Style="display:none"/>                                                    
                                                    <asp:Button ID="actToggle" runat="server" OnClientClick=<%# "toggleGridCheckbox('MainContent_mosProfileGV','actToggle','actStatus','" + Container.DataItemIndex.ToString() + "');return false;" %> CssClass='<%# Convert.ToBoolean(Eval("status")) ? "material-icons syncToggleOn" : "material-icons syncToggleOff" %>' Style="font-size:32px" Text='<%# Convert.ToBoolean(Eval("status")) ? "toggle_on" : "toggle_off" %>' ToolTip='<%# Convert.ToBoolean(Eval("status")) ? "Disable Account" : "Enable Account" %>' />                                                
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
                                            <asp:TemplateField Visible="false" SortExpression="uid" HeaderText="UID" ItemStyle-Wrap="false" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" ConvertEmptyStringToNull="false">
                                                <HeaderStyle CssClass="altSumItmHeader" />
                                                <ItemStyle CssClass="altSumItmRow" />
                                                <ItemTemplate>
                                                    <asp:Label Text='<%# String.IsNullOrEmpty(Eval("uid").ToString()) ? "-": Eval("uid") %>' style="word-break:break-all;" runat="server"/>
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

                                            <asp:templatefield ItemStyle-Width="45" ConvertEmptyStringToNull="false" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Left" HeaderImageUrl="../App_Themes/baseObjects/btnImg_filler.png">
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
                            
                        </asp:Panel>
                    </div>
                </div>

            </asp:Panel>
            
            <!-- ------------------------- -->

            <asp:HiddenField ID="userRole" runat="server"/>
                        
            <!-- ------------------------- -->

        </ContentTemplate></asp:UpdatePanel>
    </div>

    <!-- 'main data source section -->
    <asp:SqlDataSource id="roleListDS" runat="server" DataSourceMode="DataSet" 
        SelectCommand="SELECT * FROM adm_list_role WHERE roleCode IN (1,2,3,4,5) ORDER BY roleCode"
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
    </asp:SqlDataSource>
    <asp:SqlDataSource id="hubListDS" runat="server" DataSourceMode="DataSet" 
        SelectCommand="SELECT * FROM adm_list_hub ORDER BY hubCode"
        ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
    </asp:SqlDataSource>
    <asp:SqlDataSource id="mosProfileDS" runat="server" DataSourceMode="DataSet" 
        SelectCommand="SELECT a.rec,a.uid,a.ou,a.name,a.email,a.role,a.hub,a.status,b.userRole As title,b.userFn As fn FROM adm_sys_user a LEFT OUTER JOIN adm_list_role b ON b.roleCode=a.role WHERE role NOT IN (0,9) ORDER BY role,name" 
        FilterExpression="ISNULL(uid,'') LIKE '%{0}%' OR ISNULL(name,'') LIKE '%{0}%' OR ISNULL(email,'') LIKE '%{0}%' OR ISNULL(fn,'') LIKE '%{0}%' OR ISNULL(hub,'') LIKE '%{0}%' OR ISNULL(title,'') LIKE '%{0}%'" 
        UpdateCommand="UPDATE adm_sys_user SET role=@role,hub=@hub,status=@status WHERE uid=@uid"
        ConnectionString="<%$ ConnectionStrings:dataWriteStr%>" ProviderName="<%$ ConnectionStrings:dataWriteStr.ProviderName%>">
        <FilterParameters>
            <asp:ControlParameter ConvertEmptyStringToNull="true" DefaultValue="%" PropertyName="Text" ControlID="search" />
        </FilterParameters>
        <UpdateParameters>
            <asp:Parameter Name="uid" Type="String"/>
            <asp:Parameter Name="role" Type="String"/>
            <asp:Parameter Name="hub" Type="String"/>
            <asp:Parameter Name="Status" Type="String"/>                    
        </UpdateParameters>
    </asp:SqlDataSource>

</asp:Content>
