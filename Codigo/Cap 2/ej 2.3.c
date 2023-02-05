#include <stdio.h>
/* promedio curso.
el programa, al recibir como dato el promedio de un alumno en un curso
universitario, escribe aprobado si su promedio es mayor o igual a 6, o
reprobado en caso contrario.

PRO: variable de tipo real.    */

void main(void)
{
float PRO;
printf("ingrese el promedio del alumno: ");
scanf("%f", &PRO);  /*En estas lienas se ve de manera clara
					el uso de comparaciones con if y mayor o igual*/
if (PRO >= 6.0)
	printf("\naprobado");
else
	printf("\nreprobado");



}
