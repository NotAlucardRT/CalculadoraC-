
Calculadora MVC (WinForms estilo iOS - Modo Oscuro)

Una sencilla calculadora implementada en C# usando el patrón Modelo-Vista-Controlador (MVC). Cuenta con una interfaz inspirada en iOS con modo oscuro y botones de colores personalizados.

Características:

- Arquitectura MVC clara y mantenible.
- Interfaz moderna tipo iOS:
  - Fondo oscuro
  - Botones redondeados y coloridos:
    - Sumar (verde: #34C759)
    - Restar (rojo: #FF3B30)
    - Multiplicar (azul: #007AFF)
    - Dividir (morado: #AF52DE)
- Control de errores con mensajes amigables.
- Estilo visual pensado para pantallas pequeñas.

Estructura del proyecto:

CalculadoraApp/
├── Modelo/
│   ├── Operacion.cs
│   ├── Suma.cs
│   ├── Resta.cs
│   ├── Multiplicacion.cs
│   └── Division.cs
├── Controlador/
│   └── CalculadoraController.cs
├── Vista/
│   └── CalculadoraForm.cs
└── Program.cs

Instrucciones para ejecutar:

1. Clona el repositorio o descarga los archivos.
2. Abre el proyecto en Visual Studio.
3. Compila y ejecuta (Ctrl + F5).
4. Ingresa dos números y haz clic en una operación.

Requisitos:

- .NET Framework 4.7.2 o superior
- Visual Studio 2019 o superior (o cualquier IDE que soporte WinForms)

Notas técnicas:

- Los botones se redondean usando la API de Windows (CreateRoundRectRgn).
- Los colores se aplican con ColorTranslator.FromHtml.
- Enfoque visual en contraste alto y usabilidad.
