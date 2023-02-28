# Baigiamasis Darbas

Testuojama svetainė - https://klipshop.lt

**1. Scenarijus** - Produkto puslapio funkcionalumo tikrinimas. 
----------

1. Atvejis: **Produktas prieinamas įsigijimui.** 
    
    1. Žingsnis: Atidaromas produkto puslapis
    2. Žingsnis: Sutinkama su "Slapukų dialogo" langu ir laukiama, kol jis dings *(laukiama, kol atsiras "Sutinku" mygtukas; jam atsiradus, jis nuspaudžiamas; laukiama, kol dings lango fono užsklanda)*
    3. Žingsnis. Langas paslenkamas žemyn, kad matytųsi norimas tikrinti elementas ("Prekės šiuo metu neturime")
    4. Žingsnis. Laukiama, kol norimas elementas atsiras puslapyje (iki 10s) ir grąžinama jo būsena - atsirado arba ne
    
    **Laukiamas rezultatas:** "Prekės šiuo metu nėra" elementas neatsirado (False).
        

2. Atvejis: **Sėkmingai pridėti produktą į krepšelį.**
    
    1. Žingsnis: Atidaromas produkto puslapis
    2. Žingsnis: Sutinkama su "Slapukų dialogo" langu ir laukiama, kol jis dings *(laukiama, kol atsiras "Sutinku" mygtukas; jam atsiradus, jis nuspaudžiamas; laukiama, kol dings lango fono užsklanda)*
    3. Žingsnis. Gaunamas šiuo metu krepšelyje esančių produktų kiekis.
    4. Žingsnis. Langas paslenkamas žemyn, kad matytųsi norimas tikrinti elementas ("Prekės šiuo metu neturime").
    5. Žingsnis. Laukiama, kol norimas elementas atsiras puslapyje (iki 10s) ir grąžinama jo būsena - atsirado arba ne.
    6. Žingsnis. Esant galimybei produktą įsigyti, spaudžiamas mygtukas "Dėti į krepšelį".
    7. Žingsnis. Uždaromas atsidaręs langas pasirinkimo langas (laukiama, kol bus matomas "Tęsti apsipirkimą" mygtukas,  o jam atsiradus, jis nuspaudžiamas)
    8. Žingsnis. Langas paslenkamas į patį viršų.
    9. Žingsnis. Gaunamas šiuo metu krepšelyje esantis produktų skaičius
    
    **Laukiamas rezultatas:** Šiuo metu krepšelyje esančių produktų skaičius yra didesnis už prieš tai buvusį produktų skaičių (items after > items before).
    

**2. Scenarijus** - Paieškos funkcionalumo tikrinimas. 
----------

1. Atvejis: **Rodomi rekomenduojami produktai paieškos laukelyje įvedus paieškos frazę.** 
    
    1. Žingsnis: Atidaromas pradinis puslapis
    2. Žingsnis: Sutinkama su "Slapukų dialogo" langu ir laukiama, kol jis dings *(laukiama, kol atsiras "Sutinku" mygtukas; jam atsiradus, jis nuspaudžiamas; laukiama, kol dings lango fono užsklanda)*
    3. Žingsnis. Į paieškos laukelį įvedama paieškos frazė
    4. Žingsnis. Laukiama, kol atsiras rekomenduojamus produktus talpinantis elementas.
    5. Žingsnis. Gaunamas rekomenduojamų produktų skaičius.
    
    **Laukiamas rezultatas:** Rekomenduojamų produktų skaičius yra daugiau nei 0.
        

2. Atvejis: **Paieška sėkmingai grąžina rezultatus** 
    
    1. Žingsnis: Atidaromas produkto puslapis
    2. Žingsnis: Sutinkama su "Slapukų dialogo" langu ir laukiama, kol jis dings *(laukiama, kol atsiras "Sutinku" mygtukas; jam atsiradus, jis nuspaudžiamas; laukiama, kol dings lango fono užsklanda)*
    3. Žingsnis. Į paieškos laukelį įvedama paieškos frazė
    4. Žingsnis. Spaudžiamas paieškos mygtukas
    5. Žingsnis. Laukiama, ar atsidarodo paieškos rezultatai
    6. Žingsnis. Grąžinamas atsiradusių paieškos rezultatų skaičius.
    
    **Laukiamas rezultatas:** Paieškos rezultatų skaičius yra didesnis už 0.
        
   

**3. Scenarijus** - Prekių krepšelio dalinimos funkcionalumo tikrinimas. 
----------

1. Atvejis: **Rodoma prekių krepšelio nuoroda.** 
    
    1. Žingsnis: Atidaromas produkto puslapis
    2. Žingsnis: Sutinkama su "Slapukų dialogo" langu ir laukiama, kol jis dings *(laukiama, kol atsiras "Sutinku" mygtukas; jam atsiradus, jis nuspaudžiamas; laukiama, kol dings lango fono užsklanda)*
    3. Žingsnis. Tikrinama, ar produktą galima pridėti į krepšelį (laukiama, ar atsiras "Prekės šiuo metu nėra" elementas)
    6. Žingsnis. Esant galimybei produktą įsigyti, spaudžiamas mygtukas "Dėti į krepšelį".
    7. Žingsnis. Laukiama, kol atsidariusiame pasirinkimo lange bus matomas "Žiūrėti krepšelį" mygtukas, o jam atsiradus, jis nuspaudžiamas.
    8. Žingsnis. Laukiama, kol atsiras "Dalintis krepšeliu" mygtukas ir jis nuspaudžiamas
    9. Žingsnis. Laukiama, kol atsiras "Dalintis" mygtukas.
    10. Žingsnis. Tikrinama, ar atsirado įvesties laukelis su pirkinių krepšelio nuoroda.

    
    **Laukiamas rezultatas:** Laukelis su pirkinių krepšelio nuoroda egzistuoja.
    
