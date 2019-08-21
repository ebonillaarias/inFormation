

$(document).ready(function () {

    
})


var availableTags = [
    "Centro costo 1",
    "Centro costo 2",
    "Centro costo 3",
];


$("#tags").autocomplete({
    source: availableTags
});

$("#txt_start").datepicker();

$("#txt_end").datepicker();
