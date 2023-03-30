# Static scoping

## C playground 
https://cplayground.com/

Með static scoping aðferðinni vísa breytur alltaf til umhverfis efsta stigs og er alveg ótengdur stakknum. 
Static scoping er mun þægilegra að forrita í því forritarar geta fundið út hver breytan er með því að skoða kóðann. 

Í static scoping getur breyta verið 3 möguleikar, yfirskrifaðar á þennan hátt
Skilgreind í fallinu sem compiler-inn er í
Parameter inn í fallið
Global breyta

Í flestum tungumálum í dag er breytur alltaf static scopaðar og eru óháðar stakknum.

```c
#include<stdio.h>
int x = 10;
  
// Kallað í af g()
// Compiler segir hey hvar er þetta x.
// Leitunarröðin fer
// f -> Ekki fundið
// variables -> Ekki fundið
// constants -> Fundið
int f()
{
   return x;
}

// Kallað í af main()
// Undir static scoping reglunni breytan x í fallinu gerir ekkert nema skilgreina nýja breytu sem bendir á aðra addressu en const breytan
// Compila þetta í C playground framkvæmir error því x er ónotuð breyta
int g()
{
   int x = 20;
   return f();
}
  
int main()
{
  printf("%d", g());
  return 0;
}

// Undir static scoping reglunni, að þá skilar þetta fall 10
```

Hvað með þessa útfærslu

```c
#include<stdio.h>
int x = 10;
  
// Þetta fall er ekki keyrt
int f()
{
   return x;
}

// Kallað í af g()
// Compiler segir hey hvar er þetta x. Finnur það í breytunum og skilar því
// Leitunarröðin verður
// f -> Ekki skilgreint í fallinu
// variables -> Fundið
// constants -> Ekki skoðað því að x hefur verið fundið
int f(int x)
{
   return x;
}

// Kallað í af main()
// Kallar í f(x) fallið og sendir breytuna x áfram
int g()
{
   int x = 20;
   return f(x);
}
  
int main()
{
  printf("%d", g());
  return 0;
}

// Undir static scoping reglunni, að þá skilar þetta fall 20
```

Hvað með þessa útfærslu

```c
#include<stdio.h>
int x = 10;
  
// Þetta fall er aldrei keyrt í þessu forriti
int f()
{
   return x;
}

// Kallað í af main()
// Í þessari útfærslu að þá kallar g() ekki í fallið f()
// Í staðinn skilur það breytunni x skilgreint
// Leitunarröðin verður 
// g -> Fundið
// constants -> Ekki skoðað því að x hefur verið fundið
int g()
{
   int x = 20;
   return x;
}
  
int main()
{
  printf("%d", g());
  return 0;
}

// Undir bæði static og dynamic scoping skilar þetta fall 20
```
