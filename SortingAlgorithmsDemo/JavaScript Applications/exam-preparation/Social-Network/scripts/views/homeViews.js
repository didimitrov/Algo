var app = app || {};

app.homeViews=(function () {
    function HomeViews(){
        this.guestHomeView = {
            loadGuestHomeView: loadGuestHomeView
        };

        this.homeView = {
            loadHomeView: loadHomeView
        };
    }

    function loadHomeView(selector, data){
        $.get('templates/home.html', function (template) {
            var outputHtml = Mustache.render(template, data);
            $(selector).html(outputHtml)
        })
    }

    function loadGuestHomeView(selector) {
        $.get('templates/guest-home.html', function(template) {
            var outputHtml = Mustache.render(template);
            $(selector).html(outputHtml);
        });
    }

    return {
        load: function() {
            return new HomeViews();
        }
    }
}())