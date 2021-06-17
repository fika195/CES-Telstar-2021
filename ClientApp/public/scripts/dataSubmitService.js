

function gatherinput() {

    const inputObj = new Object;

    inputObj.fromCity = document.getElementById('from').value;
    inputObj.toCity = document.getElementById('destination').value;
    inputObj.company = document.getElementById('company').value;
    document.getElementById('recommendedChecker').checked = true ? inputObj.recommendedDelivery = 1 : inputObj.recommendedDelivery = 0;
    inputObj.packageHeight = document.getElementById('height').value;
    inputObj.packageWidth = document.getElementById('width').value;
    inputObj.packageLength = document.getElementById('length').value;
    inputObj.packageWeight = document.getElementById('weight').value;

    var str = "http://we-tl-dk1.azurewebsites.net/api/internal?From=$inputObj.fromCity&Destination=$inputObj.toCity&Company=inputObj.company&Recommended=inputObj.recommendedDelivery&Height=inputObj.packageHeight&Length=$inputObj.packageLength&Width=$inputObj.packageWidth&Weight=inputObj.packageWeight";

    return str;

    //return inputJSONString = JSON.stringify(inputObj);

    document.write(inputJSONString);
    
}

function postInputJSON(){

    console.log("postInputJSON started");
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
         if (this.readyState == 4 && this.status == 200) {
             alert(this.responseText);
         }
    };
    xhttp.open("GET", gatherinput(), true);
    //xhttp.setRequestHeader("Content-type", "application/json");
    xhttp.send(gatherinput);
    console.log("GET request sent");
}

function URLBuilder(inputObj) {


    var str = Strong

}