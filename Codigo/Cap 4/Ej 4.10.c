# include <stdio.h>

/* Múltiplo.
El programa, al recibir como datos dos números enteros, determina si
el segundo es múltiplo del primero. */

int multiplo(int, int); /* Prototipo de función. */
void main(void)
{
int NU1, NU2, RES;
printf("\nIngresa los dos números: ");
scanf("%d %d", &NU1, &NU2);
RES = multiplo(NU1, NU2);
if (RES)
printf("\nEl segundo número es múltiplo del primero");
else
printf("\nEl segundo número no es múltiplo del primero");
}
int multiplo(int N1, int N2)
/* Esta función determina si N2 es múltiplo de N1. */
{
int RES;
if ((N2 % N1) == 0)
RES = 1;
else
RES = 0;
return (RES);
}
