--opgave 1 gooi xs lijst erin, x+1 geeft hij terug, x<-xs is de conditie.
verhoog :: [Int] -> [Int]
verhoog xs = [x+1|x<-xs]

--opgave 2 geeft een som terug van een lijst van x^2 die niet langer mag zijn dan de lijst van 1 t/m n.
sumsqr :: Int -> Int
sumsqr n = sum[x^2|x<-[1..n]]

--opgave 3 geeft een lijst door van getallen,ider getal in de lijst wordt x*1,x*2,x*3 teruggegeven, de lijst moet even lang zijn als de gegeven lijst X de lengte van hiervan.
vervang :: [Int] -> [Int]
vervang xs = [x*y|x<-xs,y<-[1..3]]

--opgave 4a geeft een lijst van d terug wanneer n/d geen restwaarde heeft vb n=10, 10/1 10/2 10/5 worden teruggegeven de rest niet.
-- bij n=5 of n=7 blijven er restwaardes tenzij het door 1 of zichzelf wordt gedeelt. hierbij krijg je dus 2 aantwoorden terug.
delers :: Int -> [Int]
delers n = [d|d<-[1..n],mod n d == 0]

--opgave 4b wanneer er maar 2 antwoorden uit delers n komt dan klopt het.
priemgetal :: Int -> Bool
priemgetal n = length(delers n) == 2

--opgave 4c 6 = 1+2+3 = perfect gelijk aan de delers. init geeft alles terug behalve het laatste getal. zonder de init zou hij het getal zelf ook teruggeven.
perfect :: Int -> Bool
perfect n = If sum(init(delers n)) == n Then True Else n+1

--opgave 4d geeft het grootste deelbare getal terug waar n en m door gedeeld kunnen worden bvb n=10 m=20 dan is ht grootste antwoord mogelijk 10.
-- m of n kan ook veel groter zijn dan de ander dus meer deelbare getallen hebben het x==y gedeelte zorgt ervoor dat hij alleen het overeenkomende deel terug geeft.
ggd :: Int-> Int-> Int
ggd n m = last [x|x<-(delers n),y<-(delers m),x == y]

--opgave 5 Definieer een functie pythagoras n die voor gegeven n een lijst van alle pythagorische drietallen (x,y,z) met x,y,z tussen 1 en n berekent. 
--Voor x,y,z moet dus gelden x^2 + y^2 = z^2. Denk om de efficiency, elk drietal mag maar een keer voorkomen. () is een tuple
pythagoras :: Int -> [(Int,Int,Int)]
pythagoras n = [(x,y,z)|x<-[1..n],y<-[x..n],z<-[y..n],(x^2)+(y^2)==(z^2)]

--opgave 6 Definieer een functie die twee teksten vergelijkt en de indices teruggeeft waarop beide teksten dezelfde letter bevatten. 
--Hierbij begint de index te tellen vanaf 0. Voorbeeld:*Main> dezelfdeLetter "hello world" "hallo wereld"[0,2,3,4,5,6,8]
--een string is een lijst van karakters!!!, hij zet de waarde van xs in a en ys in b, door de zip3 loop hij alle 3 componenten tegelijk door,wanneer a==b dan wordt i terug gegeven.
dezelfdeletters :: (Eq a) => [a] -> [a] -> [Int]
dezelfdeletters xs ys = [i|(a,b,i)<-zip3 xs ys [0..], a == b]

--opgave 7 Schrijf een functie die kijkt of een meegegeven string een weekdag is (maandag … zondag)en die bij iedere dag een beschrijving geeft. 
--Gebruik hierbij pattern matching. Voorbeeld:*Main> weekdag "zondag""Weekend!
weekdag :: String -> String
weekdag "zondag" = "Weekend!"
weekdag "zaterdag" = "Weekend!"
weekdag "vrijdag" = "Bijna weekend!"
weekdag x = "Werkdag!"
