var validatePalindrome = function(potentialPalindrome) {
	var v1 = potentialPalindrome.toString();
	var v2 = potentialPalindrome.toString().reverse();
	if (v1 === v2) return true;
	return false;
}

/* Surprise! There isn't an out-of-the-box "reverse" function */
String.prototype.reverse = function(){
	splitext = this.split("");
	revertext = splitext.reverse();
	reversed = revertext.join("");
	return reversed;
}

var largestPalindromeOfTwoHundreds = function() {
	var largestPalindrome = 0;
	for (var i=100; i < 1000; i++) {
		for (var j = i; j < 1000; j++){
			var k = i*j;
			if(validatePalindrome(k)){
				if (k > largestPalindrome){
					largestPalindrome = k;		
				}				
				// debugging!
				// document.write("<p>" + i + " * " + j + " = " + k + "</p>");
			}
		}
	}
	return largestPalindrome;
}


var printLargePalindrome = function(){
	document.getElementById("palindrome").innerHTML = largestPalindromeOfTwoHundreds();
}
