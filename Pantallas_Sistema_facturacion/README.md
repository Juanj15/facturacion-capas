# 💼 Sistema de Facturación – Aplicación de Escritorio

Este sistema de facturación fue desarrollado en **C# con Windows Forms** y se conecta a una base de datos **Azure SQL**. Está diseñado para facilitar la gestión de productos, clientes, facturas, usuarios y roles en una institución o comercio.

## 📋 Módulos principales

La aplicación está organizada en pestañas que permiten al usuario navegar fácilmente por las funciones disponibles:

- 🧾 **Facturación**
- 🛒 **Productos**
- 👤 **Clientes**
- 🔐 **Seguridad**
- ❓ **Ayuda**

Cada sección está conectada con su respectiva lógica de base de datos y validaciones.

## ⚙️ Tecnologías utilizadas

- **Lenguaje:** C# (.NET 8.0)
- **Framework:** Windows Forms
- **Base de datos:** Azure SQL Database
- **Acceso a datos:** ADO.NET (con procedimientos almacenados)
- **Control de versiones:** Git + GitHub

## 🗂️ Estructura del proyecto y formularios

La solución está organizada por carpetas y cada módulo tiene su formulario asociado. A continuación, se listan los principales formularios implementados:

| Formulario              | Función principal                                       |
|-------------------------|---------------------------------------------------------|
| `frmPrincipal.cs`       | Pantalla principal con pestañas del sistema             |
| `frmEmpleados.cs`       | Gestión de empleados (alta, baja, edición)              |
| `FrmEmpleadoEdit.cs`    | Edición/creación de empleados en formulario modal       |
| `frmRoles.cs`           | Asignación de roles y descripciones                     |
| `frmSeguridad.cs`       | Asignación de credenciales (usuario y contraseña)       |
| `frmProductos.cs`       | Gestión de productos del catálogo                       |
| `frmClientes.cs`        | Administración de clientes                              |
| `frmFacturas.cs`        | Generación y visualización de facturas                 |
| `frmAyuda.cs`           | Módulo de ayuda para el usuario                         |

## 🛢️ Base de datos en Azure

La aplicación se conecta a una **Azure SQL Database** configurada con las siguientes tablas principales:

- `TBLPRODUCTOS`
- `TBLCLIENTES`
- `TBLFACTURAS`
- `TBLEMPLEADO`
- `TBLROLES`
- `TBLSEGURIDAD`

Además, se hace uso de **procedimientos almacenados** para operaciones seguras y eficientes en la base de datos.

## 🔐 Seguridad

- Autenticación por usuario y contraseña.
- Validaciones de campos (email, contraseña, nombre).
- El formulario de seguridad permite asignar o cambiar credenciales de forma controlada.

> ⚠️ **Observación**: Excluidos los archivos que contienen cadenas de conexión (`AppConfig.cs`, `appsettings.json`, etc.) con un archivo `.gitignore` para evitar exposición de credenciales.

## 👨‍💻 Equipo de desarrollo

Este proyecto fue desarrollado como parte de una asignatura universitaria por el siguiente equipo:

- **Laura Camila García López**
- **Juan David García Vargas**
- **Jaime Alberto Durán Zuleta**
- **Juan José Jiménez Ortiz**

## 🚀 Estado del proyecto

✅ Conexión a base de datos funcional  
✅ CRUD completo para empleados y roles  
✅ Seguridad de usuarios  
✅ Interfaz dinámica con DataGridView  
🔄 En desarrollo: módulo de facturación con historial y reportes

---

¡Gracias por revisar este proyecto! Puedes clonar el repositorio, compilarlo con Visual Studio 2022 y ejecutar la aplicación localmente con tu cadena de conexión de Azure SQL.

