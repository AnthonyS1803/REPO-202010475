#include <stdio.h>
#include <string.h>
/* Otras funciones de la biblioteca string.h para el manejo de cadenas. */
void main(void)
{
int i;
char cad0[20] = "Hola M�xico";
char cad1[20] = "Hola Guatemala";
char cad2[20] = "Hola Venezuela";
char cad3[20] = "Hola M�xico";
char *c, c3;
i = strcmp(cad0, cad1);
/* La funci�n strcmp permite comparar dos cadenas de caracteres. Si la
primera cadena �en este caso cad0� es mayor a la segunda �cad1�,
regresa un valor positivo; si es menor, un valor negativo y de otra forma,
0. */
printf("\nResultado de la comparaci�n �cad0 y cad1�: %d", i);
i = strcmp(cad0, cad2);
printf("\nResultado de la comparaci�n �cad0 y cad2�: %d", i);
i = strcmp(cad0, cad3);
printf("\nResultado de la comparaci�n �cad0 y cad3�: %d", i);
i = strlen(cad0);
/* La funci�n strlen obtiene la longitud �el n�mero de caracteres� de
una cadena. */
printf("\nLongitud cadena cad0: %d", i);
i = strlen(cad1);
printf("\nLongitud cadena cad1: %d", i);
c = strchr(cad1, 'G'); /* c es un apuntador de tipo caracter.
*/
/* La funci�n strchr busca la posici�n en la que se encuentra un
determinado caracter en la cadena de caracteres. Si lo encuentra regresa
un apuntador a la primera ocurrencia del caracter en la cadena, de otra
forma regresa NULL. */
if (c != NULL)
{
c3 = *c; /* c3 toma el contenido de la celda de memoria a la
que apunta c.*/
printf("\nEl valor de c3 es: %c", c3);
}
c = strchr(cad2, 'V');
if (c != NULL)
{
c3 = *c;
printf("\nEl valor de c3 es: %c", c3);
}
}
