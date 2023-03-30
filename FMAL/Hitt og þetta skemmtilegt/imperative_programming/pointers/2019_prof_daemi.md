# 2019 próf pointer dæmið

```
{
    int* p = new int;
    int* q = new int;
    *p = 17;                // Contentið af p fær 17
    q = p;                  // q bendir á sömu address og p, þ.e. *p = 17 og *q = 17
    print (*q);             // Prentum út 17
    *q = *p + 1;            // *q fær gildið 18 og *p fær líka gildið 18 þar sem pointerarnir vísa báðir á sömu addressuna
    print (*p);             // Prentum út 18
    p = q;                  // Gerir í raun ekkert þar sem báðir pointerarnir vísa á sömu addressu
    print (*q);             // Prentum út 18
}
```


Hvað prentast út?   
17 18 18


C forritið sem framkvæmir þetta
```c
#include <stdio.h>
int main()
{
    int* p = new int;
    int* q = new int;
    *p = 17;
    q = p;
    printf("%d ", *q);
    *q = *p + 1;
    printf("%d ", *p);
    p = q;
    printf("%d ", *q);

    return 0;
}
```