# Calculadora de Escritorio

Esta es una calculadora de escritorio simple, creada en C# utilizando Windows Forms. Proporciona las funciones básicas de una calculadora estándar, como suma, resta, multiplicación y división, además de otros botones funcionales como porcentaje, punto decimal, y limpiar.

## Características

- **Suma, Resta, Multiplicación y División**: Realiza cálculos básicos.
- **Borrar**: Permite borrar el último dígito o limpiar la pantalla por completo.
- **Decimal**: Incluye la funcionalidad de punto decimal.
- **Manejo de Errores**: Muestra un mensaje de error si se intenta dividir entre cero.
  
## Requisitos Previos

Para ejecutar esta calculadora, necesitas:
- .NET Framework 4.8 (o superior). Puedes descargarlo [aquí](https://dotnet.microsoft.com/download/dotnet-framework).

## Instalación

### Desde Visual Studio
1. Clona o descarga el repositorio en tu máquina local.
2. Abre el proyecto en Visual Studio.
3. Compila y ejecuta el proyecto directamente desde Visual Studio con el botón "Iniciar".
  
### Instalación como Aplicación
Si deseas instalar la calculadora en tu equipo como un programa de escritorio independiente:
1. Publica el proyecto desde Visual Studio:
   - Ve a `Compilar > Publicar {nombre del proyecto}`.
   - Selecciona la ubicación donde deseas publicar.
   - Sigue las instrucciones para crear un instalador (`setup.exe`).
2. Ejecuta el archivo `setup.exe` en la carpeta de publicación para instalar la calculadora en tu equipo.
3. Una vez instalada, la aplicación estará disponible en el menú Inicio de Windows.

## Uso

- **Introducir Números**: Haz clic en los botones numéricos para ingresar los valores.
- **Operadores**: Usa los botones de operadores (`+`, `-`, `×`, `÷`) para realizar cálculos.
- **Punto Decimal**: Agrega decimales presionando el botón `.`.
- **Porcentaje**: Calcula el porcentaje de un número ingresado.
- **Igual (=)**: Muestra el resultado de la operación en curso.
- **C (Clear)**: Limpia la pantalla y restablece todos los valores.
- **CE (Clear Entry)**: Borra el último dígito ingresado.

### Ejemplo de División por Cero
Si intentas dividir por cero, la calculadora mostrará el mensaje "DIVISION BY ZERO" en la pantalla por medio segundo y luego reiniciará a 0.

## Contribución

Las contribuciones son bienvenidas. Puedes hacer un fork del proyecto, crear una nueva rama, implementar tus mejoras y luego enviar un pull request. 

1. Haz un fork del repositorio.
2. Crea una rama de características (`git checkout -b feature/NuevaCaracteristica`).
3. Haz commit de tus cambios (`git commit -m 'Añadir Nueva Característica'`).
4. Haz push a la rama (`git push origin feature/NuevaCaracteristica`).
5. Abre un pull request.

## Contacto

Para cualquier consulta o sugerencia, puedes comunicarte a través de [samgdev91@gmail.com].

---

¡Gracias por usar esta calculadora! Esperamos que sea útil en tus tareas diarias.
