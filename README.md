

# APIDEMO COM DOCKER


## OBJETIVO DA APLICAÇÃO

Nessa aplicação coloquei em prática, criar um ambiente 100% em docker,
acessando o banco de dados com orm dapper.

## BANCO DE DADOS

o banco de dados que eu escolhi foi o sqlserver.

## Eu baixei a imagem do sql server com esse comando

    docker pull mcr.microsoft.com/mssql/server:2019-latest



## Pra Usar a image docker do sqlserve, eu rodei esse comando

    docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=yourStrong(!)Password" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest


## Pra criar a imagem da aplicação eu rodei esse comando

    docker build -t dockerwebapi . 

    
## Executar o conatiner com docker-compose 

    docker-compose up --build

## Pra Gerenciar os container pela interface gráfica, eu uso o portainer
![portainer](https://user-images.githubusercontent.com/47439833/185801925-cb4b3eee-2106-471a-8cbe-f11d86e46dbb.png)    

## Se você deseja utilizar o portainer, segue o link da instalação

    https://docs.portainer.io/start/requirements-and-prerequisites
    

    

