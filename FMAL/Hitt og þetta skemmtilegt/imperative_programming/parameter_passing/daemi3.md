# Parameter dæmi 3

Þetta dæmi var á 2018 prófinu

```
{
    int x = 8;

    void p(int y) {
        y = y + 3;
        print (x);
        print (y);
    }

    p(x);
    print (x);
}
```


Hvað prentast við 
1. Call by value    
    Svar: 8 11 8

2. Call by reference    
    Svar: 11 11 11

3. Call by value result    
    Svar: 8 11 11