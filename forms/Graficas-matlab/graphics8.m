x=-7.5:0.5:7.5;
y=x;
[X,Y] = meshgrid(x,y);
R=sqrt(X.^2+Y.^2) + eps
Z = sin(R)./R ;
figure(15)
mesh(X,Y,Z)