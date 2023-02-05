#include <stdio.h>
#include <math.h>

/* funcion matematica.
el programa obtiene el resultado de una funcion.

OP y T: variables de tipo entero.
RES: variable de tipo real. */

void main(void)
{
int OP, T;
float RES;
printf("ingrese la opcion del calculo y el valor entero: ");
scanf("%d %d", &OP, &T);  /*Se maneja la variabel de manera independiste para poder ejecutae el codigo */
switch(OP)
{
	case 1: RES = T/5;
		break;
	case 2: RES = pow(T,T);
	/* la funcion pow est definida en la biblioteca math.h*/
		break;
	case 3:
	case 4: RES = 6 * T/2;
		break;
	default: RES = 1;
		break;
}
printf("\nresultado:     %7.2f", RES);
}
