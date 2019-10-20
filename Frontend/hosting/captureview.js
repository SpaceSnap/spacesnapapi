function loadResults(data) {
	console.log('test ' + data);
	_.forEach(data, function (value) {
		console.log(value);
	});

	$('#pic-description').text(`Description: ${data[0].description}`);
	$('#pic-score').text(`Score: ${data[0].score.toFixed(2)}`);

	$('#a-frame-container').hide();
	$('#results-container').removeAttr('hidden');
}	