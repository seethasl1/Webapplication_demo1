<%@ Page Title="" Language="C#" MasterPageFile="~/Mainmaster.Master" AutoEventWireup="true" CodeBehind="Regipage.aspx.cs" Inherits="Project1_webapp.Regipage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
     <div class="container">
    <div class="row align-items-left vh-100">
        <div class="col-5 mx-auto">
            <div class="card shadow border">
                <div class="card-body d-flex flex-column align-items-left">
                    <div>
                        <h5 class="card-title">Login</h5>
                    </div>
      <table>
          <tr>
              <td>            
 
    <label for="exampleInputEmail1">Email</label> </td>
        
              
      <td> <asp:TextBox ID="TxtUname" runat="server"></asp:TextBox></td>
   
 
                </tr>

   <tr>
       <td><label>Password</label></td>
    
     <td> <asp:TextBox TextMode="Password" ID="TxtPwd" runat="server" ></asp:TextBox></td> 

   </tr>
    

 <tr>
<td>
<label >Confirm Password</label>
</td> 
   <td>
<asp:TextBox TextMode="Password" ID="Txtcpwd" runat="server"></asp:TextBox>
   </td>
 </tr>
   
  <tr>
      <td>
            <label>City</label>
      </td>
      <td>
           
            <asp:DropDownList ID="TxtCity" runat="server"></asp:DropDownList>
      </td>
  </tr>
        
  
    
     
   
  <tr>
        <td>
<label >Gender</label>
        </td>
      <td>
           
          <asp:RadioButton ID="TxtGender1" runat="server" Text="Male" GroupName="Gender"  />
         <td>
<asp:RadioButton ID="TxtGender2" runat="server" Text="Female" GroupName="Gender"  />
         </td>
           
      </td>
  </tr>
 <tr>
     <td>
         <asp:Button ID="Button1" runat="server" OnClick="Submit_click" Text="Button" />
     </td>
     
 </tr>
 <tr>
     <td>
         &nbsp;</td>
     
 </tr>
 <tr>
     <td>
         &nbsp;</td>
     
 </tr>
      </table>               
    
 
        <br />
          
        </div>
    
   <div>

       <asp:GridView ID="GridView1" runat="server">
       </asp:GridView>

   </div>
</asp:Content>
