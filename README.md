# Baigiamasis Darbas

Testuojama svetainė - https://klipshop.lt

**1. Scenarijus** - Produkto puslapio funkcionalumo tikrinimas. 

1. Atvejis: *Produktas prieinamas įsigijimui.* 
    
    1. Žingsnis: Atidaromas produkto puslapis
    2. Žingsnis: Sutinkama su "Slapukų dialogo" langu ir laukiama, kol jis dings *(laukiama, kol atsiras "Sutinku" mygtukas; jam atsiradus, jis nuspaudžiamas; laukiama, kol dings lango fono užsklanda)*
    3. Žingsnis. Langas paslenkamas žemyn, kad matytųsi norimas tikrinti elementas ("Prekės šiuo metu neturime")
    4. Žingsnis. Laukiama, kol norimas elementas atsiras puslapyje (iki 10s) ir grąžinama jo būsena - atsirado arba ne
    
    **Laukiamas rezultatas:** "Prekės šiuo metu nėra" elementas neatsirado (False).
        
