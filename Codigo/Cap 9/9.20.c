# incluir  < stdio.h >
/* Escuela.
El programa, al recibir como dato un archivo de acceso directo que contiene
informaci�n de los alumnos de una escuela, genera informaci�n estad�stica importante. */
typedef  struct  /* Declaraci�n de la estructura matcal. */
{
    materia char [ 20 ];
    calificaci�n int ;
} mateal;
typedef  struct  /* Declaraci�n de la estructura alumno. */
{
    matr�cula int ;
    char nombre[ 20 ];
    matecal cal[ 5 ];
    /* Observe que un campo de esta estructura es a su vez estructura. */
} alumno;
vac�o  F1 (ARCHIVO *);
vac�o  F2 (ARCHIVO *); /* Prototipos de funciones. */
flotar F3FILE *);
vac�o  principal ( vac�o )
{
    flotador pro;
    ARCHIVO *ap;
    if ((ap = fopen ( " esc.dat " , " r " )) != NULL )
    {
        F1 (ap);
        F2 (ap);
        pro = F3 (ap);
        printf ( " \n\n PROMEDIO GENERAL MATERIA 4: %f " ,pro);
    }
    m�s
        printf ( " \n El archivo no se puede abrir " );
    cerrar (ap);
}
vac�o  F1 (ARCHIVO *ap)
/* La funci�n escribe la matr�cula y el promedio general de cada alumno. */
{
    alumno alu;
    intj ;
    suma flotante , pro;
    printf ( " \n MATRICULA y PROMEDIOS " );
    fread (&alu, tama�o de (alumno), 1 , ap);
    mientras (! feof (ap))
    {
        printf ( " \n Matricula: %d " , alu. matricula );
        suma = 0.0 ;
        para (j= 0 ; j< 5 ; j++)
            suma += alu. cal [j]. calificacion ;
        pro = suma / 5 ;
        printf ( " \t Promedio: %f " , pro);
        fread (&alu, tama�o de (alumno), 1 , ap);
    }
}
vac�o  F2 (ARCHIVO *ap)
/* La funci�n escribe la matr�cula de los alumnos cuya calificaci�n en la
tercera materia es mayor a 9. */
{
    alumno alu;
    intj ;
    rebobinar (ap);
    printf ( " \n\n ALUMNOS CON CALIFICACION > 9 EN MATERIA 3 " );
    fread (&alu, tama�o de (alumno), 1 , ap);
    mientras (! feof (ap))
    {
        si (alu. cal [ 2 ]. calificacion > 9 )
            printf ( " \n Matricula del alumno: %d " , alu. matricula );
        fread (&alu, tama�o de (alumno), 1 , ap);
    }
}
flotante  F3 (ARCHIVO *ap)
/* Esta funci�n obtiene el promedio general de la materia 4. */
{
    alumno alu;
    int i = 0 ;
    suma flotante = 0 , favorable;
    rebobinar (ap);
    fread (&alu, tama�o de (alumno), 1 , ap);
    mientras (! feof (ap))
    {
        yo++;
        suma += alu. cal [ 3 ]. calificacion ;
        fread (&alu, tama�o de (alumno), 1 , ap);
    }
    pro = ( flotante ) suma / i;
    volver (pro);
}
