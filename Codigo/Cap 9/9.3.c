#include <stdio.h>
/* Archivos y cadenas de caracteres.
El programa escribe cadenas de caracteres en un archivo. */
void main(void)
{
    char cad[50];
    int res;
    FILE *ar;
    if ((ar = fopen("arc.txt", "w")) != NULL)
        /* Se abre el archivo para escritura. En la misma instrucci�n se verifica si se pudo abrir. */
    {
        printf("\n�Desea ingresar una cadena de caracteres? Si-1 No-0:");
        scanf("%d", &res);
        while (res)
        {
            fflush(stdin);
            printf("Ingrese la cadena: ");
            gets(cad);
            fputs(cad, ar); /* Observa la forma como se escribe la cadena en el archivo.*/
            printf("\n�Desea ingresar otra cadena de caracteres? Si-1 No-0:");
            scanf("%d", &res);
            if (res)
                fputs("\n", ar);
            /* Se indica un salto de l�nea, excepto en la �ltima cadena. Si no
            se hiciera esta indicaci�n, la funci�n fputs pegar�a las cadenas y
            luego tendr�amos dificultades en el momento de leerlas. Por otra
            parte, si realiz�ramos este salto de l�nea al final de la �ltima
            cadena, en la escritura se repetir�a la �ltima cadena. */
        }
        fclose(ar);
    }
    else
        printf("No se puede abrir el archivo");
}
