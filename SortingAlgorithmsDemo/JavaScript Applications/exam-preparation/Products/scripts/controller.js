var app = app || {};

app.controller = (function () {
    function Controller(model){
        this._model = model;
    }

    return{
        get: function (model) {
            return new Controller(model)
        }
    }
}());