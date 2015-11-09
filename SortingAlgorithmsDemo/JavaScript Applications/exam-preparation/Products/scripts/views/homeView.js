var app = app || {};

app.views = app.views || {};

app.views.homeView= (function () {
    function HomeView(selector, data){
        var defer = Q.defer();

        $.get('templates/home.html', function (template) {
            var temp = Handlebars.compile(template);
            var html = temp(data);
        }).success(function (data) {
            defer.resolve(data)
        }).error(function (error) {
            defer.reject(error)
        });
        return defer.promise
    }

    return{
        load: function (selector, data) {
            return new HomeView(selector, data)
        }
    }
}());