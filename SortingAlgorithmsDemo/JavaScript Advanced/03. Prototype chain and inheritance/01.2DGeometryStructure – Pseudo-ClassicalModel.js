Object.prototype.extends= function (parent) {
    this.prototype = Object.create(parent.prototype);
    this.prototype.constructor = this;
};

var Coords = (function () {
    function Coords(x, y){
        this._x = x;
        this._y = y;
    }
    Coords.prototype.toString = function () {
        return "(x: " + this._x + ", y: " + this._y + ")";
    }
    return Coords;
})();

var ShapesModule = (function () {

    var Shape = (function () {
    function Shape(point, colour) {
        this._point = point;
        this._colour = colour;
    }

    Shape.prototype.toString = function () {
        return "my color is " + this._colour + ", my point A has coords " + this._point.toString();
    };

    return Shape;
    }());

    var Circle = (function () {
       function Circle(pointO, colour, r){
           Shape.call(this,pointO,colour);
            this._r= r;
       }
        Circle.extends(Shape);

        Circle.prototype.toString= function () {
            var parentToString = Shape.prototype.toString.call(this);
            return "I'm circle, " + parentToString + " and my radius is " + this._r + ".";
        };
        return Circle;
    })();

    var Rectangle = (function () {
       function Rectangle(pointA, width, height, colour){
           Shape.call(this, pointA, colour);
            this._width= width;
            this._height = height;
       }
        Rectangle.extends(Shape);

        Rectangle.prototype.toString = function () {
            var parentToString = Shape.prototype.toString.call(this);
            return "I'm rectangle, " + parentToString + ", my width is " + this._width + " and my height is " + this._height + ".";
        };
        return Rectangle;
    })();

    var Triangle = (function () {
        function Triangle(pointA, colour, pointB, pointC ){
            Shape.call(this, pointA, colour);
            this._pointB = pointB;
            this._pointC= pointC;
        }

        Triangle.extends(Shape);

        Triangle.prototype.toString = function () {
            var parentToString = Shape.prototype.toString.call(this);
            return "I'm triangle, " + parentToString + ", my point B has coords " + this._pointB.toString() + " and my point C has coords " + this._pointC.toString() + ".";
        };
        return Triangle;
    })();

    var Line = (function () {
        function Line(pointA, pointB, colour){
            Shape.call(this, pointA,colour);
            this._pointB = pointB
        }

        Line.extends(Shape);

        Line.prototype.toString = function () {
            var parentToString = Shape.prototype.toString.call(this);
            return  "I'm line, " + parentToString + ", my point B has coords " + this._pointB.toString() + ".";
        };
        return Line;
    })();

    var Segment = (function () {
        function Segment(pointA, pointB, colour){
            Shape.call(this, pointA, colour);
            this._pointB = pointB
        }

        Line.extends(Shape);

        Segment.prototype.toString = function () {
            var parentToString = Shape.prototype.toString.call(this);
            return "I'm segment, " + parentToString + ", my point B has coords " + this._pointB.toString() + ".";
        };
        return Segment;
    })();

    return {
        Circle: Circle,
        Rectangle: Rectangle,
        Triangle: Triangle,
        Line: Line,
        Segment: Segment
    }
})();

var circle = new ShapesModule.Circle(new Coords(5, 10), "#f00", 5);
var rectangle = new ShapesModule.Rectangle(new Coords(6, 3), "#0ff", 20, 40);
var triangle = new ShapesModule.Triangle(new Coords(2, 4.5), "#05f", new Coords(-6, 7.3), new Coords(9.23, 5.449));
var line = new ShapesModule.Line(new Coords(5.7, 3.14), "#f0f", new Coords(2.23, -3.14));
var segment = new ShapesModule.Segment(new Coords(3.56, 1.23), "#00f", new Coords(9.87, -4.56));


console.log(circle.toString() + "\n");
console.log(rectangle.toString() + "\n");
console.log(triangle.toString() + "\n");
console.log(line.toString() + "\n");
console.log(segment.toString() + "\n");