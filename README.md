Código e interface do projeto.

Para executar o código, primeiro inicie a API (em https://github.com/JoaoG-Pereira/API.git)
Depois, em Configuracoes.cs (desse projeto), altere o caminho da API:

API_URL = "https://localhost:{PORTA}";

Para acessar os programa de aquecimento pré-configurados (e funções de CRUD), é necessário fazer login. Ele pode ser feito durante a execução.
A conta de usuário padrão é:
Usuário: admin
Senha: 1234

As senhas são criptografadas com o hash SHA-256.
É possível cadastrar novos usuários pela API, mas essa função não foi adicionada às tela.
