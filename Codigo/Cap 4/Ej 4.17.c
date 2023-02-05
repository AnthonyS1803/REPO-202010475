#include <stdio.h>

/* Lluvias.
El programa permite calcular el promedio mensual de las lluvias caídas en
tres regiones importantes del país. Determina también cuál es la región
con mayor promedio de lluvia anual. */
void Mayor(float, float, float); /* Prototipo de función. */
void main(void)
{
int I;
float GOL, PAC, CAR, AGOL = 0, APAC = 0, ACAR = 0;
for (I =1; I <= 12; I++)
{
printf("\n\nIngresa las lluvias del mes %d", I);
printf("\nRegiones Golfo, Pacífico y Caribe: ");
scanf("%f %f %f", &GOL, &PAC, &CAR);
AGOL += GOL;
APAC += PAC;
ACAR += CAR;
}
printf("\n\nPromedio de lluvias Región Golfo: %6.2f", (AGOL / 12));
printf("\nPromedio de lluvias Región Pacífico: %6.2f ", (APAC / 12));
printf("\nPromedio de lluvias Región Caribe: %6.2f \n", (ACAR / 12));
Mayor(AGOL, APAC, ACAR);
/* Se llama a la función Mayor. Paso de parámetros por valor. */
}
void Mayor(float R1, float R2, float R3)
/* Esta función obtiene la región con mayor promedio de lluvia anual. */
{
if (R1 > R2)
if (R1 > R3)
printf("\nRegión con mayor promedio: Región Golfo. Promedio:
 %6.2f",R1 / 12);
else
printf("\nRegión con mayor promedio: Región Caribe. Promedio:
 %6.2f",R3 / 12);
else
if (R2 > R3)
printf("\nRegión con mayor promedio: Región Pacífico. Promedio:
 %6.2f",R2 / 12);
else
printf("\nRegión con mayor promedio: Región Caribe. Promedio:
 %6.2f",R3 / 12);
}
