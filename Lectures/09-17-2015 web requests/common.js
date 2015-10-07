var mainUrl = "http://webprogrammingassignment3.azurewebsites.net/api/starWars";

function forceGetFunc() {
	$.ajax(mainUrl, {
		method: "GET",
		success: simpleResponse
	} );

}

function simpleResponse(data, data2, data3) {
	document.getElementById('result').innerHTML = JSON.stringify(data);
	alert('second');
}

function forcePushFunc() {
	$.ajax(mainUrl, {
		method: "POST",
		processData: false,
		contentType: "application/json",
		success: simpleResponse,
		data: JSON.stringify({
			FirstName: document.getElementById('firstName').value,
			Character: document.getElementById('favoriteCharacter').value
			})
	});
	alert('first');
}