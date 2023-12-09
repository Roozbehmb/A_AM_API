    $(document).ready(function () {
        $("#submitBtn").click(function () {
            var FirstName = $("#FirstName").val();
            var LastName = $("#LastName").val();
            $.ajax({
                type: "POST",
                url: "WebService.asmx/SaveData",
                data: JSON.stringify({ FirstName: FirstName, LastName: LastName }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert("Data saved successfully!"+response.d);
                },
                error: function (error) {
                    console.log(error);
                    alert("An error occurred while saving data.");
                }
            });
        });
    });
