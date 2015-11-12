var app = app || {};

app.user= (function () {
    function User(baseUrl, ajaxRequester, headers){
        this.baseUrl = baseUrl;
        this.requester = ajaxRequester;
        this.headers = headers
    }
    
    User.prototype.register = function (username, password, name, about, gender, picture) {
        var serviceUrl = this.baseUrl+'users';
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

    return{
        load: function (baseUrl, ajaxRequester, headers){
            return new User(baseUrl,ajaxRequester,headers)
        }
    }
}())