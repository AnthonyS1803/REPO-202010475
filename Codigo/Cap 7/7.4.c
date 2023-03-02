#include <stdio.h>
/* Declaraci�n de cadenas de caracteres y asignaci�n de valores. */
void main(void)
{
char *cad0;
cad0 = "Argentina"; /* La declaraci�n y la asignaci�n son correctas. */
puts(cad0);
cad0 = "Brasil";
/* Correcto. Se modifica el contenido de la posici�n en memoria a la que apunta
la variable cad0 �apuntador de tipo cadena de caracteres. */
puts(cad0);
char *cad1;
gets(*cad1); gets(cad1);
/* Incorrecto. Ambas lecturas generan un error en la ejecuci�n del programa.
Para que un apuntador de tipo cadena de caracteres se pueda utilizar con la
funci�n de lectura gets, es necesario inicializarlo como se hace en la siguiente
instrucci�n. */
char *cad1 = "";
gets(cad1);
/* Correcto. Primero se le asigna un valor a la posici�n de memoria a la que
apunta cad1. Luego podemos modificar el contenido de esta posici�n de memoria
utilizando la funci�n gets. */
char cad1[];
/* Incorrecto. Se genera un error en la compilaci�n del programa, porque no
se reserva el espacio correspondiente. */
char cad2[20] = "M�xico"; /* Correcto. */
puts(cad2);
gets(cad2);
/* El valor de una cadena (declarada como cadena[longitud]) se puede modificar
por medio de lecturas o utilizando funciones de la biblioteca string.h
(ejemplo 7.6). */
puts(cad2);
cad2[10] = "Guatemala";
/* Incorrecto. Observa cuidadosamente el caso anterior y analiza la diferencia
que existe con �ste. Aqu� se produce un error en la compilaci�n del programa,
al tratar de asignar la cadena de caracteres �Guatemala� al caracter 11 de la
cadena. */
}
