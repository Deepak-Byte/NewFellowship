$(document).ready(function () {
  //  Add()
});

function Add() {
    var Name = $('#aname').val();
    var Email = $('#ae').val();
    var Number = $('#an').val();
    var Age = $('#aa').val();
    var data = { Name: Name, Email: Email, Number: Number, Age: Age };


    console.log("dataaaaa", data)
    alert(Name+ Email+ Number+ Age);
    $.ajax({
        type: "post",
        url: "https://localhost:44358/api/Employee/Add",
        contentType: "application/json",
        data: JSON.stringify(data),
        dataType: "json",
        success: function (responsive) {
            console.log("Response", responsive)
            alert(responsive.message);
        },
        Error: function ()
        {
            alert("error");
        }
    });
}

function displayemp() {
    var id = $('#displaybyid').val();
    alert(id);
    $.ajax({
        type: "Get",
        url: "https://localhost:44358/api/Employee/viewId/" + id,
        success: function (data)
        {
            if (data)
            {
                var singleempdata = "<tr><td>" + (data.singleEmployeedata).id + "</td><td>" + (data.singleEmployeedata).name + "</td><td>" + (data.singleEmployeedata).email + "</td><td>" + (data.singleEmployeedata).number + "</td><td>" + (data.singleEmployeedata).age + "</td></tr>";
                $('#viewbyid').append(singleempdata);                     ////appned here is to perform adding data into table
                console.log("data: =>", (data.singleEmployeedata), singleempdata);
            }
        },
        Error: function (response)
        {
            Console.log(response + " Return data from Backend");
        }
    });
}

function DeleteId() {
    var ID = $('#delid').val();
    var data = { ID: ID };
    
    console.log("Inpute", data)
    alert(ID);
    $.ajax({
        type: "Delete",
        url: "https://localhost:44358/api/Employee/Delete/" + ID,
        contentType: "application/json",
        dataType: "json",
        success: function (responsive) {
            console.log("Response", responsive)
            alert(responsive.message);
        }
    });
}

function Updatemp() {
    var ID = $('#updid').val();
    var Name = $('#updname').val();
    var Email = $('#updemail').val();
    var Number = $('#updnumber').val();
    var Age = $('#updage').val();
    var updatedata = { ID: ID, Name: Name, Email: Email, Number: Number, Age: Age };

    console.log("dataaaaa", updatedata)
    alert(ID + Name + Email + Number + Age);
    $.ajax({
        type: "put",
        url: "https://localhost:44358/api/Employee/update",
        contentType: "application/json",
        data: JSON.stringify(updatedata),          ///converts a JavaScript object or value to a JSON string
        dataType: "json",
        success: function (responsive) {
            alert(responsive.message);
            console.log("Response", responsive)
        },
        Error: function () {
            alert("error");
            console.log()
        }
    });
}


var k = 10;
function searchemp(number) {
    console.log(number);
    $(document).ready(function () { 
        $.ajax({
            type: "get",
            url: "https://localhost:44358/api/Employee/view",
            contentsType: "application/json",
           
            success: function (data) {
                alert(number);
                if (data.list)
                {
                    if (number == 1)
                    {
                        $('#Listview').empty(); // empty the div before fetching and adding new data
                        for (v = k - 10; v < k ; v++)
                        {
                            var empdatanext = "<tr><td>" + (data.list)[v].id + "</td><td>" + (data.list)[v].name + "</td><td>" + (data.list)[v].email + "</td><td>" + (data.list)[v].number + "</td><td>" + (data.list)[v].age + "</td></tr>";
                            $('#Listview').append(empdatanext);
                        }
                        $('#pagenumber').empty();
                        $('#pagenumber').append(k);
                        k = k + 10;
                    }
                    else
                    {
                        $('#Listview').empty(); 
                        for (v = k - 20; v < k - 10; v++) 
                        {
                            var empdataprevice = "<tr><td>" + (data.list)[v].id + "</td><td>" + (data.list)[v].name + "</td><td>" + (data.list)[v].email + "</td><td>" + (data.list)[v].number + "</td><td>" + (data.list)[v].age + "</td></tr>";
                            $('#Listview').append(empdataprevice);
                        }
                        $('#pagenumber').empty();
                        $('#pagenumber').append(k-10);
                        k = k - 10;
                    }
                }
            }
        })
    })
}

 

