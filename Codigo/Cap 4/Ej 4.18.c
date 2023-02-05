#include <stdio.h>
#include <math.h>
/* Expresión.
El programa escribe los valores de T, P y Q que satisfacen una determinada
expresión.*/
int Expresion(int, int, int); /* Prototipo de función. */
void main(void)
{
int EXP, T = 0, P = 0, Q = 0;
EXP = Expresion(T, P, Q);
while (EXP < 5500)
{
while (EXP < 5500)
{
while (EXP < 5500)
{
printf("\nT: %d, P: %d, Q: %d, Resultado: %d", T, P, Q, EXP);
Q++;
EXP = Expresion(T, P, Q);
}
P++;
Q = 0;
EXP = Expresion(T, P, Q);
}
T++;
P = 0;
Q = 0;
EXP = Expresion(T, P, Q);
}
}
int Expresion(int T, int P, int Q)
/* Esta función obtiene el resultado de la expresión para los valores
de T, P y Q. */
{
int RES;
RES = 15 * pow(T,4) + 12 * pow(P,5) + 9 * pow(Q,6);
return (RES);
}
