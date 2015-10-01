var mainUrl = "http://localhost:64417/api/heroes";

function heroesGetFunc() {
	$.ajax(mainUrl,
		{method: "GET",
		success: simpleResponse
		}
	);	
}

function heroesPostFunc() {
	$.ajax(mainUrl,
		{method: "POST",
		success: simpleResponse,
		contentType: "application/json",
		data: JSON.stringify({
			Name: document.getElementById('heroName').value,
			Universe: document.getElementById('universe').value,
			StartingHealth: document.getElementById('startingHealth').value
			}),
		processData: false
		}
	);
}

function heroesPatchFunc() {
	$.ajax(mainUrl + "/" + document.getElementById('heroIndex').value,
		{method: "PATCH",
		success: simpleResponse,
		contentType: "application/json",
		data: JSON.stringify({
			Name: document.getElementById('heroName').value,
			Universe: document.getElementById('universe').value,
			StartingHealth: document.getElementById('startingHealth').value
			}),
		processData: false
		}
	);
}

function simpleResponse(data) {
	document.getElementById('result').innerHTML = JSON.stringify(data);
}
