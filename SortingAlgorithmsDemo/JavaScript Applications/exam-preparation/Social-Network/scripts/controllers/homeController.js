var app = app || {};

app.homeController= (function () {
    function HomeController(views){
        this.views = views;
    }

    HomeController.prototype.loadGuestHomePage= function (selector) {
        this.views.guestHomeView.loadGuestHomeView(selector)
    }

    HomeController.prototype.loadHomePage= function (selector) {
        var data={
            username: sessionStorage['username'],
            name: sessionStorage['name'],
            picture: sessionStorage['picture']
        };

         this.views.homeView.loadHomeView(selector, data)
    }


    return{
        load: function (views) {
            return new HomeController(views);
        }
    }
}())