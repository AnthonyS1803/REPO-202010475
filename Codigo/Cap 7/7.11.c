# include <stdio.h>
# include <ctype.h>

/* Verifica.
El programa, al recibir como datos una cadena de caracteres y una posici�n espec�fica en la cadena, determina si el caracter correspondiente es una letra
min�scula. */
void main(void)
{
char p, cad[50];
int n;
printf("\nIngrese la cadena de caracteres (m�ximo 50): ");
gets(cad);
printf("\nIngrese la posici�n en la cadena que desea verificar: ");
scanf("%d", &n);
if ((n >= 0) && (n < 50))
{
p = cad[n-1];
if (islower(p))
printf("\n%c es una letra min�scula", p);
else
printf("\n%c no es una letra min�scula", p);
}
else
printf("\nEl valor ingresado de n es incorrecto");
}
