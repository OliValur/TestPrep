# Parameter dæmi 1

```c
// Pseudo code, C will not print those statements
#include <stdio.h>
int a; = 6
int b;

/* function declaration */
void p(int x, int y)
{
    x = x + 2;               // x = 3      
    a = x * y;               // a = 3 * 2 = 6   
    x = x + 1;               // x = 3 + 1 = 4   
}

int main () {
   a = 1;
   b = 2;

   p(a,b);
   print(a)

   return 0;
}
```

Hvað prentast við   
1. Call by reference   
    Svar: 7

2. Call by value result   
    Svar: 4