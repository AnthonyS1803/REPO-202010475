#include <stdio.h>

/* Cuenta caracteres.
El programa, al recibir como datos una cadena de caracteres y un caracter,
cuenta cu�ntas veces se encuentra el caracter en la cadena. */
int cuenta(char *, char); /* Prototipo de funci�n. */
void main(void)
{
char car, cad[50];
int res;
printf("\nIngrese la cadena de caracteres: ");
gets(cad);
fflush(stdin);
printf("\nIngrese el caracter: ");
car = getchar();
res = cuenta(cad, car);
printf("\n\n%c se encuentra %d veces en la cadena %s", car, res, cad);
}
int cuenta(char *cad, char car)
/* Esta funci�n se utiliza para obtener el n�mero de veces que se encuentra
el caracter en la cadena. */
{
int i = 0, r = 0;
while (cad[i] != '\0')
{
if (cad[i] == car)
r++;
i++;
}
return (r);
}
