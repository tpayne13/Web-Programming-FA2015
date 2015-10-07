function addStuff() {
	var results = document.getElementById('results');
	var userValue = document.getElementById('userValue').value;
	results.innerHTML = '';
	
	try {
		var userObject = JSON.parse(userValue);
	} catch (error) {
		results.innerHTML = error;
		return;
	}
	
	var displayElement = document.createElement('div');
	
	if (!Array.isArray(userObject)) {
		results.innerHTML = "Was not an array.";
		return;
	}
	
	for (var i = 0; i < userObject.length; i++) {
		// number, object are valid types
		if (typeof userObject[i] === "string" ||
			typeof userObject[i] === "number") {
			var userStringElement = document.createTextNode(userString);	
			var pElement = document.createElement('p');
			pElement.appendChild(userStringElement);
			results.appendChild(pElement);
		} else if (Array.isArray(userObject[i])) {
			var mySum = 0;
			for (var j = 0; j < userObject[i].length; j++) {
				if (typeof userObject[i][j] === "number") {
					mySum += userObject[i][j];
				} else {
					results.innerHTML = "One of your values wasn't a number in a sub-array.";
					return;
				}
			}
			var userStringElement = document.createTextNode(mySum);	
			var pElement = document.createElement('p');
			pElement.appendChild(userStringElement);
			results.appendChild(pElement);
		} else {
			results.innerHTML = "Outer array element wasn't a number, string, or array.";
		}
	}	
	//results.appendChild(displayElement);
	//var errorText = document.createTextNode("My Error");
	//results.appendChild(errorText);
}
