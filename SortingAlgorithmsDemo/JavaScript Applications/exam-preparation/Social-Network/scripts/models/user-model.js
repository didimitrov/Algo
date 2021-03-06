var app = app || {};

app.user= (function () {
    function User(baseUrl, ajaxRequester, headers){
        this.baseUrl = baseUrl;
        this.requester = ajaxRequester;
        this.headers = headers
    }
    
    User.prototype.register = function (username, password, name, about, gender, picture) {
        var serviceUrl = this.baseUrl+ 'users';
        var data={
            username:username,
            password: password,
            name: name,
            about: about,
            gender: gender,
            picture: picture
        };

      return  this.requester.post(serviceUrl,this.headers.getHeaders(true), data)
    }
    
    User.prototype.login= function (username, password) {
        var serviceUrl = this.baseUrl+'login?username='+username+'&password='+password;
        return this.requester.get(serviceUrl,this.headers.getHeaders())
    }

    User.prototype.logout= function () {
        var serviceUrl = this.baseUrl+'logout';
        return this.requester.post(serviceUrl,this.headers.getHeaders(true))
    }

    User.prototype.editProfile = function(userId, username, password, name, about, gender, picture) {
        var serviceUrl = this.baseUrl + 'users/' + userId;
        var data = {};

        if (username !== '') {
            data.username = username;
        }

        if (password !== '') {
            data.password = password;
        }

        if (name !== '') {
            data.name = name;
        }

        if (about !== '') {
            data.about = about;
        }

        if (gender !== undefined) {
            data.gender = gender;
        }

        if (picture !== undefined) {
            data.picture = picture;
        }

        return this.requester.put(serviceUrl, this.headers.getHeaders(true), data);
    };

    return{
        load: function (baseUrl, ajaxRequester, headers){
            return new User(baseUrl,ajaxRequester,headers)
        }
    }
}())