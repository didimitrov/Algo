var app = app || {};

app.homeController= (function () {
    function HomeController(views){
        this.views = views;
    }

    HomeController.prototype.loadGuestHomePage= function (selector) {
        return this.views.HomeViews().loadGuestHomePage(selector)
    }

    HomeController.prototype.loadHomePage= function (selector) {
        var data={
            username: sessionStorage['username'],
            name: sessionStorage['name'],
            picture: sessionStorage['picture']
        };

        return this.views.HomeViews().loadHomePage(selector, data)
    }


    return{
        load: function (views) {
            return new HomeController(views);
        }
    }
}())