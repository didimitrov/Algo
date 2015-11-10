var app = app || {};

app.credentials=(function () {


    function getHeaders(){
    var PARSE_APP_ID = 'SMNynWfo18IfxXeLpfE6riLuBYvsaW2Cj5p6x9y0';
    var PARSE_REST_API_KEY = '666h99DRXKX0ocwax5Db7Dyagss1hhw5KELJwX7q';

    var headers = {
            'X-Parse-Application-Id': PARSE_APP_ID,
            'X-Parse-REST-API-Key': PARSE_REST_API_KEY,
            'Content-Type': 'application/json'
        },

        sessionToken = this.getSessionToken();

        if (sessionToken) {
            headers['X-Parse-Session-Token'] = sessionToken;
        }
        return headers;

}
    function getSessionToken(){
        return sessionStorage['sessionToken'] ? sessionStorage['sessionToken'] : undefined;
    }

    function setSessionToken(sessionToken){
        sessionStorage['sessionToken']= sessionToken;
    }

    function getUserId(){
        return sessionStorage['userId'] ? sessionStorage['userId'] : undefined;
    }

    function setUserId(userId){
        sessionStorage['userId']=userId;
    }

    function getUsername(){
        return sessionStorage['username'] ? sessionStorage['username']: undefined;
    }

    function setUsername(username){
        sessionStorage['username']= username;
    }

    function clearSessionStorage(){
        sessionStorage.clear();
    }

    return{
        getHeaders: getHeaders,
        getSessionToken: getSessionToken,
        setSessionToken: setSessionToken,
        getUserId: getUserId,
        setUserId: setUserId,
        getUsername: getUsername,
        setUsername: setUsername,
        clearStorage: clearSessionStorage
    }
}());