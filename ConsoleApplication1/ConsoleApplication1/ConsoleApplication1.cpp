#include<stdio.h>

int main() {
    int n;
    scanf("%d", &n);
    int arr[n];
    int c;
    for (int i = 0; i < n; i++) {
        scanf("%d", &arr[i]);
    }

    for (int i = 0; i < n - 1; i++) {
        for (int j = 0; j < n - 1; j++) {
            if (arr[j + 1] < arr[j]) {
                c = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = c;
            }
        }
    }
    for (int i = 0; i < n; i++) {
        printf("%d ", arr[i]);
    }

    return 0;
}