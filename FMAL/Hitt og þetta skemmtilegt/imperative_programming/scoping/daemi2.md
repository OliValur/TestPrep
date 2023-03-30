# Scoping dæmi 2

Þetta dæmi var á 2018 prófinu

```
{
int x = 1;           

void p() {                
    x = x + 5;
}

{
    int x = 2;       
    p();
    print (x);
}

print (x);
}
```

Hvað prentast við    
1. **Static scoping reglunni**      
    Svar: 2 6

2. **Dynamic scoping reglunni**      
    Svar: 7 1