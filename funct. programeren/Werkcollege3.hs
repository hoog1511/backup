--opgave 1 Vind m.b.v. backtracking het (unieke) getal n bestaande uit 9 cijfers, het cijfer moet kunnen worden gedeeld door het nieuwe getal.
--VB: getal 1 in kan gedeeld worden door 1 klopt, getal 2  12 kan gedeeld worden door 2 .... etc
del :: Eq a => [a] -> [a] -> [a]
del xs ys = [y| y <- ys, not(elem y xs)]
--Voorkomt verdubbelingen (dat 2x hetzelfde getal kan voorkomen).
--xs is een lijst van getallen en elem kijkt of zijn getal in lijst xs zit.
--ys is een lijst van getallen die de keuze van getallen aangeeft in een lijst.
--Is hetzelfde als steeds [x1|x1<--[1..9],x1 /= x2]

uniekgetal :: [(Int,Int,Int,Int,Int,Int,Int,Int,Int)]
uniekgetal = [(x1,x2,x3,x4,x5,x6,x7,x8,x9)|
 x1<-[1..9],
 mod x1 1 == 0,
 x2<-(del[x1][1..9]),
 let a = (x1*10)+x2,
 mod a 2 == 0,
 x3<-(del[x1,x2][1..9]),
 let b = (a*10)+ x3,
 mod b 3 == 0,
 x4<-(del[x1,x2,x3][1..9]),
 let c = (b*10) + x4,
 mod c 4 == 0,
 x5<-(del[x1,x2,x3,x4][1..9]),
 let d = (c*10) + x5,
 mod d 5 == 0,
 x6<-(del[x1,x2,x3,x4,x5][1..9]),
 let e = (d*10) + x6,
 mod e 6 == 0,
 x7<-(del[x1,x2,x3,x4,x5,x6][1..9]),
 let f = (e*10) + x7,
 mod f 7 == 0,
 x8<-(del[x1,x2,x3,x4,x5,x6,x7][1..9]),
 let g = (f*10) + x8,
 mod g 8 == 0,
 x9<-(del[x1,x2,x3,x4,x5,x6,x7,x8][1..9]),
 let h = (g*10) + x9,
 mod h 9 == 0]

--opgave 2 magische kubus, alle 4 hoeken van een vlak moeten bij elkaar 18 zijn.
--magiccube :: [(Int,Int,Int,Int,Int,Int,Int,Int,Int)]
magiccube = [(a,b,c,d,e,f,g,h)|
 a <- [1..8],
 b <- (del[a][1..8]),
 c <- (del[a,b][1..8]),
 d <- (del[a,b,c][1..8]),
 a+b+c+d == 18,
 e <- (del[a,b,c,d][1..8]),
 f <- (del[a,b,c,d,e][1..8]),
 a+b+e+f ==18,
 g <-(del[a,b,c,d,e,f][1..8]),
 a+c+e+g ==18,
 h <- (del[a,b,c,d,e,f,g][1..8]),
 b+d+f+h ==18,
 c+d+g+h ==18,
 e+f+g+h ==18]

