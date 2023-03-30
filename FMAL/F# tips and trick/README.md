# F# (F-sharp)
It is a __functional programming language__ (or _functional-first_) that is based in the `dotnet` framework. It is a relatively new language and very good for learning about functional programming
> [Watch the introduction video](https://www.youtube.com/watch?v=Teak30_pXHk&list=PLEoMzSkcN8oNiJ67Hd7oRGgD1d4YBxYGC) and [Fundimentals tutorial](https://www.youtube.com/watch?v=SvOInBxPL30)

## Install f-sharp
 Install the `.NET Core SDK` from microsoft (it includes `F#`), that is all.
> Visit [fsharp.org](https://fsharp.org/) for more details

> The `ionide-fsharp` extention for _f-sharp_ is useful when you are coding in VSCode, and probably on other editors as well. 

### Programming in Terminal
1. open a terminal and run `dotnet fsi` to do some live programming in `F#`
> You can load code from `.fs` files into the terminal program
>```
>#load "SomeModule.fs";;
>open SomeModule;;
>```
> It will print out all the defined values that were loaded.
## Syntax notes
* all defined variables/values are immutable
* The program will essentially be nested functions.
* `;;` are required line endings.  
* `let` defines the variable/function scope, can also be considered a code block.
* Since `F#` is part of the `dotnet` framework, you can actually make use of any features/libraries available to `dotnet` from within `F#`.

>Defined values cannot have their data type mutated, for example you cannot use the `sqrt` method to get the square root of an integer, because it only works on floats. You would have to convert the integer into a float in order for the method to work, such as `sqrt float(2)`

## Easy way to run the code from file.

1. Load the _module_ (if any) into whatever file you plan on executing by adding this to your file. 
    ```fs
    #load "pathToModuleFile.fs";;
    open ModuleName;;
    ```
    1. Have `module` as the first line in the file you wish to be loadable into other files.
        ```fs
        module MyProgramName
        ```
1. To run the file directly in the terminal:
    ```fs
    dotnet fsi --use:FileName.fs
    ```
* If you wish to close the script, then you can either type into the open `fsi` terminal, or include it at the bottom of your executing file:
    ```fs
    #quit;;
    ```

## More links
* [Setting up F# development in VSCode](https://forums.fsharp.org/t/how-to-set-up-f-development-in-visual-studio-code/1125)
# Notes Index
* [FSI (Fsharp Interactive) terminal](fsharp-terminal.md)
* [Basic syntax](fsharp-basic.md) / [more notes](fsharp-syntax.md)
    * [Fsharp Crashcourse PDF](f-sharp-crash-course.pdf)
* [Functions](fsharp-functions.md)
* [Lists](fsharp-lists.md)
* [Records](fsharp-records.md) (like _tuples_)
* [Reference pointers](fsharp-pointers.md)