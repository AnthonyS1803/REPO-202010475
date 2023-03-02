#include <stdio.h>
#include <string.h>
/* Bienes ra�ces.
El programa maneja informaci�n sobre las propiedades que tiene una empresa
de bienes ra�ces de la ciudad de Lima, Per�, tanto para venta como para renta. */
typedef struct /* Declaraci�n de la estructura ubicaci�n.*/
{
    char zona[20];
    char calle[20];
    char colo[20]; /* Colonia. */
} ubicacion;
typedef struct /* Declaraci�n de la estructura propiedades.*/
{
    char clave[5];
    float scu; /* Superficie cubierta. */
    float ste; /* Superficie terreno. */
    char car[50]; /* Caracter�sticas. */
    ubicacion ubi; /* Observa que este campo es de tipo estructura
ubicaci�n. */
    float precio;
    char dispo; /* Disponibilidad. */
} propiedades;
void Lectura(propiedades, int);
void F1(propiedades *, int); /* Prototipos de funciones. */
void F2(propiedades *, int);
void main(void)
{
    propiedades PROPIE[100];
    /* Se declara un arreglo unidimensional de tipo estructura propiedades. */
    int TAM;
    do
    {
        printf("Ingrese el numero de propiedades: ");
        scanf("%d", &TAM);
    }
    while (TAM > 100 || TAM < 1);
    /* Se verifica que el tama�o del arreglo sea correcto. */
    Lectur(PROPIE, TAM);
    F1(PROPIE, TAM);
    F2(PROPIE, TAM);
}
void Lectur(propiedades A[], int T)
/* Esta funci�n se utiliza para leer un arreglo unidimensional de tipo estructura
propiedades de T elementos. */
{
    int I;
    for (I=0; I<T; I++)
    {
        printf("\n\tIngrese datos de la propiedad %d", I + 1);
        printf("\nClave: ");
        fflush(stdin);
        gets(A[I].clave);
        printf("Superficie cubierta: ");
        scanf("%f", &A[I].scu);
        printf("Superficie terreno: ");
        scanf("%f", &A[I].ste);
        printf("Caracteristicas: ");
        fflush(stdin);
        gets(A[I].car);
        printf("\tZona: ");
        fflush(stdin);
        gets(A[I].ubi.zona);
        printf("\tCalle: ");
        fflush(stdin);
        gets(A[I].ubi.calle);
        printf("\tColonia: ");
        fflush(stdin);
        gets(A[I].ubi.colo);
        printf("Precio: ");
        scanf("%f", &A[I].precio);
        printf("Disponibilidad (Venta-V Renta-R): ");
        scanf("%c", &A[I].dispo);
    }
}
void F1(propiedades A[], int T)
/* Esta funci�n se utiliza para generar un listado de las propiedades
disponibles para venta en la zona de Miraflores, cuyo valor oscila entre
450,000 y 650,000 nuevos soles. */
{
    int I;
    printf("\n\t\tListado de Propiedades para Venta en Miraflores");
    for (I=0; I<T; I++)
        if ((A[I].dispo == 'V') && (strcmp (A[I].ubi.zona, "Miraflores") == 0))
            if ((A[I].precio >= 450000) && (A[I].precio <= 650000))
            {
                printf("\nClave de la propiedad: ");
                puts(A[I].clave);
                printf("\nSuperficie cubierta: %f", A[I].scu);
                printf("\nSuperficie terreno: %f", A[I].ste);
                printf("\nCaracteristicas: ");
                puts(A[I].car);
                printf("Calle: ");
                puts(A[I].ubi.calle);
                printf("Colonia: ");
                puts(A[I].ubi.colo);
                printf("Precio: %.2f\n", A[I].precio);
            }
}
void F2(propiedades A[], int T)
/* Al recibir como datos una zona geogr�fica de Lima, Per�, y un cierto rango
respecto al monto, esta funci�n genera un listado de todas las propiedades
disponibles para renta. */
{
    int I;
    float li, ls;
    char zon[20];
    printf("\n\t\tListado de Propiedades para Renta");
    printf("\nIngrese zona geografica: ");
    fflush(stdin);
    gets(zon);
    printf("Ingrese el limite inferior del precio:");
    scanf("%f", &li);
    printf("Ingrese el limite superior del precio:");
    scanf("%f", &ls);
    for (I=0; I<T; I++)
        if ((A[I].dispo == 'R') && (strcmp (A[I].ubi.zona, zon) == 0))
            if ((A[I].precio >= li) && (A[I].precio <= ls))
            {
                printf("\nClave de la propiedad: ");
                puts(A[I].clave);
                printf("\nSuperficie cubierta: %d", A[I].scu);
                printf("\nSuperficie terreno: %d", A[I].ste);
                printf("\nCaracteristicas: ");
                puts(A[I].car);
                printf("Calle: ");
                puts(A[I].ubi.calle);
                printf("Colonia: ");
                puts(A[I].ubi.colo);
                printf("Precio: %.2f", A[I].precio);
            }
}
