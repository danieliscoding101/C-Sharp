x = linspace(0,2*pi,30);
y = sin(x);
z = cos(x);
a = 2*sin(x).*cos(x);
b = sin(x)./(cos(x)+eps);
figure(12)
subplot(221)
plot(x,y),axis([0 2*pi -1 1]), title('sin(x)')
subplot(222)
plot(x,z),axis([0 2*pi -1 1]), title('cos(x)')
subplot(223)
plot(x,a),axis([0 2*pi -1 1]), title('2sin(x)cos(x)')
subplot(224)
plot(x,b),axis([0 2*pi -20 20]), title(' sin(x)/cos(x)')