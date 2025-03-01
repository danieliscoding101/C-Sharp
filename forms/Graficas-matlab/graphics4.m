x = linspace(0,2*pi,30);
y = sin(x);
z = cos(x);
figure(10)
plot(x,y,'b',x,z,'r.-')
legend('Seno(x)','Coseno(x)')
xlabel('x'),ylabel('y')
grid