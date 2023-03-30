# Static vs Dynamic scoping

## Perl playground
https://perlbanjo.com/

Í langflestum tungumálum er static scoping notað. Það er einfaldlega vegna þess að í static scoping er auðvelt að rökræða og skilja bara með því að horfa á kóðann.
Við getum séð hvaða breytur eru í scope-inu bara með því að horfa á textann í editor-inum okkar.

Dynamic scoping er sama um það hvernig kóðinn er skrifaður, bara í hvaða röð hann keyrir. 
Í hvert skipti sem að nýtt fall er keyrt, nýtt scope er ýtt á stakkinn.
En þegar fall er búið að keyra, þá er því scope-i hent af stakknum.

Perl er eitt af þeim tungumálum sem að styður bæði dynamic og static scoping.
Það notar lykilorðin 'my' og 'local' til að skilgreina hvort breytur séu dynamic eða static.

```perl
$x = 10;
$y = 15;
sub f 
{ 
   return $x; 
}

sub static 
{ 
   # Þar sem my er notað, þá notar x
   # static scoping. 
   my $x = 20; 
  
   return f(); 
}

sub dynamic
{ 
   # Þar sem local er notað, þá notar x
   # dynamic scoping. 
   local $x = 20; 
  
   return f(); 
}

sub test
{
   dynamic();

   # Hverju verður skilað hér? 10 eða 20?
   # Hver er stakkurinn þegar komið er hingað?
   return $x;
}

print static()."\n"; 
print dynamic()."\n";

print test()."\n";
print $y."\n";

# Þetta forrit prentar út 
# 10
# 20
# ?
# 15
```