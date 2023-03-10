#include <stdio.h>
/* Examen de admisi�n.
El programa, al recibir como dato un archivo de acceso directo que contiene
informaci�n sobre los alumnos que presentaron el examen de admisi�n a una
universidad, genera informaci�n importante para el Departamento de Control escolar. */
typedef struct /* Declaraci�n de la estructura alumno. */
{
    int clave;
    char nombre[20];
    int carrera;
    float promedio;
    float examen;
    char telefono[12];
} alumno;
float F1(FILE *);
void F2(FILE *,FILE *, FILE *, FILE *, FILE *, FILE *);
void F3(FILE *, FILE *, FILE *, FILE *, FILE *); /* Prototipos de funciones. */
void main(void)
{
    float pro;
    FILE *ap, *c1, *c2, *c3, *c4, *c5;
    ap = fopen("alu1.dat", "r");
    /* Observa que los archivos car1.dat, car2.dat, car3.dat, car4.dat y car5.dat
    se abren en la modalidad para escribir y leer. */
    c1 = fopen("car1.dat", "w+");
    c2 = fopen("car2.dat", "w+");
    c3 = fopen("car3.dat", "w+");
    c4 = fopen("car4.dat", "w+");
    c5 = fopen("car5.dat", "w+");
    if ((ap!=NULL) && (c1!=NULL) && (c2!=NULL) && (c3!=NULL) &&
            (c4!=NULL) && (c5!=NULL))
    {
        pro = F1(ap);
        printf("\nPROMEDIO EXAMEN DE ADMISION: %.2f", pro);
        F2(ap, c1, c2, c3, c4, c5);
        F3(c1, c2, c3, c4, c5);
    }
    else
        printf("\nEl o los archivos no se pudieron abrir";
               fclose(ap);
               fclose(c1);
               fclose(c2);
               fclose(c3);
               fclose(c4);
               fclose(c5);
    }
float F1(FILE *ap)
/* Esta funci�n obtiene el promedio del examen de admisi�n. */
{
    alumno alu;
    float sum = 0, pro;
    int i = 0;
    fread(&alu, sizeof(alumno), 1, ap);
    while (!feof(ap))
    {
        i++;
        sum += alu.examen;
        fread(&alu, sizeof(alumno), 1, ap);
    }
    pro = sum / i;
    return (pro);
}
void F2(FILE *ap, FILE *c1, FILE *c2, FILE *c3, FILE *c4, FILE *c5)
/* Esta funci�n genera un archivo de los alumnos admitidos en cada una de
?las carreras de la universidad. */
{
    alumno alu;
    rewind(ap);
    fread(&alu, sizeof(alumno), 1, ap);
    while (!feof(ap))
    {
        /* Se analiza si el candidato es admitido a la universidad. */
        if (((alu.examen >= 1300) && (alu.promedio >= 8)) || ((alu.examen >= 1400) &&
                (alu.promedio >= 7)))
        {
            switch (alu.carrera)
            {
            case 1:
                fwrite(&alu, sizeof(alumno), 1, c1);
                break;
            case 2:
                fwrite(&alu, sizeof(alumno), 1, c2);
                break;
            case 3:
                fwrite(&alu, sizeof(alumno), 1, c3);
                break;
            case 4:
                fwrite(&alu, sizeof(alumno), 1, c4);
                break;
            case 5:
                fwrite(&alu, sizeof(alumno), 1, c5);
                break;
            }
        }
        fread(&alu, sizeof(alumno), 1, ap);
    }
}
void F3 (FILE *c1, FILE *c2, FILE *c3, FILE *c4, FILE *c5)
/* Esta funci�n se utiliza para obtener el promedio que consiguieron los
alumnos admitidos en cada una de las carreras. */
{
    alumno alu;
    float cal[5], sum;
    int i, j;
    i = 0;
    sum = 0;
    rewind(c1); /* Es importante posicionarse al inicio del archivo, pues
de lo contrario se generar�a un error al ejecutar el programa. */
    fread(&alu, sizeof(alumno), 1, c1);
    while (!feof(c1))
    {
        i++;
        sum += alu.examen;
        fread(&alu, sizeof(alumno), 1, c1);
    }
    if (i)
        cal[0] = (sum / i);
    else
        cal[0] = 0;
    rewind(c2);
    sum = 0;
    i = 0;
    fread(&alu, sizeof(alumno), 1, c2);
    while (!feof(c2))
    {
        i++;
        sum += alu.examen;
        fread(&alu, sizeof(alumno), 1, c2);
    }
    if (i)
        cal[1] = (sum / i);
    else
        cal[1] = 0;
    rewind(c3);
    sum = 0;
    i = 0;
    fread(&alu, sizeof(alumno), 1, c3);
    while (!feof(c3))
    {
        i++;
        sum += alu.examen;
        fread(&alu, sizeof(alumno), 1, c3);
    }
    if (i)
        cal[2] = (sum / i);
    else
        cal[2] = 0;
    rewind(c4);
    sum = 0;
    i = 0;
    fread(&alu, sizeof(alumno), 1, c4);
    while (!feof(c4))
    {
        i++;
        sum += alu.examen;
        fread(&alu, sizeof(alumno), 1, c4);
    }
    if (i)
        cal[3] = (sum / i);
    else
        cal[3] = 0;
    rewind(c5);
    sum = 0;
    i = 0;
    fread(&alu, sizeof(alumno), 1, c5);
    while (!feof(c5))
    {
        i++;
        sum += alu.examen;
        fread(&alu, sizeof(alumno), 1, c5);
    }
    if (i)
        cal[4] = (sum / i);
    else
        cal[4] = 0;
    /* Se imprimen los promedios de los alumnos admitidos en cada carrera. */
    for (i=0; i<5; i++)
        printf("\nPromedio carrera %d: %.2f", i+1, cal[i]);
}
