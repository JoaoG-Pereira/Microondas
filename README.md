Código e interface do projeto.
Para executar o código, primeiro inicie a API (em https://github.com/JoaoG-Pereira/API.git). Depois, em Configuracoes.cs (desse projeto), altere o caminho da API:

API_URL = "https://localhost:{PORTA}";

Para acessar os programa de aquecimento pré-configurados (e funções de CRUD), é necessário fazer login. Ele pode ser feito durante a execução.
A conta de usuário padrão é:
Usuário: admin
Senha: 1234

As senhas são criptografadas com o hash SHA-256.
É possível cadastrar novos usuários pela API, mas essa função não foi adicionada às tela.

Sobre o projeto:
Foi desenvolvido usando arquitetura multi-camadas, na qual:
* Modelo (Entity Layer): Objetos e estruturas de dados
* Dados (DAL - Data Access Layer): Camada que se comunica com a API e retorna os dados
* Regras de negócio (BLL - Business Logic Layer): Camada com toda a lógica de validações e regras. Também comunica a interface e a camada de dados
* Intefaces (Presentation Layer): Telas em WindowsForms.
