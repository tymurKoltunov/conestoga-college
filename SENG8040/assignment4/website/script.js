
function save(){
	let entity = [];
	let seller = document.getElementById("seller").value;
    let address = document.getElementById("address").value;
    let city = document.getElementById("city").value;
    let phone = document.getElementById("phone").value;
    let email = document.getElementById("email").value;
    let model = document.getElementById("vehicleModel").value;
    let manufacturer = document.getElementById("vehicleManufacturer").value;
    let year = document.getElementById("vehicleYear").value;	
	let i;
	let str;
	let result = true;
	let mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
	let phoneformat1 =/\d{3}-\d{3}-\d{4}/;
	let phoneformat2 = /\(\d{3}\)\d{3}-\d{4}\)/;
	if(phone.match(phoneformat2) || phone.match(phoneformat1)){
		document.getElementById("phoneError").innerHTML = "";
	}
	else{
  		document.getElementById("phoneError").innerHTML = "Input not valid";
    	result = false;
    }
	if (email.match(mailformat)){
       	document.getElementById("emailError").innerHTML = "";
  	} 
  	else{
  		document.getElementById("emailError").innerHTML = "Input not valid";
    	result = false;
    }
	if (city == "") {
    	document.getElementById("cityError").innerHTML = "Input not valid";
    	result = false;
  	} 
  	else
  		document.getElementById("cityError").innerHTML = "";
	if (address == "") {
    	document.getElementById("addressError").innerHTML = "Input not valid";
    	result = false;
  	} 
  	else
  		document.getElementById("addressError").innerHTML = "";
	if (seller == "") {
    	document.getElementById("sellerError").innerHTML = "Input not valid";
    	result = false;
  	} 
  	else
  		document.getElementById("sellerError").innerHTML = "";
	if (isNaN(year)) {
    	document.getElementById("yearError").innerHTML = "Input not valid";
    	result = false;
  	} 
  	else
  		document.getElementById("yearError").innerHTML = "";
  	entity.push(seller);
  	entity.push(address);
  	entity.push(city);
  	entity.push(phone);
  	entity.push(email);
  	entity.push(model);
  	entity.push(manufacturer);
  	entity.push(year);
  	if(result){
  		for (i = 0; i > -1;) {
			str = i.toString();
			if(localStorage.getItem(str) == null){			
				break;
	    	}
	    	else
	    		i++;
		}	
		localStorage.setItem(str, JSON.stringify(entity));	
		window.location.replace("added.html");
  	}	
}
function display(){
	let entity = [];
	let i;
	let display = "";
	let str;
	for (i = 0; i > -1;) {
		str = i.toString();
		if(localStorage.getItem(str) == null)	
			break;	    
	    else{
	    	entity.push(JSON.parse(localStorage.getItem(str)));
			i++;
	    }
	    	
	}
	for (let j = 0; j < entity.length; j++) {
		let obj = entity[j];
		for (let property in obj) {
			display += obj[property] + " ";
			alert(obj.length);
		}
		display += "\n";
	}
	document.getElementById("display").value = display;

}
function added(){
	let entity = [];
	let i;
	let d = "";
	let last;
	let str;
	let model;
	let manuf;
	let year;
	last = JSON.parse(getLastElementFromLocalStorage());	
	i = 0;
	for (let property in last) {
			d += last[property] + " / ";
			if(i == 5){				
				model = last[property];				
			}
			if(i == 6){
				manuf = last[property];
			}
			if(i == 7){
				year = last[property];
			}
			i++;
		}		

	let link = "http://jdpower.com/cars/" + manuf + "/" + model + "/" + year;
	document.getElementById("added").innerHTML = d;
	document.getElementById("link").innerHTML = link;
	document.getElementById("link").href = link;
}
function getLastElementFromLocalStorage() {
	let i = 0;
	while(true) {
		if(localStorage.getItem(i.toString()) == null) {
			return localStorage.getItem((i - 1).toString());
		}
		i++;
	}
}