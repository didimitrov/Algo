$(document).ready(function () {
    var COUNTRIES_LIST_ID = "zglO59FNb78GVcUsUOJLp1tqfLxcZ3u3C8a88hox";
    var COUNTRIES_LIST_KEY = "vgv5unJ0bLI5N1fs0NfgOrD2GnSGCEjzdPCNbDZO";
    var headers = {
        "X-Parse-Application-Id": COUNTRIES_LIST_ID,
        "X-Parse-REST-API-Key": COUNTRIES_LIST_KEY
    };
    loadCountries();

    function townsRequest() {
        $('.selected').removeClass('selected');
        $(this).addClass('selected');

        $.ajax({
            method: 'get',
            headers: headers,
            url: 'https://api.parse.com/1/classes/Town?where='+
            '{"country": {"__type": "Pointer","className": "Country", "objectId": "' + $(this).attr('objectId') +'"}}'
        }).success(function (data) {
            $('#towns').children().remove();
            for (var i in data.results) {
                var town = data.results[i];
                var townItem = $('<li>').text(town.name);
                townItem.appendTo($('#towns'));
            }
        }).error(function () {
            alert('Towns cant be loaded')
        });
    }

   function loadCountries(){
       $('#countries').children().hide();
       $.ajax({
           method: 'get',
           headers: headers,
           url: "https://api.parse.com/1/classes/Country"
       }).success(function(data){
           for (var i in data.results) {
               var country = data.results[i];
               var countryItem = $('<li>').text(country.name);
               $(countryItem).attr('objectId', country.objectId);
               countryItem.appendTo($('#countries'));
               countryItem.on('click',townsRequest)


               var options = $('<div class="options">');
               options.attr('class', country.objectId);

               var deleteButton = $('<button class="delete">Delete</button>');
               deleteButton.data('country', country);
               deleteButton.click(delCountry);
               options.append(deleteButton);

               options.appendTo(countryItem);
               countryItem.appendTo($("#countries"));
           }
       }).error(function () {
           alert('Cannot load countries')
       });
   }

    $.ajax({
        method: 'get',
        headers: headers,
        url: "https://api.parse.com/1/classes/Town?order=name"
    }).success(function (data){
        for (var i in data.results) {
            var town = data.results[i];
            var townItem = $('<li>').text(town.name);
            townItem.appendTo($('#towns'));
        }
    }).error(function () {
        alert('Towns cant be loaded')
    });

   var addCountry = function () {
       var input = $('#newCountryName').val();
       if (input) {
           $.ajax({
               method: 'post',
               headers: headers,
               url: "https://api.parse.com/1/classes/Country",
               contentType: 'application/json',
               data: JSON.stringify({"name": input})
           }).success(function () {
               loadCountries();
              // alert("New country successfully added");
               input.remove();
           }).error(function () {
               alert('Error occurred while adding new country')
           });
       }
   };
    $('#town-add-btn').on('click', addCountry);


    var delCountry = function () {
        var country =$(this).data('country');
            $.ajax({
                method: 'delete',
                headers: headers,
                url: "https://api.parse.com/1/classes/Country/"+country.objectId,
                contentType: 'application/json',
            }).success(function () {
                loadCountries();
                input.remove();
            }).error(function () {
                alert('Error occurred while adding new country')
            });
        }
});