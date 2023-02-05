#include <stdio.h>
#include <math.h>

/* Serie de ULAM.
El programa, al recibir como dato un entero positivo, obtiene y escribe
?la serie de ULAM.
NUM: variable de tipo entero. */

void main(void)
{
int NUM;
printf("Ingresa el número para calcular la serie: ");
scanf("%d", &NUM);
if (NUM > 0)
{
printf("\nSerie de ULAM\n");
printf("%d \t", NUM);
while (NUM != 1)
{
if (pow(-1, NUM) > 0)
NUM = NUM / 2;
else
NUM = NUM * 3 + 1;
printf("%d \t", NUM);
}
}
else
printf("\n NUM debe ser un entero positivo");
}
