# Call by value

## C playground 
https://cplayground.com/

Við það að setja parametra inn í föll að þá eru tekin afrit af alvöru gildinu og sent áfram inn í föllin.
Þ.a.l. breytingar gerðar á parametrunum inn í föllum taka engin gildi utan þess

```c
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

Við það að keyra fallið prentast út þessi texti

    Fyrir swap, gildi a er : 100
    Fyrir swap, gildi b er : 200
    After swap, gildi a er : 100
    After swap, gildi b er : 200
