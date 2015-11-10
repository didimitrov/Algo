var app = app|| {};

app._model =app._model || {};

app._model.products = (function () {
  function Products(ajaxRequester){
      this._requester = ajaxRequester;
      this._products = {
          'products': []
      }
  }

    Products.prototype.getAllProducts= function () {
        var defer = Q.defer();
        var _this= this;
        var userId = app.credentials.getUserId();

        this._requester.get('classes/Product')
            .then(function (data) {
                _this._products['products'].lenght= 0;

                $.each(data['result'], function (key, productData) {
                    var product={
                        objectId: productData.objectId,
                        name: productData.name,
                        category: productData.category,
                        price: productData.price,
                        owner: productData.user.objectId,
                        createdAt: productData.createdAt
                    };
                    _this._products.push(product);
                });
                defer.resolve(_this._products);
            }, function (error) {
                defer.reject(error)
            });

        return defer.promise;
    }

    Products.prototype.getById= function (id) {
        var defer = Q.defer();

        this._requester.get('classes/product' + id)
            .then(function (data) {
            defer.resolve(data)
        }, function (error) {
                defer.reject(error)
            })
        return defer.promise;
    }

    Products.prototype.addProduct= function (productData) {
        var defer = Q.defer();

        this._requester.post('classes/product', productData)
            .then(function (data) {
                defer.resolve(data)
            }, function (error) {
                defer.reject(error)
            })
        return defer.promise;

    }

    Products.prototype.editProduct= function (id, productData) {
        var defer = Q.defer();

        this._requester.put('classes/product'+id, productData)
            .then(function (data) {
                defer.resolve(data)
            }, function (error) {
                defer.reject(error)
            });
        return defer.promise;

    }

    Products.prototype.deleteProduct= function (id) {
        var defer = Q.defer();

        this._requester.delete('classes/product'+id)
            .then(function (data) {
                defer.resolve(data)
            }, function (error) {
                defer.reject(error)
            });
        return defer.promise;

    }

    Products.prototype.filterProducts= function (filter) {
        var defer = Q.defer();
        var _this = this;
        var userId = app.credentials.getUserId();

        var where={
            category: {
                '$in': [filters.category]
            },
            price: {
                "$gte": filters.minPrice,
                "$lte": filters.maxPrice
            }
        }

        this._requester.get('classes/product?where'+JSON.stringify(where))
            .then(function (data) {
                _this._products['products'].lenght=0;

                $.each(data['results'], function(key, productData){
                    if(productData.name.indexOf(filters.keyword) > -1){
                        var product = {
                            objectId: productData.objectId,
                            name: productData.name,
                            category: productData.category,
                            price: productData.price,
                            owner: userId === productData.user.objectId,
                            createdAt: productData['createdAt']
                        };
                        _this._products['products'].push(product)
                    }
                });
                   defer.resolve(_this._products)
            },function(error){
                defer.reject(error);
            });
        return defer.promise;
    };

    return {
        get: function(ajaxRequester){
            return new Products(ajaxRequester)
        }
    }
}());