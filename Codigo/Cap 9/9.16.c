#include <stdio.h>
#include <stdlib.h>
/* Suma reales.
El programa lee cadenas de caracteres de un archivo, detecta aquellas que
comienzan con n�meros, los suma y calcula el promedio de los mismos. */
void sumypro(FILE *); /* Prototipo de funci�n. */
void main(void)
{
    FILE *ap;
    if ((ap=fopen("arc2.txt", "r")) != NULL)
    {
        sumypro(ap);
        /* Se llama a la funci�n sumypro. Se pasa el archivo ap como par�metro. */
        fclose(ap);
    }
    else
        printf("No se puede abrir el archivo");
}
void sumypro(FILE *ap1)
/* Esta funci�n lee cadenas de caracteres de un archivo, detecta aquellas
que comienzan con n�meros, y obtiene la suma y el promedio de dichos n�meros. */
{
    char cad[30];
    int i = 0;
    float sum = 0.0, r;
    while (!feof (ap1))
    {
        fgets(cad,30,ap1); /* Se lee la cadena del archivo. */
        r = atof(cad);
        /* Recuerda que la funci�n atof convierte una cadena de caracteres que
        contiene n�meros reales a un valor de tipo double. Si la cadena comienza
        con otro caracter o no contiene n�meros, regresa 0 o el valor queda indefinido. */
        if (r)
        {
            i++;
            sum += r;
        }
    }
    printf("\nSuma: %.2f2", sum);
    if (i) /* Si el valor de i es distinto de cero, calcula el promedio. */
        printf("\nPromedio: %.2f", sum/i);
}
