var app = app || {};

(function () {
    var apiId = '27qwWWklmDm4DO2fbOkx6N1ylctpf9wWfg9rA7PC';
    var restAPIKey = 'h2BduNbkQiaBFYN9j8vviqHD5MgQHtIwftd5bjGU';
    var baseUrl = 'https://api.parse.com/1/';

    var headers = app.headers.load(apiId, restAPIKey);
    var requester = app.requester.load();
    //var noty = app.noty.load();

    //views
  //  var userViews = app.userViews.load();
    var homeViews = app.homeViews.load();
    //models
    var userModel = app.user.load(baseUrl, requester, headers)

    //controllers
    var homeController= app.homeController.load(homeViews)

}())