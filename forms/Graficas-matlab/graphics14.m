syms x y
[a1 a2] = solve(x^2+x*y+y-3, x^2-4*x+3)
dsolve('Dy = 1 +y^2')