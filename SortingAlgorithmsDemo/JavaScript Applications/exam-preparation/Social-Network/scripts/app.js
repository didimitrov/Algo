var app = app || {};

(function () {
    var apiId = '27qwWWklmDm4DO2fbOkx6N1ylctpf9wWfg9rA7PC';
    var restAPIKey = 'h2BduNbkQiaBFYN9j8vviqHD5MgQHtIwftd5bjGU';
    var baseUrl = 'https://api.parse.com/1/';

    var requester = app.requester.load();
    var headers = app.headers.load(apiId, restAPIKey);
    //var noty = app.noty.load();

    //views
    var userViews = app.userViews.load();
    var homeViews = app.homeViews.load();

    //models
    var userModel = app.user.load(baseUrl, requester, headers);

    //controllers
    var homeController= app.homeController.load(homeViews);
    var userController= app.userController.load(userModel, userViews);
    
    app.router= Sammy(function () {
        var selector = '#main';

        this.before(function () {
           var userId = sessionStorage['userId'];

            if(userId){
                $('header').show()
            }else{
                $('header').hide()
            }
        });
        this.before('#/', function() {
            var userId = sessionStorage['userId'];

            if (userId) {
                this.redirect('#/home/');
                return false;
            }
        });
        this.before('#/home/', function() {
            var userId = sessionStorage['userId'];

            if (!userId) {
                this.redirect('#/');
                return false;
            }
        });
        this.before('#/register/', function() {
            var userId = sessionStorage['userId'];
            if(userId) {
                this.redirect('#/home/');
                return false;
            }
        });
        this.before('#/login/', function() {
            var userId = sessionStorage['userId'];
            if(userId) {
                this.redirect('#/home/');
                return false;
            }
        })
        this.before('#/logout/', function() {
            var userId = sessionStorage['userId'];
            if(!userId) {
                this.redirect('#/');
                return false;
            }
        });

        this.get('#/', function () {
            homeController.loadGuestHomePage(selector);
        });
        this.get('#/register/', function () {
            userController.loadRegisterPage(selector);
        });
        this.get('#/login/', function () {
            userController.loadLoginPage(selector)
        })
        this.get('#/logout/', function () {
            userController.logout();
        });

        this.get('#/home/', function () {
            homeController.loadHomePage('#header');
           // postController.loadAllPostsPage(selector);
        });


        // triggers
        this.bind('login', function(event, data) {
            userController.login(data.username, data.password);
        });

        this.bind('register', function(event, data) {
            userController.register(data.username, data.password, data.name, data.about, data.gender, data.picture);
        });
    })
    app.router.run('#/');
}())