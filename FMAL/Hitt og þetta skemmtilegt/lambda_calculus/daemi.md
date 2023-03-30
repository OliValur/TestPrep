# Lambda dæmi

(λx.(λy.xy))(λx.x)(z)

**Svar: z**



(λz.z) (λy.y y) (λx.x a)   

**Svar: a a**



(λz.z) (λz.z z) (λz.z y) 

**Svar: y y**



(λx.λy.x y y) (λa.a) b

**Svar: b b**



(λx.λy.x y y) (λy.y) y

**Svar: y y**



(λx.x x) (λy.y x) z 

**Svar: x x z**



(λx. (λy. (x y)) y) z

**Svar: z y**



((λx.x x) (λy.y)) (λy.y) 

**Svar: λy.y**



(((λx. λy.(x y))(λy.y)) w)  

**Svar: w**


// TODO: Gera 2019 lambda dæmið erfiða