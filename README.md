# E_Academy_Backend
## Database Schema
![Screenshot 2024-05-31 130758](https://github.com/ParsaJR/E_Academy_Backend/assets/98831377/8a7f84e6-8e87-414c-b672-d52100a1cf22)
## Setup WebAPI using [Docker-Compose](https://docs.docker.com/compose)
1. Create 'docker-compose.yml' file
```yaml
version: '3.4'
networks:
  E_Academy_Network: 
services:
  e_academy_database:
    container_name: "E_Academy_DB"
    image: mcr.microsoft.com/mssql/server:2022-latest
    ports:
      - 8002:1433
    environment:
      - ACCEPT_EULA=Y
      - MSSQL_SA_PASSWORD=password@12345
    networks:
      - E_Academy_Network
  e_academy_backend:
    container_name: "E_Academy_API"
    image: parsajr/eacademybackend
    ports:
      - 8001:8080
    depends_on:
      - e_academy_database
    environment:
      - DB_HOST=e_academy_database
      - DB_NAME=E_Academy
      - DB_SA_PASSWORD=password@12345
    networks:
      - E_Academy_Network
```
2. Change the environment variables
3. Run "docker compose up" in your directory
4. WebAPI and database(to connect to it via SQL Server Management Studio) are exposed on ports '8001' and '8002' respectively.
 > Migrations will be performed automatically

## Run for Development
* Open solution in Visual Studio 2022
* Change the environment variables for Sql Server
* Set project as Startup Project and build the project.
* Run the application.

