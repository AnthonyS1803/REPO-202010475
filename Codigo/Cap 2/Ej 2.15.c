#include <stdio.h>

/* spa.
el programa, al recibir como datos el tipo de tratamiento, la edad y el
numero de dias de internacion de un cliente en un spa, calula el costo
total del tratamiento.

TRA, EDA, DIA: variable de tipo entero.
COS: variable de tipo real. */

void main(void)
{
	int TRA, EDA, DIA;
	float COS;
	printf("ingrese tipo de tratamiento, edad y dias: ");
	scanf("%d %d %d", &TRA, &EDA, &DIA);
	switch(TRA)
	{
		case 1: COS = DIA * 2800; break;
		case 2: COS = DIA * 1950; break;
		case 3: COS = DIA * 2500; break;
		case 4: COS = DIA * 1150; break;
		default: COS = -1; break;
	}
	if (COS != -1)
	{
		if (EDA >= 60)
			COS = COS * 0.75;
		printf("\nclave tratamiento: %d\t dias: %d\t costo total: %8.2f",
		TRA, DIA, COS);
	}
	else
		printf("\nla clave del tratamiento es incorrecta");
}
