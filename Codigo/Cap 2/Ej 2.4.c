#include <stdio.h>

/* incremento de precio.
el programa, al recibir como dato el precio de un producto, incrementa al
mismo 11% si es menor a 1500$ y 8% en caso contrario (mayot o igual).

PRE y NPR variables de tipo real.  */

void main(void)
{
float PRE, NPR;
printf("ingrese el precio del producto: ");
scanf("%f", &PRE); /*Expresa la comparacion en los datos que va a elevar de precio */
if (PRE < 1500)
	NPR = PRE * 1.11;
else
	NPR = PRE * 1.08;
printf("\nnuevo precio del producto: %8.2f", NPR);
}
