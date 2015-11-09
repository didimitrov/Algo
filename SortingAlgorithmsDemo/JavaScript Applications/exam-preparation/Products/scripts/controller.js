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
    
    Controller.prototype.loadRegisterPage= function (selector) {
        if (!this._model.users.isLogged()) {
            app.views.registerView.load(selector)
        }else {
            window.location.replace('#/');
            //Noty.error('Already logged in!');
        }
    };

    Controller.prototype.loadLoginPage= function (selector) {
        if (!this._model.users.isLogged()) {
            app.views.loginView.load(selector)
        }else {
            window.location.replace('#/');
            //Noty.error('Can\'t register while logged in!');
        }
    };


    Controller.prototype.attachEventHandlers= function () {
        var selector = '#main';
        attachRegisterHandler.call(this, selector);

    };
        var attachRegisterHandler = function (selector) {
            var _this= this;

            $(selector).on('click', '#register-button', function(){
               var userData= {
                    username:$('#username').val(),
                    password: $('#password').val()
               };
                    if(!userData.username || !userData.password){
                        Noty.error('Username and password cannot be empty.');
                    } else if(userData.password !== $('#confirm-password').val()){
                        Noty.error('Passwords must be identical.');
                        } else {
                            _this._model.users.register(userData)
                                .then(function () {
                                    console.log('Registration successful.'); //Noty.success
                                    _this.redirectTo('#/');
                                }, function (error) {
                                   console.log('Your registration has encountered an error.');
                                    _this.redirectTo('#/');
                                });
                    }
                return false;
            })
        };






    return{
        get: function (model) {
            return new Controller(model)
        }
    }
}());