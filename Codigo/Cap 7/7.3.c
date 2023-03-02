#include <stdio.h>
/* Funciones para el manejo de cadenas de caracteres de la biblioteca stdio.h. */
void main(void)
{
char *cad0 = "Buenos d�as"; /* En este caso se asignan 11 caracteres m�s el
caracter de terminaci�n �\0� a la posici�n de memoria a la que apunta la
variable cad0 �apuntador del tipo cadena de caracteres. */
char cad1[20] = "Hola"; /* Se asignan cuatro caracteres m�s el caracter
de terminaci�n a la variable tipo char cad1. Observa que cad1 tiene espacio
para 20 caracteres.*/
char cad2[] = "M�xico"; /* En este caso se asignan seis caracteres (m�s
el caracter de terminaci�n) a la variable cad2. Observa que cad2 no tiene espacio
reservado como cad1; por lo tanto, acepta cualquier n�mero de caracteres. */
char cad3[] = {'B', 'i', 'e', 'n', 'v', 'e', 'n', 'i', 'd', 'o', '\0'};
/* Observa otra forma de asignaci�n de valores a la variable cad3. */
char cad4[20], cad5[20], cad6[20];
printf("\nLa cadena cad0 es: ");
puts(cad0);
/* La funci�n puts es la m�s apropiada para escribir cadenas de caracteres.
Observa que esta funci�n baja autom�ticamente una l�nea despu�s de imprimir
la cadena. */
printf("\nLa cadena cad1 es: ");
printf("%s", cad1);
/* La funci�n printf, con el formato de variable %s, tambi�n se puede utilizar
para escribir cadenas de caracteres. Baja autom�ticamente una l�nea despu�s
de escribir la cadena.*/
printf("\nLa cadena cad2 es: ");
puts(cad2);
printf("\nLa cadena cad3 es: ");
puts(cad3);
printf("\nIngrese una l�nea de texto �se lee con gets�: \n");
/* La funci�n gets es la m�s apropiada para leer cadenas de caracteres. */
gets(cad4);
printf("\nLa cadena cad4 es: ");
puts(cad4);
fflush(stdin);
printf("\nIngrese una l�nea de texto �se lee con scanf�: \n");
scanf("%s", cad5);
/* La funci�n scanf, con el formato de variable %s, tambi�n se puede utilizar
para leer una cadena de caracteres, aunque con algunas restricciones. Si la
cadena est� formada por varias palabras s�lo lee la primera. Por ejemplo, si
queremos ingresar la cadena �Buenos d�as�, s�lo lee la palabra �Buenos�, por
ello esta funci�n �nicamente es �til si conocemos con anticipaci�n que la
cadena que vamos a leer est� formada por una sola palabra. */
printf("\nLa cadena cad5 es: ");
printf("%s", cad5);
fflush(stdin);
char p;
int i = 0;
/* La declaraci�n de variables siempre se debe realizar en la parte inicial del
programa. En este caso se colocan en esta secci�n (char p e int i = 0) para
que puedas observar la relaci�n directa con las l�neas de programaci�n que se
muestran a continuaci�n. */
printf("\nIngrese una l�nea de texto �se lee cada caracter con getchar�: \n");
/* Se utiliza la funci�n getchar para leer caracteres de la l�nea de texto y
asignarlos a la variable de tipo cadena de caracteres cad6. Observa que se leen
caracteres mientras no se encuentre al caracter que indica fin de l�nea �\n�. */
while ((p = getchar())!= '\n')
cad6[i++] = p;
cad6[i] = '\0';
/* Al final de la cadena se incorpora el caracter de terminaci�n NULL para
indicar el fin de la misma. */
printf("\nLa cadena cad6 es: ");
puts(cad6);
}
