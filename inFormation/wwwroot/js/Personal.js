





$(document).ready(function () {
    
    $.fn.datepicker.dates['es'] = {
        days: ['Domingo', 'Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado'],
        daysShort: ['Dom', 'Lun', 'Mar', 'Mié', 'Juv', 'Vie', 'Sáb'],
        daysMin: ['Do', 'Lu', 'Ma', 'Mi', 'Ju', 'Vi', 'Sá'],
        months: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
        monthsShort: ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun', 'Jul', 'Ago', 'Sep', 'Oct', 'Nov', 'Dic'],
        today: "Hoy"
    };

    $("#txt_start").datepicker({
        isRTL: false,
        //format: 'dd.mm.yyyy hh:ii',
        autoclose: true,
        language: 'es'
    });

    $("#txt_end").datepicker({
        isRTL: false,
        //format: 'dd.mm.yyyy hh:ii',
        autoclose: true,
        language: 'es'
    });


})


var availableTags = [
    "Centro costo 1",
    "Centro costo 2",
    "Centro costo 3",
];


$("#tags").autocomplete({
    source: availableTags
});

//$.datepicker.regional['es'] = {
//    closeText: 'Cerrar',
//    prevText: '<Ant',
//    nextText: 'Sig>',
//    currentText: 'Hoy',
//    monthNames: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
//    monthNamesShort: ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun', 'Jul', 'Ago', 'Sep', 'Oct', 'Nov', 'Dic'],
//    dayNames: ['Domingo', 'Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado'],
//    dayNamesShort: ['Dom', 'Lun', 'Mar', 'Mié', 'Juv', 'Vie', 'Sáb'],
//    dayNamesMin: ['Do', 'Lu', 'Ma', 'Mi', 'Ju', 'Vi', 'Sá'],
//    weekHeader: 'Sm',
//    dateFormat: 'dd/mm/yy',
//    firstDay: 1,
//    isRTL: false,
//    showMonthAfterYear: false,
//    yearSuffix: ''
//};
//$.datepicker.setDefaults($.datepicker.regional['es']);


