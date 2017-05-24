gem a b = (a + b) / 2

verhoog n = n + 1

ing a b = a * b + a / b

cirkeloppervlak r = pi * r^2

opbrengst b n r = b* (1+(r/100))^n

allegelijk a b c = a==b && b==c

alleverschillend a b c = if a==b && b==c && a==c then False else True

derde xs = take 1 (drop 2 xs)

plak3 xs ys zs = xs ++ ys ++ zs

select3 xs = take 7 (drop 2 xs)