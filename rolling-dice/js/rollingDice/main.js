// Put your code here

console.log("Let's roll some dice, baby!");
console.log("---------------------------");


for (let i = 0; i <10; i++){
    let die1 = Roll(dieValue);
    let die2 = Roll(dieValue);

    const message = `${die1} + ${die2} == ${die1 + die2}`
    if ( die1 === die2){
        message += "DOUBLES!"
    }
    console.log(message);

}


const Roll = () => {
    const dieValue = Math.random(1,6)
    return dieValue
}

const dieToString = () => {

    let dieString = ""

if ( Roll === 1){
    dieString = "one";
}
else if ( Roll === 2){
    dieString = "two";
}
else if ( Roll === 3){
    dieString = "three";
}
else if ( Roll === 4){
    dieString = "four";
}
else if ( Roll === 5){
    dieString = "five";
}
else{
    dieString = "six";
}

return dieString;

}