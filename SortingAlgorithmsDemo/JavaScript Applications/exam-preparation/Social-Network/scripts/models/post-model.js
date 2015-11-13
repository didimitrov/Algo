var app = app || {};

app.post= (function () {
    function Post(baseUrl, ajaxRequester, headers){
        this.serviceUrl = baseUrl+ 'classes/Post/';
        this.requester = ajaxRequester;
        this.headers= headers;
    }

    Post.prototype.allPosts= function () {
        return this.requester.get(this.serviceUrl+'?include=createdBy&order=-createdAt', this.headers.getHeaders())
    }

    Post.prototype.post= function (content) {
        var data={
            content: content,
            createdBy:{
                __type: 'Pointer',
                className: '_User',
                objectId: sessionStorage['userId']
            }
        };

        return this.requester.post(this.serviceUrl,this.headers.getHeaders(true), data)
    }


    return {
        load: function(baseUrl, ajaxRequester, headers){
           return new Post(baseUrl, ajaxRequester, headers)
        }
    }
}())