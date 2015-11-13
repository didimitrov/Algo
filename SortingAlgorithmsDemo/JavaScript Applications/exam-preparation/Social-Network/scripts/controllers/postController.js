var app = app|| {};

app.postController= (function () {
    function PostController(model,views){
        this.model = model;
        this.views= views
    }

    PostController.prototype.loadAllPostsPage= function (selector) {
        var _this = this;

        this.model.allPosts()
            .then(function (data) {
                for(var i in data.results){
                    data.results[i].authorUsername = data.results[i].createdBy.username;
                    data.results[i].authorName = data.results[i].createdBy.name;
                    data.results[i].authorPicture = data.results[i].createdBy.picture;
                    data.results[i].authorId = data.results[i].createdBy.objectId;
                    data.results[i].authorAbout = data.results[i].createdBy.about;
                    data.results[i].authorGender = data.results[i].createdBy.gender;
                }

                _this.views.allPostsView.loadAllPostsViewPage(selector, data);
            }, function(error) {
                Noty.error('error-message');
            })
    };

    PostController.prototype.post= function (content) {

        return this.model.post(content)
            .then(function (data) {
                console.log(data);
                window.location= '#/';
                Noty.success("Success")
            },
            function (error) {
                Noty.error('Error')
            })
    };

    return{
        load: function (model, views) {
            return new PostController(model,views)
        }
    }
}());