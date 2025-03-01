x=[1,2,1,0];
y=[0,1,2,1];
figure(17)
fill(x,y,'r')
title('rombo')
%Gráficas de funciones implicitas.
y='[10*sin(x),5*cos(x)]'
figure(18)
fplot(y,[0 4*pi -12 12])
grid