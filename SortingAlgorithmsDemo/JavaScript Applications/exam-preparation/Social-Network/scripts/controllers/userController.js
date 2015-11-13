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
    UserController.prototype.loadEditProfilePage = function(selector) {
        var data = {
            username: sessionStorage.username,
            name: sessionStorage.name,
            about: sessionStorage.about,
            gender: sessionStorage.gender
        };

        this.views.editProfileView.loadEditProfileView(selector, data);
    };

    UserController.prototype.register= function (username, password, name, about, gender, picture) {

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
               Noty.success( 'Register successful.');
           }, function(error) {
               Noty.error('Register failed.');
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
                Noty.success('Login successful.');
            }, function(error) {
                Noty.error('Login failed.');

            })
    }

    UserController.prototype.logout = function() {
        var _this = this;

        return this.model.logout()
            .then(function() {
                clearUserFromStorage();
                window.location = '#/';
                Noty.success('You successfully logged out.');
            }, function(error) {
                Noty.error('Failed.');
            });
    };

    UserController.prototype.editProfile = function(username, password, name, about, gender, picture) {

        return this.model.editProfile(sessionStorage.userId, username, password, name, about, gender, picture)
            .then(function(editProfileData) {
                var data = {
                    objectId: sessionStorage.userId,
                    username: username,
                    name: name || sessionStorage.name,
                    about: about || sessionStorage.about,
                    gender: gender || sessionStorage.gender,
                    picture: picture || sessionStorage.picture,
                    sessionToken: sessionStorage.sessionToken
                };

                setUserToStorage(data);
                window.location = '#/';
                Noty.success( 'Profile updated successfully.');
            }, function(error) {
                Noty.error('Error');
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