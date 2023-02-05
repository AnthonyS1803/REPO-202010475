#include <stdio.h>

/* billete de ferrocarril.
el programa calcula el costo de un billete de ferrocarril teniendo en
cuenta la distancia entre las dos cuidades y el tiempo de permanencia
del pasajero

DIS y TIE: variables de tipo entero.
BIL: variable de tipo real. */

void main(void)
{
	int DIS, TIE;
	float BIL;
	printf("ingrese la ditancia entre ciudades y el tiempo de estancia: ");
	scanf("%d %d", &DIS, &TIE);
	if ((DIS * 2  > 500) && (TIE > 10))
		BIL = DIS * 2 *0.19 * 0.8;
	else
		BIL = DIS * 2 * 0.19;
	printf("\n\ncosto del billete: %7.2f", BIL);
}
