# Parameter dæmi 2

Þetta dæmi var á 2019 prófinu

```c
{
    int x = 17;

    void p(int y) {
        print (y);
        y = 42;
        print (x);
    }

    p(x);
    print(x);
}
```

Hvað prentast við 
1. Call by value    
    Svar: 17 17 17

2. Call by reference     
    Svar: 17 42 42

3. Call by value result     
    Svar: 17 17 42