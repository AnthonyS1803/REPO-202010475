#include <stdio.h>
/* Incorpora caracteres.
El programa agrega caracteres al archivo libro.txt. */
void main(void)
{
    char p1;
    FILE *ar;
    ar = fopen("libro.txt", "a");
    /* Se abre el archivo con la opci�n para incorporar caracteres. */
    if (ar != NULL)
    {
        while ((p1 = getchar()) != '\n')
            fputc(p1, ar);
        fclose(ar);
    }
    else
        printf("No se puede abrir el archivo");
}
