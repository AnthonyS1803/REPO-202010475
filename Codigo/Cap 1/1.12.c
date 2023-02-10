#include <stdio.h>

void main(void)
{
    int i, j, k = 2, l = 7;

    i = 9 + 3 * 2;
    j = 8 % 6 + 4 * 2;
    i %= j;

    printf ("\nEl valor de i es: %d", i);

    ++l ;
    --k -= l++ * 2;
    printf ("\nEl valor de k es: %d", k);

    i = 5.5 - 3 * 2 % 4;
    j = (i * 2 - (k = 3, --k));
    printf ("\nEl valor de j es: %d", j);

}
