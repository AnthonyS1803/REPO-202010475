#include <stdio.h>
#include <stdlib.h>
/* Funciones para el manejo de caracteres de la biblioteca stdlib.h. */
void main(void)
{
int i;
double d;
long l;
char cad0[20], *cad1;
printf("\nIngrese una cadena de caracteres: ");
gets(cad0);
i = atoi(cad0);
/* La funci�n atoi convierte una cadena de caracteres que contiene n�meros
a ?un valor de tipo entero. Si la cadena comienza con otro caracter o no
contiene n�meros, regresa 0 o el valor queda indefinido. */
printf("\n%s \t %d", cad0, i+3);
/* Se imprime el valor de i+3 para demostrar que i ya fue convertido a un
entero.*/
printf("\nIngrese una cadena de caracteres: ");
gets(cad0);
d = atof(cad0);
/* La funci�n atof convierte una cadena de caracteres que contiene n�meros
reales a un valor de tipo double. Si la cadena comienza con otro caracter
o no contiene n�meros, regresa 0 o el valor queda indefinido. */
printf("\n%s \t %.2lf ", cad0, d+1.50);
d = strtod(cad0, &cad1);
/* La funci�n strtod convierte una cadena de caracteres que contiene n�meros
reales a un valor de tipo double. El resto de la cadena se almacena en el
segundo argumento de la funci�n, &cad1, un apuntador de tipo cadena de
caracteres. Si la cadena no contiene n�meros o comienza con otro caracter,
regresa 0 o el valor queda indefinido. */
printf("\n%s \t %.2lf", cad0, d+1.50);
puts(cad1);
l = atol(cad0);
/* La funci�n atol convierte una cadena de caracteres que contiene n�meros a
un valor de tipo long. Si la cadena no contiene n�meros o comienza con
otro caracter, regresa 0 o el valor queda indefinido. */
printf("\n%s \t %ld ", cad0, l+10);
l = strtol(cad0, &cad1, 0);
/* La funci�n strtol convierte una cadena de caracteres que contiene n�meros a
un valor de tipo long. El resto de la cadena se almacena en el otro argumento
de la funci�n, &cad1. El tercer argumento se utiliza para indicar que la
cadena puede estar en formato octal, decimal o hexadecimal. Si la cadena no
contiene n�meros o comienza con otro caracter, regresa 0 o el valor queda
indefinido. */
printf("\n%s \t %ld", cad0, l+10);
puts(cad1);
}
