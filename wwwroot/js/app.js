function saveMessage(Name, Email) {
    // alert("Record inserted successfully. Name is : " + Name + " and email id : " + Email);
    document.getElementById("messageBox").innerText = "Record inserted successfully. Name is : " + Name + " and email id : " + Email;
}


function SetFocusOnName(element) {

    element.focus();
     
}

function GetCity() {

    var cities = ["Noida", "Delhi", "Gurugram", "Mumbai", "Lacknow"];

    return cities;
}