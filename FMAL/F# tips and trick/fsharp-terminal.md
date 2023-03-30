# F-sharp in terminal

## FSI (F-sharp interactive)
If you have the _.NET Core SDK_ installed and enabled, then you can open the `fsi` terminal through `dotnet`. It will execute block of code you write, ending the blocks with `;;` to execute it.
```
dotnet fsi
```

* For some help with `fsi`
    ```
    #help;;
    ```
* To exit the `fsi`
    ```
    #quit;;
    ```

## Using FSI within VSCode
As long as the `fsi` terminal is open, it will remember all the previously executed code. You might want to kill the terminal for a fresh start when it matters.

### Through the Command Palette
>You can write `fsi` into the Command Palette (`View` > `Command Palette`) to get a list of all the commands you can perform on the currently selected  `.fs` file. Such as `send line`, `send selection` or `send file`, which will all send the indicated code to be executed in the Fsharp Interactive terminal. 
>
> The Command Palette also shows you the associated keyboard shortcuts if the commands have them, which is very handy.

### Keyboard shortcuts
>* `Alt` + `Enter` (Send selection)
    > This will send the selected code in the `fsi` terminal to be executed.


## Loading code from file in `fsi`
1. First the script needs to be a module, by adding this at the top of the file:
    ```
    module Script1
    ```
1. Load your code from the file to the `fsi` terminal
    ```
    #load "Script1.fsx"
    open Script1
    ```