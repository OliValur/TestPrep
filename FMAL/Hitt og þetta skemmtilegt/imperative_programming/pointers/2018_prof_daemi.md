# 2018 próf pointer dæmið

```
{
    int* p = new int;
    int* q = new int;
    *p = 17;                // Contentið af p fær 17
    *q = 42;                // Contentið af q fær 42 
    p = q;                  // p bendir nú á sömu addressuna og q, þ.e. *p verður að 42
    print (*p);             // Prentum út 42
    *p = *q + 1;            // Contentið af addressunni sem p og q benda á fær gildið 43
    print (*p);             // Prentum út 43
    print (*q);             // Prentum út 43
}
```


Hvað prentast út?   
42 43 43


C forritið sem framkvæmir þetta
```c
#include <stdio.h>
int main()
{
    int* p = new int;
    int* q = new int;
    *p = 17; 
    *q = 42;
    p = q;
    printf("%d ", *p);
    *p = *q + 1;
    printf("%d ", *p);
    printf("%d ", *q);

    return 0;
}
```