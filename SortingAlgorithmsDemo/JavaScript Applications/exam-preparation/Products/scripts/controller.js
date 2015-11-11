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

            var name = app.credentials.getUsername();
            $("#hiUser").html('Hello, <span>' +
                sessionStorage['username'] + '</span>')

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

    Controller.prototype.logout = function(){
        var _this = this;

        if(this._model.users.isLogged()){
            this._model.users.logout()
                .then(function(){
                    _this.redirectTo('#/');
                    console.log('Successfully logged out.');
                });
        } else {
            console.log('Already logged out.');
            this.redirectTo('#/')
        }
    };

    Controller.prototype.loadProductsPage= function (selector) {
        var _this= this,
           categories=[];

        if (this._model.users.isLogged()) {
            _this._model.products.getAllProducts()
                .then(function (data) {
                    $.each(data.products, function (key, value) {
                        categories.push(value.category);
                    });
                    data.categories =  $.unique(categories);
                    app.views.productsView.load(selector, data)
                })
        }else {
            this.redirectTo('#/');
            console.log('You have to login to see this page!'); //Noty.error
        }

    }

    Controller.prototype.loadProductAdd= function (selector) {
        if(this._model.users.isLogged){
            app.views.addProductView.load(selector);
        }else{
            this.redirectTo('/#');
            console.log('You have to login to add a new product!')
        }
    }

    Controller.prototype.redirectTo = function(url) {
        window.location = url;
    }

    Controller.prototype.attachEventHandlers= function () {
        var selector = '#main';
        attachRegisterHandler.call(this, selector);
        attachLoginHandler.call(this, selector);
        attachProductHandler.call(this, selector);
        attachAddProductHandler.call(this, selector);
        attachDeleteProductHandler.call(this, selector);
        attachEditProductHandler.call(this, selector);

    };

    var attachDeleteProductHandler = function (selector) {
        var _this= this;

        $(selector).on('click','.delete-button', function () {
            var id = $(this).attr('product-id').val();

            _this._model.products.deleteProduct(id)
                .then(function () {
                    console.log('Product successfully deleted.')
                }, function () {
                    console.log('Your product edit has encountered an error.')
                })
            return false;
        })
    }

    var attachEditProductHandler= function (selector) {
        var _this= this;

        $(selector). on('click', '#edit-product-button', function () {
            var productData={
                name: $('#name').val(),
                price: Number($('#price').val()),
                category: $('#category').val()
            };
            var id = $(this).attr('product-id').val();
            if (!productData.name || !productData.price || !productData.category) {
                console.log('No empty field allowed')
            } else{
                _this._model.products.editProduct(id, productData)
                    .then(function () {
                        console.log('Product successfully edited.');
                        _this.redirectTo('#/products')
                    }, function () {
                        console.log('Your product edit has encountered an error.')
                    })
            }
            return false;
        })
    }

    var attachProductHandler= function (selector) {
        var _this= this;
        $(selector).on('click', '.edit-button', function () {
            _this.redirectTo('#/product/edit/'+ $(this).attr('product-id'))
            return false
        })

        $(selector).on('click', '.delete-button', function () {
            _this.redirectTo('#/product/delete/'+ $(this).attr('#product-id'))
            return false
        })

        $(selector).on('click', '#clear-filters', function () {
            //$('.filters form')[0].reset();
            _this.loadProducts(selector);

            return false;
        });

        $(selector).on('click', '.filter-button', function () {
            var filters = {
                keyword: $('#search-bar').val(),
                minPrice: Number($('#min-price').val()),
                maxPrice: Number($('#max-price').val()),
                category: $('#category').val()
            };

            _this._model.products.filterProducts(filters)
                .then(function(data){
                    console.log(data);
                    app.views.productsView.load(selector, data);
                });

            return false;
        });
    }
    
    var attachAddProductHandler= function (selector) {
        var _this= this;

        $(selector).on('click', '#add-product-button', function () {
            var productData={
                name: $('#name').val(),
                price: Number($('#price').val()),
                category: $('#category').val(),
                "ACL": {"*":{"read":true}}
            };
            if (!productData.name || !productData.price || !productData.category) {
                console.log('No empty field allowed')
            } else{
                _this._model.users.getCurrentUserData()
                    .then(function (user) {
                        productData.user={
                            '__type': 'Pointer',
                            'className': '_User',
                            'objectId': user.userId
                        };
                        productData.ACL[user.userId] = {"write":true,"read":true};

                        _this._model.products.addProduct(productData)
                            .then(function(){
                                console.log('Product successfully created.')
                                _this.redirectTo('#/products')
                            }, function () {
                                console.log('Your product submit has encountered an error.')
                            })
                    })
            }
            return false;
        })
    }


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

    var attachLoginHandler= function (selector) {
        var _this= this;

        $(selector).on('click', '#login-button', function () {
            var userData= {
                username:$('#username').val(),
                password: $('#password').val()
            };

            _this._model.users.login(userData.username, userData.password)
                .then(function () {
                    console.log('Login successful.'); //Noty.success
                    _this.redirectTo('#/');
                }, function (error) {
                    console.log('Your login has encountered an error.');
                    _this.redirectTo('#/');
                });
            return false;
        })
    }




    return{
        get: function (model) {
            return new Controller(model)
        }
    }
}());