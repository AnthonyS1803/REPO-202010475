#include <stdio.h>

int main() {
    int n;
    printf("Ingresar el tamaño de los arrays: ");
    scanf("%d", &n);

    int a[n], b[n], c[n];
    printf("Ingresar los valores del primer array:\n");
    for (int i = 0; i < n; i++) {
        scanf("%d", &a[i]);
    }
    printf("Ingresar los valores del segundo array:\n");
    for (int i = 0; i < n; i++) {
        scanf("%d", &b[i]);
    }

    for (int i = n-1; i >= 0; i--) {
        c[i] = a[i] + b[i];
    }

    printf("El resultado de la suma de los arrays de manera inversa es:\n");
    for (int i = 0; i < n; i++) {
        printf("%d ", c[i]);
    }
    printf("\n");

    return 0;
}
