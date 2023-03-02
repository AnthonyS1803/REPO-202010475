#include <stdio.h>
#include <string.h>

void intercambia(char FRA[20][30], int); /* Prototipo de funci�n. */
void main(void)
{
int i, n;
char FRA[20][30];
printf("\nIngrese el n�mero de filas del arreglo: ");
scanf("%d", &n);
for (i=0; i<n; i++)
{
printf("Ingrese la l�nea de texto n�mero %d: ", i+1);
fflush(stdin);
gets(FRA[i]);
}
printf("\n\n");
intercambia(FRA, n);
for (i=0; i<n; i++)
{
printf("Impresi�n de la l�nea de texto %d: ", i+1);
puts(FRA[i]);
}
}
void intercambia(char FRA[20][30], int n)
/* Esta funci�n intercambia las filas del arreglo. */
{
int i, j;
j = n - 1;
char cad[30];
for (i=0; i < (n/2); i++)
{
strcpy(cad, FRA[i]);
strcpy(FRA[i], FRA[j]);
strcpy(FRA[j], cad);
j--
}
}
