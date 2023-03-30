# F# records
Records are like __tuples__, but components are identified by field names rather than positionally.
* The order in which the fields are listed in a record is irrelevant
* Record types can be recursive
* Field values can be mutable
```fsharp
type person = { name: string; age: int}

let j = { name = "john"; age = 35}
```
> Notice that the same keyword `type` that is used in datatype definitions is also used in record type definitions. Also notice the use of `:` in the record type and `=` in a record.

## Field selection

Field selection can be done with dot-notation or by pattern-matching. 
```fsharp
let n = j.name;;
let { name = n; age = _} = j;;
let {age = a } = j;;
let { person.name = n } = j;;
```
### Recursive records
```fsharp
type parentage = {  name: string;
                    father: parantage option; 
                    mother: parantage option}
let j = { name = "john"; father = None; mother = None};;
let k = { name = "mary"; father = Some j; mother = None};;
```

### Mutable field values
Record field values can be mutable (destructively updatable). This is the first moment we see something not purely functional (iperative) in `F#`
```fsharp
let j = { name = "john"; age = "35"};;
j.age <- 36;;
```
> Note that this is an expression, not a definition by let. This expression is of type `unit`. It returns `()` (no information) but has a side-effect.
>
> Such expressions are called __commands__


###