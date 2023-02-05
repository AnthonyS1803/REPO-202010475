#include <stdio.h>

/* Primos.
El programa almacena en un arreglo unidimensional los primeros 100 n�meros
primos. */
const int TAM = 100;
void Imprime(int, int); /* Prototipos de funciones. */
void Primo(int, int *);
void main(void)
{
int PRI[TAM] = {1,2};
int FLA, J = 2, PRI = 3;
while (J <= TAM)
{
FLA = 1;
Primo(PRI, &FLA); /* Se llama a la funci�n que determina si PRI es
primo. */
if (FLA) /* Si FLA es 1, entonces PRI es primo. */
{
P[J] = PRI;
J++;
}
PRI += 2;
}
Imprime(P, TAM);
}
void Primo(int A, int *B)
/* Esta funci�n determina si A es primo, en cuyo caso el valor de *B no se
altera. */
{
int DI = 3;
while (*B && (DI < (A / 2)))
{
if ((A % DI) == 0)
*B = 0;
DI++;
}
}
void Imprime(int Primos[], int T)
/* Esta funci�n imprime el arreglo unidimensional de n�meros primos. */
{
int I;
for (I=0; I<T; I++)
printf("\nPrimos[%d]: %d", I, Primos[I]);
}
