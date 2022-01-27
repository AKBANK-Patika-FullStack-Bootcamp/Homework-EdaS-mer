const myDog = require("./kopek");
const kopekBakimi = require("./kopekBakimiUtility");
kopekBakimi.kopekTemizleme();
console.log("köpek ilgi saati : ",(myDog.kopekKilosu*kopekBakimi.kopekBakimSaati+"kg"));

