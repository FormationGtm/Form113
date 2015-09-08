$(document).ready(function () {
    var uri = 'http://form114.dlucazeau.fr/api/produitsapi';
    // Send an AJAX request
    $.getJSON(uri){console.log(data);}
        //.done(function (data) {
            
            // On success, 'data' contains a list of products.
            // $.each(data, function (key, item) {
            // Add a list item for the product.
            // $('<li>', { text: key+" : "+item }).appendTo($('#content'));
            //  });
        });
