#include <stdio.h>
#include <math.h>

void main(void)
{
    float LA1, LA2, LA3, AUX, ARE;
    printf("Ingrese los lados del triangulo: ");
    scanf("%f %f %f ", &LA1, &LA2, &LA3);
    AUX = (LA1 + LA2 + LA3) / 2;
    ARE = sqrt (AUX * (AUX - LA1) * (AUX - LA2) * (AUX - LA3));
    printf("\nEl area del triangulo es: %6.2f", ARE);

}
