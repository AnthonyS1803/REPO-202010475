# include <stdio.h>
# include <math>

/* Cálculo de P.
El programa obtiene el valor de P aplicando una serie determinada.
I, B, C: variables de tipo entero.

RES: variable de tipo real de doble precisión. */

void main(void)
{
int I = 1, B = 0, C;
double RES;
RES = 4.0 / I;
C = 1;
while ((fabs (3.1415 - RES)) > 0.0005)
{
I += 2 ;
if (B)
{
RES += (double) (4.0 / I);
B = 0;
}
else
{
RES -= (double) (4.0 / I);
B = 1;
}
C++;
}
printf("\nNúmero de términos:%d", C);
}
