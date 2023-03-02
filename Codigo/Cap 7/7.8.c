#include <stdio.h>
#include <string.h>
#include <ctype.h>

/* Min�sculas y may�sculas.
El programa, al recibir como dato un arreglo unidimensional de tipo
cadena de caracteres, determina el n�mero de min�sculas y may�sculas
que hay en cada cadena. */
void minymay(char cad); /* Prototipo de funci�n. */
void main(void)
{
int i, n;
char FRA[20][50];
/* Observa c�mo se declara el arreglo unidimensional de cadena de
caracteres. */
printf("\nIngrese el n�mero de filas del arreglo: ");
scanf("%d", &n);
for (i=0; i<n; i++)
{
/* Para cada fila se lee la cadena correspondiente. */
printf("Ingrese la l�nea %d de texto: ", i+1);
fflush(stdin);
gets(FRA[i]);
}
printf("\n\n");
for (i=0; i<n; i++)
minymay(FRA[i]);
}
void minymay (char cad)
/* Esta funci�n se utiliza para calcular el n�mero de min�sculas
y may�sculas que hay en cada cadena. */
{
int i = 0, mi = 0, ma = 0;
while(cad[i] != '\0')
{
if (islower(cadena[i]))
mi++;
else
if (isupper(cadena[i]))
ma++;
i++;
}
printf("\n\nN�mero de letras min�sculas: %d", mi);
printf("\nN�mero de letras may�sculas: %d", ma);
}
