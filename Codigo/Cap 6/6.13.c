#include <stdio.h>

/* Empresa textil.
El programa, al recibir un arreglo tridimensional que contiene informaci�n
sobre las ventas mensuales de tres departamentos en los �ltimos ocho a�os,
genera informaci�n estad�stica valiosa para la empresa. */
const int MES = 12;
const int DEP = 3;
const int A�O = 8;
void Lectura(float [MES][DEP][A�O], int, int, int);
void Funcion1(float [MES][DEP][A�O], int, int, int);
void Funcion2(float [MES][DEP][A�O], int, int, int); /* Prototipos
de funciones. */
void Funcion3(float [MES][DEP][A�O], int, int, int);

void main(void)
{
    float PRO[MES][DEP][A�O];
    Lectura(PRO, MES, DEP, A�O);
    Funcion1(PRO, MES, DEP, 2);
    Funcion2(PRO, MES, DEP, A�O);
    Funcion3(PRO, MES, DEP, A�O);
}
void Lectura(float A[][DEP][A�O], int F, int C, int P)
/* La funci�n Lectura se utiliza para leer un arreglo tridimensional de tipo
real de F filas, C columnas y P planos de profundidad. */
{
    int K, I, J;
    for (K=0; K<P; K++)
        for (I=0; I<F; I++)
            for (J=0; J<C; J++)
            {
                printf("A�o: %d\tMes: %d\tDepartamento: %d ", K+1, I+1, J+1);
                scanf("%f", &A[I][J][K]);
            }
}
void Funcion1(float A[][DEP][A�O],int F, int C, int P)
/* Esta funci�n se utiliza para obtener las ventas totales de la empresa
en el segundo a�o. */
{
    int I, J;
    float SUM = 0.0;
    for (I=0; I<F; I++)
        for (J=0; J<C; J++)
            SUM += A[I][J][P-1];
    printf("\n\nVentas totales de la empresa en el segundo a�o: %.2f", SUM);
}
void Funcion2(float A[][DEP][A�O],int F, int C, int P)
/* Esta funci�n se utiliza para obtener el departamento que tuvo las mayores
ventas en el �ltimo a�o. Genera adem�s el importe de las ventas. */
{
    int I, J;
    float SUM1 = 0, SUM2 = 0, SUM3 = 0;
    for (I=0; I<F; I++)
        for (J=0; J<C; J++)
            switch (J+1)
            {
            case 1:
                SUM1 += A[I][J][P-1];
                break;
            case 2:
                SUM2 += A[I][J][P-1];
                break;
            case 3:
                SUM3 += A[I][J][P-1];
                break;
            }
    if (SUM1 > SUM2)
        if (SUM1 > SUM3)
        {
            printf("\n\nDepartamento con mayores ventas en el ultimo a�o: Hilos");
            printf("Ventas:%.2f", SUM1);
        }
        else
        {
            printf("\n\nDepartamento con mayores ventas en el ultimo a�o: Licra");
            printf("" Ventas:%.2f", SUM3);
        }
    else if (SUM2 > SUM3)
    {
        printf("\n\nDepartamento con mayores ventas en el �ltimo a�o: Lanas");
        printf(" Ventas:%.2f", SUM2);
    }
    else
    {
        printf("\n\nDepartamento con mayores ventas en el ultimo a�o: Licra");
        printf(" Ventas:%.2f", SUM3);
    }
}
void Funcion3(float A[][DEP][A�O],int F, int C, int P)
/* Esta funci�n se utiliza para obtener el departamento, mes y a�o con la mayor
venta. Escribe tambi�n el monto de las ventas. */
{
    int K, I, J, DE, ME, AN;
    float VEN = -1.0;
    for (K=0; K<P; K++)
        for (I=0; I< F; I++)
            for (J=0; J<C; J++)
                if (A[I][J][K] > VEN)
                {
                    VEN = A[I][J][K];
                    DE = J;
                    ME = I;
                    AN = K;
                }
    printf("\n\nDepartamento: %d\tMes: %d\tA�o: %d", DE+1, ME+1, AN+1);
    printf("\tVentas: %.2f", VEN);
}
