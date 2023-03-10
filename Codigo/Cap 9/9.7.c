#include <stdio.h>
/* Archivos con variables enteras y reales.
El programa lee informaci�n de los alumnos de una escuela, almacenada en un
archivo. Utiliza una funci�n para realizar la lectura, pero el archivo se abre
y cierra desde el programa principal. */
void promedio(FILE *);
/* Prototipo de funci�n. Se pasa un archivo como par�metro. */
void main(void)
{
    FILE *ar;
    if ((ar = fopen("arc9.txt", "r")) != NULL)
    {
        promedio(ar); /* Se llama a la funci�n promedio. Observe la forma
como se pasa el archivo como par�metro. */
        fclose(ar);
    }
    else
        printf("No se puede abrir el archivo");
}
void promedio(FILE *ar1) /* Observa la forma como se recibe el archivo. */
/* Esta funci�n lee los datos de los alumnos desde un archivo, e imprime tanto
la matr�cula como el promedio de cada alumno. */
{
    int i, j, n, mat;
    float pro, cal;
    fscanf(ar1, "%d", &n);
    for (i=0; i<n; i++)
    {
        fscanf(ar1, "%d", &mat);
        printf("%d\t", mat);
        pro = 0;
        for (j = 0; j < 5; j++)
        {
            fscanf(ar1, "%f", &cal);
            pro += cal;
        }
        printf("\t %.2f ", pro / 5);
        printf("\n");
    }
}
