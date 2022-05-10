<%@ Page Title="" Language="C#" MasterPageFile="~/template/Default.Master" AutoEventWireup="true" CodeBehind="reset.aspx.cs" Inherits="eSSIC.MOS.Reset" %>
<%@ MasterType VirtualPath="~/template/Default.Master" %>

<asp:Content ID="headerSection" ContentPlaceHolderID="HeaderContent" runat="server"></asp:Content>
<asp:Content ID="mainSection" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="resetPanelUP" runat="server"><ContentTemplate>
        <asp:HiddenField ID="ud" runat="server" />
        <div align="center">
            <div class="w3-hide-medium w3-hide-large" style="height:20px"></div>
            <div class="w3-hide-small" style="height:calc(10vh)"></div>
            <asp:Panel ID="signInPanel" runat="server" CssClass="w3-container reportContent" Style="width:100%;min-width:360px;max-width:1000px;" Enabled="true">
                <div class="w3-row">
                    <div class="w3-col s12 m6 l5">
                        <asp:Table runat="server" CellPadding="3" CssClass="subItemPanel">
                            <asp:TableRow>
                                <asp:TableCell ColumnSpan="3" Height="46" CssClass="subItemHeader" Style="position:relative;padding:11px 0px 13px 15px">                                        
                                    <asp:Image runat="server" ImageUrl="~/App_Themes/baseObjects/icon_passwordTitle.png" Height="16"/>
                                    <asp:Image runat="server" ImageUrl="~/App_Themes/baseObjects/Shell_logo_r1.png" style="height:32px;position:absolute;right:10px;top:8px"/>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow Height="15"><asp:TableCell></asp:TableCell></asp:TableRow>
                            <asp:TableRow CssClass="syncColTitle">
                                <asp:TableCell RowSpan="11" Width="15"></asp:TableCell>
                                <asp:TableCell><asp:Label runat="server" style="font-size:12px;font-weight:bold;color:#999999" Text="Current"/></asp:TableCell>
                                <asp:TableCell RowSpan="11" Width="15"></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell><asp:TextBox ID="old" runat="server" Width="100%" CssClass="watermarkTextField syncTextAddOn" Style="font-size:14px" TextMode="Password" Placeholder="*****"/></asp:TableCell>                            
                            </asp:TableRow>
                            <asp:TableRow Height="15"><asp:TableCell></asp:TableCell></asp:TableRow>                        
                            <asp:TableRow CssClass="syncColTitle">
                                <asp:TableCell><asp:Label runat="server" style="font-size:12px;font-weight:bold;color:#999999" Text="New"/></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell><asp:TextBox ID="new1" runat="server" Width="100%" CssClass="watermarkTextField syncTextAddOn" Style="font-size:14px" TextMode="Password" Placeholder="*****"/></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow Height="15"><asp:TableCell></asp:TableCell></asp:TableRow>
                            <asp:TableRow CssClass="syncColTitle">
                                <asp:TableCell><asp:Label runat="server" style="font-size:12px;font-weight:bold;color:#999999" Text="Repeat New"/></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell><asp:TextBox ID="new2" runat="server" Width="100%" CssClass="watermarkTextField syncTextAddOn" Style="font-size:14px" TextMode="Password" Placeholder="*****"/></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow Height="30" VerticalAlign="Middle">
                                <asp:TableCell>
                                    <asp:Label ID="resetMsg" runat="server" CssClass="msgRed"/>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow HorizontalAlign="Left">
                                <asp:TableCell Style="padding:10px 0px 15px 0px;position:relative">
                                    <asp:Button ID="pwReset" runat="server" OnClick="ChangePass" CssClass="altButton" Text="Proceed Change" OnClientClick="if(!checkEmptyField('RESET')){return false;}else{encryptField(2,false,'MainContent_mk','MainContent_en','MainContent_old'+'|'+'MainContent_new1'+'|'+'MainContent_new2','MainContent_cp');}" />
                                    <input type="reset" name="Reset" class="altButton" Style="float:left;margin:0px 5px 0px 3px" onclick="$('#MainContent_resetMsg').empty();" />
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                        <ajax:FilteredTextBoxExtender ID="newFT" runat="server" TargetControlID="new1" FilterType="Custom,Numbers,LowercaseLetters,UppercaseLetters" ValidChars="!#$%&()*+-./=?@[\]^_{}~" Enabled="true"/>
                        <ajax:FilteredTextBoxExtender ID="repeatFT" runat="server" TargetControlID="new2" FilterType="Custom,Numbers,LowercaseLetters,UppercaseLetters" ValidChars="!#$%&()*+-./=?@[\]^_{}~" Enabled="true"/>
                        <asp:HiddenField ID="mk" runat="server" /><asp:HiddenField ID="en" runat="server" /><asp:HiddenField ID="cp" runat="server" />
                    </div>
                    <div class="w3-col s12 m6 l7">
                        <asp:Table runat="server">
                            <asp:TableRow Height="20" CssClass="w3-hide-medium w3-hide-large"><asp:TableCell ColumnSpan="2"></asp:TableCell></asp:TableRow>
                            <asp:TableRow VerticalAlign="Top">
                                <asp:TableCell RowSpan="2" CssClass="w3-hide-small" Width="25"></asp:TableCell>
                                <asp:TableCell Height="30" CssClass="syncColTitle"><asp:Label runat="server" Text="REQUIREMENT" /></asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell VerticalAlign="Top" CssClass="syncStatusRoot" Style="max-width:300px">
                                    <asp:Table runat="server" CellPadding="4" Style="font-size:12px;color:#666666">
                                        <asp:TableRow>
                                            <asp:TableCell>
                                                <asp:Label runat="server" Width="100%" Text="1.&nbsp A minimum length of <Strong>8</Strong> characters." />
                                            </asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow>
                                            <asp:TableCell>
                                                <asp:Label runat="server" Width="100%" Text="2.&nbsp Must contain at least <Strong>3</Strong> of the following categories:" />
                                            </asp:TableCell>
                                        </asp:TableRow>                                    
                                        <asp:TableRow>
                                            <asp:TableCell>
                                                <asp:Label runat="server" Width="100%" Style="padding-left:20px" Text="● &nbsp UPPERCASE characters" />
                                            </asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow>
                                            <asp:TableCell>
                                                <asp:Label runat="server" Width="100%" Style="padding-left:20px" Text="● &nbsp lowercase charaters" />
                                            </asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow>
                                            <asp:TableCell>
                                                <asp:Label runat="server" Width="100%" Style="padding-left:20px" Text="● &nbsp numeric digits from 0 to 9" />
                                            </asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow>
                                            <asp:TableCell>
                                                <asp:Label runat="server" Width="100%" Style="padding-left:20px" Text="● &nbsp special characters ( e.g.&nbsp %  !  #  @ )" />
                                            </asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow Height="5"><asp:TableCell></asp:TableCell></asp:TableRow>
                                    </asp:Table>                                
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>                
                </div>
            </asp:Panel>                    
        </div>   
    </ContentTemplate></asp:UpdatePanel>

</asp:Content>
