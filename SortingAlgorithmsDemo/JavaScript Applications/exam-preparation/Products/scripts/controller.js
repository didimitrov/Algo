var app = app || {};

app.controller = (function () {
    function Controller(model){
        this._model = model;
    }

    Controller.prototype.loadHeader= function (headerSelector) {
        var isLogged = {
            isLogged: false
        };

        if(this._model.users.isLogged()){
            isLogged.isLogged = true;
        }

        return  app.views.menuView.load(headerSelector, isLogged);
    };

    Controller.prototype.loadHomePage = function(selector){
        var _isLogged = {
            isLogged: false
        };

        if(this._model.users.isLogged()){
            _isLogged.isLogged = true;

        }

        return app.views.homeView.load(selector, _isLogged);
    };

    return{
        get: function (model) {
            return new Controller(model)
        }
    }
}());