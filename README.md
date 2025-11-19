# 📚 Sistema de Horarios para Secundaria

**Proyecto desarrollado en .NET Core C#, SQLite y Windows Forms**

## 📖 Descripción

El **Sistema de Horarios para Secundaria** es una aplicación de
escritorio diseñada para gestionar maestros, materias, grupos, salones y
la creación de horarios semanales sin conflictos.\
El proyecto está construido en **.NET Core**, utiliza **Windows Forms**
para la interfaz de usuario, **SQLite** como base de datos local y
aplica **Inyección de Dependencias** junto a una arquitectura por capas
para mantener el sistema escalable, limpio y fácil de mantener.

## 🏗️ Arquitectura del Proyecto

El proyecto sigue una estructura modular compuesta por cuatro capas
principales:

    /Aplicacion
    /Dominio
    /Infrastructura
    /Presentacion

### 🔹 Dominio

-   Entidades principales (Docente, Materia, Grupo, Salón, Horario)
-   Reglas del dominio y validaciones
-   Contratos e interfaces fundamentales

### 🔹 Aplicación

-   Servicios de aplicación
-   DTOs y modelos
-   Manejo de casos de uso

### 🔹 Infraestructura

-   Persistencia de datos con SQLite
-   Repositorios concretos
-   Configuración de acceso a datos

### 🔹 Presentación

-   Formularios Windows Forms
-   Integración con Aplicación mediante DI
-   Validaciones e interacción de usuario

## 🗄️ Base de Datos

-   SQLite (portabilidad, fácil respaldo, sin servidor)

## 🧩 Tecnologías Utilizadas

-   .NET Core / .NET 6+
-   C#
-   Windows Forms
-   SQLite
-   Inyección de Dependencias
-   Arquitectura por Capas

## 🚀 Cómo Ejecutar el Proyecto

``` bash
git clone https://github.com/tu-usuario/sistema-horarios.git
dotnet restore
dotnet build
dotnet run --project Presentacion
```
## 🖼️ Capturas de Pantalla
![Pantalla principal](assets/img1.png)
![Pantalla principal](assets/img2.png)
![Pantalla principal](assets/img3.png)
![Pantalla principal](assets/img4.png)
![Pantalla principal](assets/img5.png)
![Pantalla principal](assets/img6.png)
![Pantalla principal](assets/img7.png)
## 📌 Características Principales

-   Gestión de docentes, materias, grupos y salones
-   Creación y edición de horarios
-   Arquitectura limpia y mantenible



## 🧪 Roadmap / Mejoras Futuras

-   Exportación a PDF/Excel
-   Control de usuarios
-   Migración opcional a WPF
-   Tests unitarios

## 📄 Licencia

Proyecto de uso libre para fines educativos.



