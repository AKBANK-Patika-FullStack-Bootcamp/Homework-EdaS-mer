const arr = [2,3,4]; // dec array 
var res; // result variable  
console.log(arr); // print normal array 
console.log("girlsPower function is called."); //print
//console.log("cikti",girlsPower(arr));
let girlsPowerToplama = num =>{ // A function that divides the incoming number by two, adds three, and returns the result.
    num = (num/2)+3;
    return num;
}

function girlsPower(arr){
arr.forEach(number => {
    res = arr.map(number=> girlsPowerToplama(number)) // go to girlspowerToplama function each element of array 
});
return res;
}
console.log("cikti : ",girlsPower(arr)); // go to girlsPower func then print to result to the screen .

