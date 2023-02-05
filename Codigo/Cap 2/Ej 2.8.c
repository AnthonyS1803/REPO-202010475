#include <stdio.h>

/* asistentes.
el programa, al recibir como datos la matricula, la carrera , el semestre
y el promedio de un alumno de una universidad privada, determina si
este puede ser asistente de su carrera

MAT, CAR y SEM: variables de tipo entero.
PRO: variable de tipo real. */

void main(void)
{
int MAT, CAR, SEM;
float PRO;
printf("ingrese matricula:  ");
scanf("%d", &MAT);
printf("ingrese carrera(1-industrial 2-telematica 3-computacion 4-mecanica)  :");
scanf("%d", &CAR);
printf("ingrese semestre:  ");
scanf("%d", &SEM);
printf("ingrese promedio: ");
scanf("%f", &PRO);
switch(CAR)
{
	case 1: if (SEM >= 6 && PRO >= 8.5)
			printf("\n%d %d %5.2f", MAT, CAR, PRO);
		break;
	case 2: if (SEM >= 5 && PRO >= 9.0)
			printf("\n%d %d %5.2f", MAT, CAR, PRO);
		break;
	case 3: if (SEM >= 6 && PRO >= 8.8)
			printf("\n%d %d %5.2f", MAT, CAR, PRO);
		break;
	case 4: if (SEM >= 7 && PRO >= 9.0)
			printf("\n%d %d %5.2f", MAT, CAR, PRO);
		break;
		default: printf("\n error en la carrera");
		break;
	}
}
