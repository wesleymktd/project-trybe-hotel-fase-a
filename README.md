## 🧐 Sobre

<p align="left"> 
O projeto Trybe Hotel se trata da implementação de uma Api de um site de reserva de uma rede de Hoteis onde nessa primeira foram implementados os seguintes processos:

### Cadastro e consulta de cidades
  - Rota de consulta GET /city
    - O corpo da resposta deve seguir o formato abaixo:

```json
[
    {
	    "cityId": 1,
	    "name": "Rio Branco"
    },

  /*...*/
]
```
  - Rota de cadastro de cidades POST /city
    - O corpo da requisição deve seguir o padrão abaixo

```json
{
	"Name": "Rio de Janeiro"
}
```
### Cadastro e consulta de hotéis
  - Rota de consulta GET /hotel
    - O corpo da resposta deve seguir o formato abaixo:

```json
[
    {
		  "hotelId": 1,
		  "name": "Trybe Hotel SP",
		  "address": "Avenida Paulista, 1400",
		  "cityId": 1,
		  "cityName": "São Paulo"
	  },

  /*...*/
]
```
  - Rota de cadastro de Hoteis POST /hotel
    - O corpo da requisição deve seguir o padrão abaixo

```json
{
	"Name":"Trybe Hotel RJ",
	"Address":"Avenida Atlântica, 1400",
	"CityId": 2
}
```
### Cadastro, consulta e exclusão de quartos
  - Rota de consulta de quarto GET /room/:hotelId
    - O corpo da resposta deve seguir o formato abaixo:

```json
[
    {
		  "roomId": 1,
		  "name": "Suite básica",
		  "capacity": 2,
		  "image": "image suite",
		  "hotel": {
  			"hotelId": 1,
			  "name": "Trybe Hotel SP",
			  "address": "Avenida Paulista, 1400",
			  "cityId": 1,
			  "cityName": "São Paulo"
		  }
	  },

  /*...*/
]
```
  - Rota de cadastro de Quartos POST /room
    - O corpo da requisição deve seguir o padrão abaixo

```json
{
	"Name":"Suite básica",
	"Capacity":2,
	"Image":"image suite",
	"HotelId": 1
}
```
  - Rota de exclusão de Quartos DELETE /room/:roomId
- 
- testes automatizados
 

## ⚒ Instalando <a name = "installing"></a>

```bash
# Clone o projeto
$ git clone git@github.com:wesleymktd/project-trybe-hotel-fase-a.git
# Acesse
$ cd ./project-trybe-hotel-fase-a/src
# Instale as dependencias
$ dotnet restore
# Acesse o diretório TrybeHotel
$ cd TrybeHotel
# Inicie o projeto
$ dotnet run

```

## ⚒ Testes automatizados <a name = "installing"></a>

```bash
# Clone o projeto
$ git clone git@github.com:wesleymktd/project-trybe-hotel-fase-a.git
# Acesse o diretório TrybeHotel.test

# Execute o comando dotnet test
# para filtrar por algum teste específico execute o comando
$ dotnet test --filter `nome_do_teste`

```

## Principais tecnologias utilizadas:
- C#;
- ASP.NET
- EntityFramework
- Xunit
- azure sql edge
