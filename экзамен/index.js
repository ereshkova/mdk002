let result2 = [];
function index1 (i) {
    let x = Math.pow (i, 2);
    let y = Math.sqrt (i);
    return [x, y];
}
for (let i = -10; i <=10; i++) {
    result2.push (index1(i));
}
console.log("1-", result2);