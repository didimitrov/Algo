var app = app || {};

(function () {
    var baseUrl ='https://api.parse.com/1/';
    var ajaxRequester = app.requester.get(baseUrl);
    var models = app.model.get(ajaxRequester);
    var controller = app.controller.get(models)
    controller.attachEventHandlers();

    app.router = Sammy(function () {
        var mainSelector= '#main',
            menuSelector= '#menu';

        this.get('#/', function () {
            loadHeader();
            controller.loadHomePage(mainSelector);
        })

        this.get('#/register', function () {
            loadHeader();
            controller.loadRegisterPage(mainSelector)
        })

        this.get('#/login', function () {
            loadHeader();
            controller.loadLoginPage(mainSelector)
        })

        this.get('#/logout', function () {

            controller.logout()
        })

        this.get('#/products', function () {
            loadHeader();
            controller.loadProductsPage(mainSelector);
        });

        this.get('#/product/add', function () {
            loadHeader();
            controller.loadProductAdd(mainSelector);
        });

        function loadHeader(){
            return controller.loadHeader(menuSelector)
        }

    });


    app.router.run('#/')
}());
