x= linspace(-1,3);
p = [1 4 -7 -10];
v = polyval(p,x);
figure(5)
plot(x,v),title('x^3+4x^2-7x-10')
xlabel('x'),ylabel('v')