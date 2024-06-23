# Plano de Testes de Software

| **Caso de Teste** 	| **Caso de Teste 01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - Permitir que o usuário crie uma conta.|
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	|<br>1- Acessar a página de cadastro<br><br> 2-  Preencher os campos obrigatórios (Nome completo, e-mail, celular, senha e confirmar a senha</br><br>3- Clicar no botão "Criar conta"<br><br>
|Critério de Êxito | O cadastro foi realizado. |
|   |   |

| **Caso de Teste** 	| **Caso de Teste 02 – Autenticação de usuários** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - O sistema deve conter autenticação de usuários.|
| Objetivo do Teste 	| Verificar se o usuário consegue se autenticar na aplicação. |
| Passos 	|1- Acessar a página de login<br><br>2- Inserir e-mail e senha corretos<br><br>3- Clicar no botão "Entrar"|
|Critério de Êxito | O usuário foi autenticado com sucesso. |
|   |   |

| **Caso de Teste** 	| **Caso de Teste 03 – Efetivar compras** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - Permitir que o usuário consiga efetivar compras.|
| Objetivo do Teste 	| Verificar se o usuário consegue finalizar uma compra. |
| Passos 	|<br> 1- Selecionar produtos para o carrinho<br><br>2- Acessar o carrinho<br><br>3- Clicar no botão "Finalizar compra"<br><br>4- Preencher os dados de pagamento e envio<br><br>5- Confirmar a compra<br><br>|
|Critério de Êxito | A compra foi realizada com sucesso. |
|   |   |

| **Caso de Teste** 	| **Caso de Teste 04 – Cadastrar endereço** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-004 - Permitir que o usuário consiga cadastrar seu endereço.|
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar um endereço. |
| Passos 	|<br>1- Acessar a página de perfil<br><br>2- Navegar até a seção de endereços<br><br>3- Clicar em "Adicionar endereço"<br><br>4- Preencher os campos obrigatórios (endereço, cidade, estado, CEP)<br><br>5- Salvar o endereço<br><br>|
|Critério de Êxito | O endereço foi cadastrado com sucesso. |
|   |   |

| **Caso de Teste** 	| **Caso de Teste 05 – Pesquisar produtos** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-005 - Permitir que o usuário pesquise produtos.|
| Objetivo do Teste 	| Verificar se o usuário consegue pesquisar produtos. |
| Passos 	|<br>1- Acessar a barra de pesquisa<br><br>2- Inserir o nome do produto<br><br>3- Clicar no ícone de pesquisa<br><br>|
|Critério de Êxito | Os produtos relacionados à pesquisa são exibidos. |
|   |   |

| **Caso de Teste** 	| **Caso de Teste 06 – Gerenciar carrinho** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-006 - Permitir que o usuário tenha um carrinho.|
| Objetivo do Teste 	| Verificar se o usuário consegue adicionar, remover e editar itens no carrinho. |
| Passos 	|<br>1- Adicionar um produto ao carrinho<br><br>2- Remover um produto do carrinho<br><br>3- Alterar a quantidade de um produto no carrinho<br><br>|
|Critério de Êxito | Os itens no carrinho são gerenciados conforme as ações do usuário.|
|   |   |

| **Caso de Teste** 	| **Caso de Teste 07 – Administrador** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-007 - Permitir que exista um usuário administrador.|
| Objetivo do Teste 	| Verificar se o usuário administrador possui acesso a funcionalidades administrativas. |
| Passos 	|<br>1- Logar com uma conta de administrador<br><br>2- Navegar até o painel administrativo<br><br>3- Realizar ações administrativas (ex: gerenciamento de usuários, produtos, pedidos)<br><br>|
|Critério de Êxito | O administrador consegue acessar e utilizar as funcionalidades administrativas.|
|   |   |

| **Caso de Teste** 	| **Caso de Teste 08 – Conferir etapa do pedido** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-008 - Permitir que exista uma forma de conferir a etapa do processamento do pedido.|
| Objetivo do Teste 	| Verificar se o usuário consegue acompanhar as etapas de processamento do pedido. |
| Passos 	|<br>1- Acessar a seção de pedidos<br><br>2- Selecionar um pedido específico<br><br>3- Visualizar as etapas de processamento do pedido<br><br>|
|Critério de Êxito |As etapas do pedido são exibidas corretamente.|
|   |   |

| **Caso de Teste** 	| **Caso de Teste 09 – Barra de favoritos** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-009 - Permitir que exista uma barra de favoritos.|
| Objetivo do Teste 	| Verificar se o usuário consegue adicionar e visualizar produtos na barra de favoritos.|
| Passos 	|<br>1- Adicionar um produto aos favoritos<br><br>2- Acessar a barra de favoritos<br><br>3- Remover um produto dos favoritos<br><br>|
|Critério de Êxito |Os produtos são gerenciados corretamente na barra de favoritos.|
|   |   |

| **Caso de Teste** 	| **Caso de Teste 10 – Feedback e avaliação de produtos** 	|
|:---:	|:---:	|
|	Requisito Associado 	|RF-010 - O sistema deve incorporar uma funcionalidade de feedback e avaliação de produtos.|
| Objetivo do Teste 	| Verificar se o usuário consegue deixar feedback e avaliar produtos.|
| Passos 	|<br>1- Acessar a página de um produto<br><br>2- Clicar em "Deixar feedback" ou "Avaliar produto"<br><br>3- Preencher os campos de avaliação e feedback<br><br>4- Enviar a avaliação/feedback<br><br>|
|Critério de Êxito |O feedback e a avaliação são enviados e exibidos corretamente.|
|   |   |

| **Caso de Teste** 	| **Caso de Teste 11 – Recuperar senha** 	|
|:---:	|:---:	|
|	Requisito Associado 	|RF-011 - O sistema deve permitir que o usuário recupere sua senha.|
| Objetivo do Teste 	| Verificar se o usuário consegue recuperar sua senha.|
| Passos 	|<br>1- Acessar a página de login<br><br>2- Clicar em "Esqueci minha senha"<br><br>3- Inserir o e-mail cadastrado<br><br>4- Receber o e-mail de recuperação<br><br>5- Seguir o link de recuperação e redefinir a senha<br><br>|
|Critério de Êxito |A senha é redefinida com sucesso.|
|   |   |

## Ferramentas de Testes (Opcional)

Comente sobre as ferramentas de testes utilizadas.
 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
