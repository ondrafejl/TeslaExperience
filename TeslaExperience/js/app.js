//promenna ridicka pro zjisteni zda cena bude pro ridice(1) nebo pasazera(0)
var ridicka = true;
//promenna teslicka pro zjisteni zda cena bude pro performance(1) nebo basic(0)
var teslicka = false;
//promenna misto pro zjisteni mista vyzvednuti
var misto = "SPŠE Ječná";

//metoda pro zmenu ridice 
function driver(){
    //nastavit nacenění pro řidiče
    ridicka = true;
    //spočítat cenu
    spocti();
    //nastavim cerne pozadi a bily text ridicovi
    var driverDiv = document.getElementById("registration-driver");
    driverDiv.style.color = "white";
    driverDiv.style.backgroundColor = "black";
    //nastavím bile pozadi a cerny text pasazerovi
    var passengerDiv = document.getElementById("registration-passenger");
    passengerDiv.style.color = "black";
    passengerDiv.style.backgroundColor = "white";
    //přidání eventlisteneru aby tlacitka vypadala jako tlacitka
    var puvodniBarva1 = driverDiv.style.backgroundColor;
    driverDiv.addEventListener("mouseenter", function() {
        driverDiv.style.backgroundColor = "darkgray";
    });
    driverDiv.addEventListener("mouseleave", function() {
        driverDiv.style.backgroundColor = puvodniBarva1;
    });
    driverDiv.addEventListener("mousedown", function() {
        driverDiv.style.backgroundColor = "gray";
    });
    var puvodniBarva2 = passengerDiv.style.backgroundColor;
    passengerDiv.addEventListener("mouseenter", function() {
        passengerDiv.style.backgroundColor = "darkgray";
    });
    passengerDiv.addEventListener("mouseleave", function() {
        passengerDiv.style.backgroundColor = puvodniBarva2;
    });
    passengerDiv.addEventListener("mousedown", function() {
        passengerDiv.style.backgroundColor = "gray";
    });
}

//metoda pro zmenu pasažéra
function passenger(){
    //nastavit nacenění pro řidiče
    ridicka = false;
    //spočítat cenu
    spocti();
    //nastavím bile pozadi a cerny text ridicovi
    var driverDiv = document.getElementById("registration-driver");
    driverDiv.style.color = "black";
    driverDiv.style.backgroundColor = "white";
    //nastavím cerne pozadi a bily text pasazerovi
    var passengerDiv = document.getElementById("registration-passenger");
    passengerDiv.style.color = "white";
    passengerDiv.style.backgroundColor = "black";
    //přidání eventlisteneru aby tlacitka vypadala jako tlacitka
    var puvodniBarva1 = driverDiv.style.backgroundColor;
    driverDiv.addEventListener("mouseenter", function() {
        driverDiv.style.backgroundColor = "darkgray";
    });
    driverDiv.addEventListener("mouseleave", function() {
        driverDiv.style.backgroundColor = puvodniBarva1;
    });
    driverDiv.addEventListener("mousedown", function() {
        driverDiv.style.backgroundColor = "gray";
    });
    var puvodniBarva2 = passengerDiv.style.backgroundColor;
    passengerDiv.addEventListener("mouseenter", function() {
        passengerDiv.style.backgroundColor = "darkgray";
    });
    passengerDiv.addEventListener("mouseleave", function() {
        passengerDiv.style.backgroundColor = puvodniBarva2;
    });
    passengerDiv.addEventListener("mousedown", function() {
        passengerDiv.style.backgroundColor = "gray";
    });
}

//metoda pro zmenu na performance
function performance(){
    //nastavit nacenění pro performance
    teslicka = true;
    //spočítat cenu
    spocti();
    //nastavim cerne pozadi a bily text performance
    var performanceDiv = document.getElementById("registration-performance");
    performanceDiv.style.color = "white";
    performanceDiv.style.backgroundColor = "black";
    //nastavím bile pozadi a cerny text basicu
    var basicDiv = document.getElementById("registration-basic");
    basicDiv.style.color = "black";
    basicDiv.style.backgroundColor = "white";
    //přidání eventlisteneru aby tlacitka vypadala jako tlacitka
    var puvodniBarva1 = performanceDiv.style.backgroundColor;
    performanceDiv.addEventListener("mouseenter", function() {
        performanceDiv.style.backgroundColor = "darkgray";
    });
    performanceDiv.addEventListener("mouseleave", function() {
        performanceDiv.style.backgroundColor = puvodniBarva1;
    });
    performanceDiv.addEventListener("mousedown", function() {
        performanceDiv.style.backgroundColor = "gray";
    });
    var puvodniBarva2 = basicDiv.style.backgroundColor;
    basicDiv.addEventListener("mouseenter", function() {
        basicDiv.style.backgroundColor = "darkgray";
    });
    basicDiv.addEventListener("mouseleave", function() {
        basicDiv.style.backgroundColor = puvodniBarva2;
    });
    basicDiv.addEventListener("mousedown", function() {
        passengerDiv.style.backgroundColor = "gray";
    });
}

//metoda pro zmenu na performance
function basic(){
    //nastavit nacenění pro performance
    teslicka = false;
    //spočítat cenu
    spocti();
  //nastavím bile pozadi a cerny text performance
    var performanceDiv = document.getElementById("registration-performance");
    performanceDiv.style.color = "black";
    performanceDiv.style.backgroundColor = "white";
    //nastavím cerne pozadi a bily text basicu
    var basicDiv = document.getElementById("registration-basic");
    basicDiv.style.color = "white";
    basicDiv.style.backgroundColor = "black";
    //přidání eventlisteneru aby tlacitka vypadala jako tlacitka
    var puvodniBarva1 = performanceDiv.style.backgroundColor;
    performanceDiv.addEventListener("mouseenter", function() {
        performanceDiv.style.backgroundColor = "darkgray";
    });
    performanceDiv.addEventListener("mouseleave", function() {
        performanceDiv.style.backgroundColor = puvodniBarva1;
    });
    performanceDiv.addEventListener("mousedown", function() {
        performanceDiv.style.backgroundColor = "gray";
    });
    var puvodniBarva2 = basicDiv.style.backgroundColor;
    basicDiv.addEventListener("mouseenter", function() {
        basicDiv.style.backgroundColor = "darkgray";
    });
    basicDiv.addEventListener("mouseleave", function() {
        basicDiv.style.backgroundColor = puvodniBarva2;
    });
    basicDiv.addEventListener("mousedown", function() {
        basicDiv.style.backgroundColor = "gray";
    });
}

//metoda pro spočítání ceny
function spocti(){
    //promenna ceny
    var price = 0;
    //logika pocitani ceny
    if (ridicka === true) {
        price += 2500;
    }else if (ridicka === false) {
        price += 1500;
    }
    if(teslicka === true) {
        price += 1000;
    } else if (teslicka === false) {
        price += 600;
    }
    //konecne zapsani ceny do promenne
    var result = "Cena: " + price + " Kč";
    //zverejneni ceny na stranku
    document.getElementById("price-value").innerHTML = result;
}


//vybirani mista vyzvednuti place 1
function place1(){
    //nastavit nacenění pro performance
    misto = "SPŠE Ječná";
  //nastavím cerne pozadi a bily text place1
    var place1Div = document.getElementById("registration-place1");
    place1Div.style.color = "white";
    place1Div.style.backgroundColor = "black";
    //nastavím bile pozadi a cerny text place2
    var place2Div = document.getElementById("registration-place2");
    place2Div.style.color = "black";
    place2Div.style.backgroundColor = "white";
    //nastavím bile pozadi a cerny text place2
    var place3Div = document.getElementById("registration-place3");
    place3Div.style.color = "black";
    place3Div.style.backgroundColor = "white";
    //přidání eventlisteneru aby tlacitka vypadala jako tlacitka
    var puvodniBarva1 = place1Div.style.backgroundColor;
    place1Div.addEventListener("mouseenter", function() {
        place1Div.style.backgroundColor = "darkgray";
    });
    place1Div.addEventListener("mouseleave", function() {
        place1Div.style.backgroundColor = puvodniBarva1;
    });
    place1Div.addEventListener("mousedown", function() {
        place1Div.style.backgroundColor = "gray";
    });
    var puvodniBarva2 = place2Div.style.backgroundColor;
    place2Div.addEventListener("mouseenter", function() {
        place2Div.style.backgroundColor = "darkgray";
    });
    place2Div.addEventListener("mouseleave", function() {
        place2Div.style.backgroundColor = puvodniBarva2;
    });
    place2Div.addEventListener("mousedown", function() {
        place2Div.style.backgroundColor = "gray";
    });
    var puvodniBarva3 = place3Div.style.backgroundColor;
    place3Div.addEventListener("mouseenter", function() {
        place3Div.style.backgroundColor = "darkgray";
    });
    place3Div.addEventListener("mouseleave", function() {
        place3Div.style.backgroundColor = puvodniBarva3;
    });
    place3Div.addEventListener("mousedown", function() {
        place3Div.style.backgroundColor = "gray";
    });
}

//vybirani mista vyzvednuti place 2
function place2(){
    //nastavit nacenění pro performance
    misto = "Nádraží Libeň";
  //nastavím bile pozadi a cerny text place1
    var place1Div = document.getElementById("registration-place1");
    place1Div.style.color = "black";
    place1Div.style.backgroundColor = "white";
    //nastavím cerne pozadi a bily text place2
    var place2Div = document.getElementById("registration-place2");
    place2Div.style.color = "white";
    place2Div.style.backgroundColor = "black";
    //nastavím bile pozadi a cerny text place3
    var place3Div = document.getElementById("registration-place3");
    place3Div.style.color = "black";
    place3Div.style.backgroundColor = "white";
    //přidání eventlisteneru aby tlacitka vypadala jako tlacitka
    var puvodniBarva1 = place1Div.style.backgroundColor;
    place1Div.addEventListener("mouseenter", function() {
        place1Div.style.backgroundColor = "darkgray";
    });
    place1Div.addEventListener("mouseleave", function() {
        place1Div.style.backgroundColor = puvodniBarva1;
    });
    place1Div.addEventListener("mousedown", function() {
        place1Div.style.backgroundColor = "gray";
    });
    var puvodniBarva2 = place2Div.style.backgroundColor;
    place2Div.addEventListener("mouseenter", function() {
        place2Div.style.backgroundColor = "darkgray";
    });
    place2Div.addEventListener("mouseleave", function() {
        place2Div.style.backgroundColor = puvodniBarva2;
    });
    place2Div.addEventListener("mousedown", function() {
        place2Div.style.backgroundColor = "gray";
    });
    var puvodniBarva3 = place3Div.style.backgroundColor;
    place3Div.addEventListener("mouseenter", function() {
        place3Div.style.backgroundColor = "darkgray";
    });
    place3Div.addEventListener("mouseleave", function() {
        place3Div.style.backgroundColor = puvodniBarva3;
    });
    place3Div.addEventListener("mousedown", function() {
        place3Div.style.backgroundColor = "gray";
    });
}

//vybirani mista vyzvednuti place 3
function place3(){
    //nastavit nacenění pro performance
    misto = "Fortuna Arena";
  //nastavím bile pozadi a cerny text place1
    var place1Div = document.getElementById("registration-place1");
    place1Div.style.color = "black";
    place1Div.style.backgroundColor = "white";
    //nastavím bile pozadi a cerny text place2
    var place2Div = document.getElementById("registration-place2");
    place2Div.style.color = "black";
    place2Div.style.backgroundColor = "white";
    //nastavím cerny pozadi a bily text place3
    var place3Div = document.getElementById("registration-place3");
    place3Div.style.color = "white";
    place3Div.style.backgroundColor = "black";
    //přidání eventlisteneru aby tlacitka vypadala jako tlacitka
    var puvodniBarva1 = place1Div.style.backgroundColor;
    place1Div.addEventListener("mouseenter", function() {
        place1Div.style.backgroundColor = "darkgray";
    });
    place1Div.addEventListener("mouseleave", function() {
        place1Div.style.backgroundColor = puvodniBarva1;
    });
    place1Div.addEventListener("mousedown", function() {
        place1Div.style.backgroundColor = "gray";
    });
    var puvodniBarva2 = place2Div.style.backgroundColor;
    place2Div.addEventListener("mouseenter", function() {
        place2Div.style.backgroundColor = "darkgray";
    });
    place2Div.addEventListener("mouseleave", function() {
        place2Div.style.backgroundColor = puvodniBarva2;
    });
    place2Div.addEventListener("mousedown", function() {
        place2Div.style.backgroundColor = "gray";
    });
    var puvodniBarva3 = place3Div.style.backgroundColor;
    place3Div.addEventListener("mouseenter", function() {
        place3Div.style.backgroundColor = "darkgray";
    });
    place3Div.addEventListener("mouseleave", function() {
        place3Div.style.backgroundColor = puvodniBarva3;
    });
    place3Div.addEventListener("mousedown", function() {
        place3Div.style.backgroundColor = "gray";
    });
}