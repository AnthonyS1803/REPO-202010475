#include <stdio.h>
/* Alumnos.
El programa pregunta al usuario el n�mero de registro que desea
modificar, obtiene el nuevo promedio del alumno y modifica tanto el
registro como el archivo correspondiente. */
typedef struct /* Declaraci�n de la estructura alumno. */
{
    int matricula;
    char nombre[20];
    int carrera;
    float promedio;
} alumno;
void modifica(FILE *); /* Prototipo de funci�n. */
void main(void)
{
    FILE *ar;
    if ((ar = fopen ("ad1.dat", "r+")) != NULL)
        modifica(ar);
    else
        printf("\nEl archivo no se puede abrir");
    fclose(ar);
}
void modifica(FILE *ap)
/* Esta funci�n se utiliza para modificar el promedio de un alumno. */
{
    int d;
    alumno alu;
    printf("\nIngrese el numero de registro que desea modificar: ");
    /* Observa que el lenguaje C almacena el primer registro en la
    posici�n cero. Por lo tanto, si desea modificar el registro n,
    debe buscarlo en la posici�n n-1. */
    scanf("%d", &d);
    fseek(ap, (d-1)*sizeof(alumno), 0);
    /* Observa que la instrucci�n fseek tiene tres argumentos. El primero
    indica que el apuntador se debe posicionar al inicio del FILE.
    El segundo se�ala el n�mero de bloques que debe moverse, en t�rminos
    de bytes, para llegar al registro correspondiente. Nota que el
    primer registro ocupa la posici�n 0. Finalmente, el tercer argumento
    muestra a partir de qu� posici�n se debe mover el bloque de bytes:
    se utiliza el 0 para indicar el inicio del archivo, 1 para expresar
    que se debe mover a partir de la posici�n en la que actualmente se
    encuentra y 2 para indicar que el movimiento es a partir del fin del
    archivo. */
    fread(&alu, sizeof(alumno), 1, ap);
    /* Luego de posicionarnos en el registro que nos interesa, lo leemos. */
    printf("\nIngrese el promedio correcto del alumno: ");
    scanf("%f", &alu.promedio); /* Modificamos el registro con el
nuevo promedio. */
    fseek(ap, (d-1)*sizeof(alumno), 0);
    /* Nos tenemos que posicionar nuevamente en el lugar correcto para
    escribir el registro modificado. Observa que si no hacemos este
    reposicionamiento escribir�amos el registro actualizado en la
    siguiente posici�n. */
    fwrite(&alu, sizeof(alumno), 1, ap);
}
