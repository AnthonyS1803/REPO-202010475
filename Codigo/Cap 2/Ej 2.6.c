#include <stdio.h>

/* incremento de salario.
el programa, al recibir como dato el nivel de un profesor, incrementa su
salario en funcion de la tabla 2.3.

NIV: variable de tipo entero.
SAL: variables de tipo real. */

void main(void)
{
float SAL;
int NIV;
printf("ingrese el nivel academico del profesor:  ");
scanf("%d", &NIV);
printf("ingrese el salario:  ");
scanf("%f", &SAL);  /*En estas barras de codigo puede apreciar,
                    luego de introducir el dato del profeasor se hace
					la misma operacion para aumentar el porciernto dado*/
switch(NIV)
printf("ingrese salario:   ");
scanf("%f", &SAL);
switch(NIV)
{
	case 1: SAL = SAL * 1.0035; break;
	case 2: SAL = SAL * 1.0041; break;
	case 3: SAL = SAL * 1.0048; break;
	case 4: SAL = SAL * 1.0053; break;
}
printf("\n\nnivel: %d \tnuevo salario: %8.2f",NIV, SAL);
}
