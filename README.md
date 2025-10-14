### 💼 Sistema de Facturación – Aplicación de Escritorio
Este proyecto es una solución completa desarrollada en C# con Windows Forms, que implementa la arquitectura por capas (Datos, Negocio y Presentación). Para ejecutar correctamente el sistema, se debe iniciar la solución completa desde Visual Studio (archivo .sln), lo cual carga automáticamente todos los módulos y formularios integrados.

La aplicación se conecta a una base de datos en Azure SQL, por lo que no requiere ingresar credenciales locales para su ejecución: la cadena de conexión está configurada en el proyecto principal.

\

### ⚙️ Tecnologías utilizadas
* Lenguaje: C# (.NET Framework 4.7.2)
* Framework: Windows Forms
* Base de datos: Azure SQL Database
* Acceso a datos: ADO.NET (con procedimientos almacenados)
* Arquitectura: 3 capas (Datos – Negocio – Presentación)
* Control de versiones: Git + GitHub
\

### 🧩 Arquitectura del sistema
El sistema está dividido en tres capas principales:

**Capa:** Datos
**Proyecto:** Capa_Datos
**Descripción:** Contiene las clases DAO con la lógica de acceso a la base de datos (consultas SQL, inserciones, actualizaciones, eliminaciones).

**Capa:** Negocio
**Proyecto:** Capa_Negocio
**Descripción:** Gestiona las reglas de negocio y validaciones antes de enviar o recibir datos de la capa de datos.

**Capa:** Presentación
**Proyecto:** Pantallas_Sistema_facturacion
**Descripción:** Contiene los formularios Windows Forms que conforman la interfaz gráfica del usuario.

\

### 📋 Módulos principales
La aplicación está compuesta por varios módulos que permiten gestionar la información de manera integral:

* 🧾 Facturación: Creación y registro de facturas.
* 🛒 Productos: Administración de productos y precios.
* 🧩 Categorías: Gestión de categorías de productos.
* 👤 Clientes: Registro y actualización de clientes.
* 🔐 Seguridad: Asignación de usuarios y contraseñas.
* ❓ Ayuda: Guía de uso y asistencia general.
\

### 🗂️ Formularios implementados
| Formulario                | Descripción                                               |
| ------------------------- | --------------------------------------------------------- |
| `frmPrincipal.cs`         | Ventana principal del sistema con pestañas de navegación. |
| `frmProductos.cs`         | Lista y búsqueda de productos.                            |
| `frmInsertarProductos.cs` | Creación y edición de productos.                          |
| `frmCategorias.cs`        | Visualización y gestión de categorías.                    |
| `frmInsertarCategoria.cs` | Registro y actualización de categorías.                   |
| `frmSeguridad.cs`         | Gestión de credenciales de usuario.                       |
| `frmClientes.cs`          | Administración de clientes.                               |
| `frmFacturas.cs`          | Generación y visualización de facturas.                   |
| `frmAyuda.cs`             | Información general del sistema.                          |

\

### 🔐 Seguridad
* Autenticación mediante usuario y contraseña
* Validaciones de campos en la capa de negocio.
* Los formularios de seguridad y empleados permiten asignar o modificar credenciales de forma controlada.

⚠️ Los archivos que contienen información sensible (por ejemplo, cadenas de conexión) están excluidos mediante .gitignore para proteger las credenciales.

\

### 👨‍💻 Equipo de desarrollo
Proyecto desarrollado como parte de una asignatura universitaria por el equipo:

* Laura Camila García López
* Juan David García Vargas
* Jaime Alberto Durán Zuleta
* Juan José Jiménez Ortiz
\

### 🚀 Estado actual del proyecto
✅ Arquitectura por capas implementada
✅ Conexión con Azure SQL Database
✅ CRUD funcional en módulos principales
✅ Validaciones de negocio en formularios
