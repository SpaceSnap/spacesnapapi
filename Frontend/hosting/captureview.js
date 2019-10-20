function loadResults(data) {
	for (var i = 0; i < 3; i++) {
		$('#pic-description' + i).text(`Description: ${data[i].description}`);
		$('#pic-score' + i).text(`Score: ${data[i].score.toFixed(2)}`);
	}

	$('#a-frame-container').hide();
	$('#results-container').removeAttr('hidden');
}