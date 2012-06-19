module("Test Palindrome (tests/tests/test_palindrome.js)");

test("truthyness of positive numbers", function() {
    var oneIsTruthy = 1 ? true : false;
    equal(oneIsTruthy, true, 'is one truthy?');
});

test("palindromeness of 323", function() {
    var actual = validatePalindrome(323)
    equal(actual, true, 'is "323" a palindrome?');
});

test("nonpalindromeness of 532", function() {
    var actual = validatePalindrome(532)
    equal(actual, false, 'is "532" a palindrome?');
});