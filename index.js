console.log ("index.js")
let arr = [9,5,3,7,4,5,6,1,8,10];
let A = arr.map((val, i, arr) => i == 0 ? Math.min(...arr) : (i == arr.indexOf(Math.min(...arr)) ? arr[0] : val));
console.log(A);

