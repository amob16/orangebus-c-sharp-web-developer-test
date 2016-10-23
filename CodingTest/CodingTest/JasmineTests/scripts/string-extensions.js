String.prototype.capitalise = function () {
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
String.prototype.spineCaseToCamelCase = function () { }
String.prototype.format = function () { }