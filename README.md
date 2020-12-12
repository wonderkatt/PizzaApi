### Pizza API gjord utav Alexander Bertilsson och John Andersson

# Design patterns:
### 1. Factory pattern. 

Vi valde att använda oss utav factory pattern för att skapa pizzor och ingredienser. Factory Pattern hjälper oss att göra det
utan att ha för många dependencies och för att koden blir mer DRY.

### 2. Visitor Pattern.

När vi ska sätta och uppdatera det totala priset på våra ordrar går vi igenom våra kollektioner av pizzor, ingredienser och drycker och summerar kostnaderna.
Visitor pattern är ett perfekt mönster för att lösa den uppgiften.

### 3. Singleton

Våran Cart och OrderStore är vad som hanterar våran state och behöver därav vara utav samma instans överallt i projektet. Singleton löser det åt oss.

# Exempel på requests:
#### Visar alla varor på menyn med tillhörande Id:n för att kunna beställa dem
    GET /Menu
#### Visar innehållet i kundvagnen
    GET /Cart
#### Lägger till en Margerita med skinka och svamp samt två coca-cola och en fanta.
    POST /Cart
    {
        "pizzas":[{
                "id": 1,
                "extraIngredients": [1, 3]
            }],
        "drinks": [1, 1, 2]
    }

#### Lägger till skinka på pizzan med id i kundvagnen. Finns det redan extra ingredienser så ersätts de med listan man skickar in här. 
    PATCH /Cart
    {
        "pizzas":[{
                "id": 0,
                "extraIngredients": [1]
            }]
    }
#### Tar bort varor med motsvarande Id från kundvagnen
    DELETE /Cart
    {
      "pizzaIds": [0,2],
      "drinkIds": [0]
    }
#### Visar alla aktiva ordrar 
    GET /Order
#### Sparar innehållet i kundvagnen och lägger det som en aktiv order i minnet
    POST /Order
#### Uppdaterar status på order med givet id. True sätter status till completed och False sätter status till cancelled 
    PATCH /Order
    {
      "id": 0,
      "orderSuccessful": true
    }
