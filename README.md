# Stock Exchange
Proyecto realizado en .NET Core para la gesti贸n de acciones de bolsa.

## Despliegue 馃殌
Una vez descargado el proyecto en nuestra m谩quina, los pasos a seguir para poner en funcionamiento el proyecto son los siguientes:

### Incluir la url para la base de datos local
Dentro del fichero "secrets.json", al cual se puede acceder haciendo click derecho en el nombre del proyecto => Administrar secretos del usuario, se debe incluir la cadena de conexi贸n a la base de datos que se crear谩 para almacenar los datos de las bolsas tal que as铆:
```
"ConnectionStrings": {
    "BagContext": "Server=(localdb)\\mssqllocaldb;Database=nombreDeLaBD;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
```
### Obtener API Key
Accediendo a la web ,https://www.alphavantage.co/, se debe solicitar una API Key que posteriormente se incluir谩 en el fichero "secrets.json" anteriormente mencionado::
```
"StockApiKey": "APIKey"
```
### Generar las tablas de la base de datos
Desde la "Consola del administrador de paquetes", y habi茅ndose situado en el proyecto "BagLib", hay que ejecutar el comando "update-database" para generar las tablas de la base de datos.

### Crear un usuario
Crear un usuario mediante Microsoft SQL Server Management Studio o el entorno que se desee con id = 1.

### Ejecutar la aplicaci贸n y poblar la base de datos
Por 煤ltimo, con la aplicaci贸n lanzada, acceder a la vista Countries y pulsar sobre el bot贸n "Actualizar desde API".



