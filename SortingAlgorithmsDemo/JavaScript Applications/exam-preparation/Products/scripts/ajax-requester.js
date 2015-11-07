var app = app || {};

app.requester = (function () {
    function Requester(baseUrl) {
        this._baseUrl = baseUrl;
    }

    Requester.prototype.get = function (serviceUrl) {  //headers
        var url = this._baseUrl + serviceUrl;
        var headers = app.credentials.getHeaders(); //remove this
        return makeRequest('GET', headers, url);
    };

    Requester.prototype.post = function (serviceUrl, data) {
        var url = this._baseUrl + serviceUrl;
        var headers = app.credentials.getHeaders(); //remove this

        return makeRequest('POST', headers, url, data);
    };

    Requester.prototype.delete = function (serviceUrl) {
        var url = this._baseUrl + serviceUrl;
        var headers = app.credentials.getHeaders(); //remove this

        return makeRequest('DELETE', headers, url);
    };

    Requester.prototype.put = function (serviceUrl, data) {
        var url = this._baseUrl + serviceUrl;
       var headers = app.credentials.getHeaders();
        return makeRequest('PUT', headers, url, data);
    };

    function makeRequest(method, headers, url, data) {
        var defer = Q.defer();
        $.ajax({
            method: method,
            headers: headers,
            url: url,
            data: JSON.stringify(data),
            processData: false,
            success: function (_data) {
                defer.resolve(_data);
            },
            error: function (error) {
                defer.reject(error);
            }
        });

        return defer.promise;
    }

    //function getHeaders() {
    //    var headers = {
    //        'X-Parse-Application-Id': 'gKTANX7eubZRN3D3UiAk6q6Z0UHOzg8bIu4HIN7T',
    //        'X-Parse-REST-API-Key': 'fU26dkPhG6muunjxRw8GB8rVUVmhohFKIEMG4mmJ',
    //        'Content-Type' : 'application/json'
    //    };
    //
    //    if(localStorage['logged-in']) {
    //        headers['X-Parse-Session-Token'] = localStorage['logged-in'];
    //    }
    //
    //    return headers;
    //}

    return {
        get: function (baseUrl) {
            return new Requester(baseUrl);
        }
    }
}());