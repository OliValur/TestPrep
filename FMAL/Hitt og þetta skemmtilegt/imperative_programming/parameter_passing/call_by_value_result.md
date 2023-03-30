# Call by value result

Hagar sér alveg eins og call_by_value þangað til að það kemur að því að eyða (e. terminate) falli. Þá skilar það parameternum áfram niður stakkinn og yfirritar gamla gildi parametersins sem var 
settur inn í fallið.

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

Við það að keyra fallið með call by value result prentast út þessi texti   
Takið eftir að þetta er sami textinn og í call_by_reference

    Fyrir swap, gildi a er : 100
    Fyrir swap, gildi b er : 200
    After swap, gildi a er : 200
    After swap, gildi b er : 100