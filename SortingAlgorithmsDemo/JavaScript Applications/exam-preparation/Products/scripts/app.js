var app = app || {};

(function () {
    var baseUrl ='https://api.parse.com/1/';
    var ajaxRequester = app.requester.get(baseUrl);
    var models = app.model.get(ajaxRequester);
    var controller = app.controller.get(models)
    //controller.attachEventHandlers();

    app.router = Sammy(function () {
        var mainSelector= '#main',
            menuSelector= '#menu';

        this.get('#/', function () {
            loadHeader();
            controller.loadHomePage(mainSelector);
        })

        function loadHeader(){
            return controller.loadHeader(menuSelector)
        }
        this.notFound = function(){

        }
    });


    app.router.run('#/')
}());
