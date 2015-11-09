var app = app || {};

app.views = app.views || {};

app.views.menuView= (function () {
    function MenuView(selector, data){
        var defer = Q.defer();

        $.get('templates/navigation.html', function (template) {
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
            return new MenuView(selector, data)
        }
    }
}());