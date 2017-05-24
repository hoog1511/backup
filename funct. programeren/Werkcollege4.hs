--Opgave 1. Definieer een functie remove n xs die alle voorkomens van n uit xs verwijdert
--hierbij pakt hij in de else alle waarden die niet overeenkomen en stopt ze in x. 
--alles dat wel overeenkomt wordt weggegooit.
remove :: (Eq a) => a->[a]->[a]
remove n [] = [] --voor als de lijst leeg is
remove n (x:xs) = if n==x then remove n xs else [x] ++ remove n xs

--Definieer ook een functie removeOnce n xs die alleen het eerste voorkomen van n uit xs verwijdert.
removeOnce :: (Eq a) => a->[a]->[a]
removeOnce n [] = []
removeOnce n (x:xs) = if n==x then xs else [x] ++ removeOnce n xs -- then xs is omdat xs al e rest van het lijstje (x:xs) is.

--Opgave 2. Definieer een functie subset xs ys die True teruggeeft als xs een deelverzameling is van ys. 
--Maak hierbij gebruik van de gedefinieerde functie elem x xs die vaststelt of een
--element in een lijst voorkomt.
subset :: (Eq a) => [a]->[a]->Bool
subset [] ys = True
subset xs [] = False
subset (x:xs) ys = if not (elem x ys) then False else subset xs ys -- xs wordt aan het eind de nieuwe (x:xs), geen (x:ys) omdat we met elem al door geheel ys gaan om met x te checken.

--Opgave 3. Definieer de functie myLast die het laatste element van een niet lege lijst teruggeeft.
mylast :: [a] -> a
mylast [x] = x
mylast (x:xs) = mylast xs -- (1:[1..10]) = (2:[2..10]) = (3:[3..10])

--Opgave 4. Definieer een functie langstebeginplateau xs die van een lijst het langste beginstuk geeft van elementen die gelijk zijn aan het eerste element.
-- > langstebeginplateau [1,2,3]
--[1]
-- > langstebeginplateau [1,1,1,1,2,3]
--[1,1,1,1]
langsteBeginPlateau :: (Eq a) => [a] -> [a]
langstebeginplateau [] = []
langstebeginplateau [x] = x
langsteBeginPlateau (x:xs) = if x == head xs then [x] ++ langsteBeginPlateau xs else [x] -- voegt continu x toe aan de lijst [x] wanneer deze overeenkomt met head xs.

--Opgave 5. Definieer de functies bintonum en numtobin voor conversie tussen decimale en binaire
--getallen. Een binair getal wordt gerepresenteerd door een lijst van nullen en enen.
numToBin :: Int -> [Int]
numToBin 0 = [0]
numToBin 1 = [1]
numToBin n = (numToBin (quot n 2)) ++ [mod n 2] -- hij deelt het gegeven getal door 2 en rond het af naar 0, hiernaast telt hij het overige getal van het gegeven getal delen door 2.
--nb 13 = (nb (quot 13 2 = 6) ++ [mod 13 2 = 1] => (nb(quot 6 2 = 3) ++ (mod 6 2 = 0) => (nb(quit 3 2 = 1) => (mod 3 2 = 1) Dan roept hij numtobin 1 = [1] aan.
-- recursie print van achter naar voor  omdat er recursie + iets wordt gedaan [1,1,0,1]. iets+recursie = van voor naar achter printen.
bintonum [] = 0
binToNum (x:xs) = if x == 1 then 2^(length xs) + binToNum xs else binToNum xs
-- 2^3,2^2,2^1,2^0. bij de 4de keer is xs [], dan gebruikt hij [] = 0.


--Opgave 6 Gegeven is dat de functie insert een getal op de juiste plaats in een gesorteerde lijst invoegt
--Geef zelf een recursieve definitie van insert. Vul hiertoe onderstaande definitie aan:
insert :: (Ord a) => a -> [a] -> [a]
insert x [] = [x]
insert x (y:ys) = if x <= y then [x,y] ++ ys else [y] ++ insert x ys
--bvb 3 [1,2,3,4] = [1] ++ [2] ++( [3,3] ++[4] ). bvb -1 [1,2,3,4] = [-1,1]++[2,3,4]

--We kunnen een lijst nu sorteren door te beginnen met een lege lijst er daar één voor één de
--elementen van de te sorteren lijst in te inserteren. Vul nu de onderstaande definitie weer aan:

isort :: (Ord a) => [a] -> [a]
isort [] = []
isort (x:xs) = insert x (isort xs)
-- isort(9:[5,7] => eerst kijken wat de functie doet dus isort gaat voor, aan het eind 7,[] geeft van insert 7 terug. 
-- daarna insert 5 [7] geeft [5,7] terug, 9 [5,7] = [5]++[7]++ dan wordt
-- insert x [] = [x] aangeroepen dus  [9] levert op [5,6,7].

--Opgave 7. Mergen is het samenvoegen van twee gesorteerde lijsten tot één gesorteerde lijst.
--Voltooi de onderstaande definitie van merge:
merge :: (Ord a) => [a] -> [a] -> [a]
merge xs [] = xs
merge [] ys = ys
merge (x:xs) (y:ys) = if x < y then [x] ++ merge xs (y:ys) else [y] ++ merge (x:xs) ys
-- [1:2,3] [4:5,6] => 1<4 True, [1]++ merge [2:3] levert uiteindelijk [1]++[2]++[3]++ op dan [] ys = ys = [1,2,3,4,5,6]
-- [4:5,6] [1:2,3] => 4<1 False, [1]++[2}++[3]++ op dan xs [] = xs dus [1]++[2}++[3]++ xs = [1,2,3,4,5,6]

--Bij msort wordt de lijst steeds in tweeën verdeeld waarna de twee helften worden gesorteerd en daarna gemerged. 
--Het sorteren van de twee helften gebeurt ook weer door deze in tweeën te verdelen en daarna de helften weer te sorteren en te mergen. 
--Dit in tweeën delen gaat net zolang door tot de overgebleven lijsten lengte 0 of 1 hebben gekregen. 
--Aan dit soort lijsten valt natuurlijk niet veel te sorteren. Voltooi nu de onderstaande definitie van msort:
msort [] = []
msort [x] = [x]
msort xs = … (take m xs) … (drop m xs) where m = …
msort xs = merge (msort (take m xs)) (msort (drop m xs)) where m = div (length xs) 2 
-- hier worden de take m en de xs (zonder m) de xs/ys van merge.
--merge (take m xs)(drop m xs)
