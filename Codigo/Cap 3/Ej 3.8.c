# include <stdio.h>

/* Factorial.
El programa calcula el factorial de un número entero.
FAC, I, NUM: variables de tipo entero. */

void main(void)
{
int I, NUM;
long FAC;

printf("\nIngrese el número: ");
scanf("%d", &NUM);

if (NUM >= 0)
{
FAC = 1;
for (I=1; I <= NUM; I++)
FAC *= I;
printf("\El factorial de %d es: %ld", NUM, FAC);
}
else
printf("\nError en el dato ingresado");
}
