<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="eSSIC.Login" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="utf-8" http-equiv="Content-Type" content="text/html" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="shortcut icon" href="~/App_Themes/baseObjects/favicon.ico" type="image/x-icon" />
    <title></title>
    <!-- Default Scripts -->
    <link href="~/App_Themes/aFonts/fontawesome.css" rel="stylesheet" type="text/css" />
    <link href="~/App_Themes/mFonts/materialicons.css" rel="stylesheet" type="text/css" />
    <link href="~/App_Themes/Calendar/Calendar.css" rel="stylesheet" type="text/css" />
    <link href="~/App_Themes/default.css" rel="stylesheet" type="text/css" />
    <link href="~/App_Themes/w3.css" rel="stylesheet" type="text/css" />    
</head>
<body class="maxHeight">
    <asp:Table runat="server" Height="100%" CellPadding="0">
        <asp:TableRow VerticalAlign="Top">
            <asp:TableCell>
                <form id="basePrimary" runat="server">
                    <asp:Panel ID="loaderPanel" runat="server"><div id="loadProgress" class="w3-modal" style="display:block;" align="center"><div class="w3-card-8 w3-loader w3-circle w3-center" style="position:relative;top:calc(50vh - 150px);"></div></div></asp:Panel>
                    <script type="text/javascript">
                        $(window).on("load", function () { $("#loadProgress").fadeOut("fast"); });
                    </script>
                    <asp:HiddenField ID="ud" runat="server" />
                    <asp:ScriptManager ID="scMgr" runat="server" EnablePageMethods="true" >
                        <Scripts>
                            <asp:ScriptReference Path="~/Scripts/jquery-3.3.1.js" />
                            <asp:ScriptReference Path="~/Scripts/default.js" />
                        </Scripts>
                    </asp:ScriptManager>
                    <!-- Main Content Section -->
                    <div align="center">
                        <div class="w3-hide-medium w3-hide-large" style="height:20px"></div>
                        <div class="w3-hide-small" style="height:calc(25vh)"></div>
                        <asp:Panel ID="signInPanel" runat="server" CssClass="w3-container reportContent" Style="width:100%;min-width:360px;max-width:1000px;" Enabled="true">
                            <div class="w3-row">
                                <div class="w3-col s12 m6 l5">
                                    <asp:Table runat="server" CellPadding="3" CssClass="subItemPanel">
                                        <asp:TableRow>
                                            <asp:TableCell ColumnSpan="3" Height="46" CssClass="subItemHeader" Style="position:relative;padding:11px 0px 13px 15px">                                        
                                                <asp:Image runat="server" ImageUrl="~/App_Themes/baseObjects/icon_signTitle.png" Height="16"/>
                                                <asp:Image runat="server" ImageUrl="~/App_Themes/baseObjects/Shell_logo_r1.png" style="height:32px;position:absolute;right:10px;top:8px"/>
                                            </asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow Height="15"><asp:TableCell></asp:TableCell></asp:TableRow>
                                        <asp:TableRow CssClass="syncColTitle">
                                            <asp:TableCell RowSpan="8" Width="15"></asp:TableCell>
                                            <asp:TableCell><asp:Label runat="server" style="color:#808080" Text="Email"/></asp:TableCell>
                                            <asp:TableCell RowSpan="8" Width="15"></asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow>
                                            <asp:TableCell><asp:TextBox ID="uid" runat="server" Width="100%" CssClass="watermarkTextField syncTextAddOn" Style="font-size:14px" Text="" Placeholder="John.Doe@shell.com"/></asp:TableCell>                            
                                        </asp:TableRow>
                                        <asp:TableRow Height="15"><asp:TableCell></asp:TableCell></asp:TableRow>
                                        <asp:TableRow CssClass="syncColTitle">
                                            <asp:TableCell><asp:Label runat="server" style="color:#808080" Text="Password"/></asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow>
                                            <asp:TableCell><asp:TextBox ID="pw" runat="server" Width="100%" CssClass="watermarkTextField syncTextAddOn" Style="font-size:14px" TextMode="Password" Placeholder="*****"/></asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow Height="25" VerticalAlign="Bottom">
                                            <asp:TableCell>
                                                <asp:Label ID="mosMsg" runat="server" Style="font-size:11px;color:red;" />
                                            </asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow HorizontalAlign="Right">
                                            <asp:TableCell Style="padding:0px 0px 15px 0px;position:relative">
                                                <asp:CheckBox ID="mosPersist" runat="server" AutoPostBack="false" Text="Keep me signed in" Style="position:absolute;left:3px;bottom:15px;" />
                                                <asp:Button ID="mosSSO" runat="server" CssClass="tagFnBtn" Text="SSO" CommandArgument="SSO" OnClick="SignIn" Style="font-size:13px" Visible="false" />
                                                <asp:Button ID="mosLogin" runat="server" CssClass="tagFnBtn" Text="Continue" CommandArgument="MOS" OnClick="SignIn" OnClientClick="if(!checkEmptyField('LOGIN')){return false;}else{encryptField(1,false,'mk','en','pw','cp');}" Style="font-size:13px" />
                                                <asp:Button ID="mosReset" runat="server" CssClass="tagFnBtn" Text="Reset" CommandArgument="MOS" OnClientClick="return false;" Style="margin-right:6px;font-size:13px" Visible="false" />
                                            </asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                    <asp:HiddenField ID="mk" runat="server" />
                                    <ajax:FilteredTextBoxExtender ID="uidFT" runat="server" TargetControlID="uid" FilterType="Custom,Numbers,LowercaseLetters,UppercaseLetters" ValidChars=".@_&'*-" Enabled="false"/>
                                </div>
                                <div class="w3-col s12 m6 l7">
                                    <asp:Table runat="server">
                                        <asp:TableRow Height="20" CssClass="w3-hide-medium w3-hide-large"><asp:TableCell ColumnSpan="2"></asp:TableCell></asp:TableRow>
                                        <asp:TableRow VerticalAlign="Top">
                                            <asp:TableCell RowSpan="3" CssClass="w3-hide-small" Width="25"></asp:TableCell>
                                            <asp:TableCell Height="30" CssClass="syncColTitle"><asp:Label runat="server" Text="DISCLAIMER" /></asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow>
                                            <asp:TableCell>
                                                <asp:Label runat="server" CssClass="syncStatusRoot" Width="100%" Height="190" Style="font-size:12px;color:#666666" Text="Additional Information Here" />
                                            </asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow>
                                            <asp:TableCell>
                                                <asp:HyperLink ID="accessBtn" runat="server" Enabled="false" Visible="false" CssClass="mainUserSignIn" Style="float:left;color:#757575;" Text="Request for Access" OnClientClick="$find('accessMPE').show();return false;" />                                
                                            </asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </div>                
                            </div>
                        </asp:Panel>        
                        <asp:HiddenField ID="en" runat="server" />
                        <ajax:ModalPopupExtender ID="accessMPE" runat="server" Enabled="false" BackgroundCssClass="modalBackground" TargetControlID="accessBtn" PopupControlID="accessPanel"/>
                        <asp:Panel ID="accessPanel" runat="server" Enabled="false" Visible="false" CssClass="picAssignRoot" >
                            <asp:UpdatePanel ID="requestPanelUP" runat="server"><ContentTemplate>  
                                <asp:Table runat="server" CellPadding="3" CssClass="subItemPanel" Style="max-width:400px;position:absolute;top:25%;left:50%;transform:translate(-50%);">
                                    <asp:TableRow>
                                        <asp:TableCell ColumnSpan="3" Height="46" CssClass="subItemHeader" Style="position:relative;padding:11px 0px 13px 15px">                                        
                                            <asp:Image runat="server" ImageUrl="~/App_Themes/baseObjects/icon_requestTitle.png" Height="16"/>
                                            <asp:LinkButton runat="server" OnClick="ResetReqField" CssClass="closeWindow" style="font-size:24px;position:absolute;top:5px;right:12px" Text="&times;" OnClientClick="$find('accessMPE').hide();" />
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow Height="20"><asp:TableCell></asp:TableCell></asp:TableRow>
                                    <asp:TableRow CssClass="syncColTitle">
                                        <asp:TableCell RowSpan="5" Width="15"></asp:TableCell>
                                        <asp:TableCell><asp:Label runat="server" style="color:#808080" Text="Email"/></asp:TableCell>
                                        <asp:TableCell RowSpan="5" Width="15"></asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell Style="position:relative">
                                            <asp:TextBox ID="acsEmail" runat="server" Width="100%" CssClass="watermarkTextField syncTextAddOn" Style="font-size:14px" Placeholder="John.Doe@shell.com"/>
                                            <asp:Label ID="validated" runat="server" CssClass="material-icons statusIndIconCheck" Text="check" Style="position:absolute;right:5px;background-color:#FFFFFF" Visible="false" />  
                                            <asp:UpdateProgress runat="server" AssociatedUpdatePanelID="requestPanelUP" DisplayAfter="0"><ProgressTemplate><asp:Image runat="server" ImageUrl="~/App_Themes/baseObjects/processing.gif" Style="position:absolute;right:6px;top:6px"/></ProgressTemplate></asp:UpdateProgress>
                                        </asp:TableCell>                            
                                    </asp:TableRow>                            
                                    <asp:TableRow>
                                        <asp:TableCell>
                                            <asp:DropDownList ID="acsRole" runat="server" OnChange="$('#acsContinue').attr('disabled', false);" Width="100%" DataSourceID="roleListDS" DataTextField="userRole" DataValueField="userFn" CssClass="normalDropDownAlt" Style="margin-top:15px;" AutoPostBack="false" EnableViewState="true" Visible="false" Appenddatabounditems="true">
                                                <asp:ListItem Text="What is your role?" Value="" Disabled Selected/>
                                            </asp:DropDownList>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow Height="25" VerticalAlign="Bottom">
                                        <asp:TableCell>
                                            <asp:Label ID="acsMsg" runat="server" Style="font-size:11px;color:red;margin-left:3px" />
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow HorizontalAlign="Right">
                                        <asp:TableCell Style="padding:0px 0px 15px 0px;position:relative">                                            
                                            <asp:Button ID="acsValidate" runat="server" OnClick="RequestValidate" CssClass="tagFnBtn" Text="Continue" OnClientClick="if(!checkEmptyField('VALID')){return false;}" Style="font-size:13px;width:80px" Visible="true" />
                                            <asp:Button ID="acsContinue" runat="server" OnClick="RequestSubmit" CssClass="tagFnBtn" Text="Submit" OnClientClick="if(!checkEmptyField('REQ')){return false;}" Style="font-size:13px;width:80px" Visible="false" />
                                        </asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                            </ContentTemplate></asp:UpdatePanel>
                            <asp:SqlDataSource id="roleListDS" runat="server" DataSourceMode="DataSet" 
                                SelectCommand="SELECT * FROM adm_list_role WHERE roleCode NOT IN (0,9) ORDER BY roleCode"
                                ConnectionString="<%$ ConnectionStrings:dataReadStr%>" ProviderName="<%$ ConnectionStrings:dataReadStr.ProviderName%>">
                            </asp:SqlDataSource>
                        </asp:Panel>
                        <asp:HiddenField ID="cp" runat="server" />
                    </div>                    
                </form>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow VerticalAlign="Top" Height="100">
            <asp:TableCell>
                <div align="center">
                    <div align="left" class="w3-container w3-padding-8 mainContent">
                        <hr />    
                        <p class="w3-text-grey">&copy; <%: DateTime.Now.Year %>&nbsp;&nbsp;SSIC-MOS</p>                    
                    </div>
                </div>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</body>
</html>
