
function test() {
	var steven = "adfa";
	
	console.log("adf", "adfa", "adf");
}

var x = 'global';
function handleStyleChange() {
	
	var firstElement = document.getElementById("first");
	var colorPickerElement = document.getElementById("colorPicker");
	
	firstElement.style.backgroundColor = colorPickerElement.value;
	
	//firstElement.style.backgroundColor = "blue";
	//firstElement.className = 'red';
	
	var json = {"key safd": "value", secondKey: 5,
		nested: {"another": "nested value"},
		keyArray: [2, 3, 4, 5, {wierd: "valueinarray"}]
		};
		
	var person = {
		firstName: document.getElementById('name').value,
		lastName: "yackel",
		address: {
			old: "1473 ",
			newAddress: "4314"
		}
	}
	
	var five = json.secondKey;
}


//window.onload = test;