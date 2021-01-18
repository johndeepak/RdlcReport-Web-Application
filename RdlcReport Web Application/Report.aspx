<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="RdlcReport_Web_Application.Report" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css" rel="stylesheet">
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
           
        <div style="max-width: 1200px;">
            <div class="panel panel-default">
                <div class="panel-heading h4 text-primary text-center">
                Search
                </div>
                <div class="panel-body">




                    <div class="form-horizontal" role="form">
                        <div class="form-group">
                            <label class="col-sm-3 control-label" for="Name">Name</label>
                            <div class="col-sm-5">
                                <asp:TextBox class="form-control" ID="Name" placeholder="Name" runat="server" required="true"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-offset-5 col-sm-10">
                            <asp:Button CssClass="btn btn-success" ID="Save" OnClick="Save_Click" runat="server" Text="Submit"></asp:Button>
                        </div>


                    </div>
                    </div>
                </div>
            </div>


            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" Height="750"></rsweb:ReportViewer>

        </div>
    </form>
</body>
</html>
