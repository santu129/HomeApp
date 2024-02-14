
// $(document).ready(function () {
function SavehouseDetails() {
    debugger;

    var info = {};
    info.HouseNo = $("#houseno").val();
    info.Location = $("#location").val();
    info.HouseType = $("#housetype").val();
    info.muncipality = $("#muncipality").val();
    info.city = $("#city").val();
    info.pin = $("#pin").val();

    info.Stateid = $("#idState").val();
    info.Districtid = $("#idDistrict").val();
    info.villageid = $("#idVillage").val();

    alert($("#houseno").val());
    $.ajax({
        url: '/Home/Register',
        type: 'POST',
        dataType: 'json',
        contentType: "application/json; charset=utf-8",
        // data: JSON.stringify(info),
        data: JSON.stringify(info),
        success: function (response) {
            debugger;
            // Handle the success response
            alert("Data Saved successfully!!");
        },
        error: function (error) {
            debugger;

            alert(error)
            // Handle the error response
            // alert("Data Not Saved successfully!!");
        }
    });

}

function StateChange(dropdown) {
    // function StateChange(dropdown) {
    debugger;
    var stateId = $(dropdown).val();
    //alert(stateId);
    $.ajax({
        url: '/Home/getDistricts',
        type: 'POST',
        dataType: 'json',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(stateId),
        success: function (response) {
            debugger;
            // Populate the dropdown with the received data
            var dropdown = $('#idDistrict');
            dropdown.empty(); // Clear existing options
            dropdown.append($('<option>', {
                value: '',
                text: 'Select District'
            }));
            // Add options dynamically
            $.each(response.result, function (index, item) {
                dropdown.append($('<option>', {
                    value: item.districtID,
                    text: item.districtName
                }));
            });
        },
        error: function (error) {
            debugger;

            alert(error)
            // Handle the error response
            // alert("Data Not Saved successfully!!");
        }
    });

}


function DistrictChange(dropdown) {
    // function StateChange(dropdown) {
    debugger;
    var districtId = $(dropdown).val();
    //alert(districtId);
    $.ajax({
        url: '/Home/getVillages',
        type: 'POST',
        dataType: 'json',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(districtId),
        success: function (response) {
            debugger;
            // Populate the dropdown with the received data
            var dropdown = $('#idVillage');
            dropdown.empty(); // Clear existing options

            dropdown.append($('<option>', {
                value: '',
                text: 'Select Village'
            }));

            // Add options dynamically
            $.each(response.result, function (index, item) {
                dropdown.append($('<option>', {
                    value: item.villageID,
                    text: item.villageName
                }));
            });
        },
        error: function (error) {
            debugger;

            alert(error)
            // Handle the error response
            // alert("Data Not Saved successfully!!");
        }
    });

}
   

    // function DistrictChange(dropdown) {
    //     var selectedValue = $(dropdown).val();
    //     console.log("Selected Value: " + selectedValue);

    //     $.ajax({
    //         url: '/Home/getVillages',
    //         type: 'GET',
    //         dataType: 'json',
    //         contentType: "application/json; charset=utf-8",
    //         // data: JSON.stringify(info),
    //         data: JSON.stringify(selectedValue),
    //         success: function (response) {
    //             debugger;
    //             // Handle the success response
    //             alert("Data Saved successfully!!");
    //         },
    //         error: function (error) {
    //             debugger;

    //             alert(error)
    //             // Handle the error response
    //             // alert("Data Not Saved successfully!!");
    //         }
    //     }
    //                     }

