var app = app || {};

app.userController= (function () {
    function UserController(model,views){  //noty
        this.views= views;
        this.model = model;
    }

    UserController.prototype.loadLoginPage= function (selector) {
        this.views.login.loadLogin(selector);
    }
    UserController.prototype.loadRegisterPage= function (selector) {
        this.views.register.loadRegister(selector); //noty
    }

    UserController.prototype.register= function (username, password, name, about, gender, picture) {
        var _this= this;

       return this.model.register(username,password,name, about, gender, picture)
            .then(function (registerData) {
               var data = {
                   objectId: registerData.objectId,
                   username: username,
                   name: name,
                   about: about,
                   gender: gender,
                   picture: picture,
                   sessionToken: registerData.sessionToken
               };

               setUserToStorage(data);
               window.location = '#/home/';
               _this.noty.success('#success-message', 'Register successful.');
           }, function(error) {
               _this.noty.error('#error-message', error.responseJSON.error);
           })
        }

    UserController.prototype.login= function (username, password) {
        
        return this.model.login(username, password)
            .then(function (dataLogin) {
                var data={
                    objectId: dataLogin.objectId,
                    username: username,
                    name: dataLogin.name,
                    about: dataLogin.about,
                    gender: dataLogin.gender,
                    picture: dataLogin.picture,
                    sessionToken: dataLogin.sessionToken
                };
                setUserToStorage(data);
                window.location = '#/home/';
                noty.success('Login successful.');
            }, function(error) {
                noty.error('Login failed.');

            })
    }

    UserController.prototype.logout = function() {
        var _this = this;

        return this.model.logout()
            .then(function() {
                clearUserFromStorage();
                window.location = '#/';
                _this.noty.success('#success-message', 'You successfully logged out.');
            }, function(error) {
                _this.noty.error('#error-message', error.responseJSON.error);
            });
    };


    function setUserToStorage(data) {
        sessionStorage['userId'] = data.objectId;
        sessionStorage['username'] = data.username;
        sessionStorage['name'] = data.name;
        sessionStorage['about'] = data.about;
        sessionStorage['gender'] = data.gender;
        sessionStorage['picture'] = data.picture;
        sessionStorage['sessionToken'] = data.sessionToken;
    }

    function clearUserFromStorage() {
        delete sessionStorage['userId'];
        delete sessionStorage['username'];
        delete sessionStorage['name'];
        delete sessionStorage['about'];
        delete sessionStorage['gender'];
        delete sessionStorage['picture'];
        delete sessionStorage['sessionToken'];
    }

    return{
        load: function (model, views) { //noty
            return new UserController(model, views)
        }
    }
}())