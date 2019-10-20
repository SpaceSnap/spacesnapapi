function loadResults(data) {
	console.log(`Loading results: ${data}`);
	if (data) {
		for (var i = 0; i < (data.length - 1) || i < 3; i++) {
			$('#pic-description' + i).text(`Description: ${data[i].description}`);
			$('#pic-score' + i).text(`Score: ${data[i].score.toFixed(2)}`);
		}
	}
	else {
		console.log('Results returned no data');
		$('#results-loaded').text('Received no results');
	}

	console.log('Done loading');
	$('#results-loading').hide();
	$('#results-loaded').removeAttr('hidden');
}