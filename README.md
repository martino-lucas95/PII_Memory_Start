![UCU](https://github.com/ucudal/PII_Conceptos_de_POO/raw/master/Assets/logo-ucu.png)

# Universidad Católica del Uruguay

## Facultad de Ingeniería y Tecnologías

### Programación II

Código de ejemplo del tema "ciclo de vida de los objetos".

Este código utiliza una clase ```Demo``` que usaremos para entender el ciclo de vida de los objetos -mira el código completo [aquí](https://github.com/ucudal/PII_Memory_Start/blob/main/src/Library/Demo.cs)-:

```csharp
public class Demo
{
    public Demo(string text)
    {
        this.Text = text;
        Console.WriteLine($"Construyendo {this.Text}...");
    }

    public string Text { get; set; }

    ~Demo()
    {
        Console.WriteLine($"Destruyendo {this.Text}...");
    }
}
```

La clase tiene una propiedad ```Text``` que representa el estado del objeto. El valor inicial de esta propiedad se pasa como argumento al constructor ```Demo(string)```.

Cuando se crea una instancia de esta clase se imprime en la consola ```Construyendo <texto>...``` donde ```<texto>``` es el valor de la propiedad ```Text```.

Cuando se destruye una instancia de esta clase se imprime en la consola ```Destruyendo <texto>...``` donde nuevamente ```<texto>``` es el valor de la propiedad ```Text```.

Esto te permite ver cuándo se construye un objeto y cuándo se destruye.

Para ver cómo funciona este clase te damos este programa principal que simplemente crea un objeto y termina:

```csharp
public static class Program
{
    public static void Main()
    {
        Demo demo1 = new Demo("Demo 1");
    }
    ...
}
```

De hecho, si ejecutas el programa principal de este repo, verás lo siguiente en la consola -mira el código completo [aquí](https://github.com/ucudal/PII_Memory_Start/blob/main/src/Program/Program.cs)-:

```
Construyendo Demo 1...
Destruyendo Demo 1...
```

Esto ocurre porque todos los objetos se destruyen cuando finaliza el programa.

Ten en cuenta que el runtime optimiza la recolección de la memoria ocupada por los objetos y no destruye los objetos de inmediato en cuanto dejan de ser accesibles.

Para forzar este comportamiento en cualquier momento durante la ejecución del programa, te damos en la clase ```Program``` un método ```void DestroyUnaccesibleObjects()```. Este método logra que se destruyan los objetos que dejan de ser accesibles.

Por ejemplo, si fuera este el programa principal, verías los mismos mensajes que antes, y luego tendrías que presionar alguna tecla para que el programa termine:

```csharp
public static class Program
{
    public static void Main()
    {
        Demo demo1 = new Demo("Demo 1");
        demo1 = null;

        DestroyUnaccesibleObjects();

        Console.Write("Press any key to continue...");
        Console.ReadKey();
    }
    ...
}
```

En la consola aparecería:

```
Construyendo Demo 1...
Destruyendo Demo 1...
Press any key to continue...
```