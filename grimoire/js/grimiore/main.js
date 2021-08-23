// Put your code here

console.log("Do you belive in magic?");
console.log("-----------------------");



const evilSpellBook = allSpells.filter(spell.isEvil);
const goodSpellBook = allSpells.filter(!spell.isEvil);

const makeEvilSpellBook = () =>{
    const evilBook ={};
    evilBook.title = "Evil Book",
    evilBook.spells = evilSpellBook 
    return evilBook
}
const makeGoodSpellBook = () =>{
    const goodBook ={};
    evilBook.title = "Good Book",
    evilBook.spells = goodSpellBook 
    return goodBook
}

const DisplaySpellBook = (book) => {
    console.log(book.Title);
    for(spell of book.spells){
        console.log(`${spell.name}`)
    }
}
DisplaySpellBook(goodBook)
console.log("")
DisplaySpellBook(evilBook)

const allSpells = [
    {
        name : "Turn enemy into a newt",
        isEvil : true,
        energyRequired : 5.1
    },
    {
        name : "Conjure some gold for a local charity",
        isEvil : false,
        energyRequired : 2.99
    },
    {
        name : "Give a deaf persomn the ability to heal",
        isEvil : false,
        energyRequired : 12.2
    },
    {
        name : "Make yourself emperor of the universe",
        isEvil : true,
        energyRequired : 100
    },
    {
        name : "Convince your relatives your political views are correct",
        isEvil : fasle,
        energyRequired : 2921.5
    },
]