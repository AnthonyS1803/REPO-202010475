#include <stdio.h>

/* Cadena invertida resuelta en forma recursiva. */
void inverso(char *); /* Prototipo de funci�n. */
void main(void)
{
char fra[50];
printf("\nIngrese la l�nea de texto: ");
gets(fra);
printf("\nEscribe la l�nea de texto en forma inversa: ");
inverso(fra);
}
void inverso(char *cadena)
/* La funci�n inverso obtiene precisamente el inverso de la cadena. La soluci�n
presentada es simple, pero para comprenderla es necesario tener conocimientos
tanto de pilas como de recursividad. Observa que mientras no se encuentre el
caracter de terminaci�n de la cadena, se llama a la funci�n recursiva con
el apuntador al siguiente caracter de la cadena. Por otra parte, queda
pendiente de ejecutar �almacenado en una pila� el caracter al cual apunta
*cadena. */
{
if (cadena[0]!= '\0')
{
inverso(&cadena[1]);
putchar(cadena[0]);
}
}
