# Sistema de Gestión de Asistencias

Este en un programa que se encarga de manejar un sistema de registro de personal 
y el procesamiento de archivos para las asistencias. Permite realizar consultas de 
asistencias ya sea de forma individual o global. También brinda la posibilidad de 
editar, agregar o eliminar personal y una opción para ver y agregar días libres.

## Herramientas y Tecnologías
- **Visual Studio**: Entorno de desarrollo
- **Visual Basic**: Lenguaje de programación principal
- **phpMyAdmin**: Base de datos local para el manejo de datos
- **MySql.Data**: Librería para manejar la conexión con la base de datos
- **RealTaiizor**: Framework de diseño que permite crear interfaces modernas

## Arquitectura de la Aplicación
La aplicación sigue el patrón de diseño **MVC (Modelo–Vista–Controlador)**:

- **Modelo**:  
  Clases que representan los datos del sistema.

- **Vista**:  
  Actividades y fragmentos encargados de mostrar la interfaz de usuario.

- **Controlador**:  
  Manejo de la lógica de negocio, navegación entre pantallas y validaciones.

## Funciones Principales
- Procesar archivos de asistencia de hasta 100 mil registros.
- Consulta de asistencias individuales y globales en fechas específicas.
- Agregar, eliminar y editar personal.
- Gestión de días libres.

## Cómo Ejecutar la Aplicación: 
1. Descarga el proyecto y abre Visual Studio, abre la carpeta **Proyecto1** y selecciona la solución (Proyecto1.sln).
2. Inicia apache y MySQL en la aplicación de XAMM y entra a la página 
de phpMyAdmin. 
3. En phpMyAdmin importa la base de datos llamada **asistencia.sql** que 
viene dentro de la carpeta raíz del proyecto.
4. Inicia la aplicación desde Visual Studio.

## Pantallas
<p align="center">
  <img src="https://github.com/user-attachments/assets/7d1679d9-f1b8-4a8b-a382-3289b2bd5ce4" width="45%" />
  <img src="https://github.com/user-attachments/assets/a14e4b88-0db3-4e26-bede-f3618698ca1a" width="45%" />
</p>

<p align="center">
  <img src="https://github.com/user-attachments/assets/aff85ac3-3b99-4e6e-bdc6-54c089c194fb" width="45%" />
  <img src="https://github.com/user-attachments/assets/f4af0c76-632a-4a5a-a349-c186249ea6ec" width="45%" />
</p>

<p align="center">
  <img src="https://github.com/user-attachments/assets/e5ec251b-2022-42b4-bfc1-1587172087b5" width="45%" />
</p>

