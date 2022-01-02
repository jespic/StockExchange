# Stock Exchange
Proyecto realizado en .NET Core para la gestión de acciones de bolsa.

## Despliegue 🚀
Una vez descargado el proyecto en nuestra máquina, los pasos a seguir para poner en funcionamiento el proyecto son los siguientes:

### Incluir la url para la base de datos local
Dentro del fichero "secrets.json", al cual se puede acceder haciendo click derecho en el nombre del proyecto => Administrar secretos del usuario, se debe incluir la cadena de conexión a la base de datos que se creará para almacenar los datos de las bolsas tal que así:
```
"ConnectionStrings": {
    "BagContext": "Server=(localdb)\\mssqllocaldb;Database=nombreDeLaBD;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
```
### Obtener API Key
Accediendo a la web ,https://www.alphavantage.co/, se debe solicitar una API Key que posteriormente se incluirá en el fichero "secrets.json" anteriormente mencionado::
```
"StockApiKey": "APIKey"
```
### Generar las tablas de la base de datos
Desde la "Consola del administrador de paquetes", y habiéndose situado en el proyecto "BagLib", hay que ejecutar el comando "update-database" para generar las tablas de la base de datos.

### Crear un usuario
Crear un usuario mediante Microsoft SQL Server Management Studio o el entorno que se desee con id = 1.

### Ejecutar la aplicación y poblar la base de datos
Por último, con la aplicación lanzada, acceder a la vista Countries y pulsar sobre el botón "Actualizar desde API".



