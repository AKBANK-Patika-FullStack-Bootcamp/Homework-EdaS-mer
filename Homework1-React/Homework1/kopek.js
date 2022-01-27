const myDog = {
    kopekAdi :"Corap",
    kopekBoyu :"51 cm",
    kopekKilosu:"5"
};
 
const {kopekAdi,kopekBoyu,kopekKilosu} = myDog;

let kopekBilgi=()=> {
    console.log(`köpek adi : ${kopekAdi}`);
    console.log(`köpek boyu : ${kopekBoyu}`)
}


module.exports = kopekBilgi();
module.exports =myDog;