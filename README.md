💼 Sistema de Facturación – Aplicación de Escritorio

Este sistema fue desarrollado en C# con Windows Forms (.NET 8.0) siguiendo una arquitectura por capas (Datos, Negocio y Presentación).
La aplicación está conectada a una base de datos SQL Server / Azure SQL y permite gestionar productos, clientes, empleados, roles y facturación.

📂 Arquitectura del proyecto

El código está organizado en tres capas:

Capa_Datos → Manejo de la base de datos con ADO.NET y procedimientos almacenados.

Capa_Negocio → Lógica de negocio, DTOs y servicios que conectan datos con presentación.

Pantallas_Sistema_Facturacion (Presentación) → Interfaz en Windows Forms.

Estructura simplificada:

facturacion-capas/
├── Capa_Datos/
│   ├── DATEmpleados.cs
│   ├── DATRoles.cs
│   └── ...
├── Capa_Negocio/
│   ├── NEGEmpleados.cs
│   ├── EmpleadoDTO.cs
│   ├── EmpleadoService.cs
│   └── ...
├── Pantallas_Sistema_Facturacion/
│   ├── frmEmpleados.cs
│   ├── FrmEmpleadoEdit.cs
│   ├── frmRoles.cs
│   └── ...
└── README.md

🧾 Módulos principales

🧾 Facturación – Generación y consulta de facturas.

🛒 Productos – Gestión de inventario.

👤 Clientes – Registro y edición de clientes.

👥 Empleados y roles – Alta, baja, edición y asignación de roles.

🔐 Seguridad – Asignación de usuarios y credenciales.

❓ Ayuda – Información de soporte para el usuario.

⚙️ Tecnologías utilizadas

Lenguaje: C#

Framework: .NET 8.0 (Windows Forms)

Base de datos: SQL Server (local o Azure SQL)

Acceso a datos: ADO.NET con procedimientos almacenados

IDE recomendado: Visual Studio 2022

Control de versiones: Git + GitHub

🚀 Cómo ejecutar el proyecto
1. Requisitos previos

Visual Studio 2022 con la carga de trabajo .NET Desktop Development.

SQL Server (local o Azure) con la base de datos creada.

Cadena de conexión configurada en el archivo App.config.

2. Clonar el repositorio
git clone https://github.com/usuario/facturacion-capas.git
cd facturacion-capas

3. Restaurar dependencias

Visual Studio lo hará automáticamente al abrir la solución (.sln).

4. Verificar proyectos

En el Explorador de soluciones asegúrate de que estén cargados:

Capa_Datos

Capa_Negocio

Pantallas_Sistema_Facturacion

Si alguno aparece descargado → clic derecho > Cargar proyecto.

5. Compilar y ejecutar

Menú Compilar > Recompilar solución

Seleccionar Pantallas_Sistema_Facturacion como Proyecto de inicio

Ejecutar con F5

🛢️ Base de datos

Tablas principales esperadas en SQL Server:

TBLPRODUCTOS

TBLCLIENTES

TBLFACTURAS

TBLEMPLEADO

TBLROLES

TBLSEGURIDAD

👉 Importante: todas las operaciones se realizan vía procedimientos almacenados para seguridad y eficiencia.

🔐 Seguridad

Inicio de sesión con usuario y contraseña.

Validaciones de campos (ej. email, documento, teléfono).

Gestión de roles con asignación desde la interfaz.

👨‍💻 Equipo de desarrollo

Proyecto realizado por:

Laura Camila García López

Juan David García Vargas

Jaime Alberto Durán Zuleta

Juan José Jiménez Ortiz

📌 Estado del proyecto

✅ CRUD de empleados y roles

✅ Seguridad de usuarios

✅ Interfaz dinámica con DataGridView

🔄 En desarrollo: módulo de facturación con historial y reportes

💡 Notas importantes

Archivos de compilación automática (bin/, obj/, .vs/, CopilotIndices/) y configuraciones de usuario están excluidos con .gitignore.

Si al abrir el proyecto aparecen conflictos, ejecutar Limpiar solución y luego Recompilar.
