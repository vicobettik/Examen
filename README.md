# Examen Práctico de Desarrollo Full Stack - Nivel Senior

## Análisis de código y resolución de problemas (OBLIGATORIO)

**Problema a resolver:**

Se te presenta una aplicación que gestiona las ventas de una tienda en línea.
Deberás realizar las siguientes tareas:

1. **Base de datos:** Actualmente, los productos y carritos se manejan en la memoria y se pierden cuando se cierra la aplicación. Por favor, implementa una base de datos persistente para almacenar los productos y los carritos. Esto puede implicar la utilización de un ORM como Entity Framework, la creación de una capa de repositorio y la adaptación de las clases existentes para gestionar las relaciones.

2. **Autenticación y Autorización:** En la actualidad, cualquier cliente puede agregar productos al carrito y realizar el checkout. Por favor, implementa un sistema de autenticación y autorización para limitar estas acciones. Esto puede incluir el uso de tecnologías como JWT, la definición de roles y permisos, y la implementación de un middleware para gestionar la autorización.

3. **Manejo de inventario:** Ahora mismo, se pueden agregar productos al carrito sin tener en cuenta si hay stock suficiente. Por favor, implementa un sistema de inventario que verifique la disponibilidad de un producto antes de permitir que se agregue al carrito.

4. **Facturación y Pagos:** Implementa un módulo para manejar la facturación y los pagos. Esto implicará la creación de una clase para gestionar los detalles de facturación y los pagos.

5. **Interfaz de usuario:** Como desarrollador Full Stack, se te pide que implementes una interfaz de usuario básica para interactuar con el backend. Esto puede incluir la creación de formularios para añadir productos al carrito, visualizar el carrito y realizar el checkout. Puedes usar cualquier marco de frontend que prefieras, como React, Angular o Vue.

Estas tareas te permitirán demostrar una amplia gama de habilidades, incluyendo trabajo con bases de datos, implementación de autenticación y autorización, manejo de la lógica de negocio y desarrollo frontend. Por favor, no dudes en preguntar si tienes alguna duda sobre las instrucciones al correo: licenciasdev@hircasa.com

## Generación de documentación y usabilidad

1. Crea un manual de usuario que explique cómo se usa tu sistema.

2. Genera la documentación necesaria en el archivo `README.md`.

# ---- SECCIÓN DEL CANDIDATO ------------

**Web API:**
1. La base de datos fue creada en el localdb por lo que es necesario ejecutar el comando:
	Update-Database en la consola del administrador de paquetes de visual studio.
2. Es necesario que la web api sea ejecutada usando el perfil "https".
3. Al ejecutar el proyecto se abrirá un explorador de internet en el cual pueden observarse los endpoints y probarlos usando swagger.
4. La interfaz de usuario esta realizada en un proyecto de Angular.
