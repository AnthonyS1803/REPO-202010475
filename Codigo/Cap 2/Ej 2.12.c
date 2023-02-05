#include <stdio.h>
#include <math.h>

/* igualdad de expresiones.
el programa, al recibir como datos T, P y N, comprueba la igualdad de
una expresion determinada.

T, P y N: variables de tipo entero. */

void main(void)
{
	int T, P, N;
	printf("ingrese los valores de T, P y N: ");
	scanf("%d %d %d", &T, &P, &N);
	if (P != 0)
	{
		if (pow(T/P, N) == (pow(T, N) / pow(P, N)))
			printf("\nse comprueba la igualdad");
		else
			printf("\nno se comprueba la igualdad");
	}
	else
			printf("\nP tiene que ser diferente de cero");
}
