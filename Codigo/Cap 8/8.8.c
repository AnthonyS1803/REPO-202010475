#include <stdio.h>
#include <string.h>
/* Hospital.
El programa genera informaci�n acerca de los pacientes de un hospital. */
typedef struct /* Declaraci�n de la estructura domicilio. */
{
    char cal[20]; /* Calle. */
    int num; /* N�mero. */
    char col[20]; /* Colonia. */
    char cp[5]; /* C�digo Postal. */
    char ciu[20]; /* Ciudad. */
} domicilio;
typedef struct /* Declaraci�n de la estructura paciente. */
{
    char nom[20]; /* Nombre y apellido. */
    int edad;
    char sexo;
    int con; /* Condici�n. */
    domicilio dom; /* Observa que el campo dom es de tipo estructura domicilio. */
    char tel[10]; /* Tel�fono. */
} paciente;
void Lectura(paciente *, int);
void F1(paciente *, int);
void F2(paciente *, int); /* Prototipos de funciones. */
void F3(paciente *, int);
void main(void)
{
    paciente HOSPITAL[100]; /* Arreglo unidimensional de tipo estructura paciente. */
    int TAM;
    do
    {
        printf("Ingrese el numero de pacientes: ");
        scanf("%d", &TAM);
    }
    while (TAM > 50 || TAM < 1); /* Se verifica que el tama�o del arreglo sea correcto. */
    Lectura(HOSPITAL, TAM);
    F1(HOSPITAL, TAM);
    F2(HOSPITAL, TAM);
    F3(HOSPITAL, TAM);
}
void Lectura(paciente A[], int T)
/* Esta funci�n se utiliza para leer un arreglo unidimensional de tipo estructura paciente de T elementos. */
{
    int I;
    for (I=0; I<T; I++)
    {
        printf("\n\t\tPaciente %d", I+1);
        fflush(stdin);
        printf("\nNombre: ");
        gets(A[I].nom);
        printf("Edad: ");
        scanf("%d", &A[I].edad);
        printf("Sexo (F-M): ");
        scanf("%c", &A[I].sexo);
        printf("Condicion (1..5): ");
        scanf("%d", &A[I].con);
        fflush(stdin);
        printf("\tCalle: ");
        gets(A[I].dom.cal);
        printf("\tNumero: ");
        scanf("%d", &A[I].dom.num);
        fflush(stdin);
        printf("\tColonia: ");
        gets(A[I].dom.col);
        fflush(stdin);
        printf("\tCodigo Postal: ");
        gets(A[I].dom.cp);
        fflush(stdin);
        printf("\tCiudad: ");
        gets(A[I].dom.ciu);
        fflush(stdin);
        printf("Telefono: ");
        gets(A[I].tel);
    }
}
void F1(paciente A[], int T)
/* Esta funci�n se utiliza para obtener el porcentaje tanto de hombres como de
mujeres registrados en el hospital. */
{
    int I,FEM, MAS, TOT;
    for (I=0; I<T; I++)
        switch (A[I].sexo)
        {
        case 'F':
            FEM++;
            break;
        case 'M':
            MAS++;
            break;
        }
    TOT = FEM + MAS;
    printf("\nPorcentaje de Hombres: %.2f%", (float)MAS / TOT * 100);
    printf("\nPorcentaje de Mujeres: %.2f%", (float)FEM / TOT * 100);
}
void F2(paciente A[], int T)
/* Esta funci�n se utiliza para obtener el n�mero de pacientes que ingresaron al
hospital en cada una de las categor�as de condici�n. */
{
    int I, C1 = 0, C2 = 0, C3 = 0, C4 = 0, C5 = 0;
    for (I=0; I<T; I++)
        switch (A[I].con)
        {
        case 1:
            C1++;
            break;
        case 2:
            C2++;
            break;
        case 3:
            C3++;
            break;
        case 4:
            C4++;
            break;
        case 5:
            C5++;
            break;
        }
    printf("\nNumero pacientes en condicion 1: %d", C1);
    printf("\nNumero pacientes en condicion 2: %d", C2);
    printf("\nNumero pacientes en condicion 3: %d", C3);
    printf("\nNumero pacientes en condicion 4: %d", C4);
    printf("\nNumero pacientes en condicion 5: %d", C5);
}
void F3(paciente A[], int T)
/* La funci�n F3 se utiliza para generar el nombre y tel�fono de todos los
pacientes que tuvieron una condici�n de ingreso de m�xima gravedad (5). */
{
    int I;
    printf("\nPacientes ingresados en estado de gravedad");
    for (I=0; I<T; I++)
        if (A[I].con == 5)
            printf("\nNombre: %s\tTelefono: %s", A[I].nom, A[I].tel);
}
