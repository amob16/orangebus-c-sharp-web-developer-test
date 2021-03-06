﻿String.prototype.capitalise = function () {
    return this.charAt(0).toUpperCase() + this.slice(1);
}
String.prototype.camelCaseToSpineCase = function () {
    // [\s] - handle whitespace
    // or (|)
    // lowercase and numbers (a-z0-9)
    // look ahead and check for uppercase
    // replace with -
    // cast everything to lowercase
    return this.replace(/[\s]+|([a-z0-9])(?=[A-Z])/g, "$1-").toLowerCase();
}
String.prototype.spineCaseToCamelCase = function () { 
    // - or whitespace [-|\s]
    // use . instead of \w to search search for characters only
    return this.replace(/[-|\s](.)/g, function(match, val){
        return val.toUpperCase();
    }).trim();
}
String.prototype.format = function () {
    var args = arguments;
    // find digits bound with braces eg {0}, {1} etc
    return this.replace(/{(\d+)}/g, function (match, number) {
        return args[number];
    });
}