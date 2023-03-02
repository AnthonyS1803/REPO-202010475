# include <stdio.h>
# include <ctype.h>
/* Funciones para el manejo de caracteres de la biblioteca ctype.h. */
void main(void)
{char p1;
printf("\nIngrese un caracter para analizar si �ste es un d�gito: ");
p1 = getchar();
if (isdigit (p1))
/* La funci�n isdigit regresa 1 si p1 es un d�gito y 0 en caso contrario. */
printf("%c es un d�gito \n", p1);
else
printf("%c no es un d�gito \n", p1);
fflush(stdin);
printf("\nIngrese un caracter para examinar si �ste es una letra: ");
p1 = getchar();
if (isalpha (p1))
/* La funci�n isalpha regresa 1 si p1 es una letra y 0 en caso contrario. */
printf("%c es una letra \n", p1);
else
printf("%c no es una letra \n", p1);
fflush(stdin);
printf("\nIngrese un caracter para examinar si �ste es una letra min�scula: ");
p1 = getchar();
if (isalpha (p1))
if (islower (p1))
/* La funci�n islower regresa 1 si p1 es una letra min�scula y 0 en caso
contrario.
La funci�n isupper, por otra parte, regresa 1 si p1 es una letra may�scula
y 0 en caso contrario. */
printf("%c es una letra min�scula \n", p1);
else
printf("%c no es una letra min�scula \n", p1);
else
printf("%c no es una letra \n", p1);
fflush(stdin);
printf("\nIngrese una letra para convertirla de may�scula a min�scula: ");
p1 = getchar();
if (isalpha (p1))
if (isupper(p1))
printf("%c fue convertida de may�scula a min�scula \n", tolower(p1));
/* La funci�n tolower convierte de may�scula a min�scula. Si la
letra es min�scula no la modifica. La funci�n toupper, por otra parte,
convierte de min�scula a may�scula. Si la letra es may�scula no la
modifica. */
else
printf("%c es una letra min�scula \n", p1);
else
printf("%c no es una letra \n", p1);
}
