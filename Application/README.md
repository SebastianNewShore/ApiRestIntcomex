# ApiRest
 INTCOMEX
 
Tecnologias utilizadas

- Arquitectura Hexagonal 3 capas (Dommain, Application, Infrastructure, Api)
- .Net Core 3.1, EntityFramework, LinQ, json, SqlServer
- Gitflow
- Aplicación de principios Solid
- Creación de pruebas unitarias
- autorización por medio de usuario y contraseña para consumo de servicios.
- Postman, Swagger
- Despliegue en Azure de aplicación y base de datos
- Utilización de Jmeter para inserción maxiva de datos

Instrucciones

Base de datos
- La BD ya se encuentra publicada en Azure, pero en caso de necesitar crear la BD en una instancia local, se puede dirigir al proyecto
 productsInformation.Infrastructure y ejecutar el program, este se encargara de crear la base de datos, basado en el modelo construido 
 Nota: modificar instancia a la que se va a conectar, si necesitan acceder a la BD desde SQL Server, me podrian compartir la ip para
 dar acceso desde el portal de Azure.
 
Aplicación.
La aplicación de encuentra desplegada en Azure, si se desea ejecutar desde visual studio, se debe dejar como proyecto de inicio el proycto
productsInformation.Infrastructure y ejecutar la aplicación, posteriormente por medio de swagger o postman se podra consumir los servicios.
