#include <stdio.h>

void main(void)
{
        int i = 5, j = 4, k, l, m;
        k = !i * 3 + --j * 2 - 3;
        printf("\nEl valor de k es : %d", k);

        l =! (!i || 1 && 0) && 1;
        printf("\nEL valor de l es: %d", l);

        m = (k = (!(12 > 10)), j = (10 || 0) && k, (!(k || j)));
        printf ("\nEL valor de m es: %d", m);
}
