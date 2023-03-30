# Scoping dæmi 1

Þetta dæmi var á 2019 prófinu

```
{
int x = 1;

void p() {
    print (x);
    x = 3;
}

{
    int x = 2;
    p();
}

print (x);
}

```

Hvað prentast við   
1. **Static scoping reglunni**    
    Svar: 1 3

2. **Dynamic scoping reglunni**   
    Svar: 2 1