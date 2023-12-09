<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="create.aspx.cs" Inherits="ASP.NETWebServiceUsingJQuery.create" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Employee</title>
    <script src="https://code.jquery.com/jquery-3.6.4.min.js"></script>


    <%--    <link href="content/bootstrap.rtl.min.css" rel="stylesheet" />
    <script src="scripts/bootstrap.bundle.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>--%>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.rtl.min.css" integrity="sha384-nU14brUcp6StFntEOOEBvcJm4huWjB0OcIeQ3fltAfSmuZFrkAif0T+UtNGlKKQv" crossorigin="anonymous">

    <script src="Scripts/index/index.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="row">
                <div class="col-sm">
                </div>
                <div class="col-sm">

                    <div class="form-group">
                        <label for="exampleInputEmail1">نام :</label>
                        <input type="FirstName" class="form-control" id="FirstName" aria-describedby="emailHelp" placeholder="نام">
                    </div>
                    <div class="form-group">
                        <label for="exampleInputEmail1">نام خانوادگی :</label>
                        <input type="LastName" class="form-control" id="LastName" aria-describedby="emailHelp" placeholder="نام خانوادگی">
                    </div>
                    <div class="form-group">
                        <label for="exampleInputEmail1">ادرس ایمیل</label>
                        <input type="Email" class="form-control" id="Email" aria-describedby="emailHelp" placeholder="ادرس ایمیل">
                    </div>
                    <div class="form-group">
                        <label for="exampleInputEmail1">ادرس:</label>
                        <textarea type="text" class="form-control" id="Address" aria-describedby="emailHelp" placeholder="ادرس"></textarea>
                    </div>
                    <button class="btn btn-success" id="submitBtn" type="submit">ارسال</button>

                </div>
                <div class="col-sm">
                </div>
            </div>


        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>

</body>
</html>
