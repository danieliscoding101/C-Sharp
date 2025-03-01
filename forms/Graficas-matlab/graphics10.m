syms a b c d x s
f= a*x^3 + x^2 -b*x -c;
diff(f)
diff(f,2)
diff(f,a,2)
g= [a*x b*x^2; c*x^3 d*s];
diff(g)