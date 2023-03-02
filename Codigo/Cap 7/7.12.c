#include <stdio.h>
#include <ctype.h>

/* Cuenta letras min�sculas y may�sculas.
El programa, al recibir como dato una frase, determina el n�mero de letras
min�sculas y may�sculas que existen en la frase. */
void main(void)
{
char cad[50];
int i = 0, mi = 0, ma = 0;
printf("\nIngrese la cadena de caracteres (m�ximo 50 caracteres): ");
gets(cad);
while(cad[i] != '\0')
{
if (islower (cad[i]))
mi++;
else
if (isupper (cad[i]))
ma++;
i++;
}
printf("\n\nN�mero de letras min�sculas: %d", mi);
printf("\nN�mero de letras may�sculas: %d", ma);
}
