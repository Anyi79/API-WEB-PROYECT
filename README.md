# API-WEB-PROYECT

Fundamentación del producto

Hemos decidido diseñar esta Web API para una tienda de ropa, con el fin de 
facilitar o dar respuestas rápidas al nicho de mercado de tiendas online tan 
demandado en la actualidad. Integrando funcionalidades para la administración 
de productos: información de precios, identificación de artículos, información 
existente en el stock; y al mismo tiempo podrán gestionar y automatizar la lista 
de pedidos. Así como también llevar el control de las ventas realizadas.
Esta Web API funciona de la misma manera que la mayoría de las API REST 
que podemos encontrar en el mundo web. Usa los métodos HTTP habituales, 
exponiendo una lista de endpoints relacionados con los recursos de la tienda.

Diseño de Tablas
Para desarrollar la API y la Base de Datos, partimos del siguiente diseño de 
tablas, el cual presenta una serie de tablas y relaciones entre ellas.
API Tienda de ropa Coders: Anyi Flores. Rosemary Rengel
La Base de Datos está representada por cuatro (04) tablas:
1. Rol: roles de acceso o uso de la API o base de datos.
2. User: datos personales de usuarios y clientes.
3. Product: inventario de los productos de la tienda y stock existente.
4. Orders: detalles, relación de pedidos realizados y del estado de estos.
Tal como se observa en el diseño anterior, User está relacionada con la tabla 
Rol a través de Id IdRol. Además, nos indicará qué rol tiene ese usuario para 
acceder al programa.
Orders está relacionada con User por medio de IdUser, lo cual indica los pedidos 
realizados por cada usuario. Y la tabla Produtc está relacionada con la tabla de 
Ordes a través de Id Product.
Tecnologías, lenguajes y versiones.
En el desarrollo de la WEB API se ha hecho uso de las siguientes tecnologías:
● Microsoft Visual Studio 2022
● Microsoft SQL Server 18
● Git
Los lenguajes utilizados durante el proyecto son:
● .Net Core v6.0
● Entity Framework v7.0
● C#
● SQL
API Tienda de ropa Coders: Anyi Flores. Rosemary Rengel
Objetivo
Simplificar o facilitar el trabajo del cliente. Para que este pueda hacer las 
modificaciones correspondientes a la base de datos (productos, stock, ventas…), 
y de esta manera tener actualizada la información y poder mostrar a los usuarios 
el catálogo de ropa de cada temporada, así como sus ofertas y novedades.
Arquitectura
Capa-Capa.
La arquitectura en capas es una de las más utilizadas por su simplicidad y 
sostenibilidad a largo plazo, permitiendo ahorrar tiempo que se traduce en un 
ahorro económico.
Consta en dividir la aplicación en capas, con la intención de que cada capa tenga 
un rol muy definido.
CONTROLADOR SERVICIOS LÓGICA
Funcionalidades
● Administración de usuarios.
● Consulta, inserción, modificación y eliminación de productos en el 
catálogo.
● Actualización de Stock.
● Filtrado de productos por marcas.
API Tienda de ropa Coders: Anyi Flores. Rosemary Rengel
Controllers y métodos
Post
Validación
Resultado del método POST con su correspondiente ENDPOINT
API Tienda de ropa Coders: Anyi Flores. Rosemary Rengel
Get
Validación
Endpoint
API Tienda de ropa Coders: Anyi Flores. Rosemary Rengel
GETBYCRITERIA
Validación
Endpoint
API Tienda de ropa Coders: Anyi Flores. Rosemary Rengel
Patch
Validación
Endpoint
API Tienda de ropa Coders: Anyi Flores. Rosemary Rengel
Delete
Validación
Endpoint
API Tienda de ropa Coders: Anyi Flores. Rosemary Rengel
Extensiones posibles
En próximas extensiones de la WEB API se perfeccionará lo siguiente:
• Filtrado de productos por precio, por fecha de inclusión y por tipo de 
productos.
• Agrupación, consulta, inserción, modificación y eliminación de productos 
por marcas.
• Consulta de pedidos realizados.
• Control de pedidos pendientes de ser entregados y cobrados
