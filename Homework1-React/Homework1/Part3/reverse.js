 
 // FİRST METHOD using for loop 

var stringName = "EdaSumer";
console.log(reverseString(stringName));
/*

function reverseString(stringName){
    var newName="";
for(var i=stringName.length-1;i>=0;i--){
  newName = newName + stringName[i];
}

return newName;
}}

*/


// SECOND METHOD  using split ,join and reverse 
/*
function reverseString(stringName){
    let splitString = stringName.split("");
    let newName = splitString.reverse();
    var joinString = newName.join("");
    return joinString;
}
*/

// THİRD METHOD -> using recursive ,is the best solution because it is recursive and minumum takes up memory
/*
function reverseString(stringName){
    if(stringName.length==0)
    return "";
    else
    return reverseString(stringName.slice(1)) + stringName.charAt(0); 
}
*/
// FOURTH METHOD using reduce
function reverseString(stringName) {
    return [...stringName].reduce((accumulator, current) => current + accumulator);
  

  }

