# Test

Gefinn er kóðinn
```

// *
{
    int x = 1;
    void p() {
        print(x);               // Stakkurinn p - ** - *
        x = 3;
    }
    
    // **
    {
        int x = 2;              // x = 3 núna í dynamic scope
        p();
    }

    print(x);                   // Stakkurinn *
}
```

Hvað er prentað undir    

**(a) static scope**    
Svar: 1 3

**(b) dynamic scope**    
Svar: 2 1