# 2020 próf pointer dæmið

```
int* p;             
int* q;             
int x;
x = 3;
p = &x;             // p er sett á addressuna af x, allar breytingar á addressuna p hafa áhrif á x
print *p;           // Prentum út contentið af p, þ.e. gildi x sem er 3
q = p;              // q bendir á sömu addressuna og p
*p = *q * 5;        // contentið af p = contentið af q * 5, þ.e.a.s. gildið á x fær 15
print x;            // Prentum út 15
```

Hvað prentast út?    
3 og 15



C forritið sem framkvæmir þetta
```c
#include <stdio.h>
int main()
{
    int* p;
    int* q;
    int x;
    x = 3;
    p = &x;
    printf("%d ", *p);
    q = p;
    *p = *q * 5;
    printf("%d", x);

   return 0;
}
```