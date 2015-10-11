function extractContent(str){
    return str.replace(/<(?:.|\n)*?>/gm, '');
}
 console.log(extractContent("<p>Hello</p><a href='http://w3c.org'>W3C</a>"));
