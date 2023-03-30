# Call by reference

## C playground 
https://cplayground.com/

Við það að setja parametra inn í föll að þá eru addressurnar sendar áfram inn í föllin.
Þ.a.l. breytingar gerðar á parametrunum inn í föllum taka gildi

```c
// Pseudo code, C will not print those statements
#include <stdio.h>

/* function declaration */
void swap(int x, int y);

int main () {

   /* local variable definition */
   int a = 100;
   int b = 200;

   printf("Fyrir swap, gildi a er : %d\n", a );
   printf("Fyrir swap, gildi b er : %d\n", b );

   /* calling a function to swap the values */
   swap(a, b);

   printf("After swap, gildi a er : %d\n", a );
   printf("After swap, gildi b er : %d\n", b );

   return 0;
}

void swap(int x, int y) {

   int temp;

   temp = x; 
   x = y;    
   y = temp; 

   return;
}
```

Við það að keyra fallið með call by reference prentast út þessi texti

    Fyrir swap, gildi a er : 100
    Fyrir swap, gildi b er : 200
    After swap, gildi a er : 200
    After swap, gildi b er : 100




Hér er breyttur C kóði frá call_by_value dæminu sem að prentar út call by reference aðferðina

```c
#include <stdio.h>

/* function declaration */
void swap(int x, int y, int arr[]);

int main () {

   /* local variable definition */
   int a = 100;
   int b = 200;
   int arr[2]; // Tökum frá minni fyrir tvær int breytur

   arr[0] = a;
   arr[1] = b;

   printf("Fyrir swap, gildi a er : %d\n", arr[0] );
   printf("Fyrir swap, gildi b er : %d\n", arr[1] );

   /* calling a function to swap the values */
   swap(a, b, arr);

   printf("After swap, gildi a er : %d\n", arr[0] );
   printf("After swap, gildi b er : %d\n", arr[1] );

   return 0;
}

void swap(int x, int y, int arr[]) {
    int temp;

    temp = x; 
    x = y;    
    y = temp; 
    
    arr[0] = x; // Overridum gildin í minninu
    arr[1] = y; // Overridum gildin í minninu

    return;
}
```