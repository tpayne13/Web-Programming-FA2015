var mainUrl = "http://localhost:59297/api/values";

function forceGetFunc() {
	forceSightIndex = -1;
	$.ajax(mainUrl,
		{method: "GET",
		success: simpleResponse
		}
	);	
}

function simpleResponse(data) {
	document.getElementById('result').innerHTML = JSON.stringify(data);
}

function forcePushFunc() {
	$.ajax(mainUrl,
		{method: "POST",
		success: simpleResponse,
		contentType: 'application/json',
		processData: false,
		data: {value: "string" }
		}
	);
}

function forceSightFunc() {
	$.ajax(mainUrl,
		{method: "GET",
		dataType: 'json',
		success: forceSightStep2
		}
	);
}

var forceSightIndex = -1;
function forceSightStep2(data) {
	if (!data.length) {
		simpleResponse({message: "Couldn't get the length"});
		return;
	}
	var index = Math.floor(Math.random() * data.length);
	$.ajax(mainUrl + "/" + index,
		{method: "GET",
		success: function(result) {
			result.message = "Picked index " + index;
			forceSightIndex = index;
			simpleResponse(result);
		}
		}
	);
}

function forceDeleteFunc() {
	$.ajax(mainUrl,
		{method: "GET",
		dataType: 'json',
		success: forceDeleteStep2
		}
	);
}

function forceDeleteStep2(data) {
	if (!data.length) {
		simpleResponse({message: "Couldn't get the length"});
		return;
	}
	var index = 0;
	if (forceSightIndex >= 0) {
		index = forceSightIndex;
	} else {
		index = Math.floor(Math.random() * data.length);
	}
	
	$.ajax(mainUrl + "/" + index,
		{method: "DELETE",
		error: function(xhr, errorStatus, errorCode) {
			alert(errorStatus, errorCode);
		},
		success: function() {
			$.ajax(mainUrl,
				{method: "GET",
				success: function (result) {
						simpleResponse({message: "Picked index " + index, data: result});
						forceSightIndex = -1;
					}
				}
			);
		}
		}
	);
}
