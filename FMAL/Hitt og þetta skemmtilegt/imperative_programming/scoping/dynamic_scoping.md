# Dynamic scoping

Dynamic scope er ekki algengt í nútíma forritunarmálum.
Á tæknilegu máli, dynamic scoping safnar bindingum saman á stakkinn og leitar á stakknum í röð eftir 'identifier'

Á einfaldara máli, dynamic scoping leitar fyrst í fallinu sem það er í, svo í fallið sem kallaði í það og svo koll af kolli

Það er best að hugsa um stakk þegar verið er að díla við dynamic scoping. 
Í hvert skipti sem nýtt fall er kallað á, er því ýtt á stakkinn.
Compiler-inn fer svo niður eftir stakknum að leita eftir 'identifiernum' byrjandi efst á stakknum eða í fallinu sem kóðinn er í akkúrat núna

```c
// A C program to demonstrate dynamic scoping with pseudo code.
#include<stdio.h>
int x = 10;

// Kallað í af g()
// Með því að kalla á f(), þá er fallinu f bætt við stakkinn
// Núna er stakkurinn f - g - main
// Leitunarröðin fyrir breytuna x verður því
// f -> Fannst ekki
// g -> Fundið, skilar 20
// main -> Verður ekki skoðað því x hefur verið fundið
// const breytan -> Verður ekki skoðað því x hefur verið fundið
int f()
{
   return x;
}

// Kallað í af main()
// Með því að kalla á g(), þá er fallinu g bætt við stakkinn
// Núna er stakkurinn g - main
int g()
{
   int x = 20;
   return f();
}

// Með því að kalla á main, þá er fallinu main bætt við stakkinn.
// Eina fallið á stakknum núna er þá main
int main()
{
  printf("%d", g());
  return 0;
}

// Undir reglum dynamic scoping að þá skilar þetta fall 20
```
