#include<stdio.h>
void main(void)
{
    int i=5, j=7, k=3, n1;
    float x=2.5, z=1.8,t;

    n1 = ((j % k)/2) + 1;
    n1 +=i;
    n1 %= --i;
    printf("\nEl valor de n1 es: %d", n1);

    t = ((float) (j % k) /2);
    t ++;
    x *= ++z;
    t -= (x += ++i);

    printf("\nEl valor de t es: %.2f", t);
}
