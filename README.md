#Pizza API gjord utav Alexander Bertilsson och John Andersson

##Design patterns:
###1. Factory pattern. 

Vi valde att använda oss utav factory pattern för att skapa pizzor och ingredienser. Factory Pattern hjälper oss att göra det
utan att ha för många dependencies och för att koden blir mer DRY.

###2. Visitor Pattern.

När vi ska sätta och uppdatera det totala priset på våra ordrar går vi igenom våra kollektioner av pizzor, ingredienser och drycker och summerar kostnaderna.
Visitor pattern är ett perfekt mönster för att lösa den uppgiften.

###3. Singleton

Våran Cart och OrderStore är vad som hanterar våran state och behöver därav vara utav samma instans överallt i projektet. Singleton löser det åt oss.
