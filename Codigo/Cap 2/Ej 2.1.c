#include <stdio.h>

/* promedio curso.
el programa, al recibir como dato el promedio de un alumno de un curso
universitario, escribe aprobado si su promedio es mayor o igual a 6.

PRO: variable de tipo real.  */

void main(void)
{
float PRO;
printf("ingrese el promedio del alumno: ");
scanf("%f", &PRO); /*En esta liena podemos ver la varible y la funcion*/
if (PRO >= 6)
	printf("\naprobado");
}
