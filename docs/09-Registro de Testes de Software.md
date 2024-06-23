# Registro de Testes de Software

O presente relatório documenta os testes realizados no software durante o período de desenvolvimento, destacando os erros encontrados, suas causas e soluções correspondentes. Além disso, são apresentados os casos de teste aceitos que passaram com sucesso.

## Avaliação

### Etapa - 1

#### Erros Encontrados
- Erro de rota não definida:

  Descrição: Tentativa de navegar para uma rota não definida no navegador.
  Causa: Nome da rota não correspondente ao definido no navegador.
  Solução: Verificar se o nome da rota está correto e corresponde exatamente ao nome definido no navegador.
  
- Erro de largura não suportada pelo módulo de animação nativa:

  Descrição: Tentativa de animar uma propriedade não suportada pelo módulo de animação nativa.
  Causa: Tentativa de animar propriedades não suportadas pelo módulo de animação nativa, como largura.
  Solução: Evitar animar propriedades não suportadas pelo módulo de animação nativa.
  
- Erro ao tentar adicionar mais uma tela ao navegador:

  Descrição: Tentativa de adicionar uma nova tela ao navegador, mas o nome da tela não corresponde a uma tela existente.
  Causa: Nome da tela incorreto ao adicionar uma nova tela ao navegador.
  Solução: Certificar-se de usar o nome correto da tela ao adicionar uma nova tela ao navegador.

- Erro de navegação não tratada:

  Descrição: Tentativa de navegar para uma tela não definida no navegador.
  Causa: Nome da tela não correspondente ao definido no navegador.
  Solução: Verificar se o nome da tela está correto e corresponde exatamente ao nome definido no navegador.

  ### Casos de Teste Aceitos


- Teste de Navegação Básica:

  Descrição: Verificação da capacidade do aplicativo de navegar entre telas.
  Resultado: Todos os casos de teste passaram com sucesso, confirmando a funcionalidade de navegação do aplicativo.
  Teste de Animação Responsiva:

  Descrição: Verificação da capacidade do aplicativo de realizar animações de forma responsiva.
  Resultado: Casos de teste falharam devido a propriedades de animação não suportadas. Solução aplicada com sucesso.

#### Conclusão
Os testes realizados no software identificaram vários erros comuns, como problemas de navegação, propriedades de animação não suportadas e nomes de telas incorretos. No entanto, esses erros foram abordados com sucesso com as soluções correspondentes aplicadas. Além disso, os casos de teste aceitos confirmaram a funcionalidade esperada do aplicativo, garantindo uma experiência de usuário consistente e sem problemas.


[Screen_recording_20240407_165140.webm](https://github.com/shigerysasaki/pmv-ads-2024-1-e3-proj-mov-t2-farmaonline/assets/126729120/2b73d4df-db3f-4edf-bdc7-a924219b0c3b)

RF-002 O sistema deve conter autenticação de usuários - ALTA

Erros Encontrados

Erro de autenticação falhada:

Descrição: Tentativa de autenticar um usuário com credenciais inválidas.
Causa: Nome de usuário ou senha incorretos.
Solução: Verificar se o nome de usuário e senha estão corretos.
Erro de sessão expirada:

Descrição: Sessão do usuário expira durante a navegação.
Causa: Tempo de inatividade excede o limite permitido.
Solução: Implementar um mecanismo de renovação de sessão ou alertar o usuário antes do término da sessão.
Casos de Teste Aceitos

Teste de Autenticação Básica:

Descrição: Verificação da capacidade do aplicativo de autenticar usuários com credenciais válidas.
Resultado: Todos os casos de teste passaram com sucesso, confirmando a funcionalidade de autenticação.
Conclusão
Os testes de autenticação de usuários foram bem-sucedidos, comprovando que o sistema é capaz de autenticar usuários com credenciais válidas e gerenciar sessões adequadamente. Os erros encontrados foram corrigidos, garantindo segurança e eficiência no processo de login.

RF-003 Permitir que o usuário consiga efetivar compras - ALTA

Erros Encontrados

Erro de pagamento não processado:

Descrição: Falha ao processar o pagamento do usuário.
Causa: Problemas com o provedor de pagamento ou dados de pagamento inválidos.
Solução: Verificar a integração com o provedor de pagamento e validar os dados fornecidos.
Erro de confirmação de compra:

Descrição: O usuário não recebe confirmação de compra após efetuar o pagamento.
Causa: Falha no sistema de notificação ou na geração do recibo.
Solução: Implementar e verificar o sistema de notificação e geração de recibos.
Casos de Teste Aceitos

Teste de Compra Completa:

Descrição: Verificação da capacidade do usuário de efetuar uma compra completa, desde a seleção do produto até a confirmação do pagamento.
Resultado: Todos os casos de teste passaram com sucesso, confirmando a funcionalidade de compra.
Conclusão
Os testes de compra foram realizados com sucesso, demonstrando que o sistema permite ao usuário efetuar compras de forma eficaz e segura. Os erros identificados foram solucionados, assegurando uma experiência de compra tranquila e confiável.

RF-004 Permitir que o usuário consiga cadastrar seu endereço - MÉDIA

Erros Encontrados

Erro de cadastro de endereço inválido:

Descrição: Falha ao cadastrar um novo endereço devido a dados inválidos.
Causa: Dados incompletos ou formato incorreto.
Solução: Implementar validação dos dados de endereço antes do cadastro.
Erro de atualização de endereço:

Descrição: Falha ao atualizar um endereço existente.
Causa: Erro na comunicação com o banco de dados ou dados inválidos.
Solução: Verificar a comunicação com o banco de dados e validar os dados fornecidos.
Casos de Teste Aceitos

Teste de Cadastro de Endereço:

Descrição: Verificação da capacidade do usuário de cadastrar e atualizar endereços.
Resultado: Todos os casos de teste passaram com sucesso, confirmando a funcionalidade de cadastro de endereço.
Conclusão
Os testes de cadastro de endereço foram bem-sucedidos, indicando que o sistema permite ao usuário cadastrar e atualizar endereços de forma eficiente. Os erros encontrados foram corrigidos, garantindo a precisão e a integridade dos dados de endereço.

RF-005 Permitir que o usuário pesquise produtos - ALTA

Erros Encontrados

Erro de pesquisa não retornando resultados:

Descrição: A pesquisa do usuário não retorna resultados.
Causa: Falta de correspondência de dados ou erro no algoritmo de pesquisa.
Solução: Verificar e ajustar o algoritmo de pesquisa para garantir correspondência adequada.
Erro de pesquisa lenta:

Descrição: A pesquisa de produtos é lenta, causando atrasos na experiência do usuário.
Causa: Problemas de desempenho no servidor ou consultas ineficientes.
Solução: Otimizar consultas de pesquisa e melhorar o desempenho do servidor.
Casos de Teste Aceitos

Teste de Pesquisa de Produtos:

Descrição: Verificação da capacidade do usuário de pesquisar produtos de forma rápida e precisa.
Resultado: Todos os casos de teste passaram com sucesso, confirmando a funcionalidade de pesquisa.
Conclusão
Os testes de pesquisa de produtos foram realizados com sucesso, comprovando que o sistema permite ao usuário pesquisar produtos de forma eficaz e rápida. Os erros identificados foram resolvidos, melhorando a performance e a precisão da funcionalidade de pesquisa.

RF-006 Permitir que o usuário tenha um carrinho - ALTA

Erros Encontrados

Erro de adição ao carrinho:

Descrição: Falha ao adicionar produtos ao carrinho.
Causa: Problemas com a sessão do usuário ou erros na lógica de adição ao carrinho.
Solução: Verificar a sessão do usuário e corrigir a lógica de adição ao carrinho.
Erro de remoção do carrinho:

Descrição: Falha ao remover produtos do carrinho.
Causa: Problemas com a sessão do usuário ou erros na lógica de remoção do carrinho.
Solução: Verificar a sessão do usuário e corrigir a lógica de remoção do carrinho.
Casos de Teste Aceitos

Teste de Funcionamento do Carrinho:

Descrição: Verificação da capacidade do usuário de adicionar e remover produtos do carrinho.
Resultado: Todos os casos de teste passaram com sucesso, confirmando a funcionalidade do carrinho.
Conclusão
Os testes de funcionalidade do carrinho foram concluídos com sucesso, indicando que o sistema permite ao usuário adicionar e remover produtos do carrinho de forma eficiente. Os erros encontrados foram corrigidos, garantindo uma experiência de compra mais fluida.

RF-007 Permitir que exista um usuário administrador - ALTA

Erros Encontrados

Erro de privilégio de administrador:

Descrição: Usuário comum consegue acessar funcionalidades de administrador.
Causa: Falha na definição de privilégios de usuário.
Solução: Implementar e verificar corretamente os níveis de acesso dos usuários.
Erro de acesso de administrador negado:

Descrição: Administrador não consegue acessar funcionalidades exclusivas.
Causa: Falha na definição de privilégios de usuário.
Solução: Verificar e corrigir a definição de privilégios de administrador.
Casos de Teste Aceitos

Teste de Funcionalidades de Administrador:

Descrição: Verificação da capacidade do usuário administrador de acessar e utilizar funcionalidades exclusivas.
Resultado: Todos os casos de teste passaram com sucesso, confirmando as funcionalidades de administrador.
Conclusão
Os testes das funcionalidades de administrador foram bem-sucedidos, garantindo que apenas usuários administradores têm acesso a funcionalidades exclusivas. Os erros identificados foram resolvidos, assegurando a correta atribuição de privilégios de acesso.

RF-008 Permitir que exista uma forma de conferir a etapa do processamento do pedido - ALTA

Erros Encontrados

Erro de atualização de status do pedido:

Descrição: O status do pedido não é atualizado corretamente.
Causa: Problemas na lógica de atualização do status ou na comunicação com o banco de dados.
Solução: Verificar a lógica de atualização e a comunicação com o banco de dados.
Erro de exibição do status do pedido:

Descrição: O status do pedido não é exibido corretamente para o usuário.
Causa: Problemas na interface do usuário ou na lógica de exibição.
Solução: Corrigir a interface do usuário e a lógica de exibição do status.
Casos de Teste Aceitos

Teste de Rastreamento de Pedido:

Descrição: Verificação da capacidade do usuário de acompanhar o status do pedido em todas as etapas do processamento.
Resultado: Todos os casos de teste passaram com sucesso, confirmando a funcionalidade de rastreamento de pedidos.
Conclusão
Os testes de rastreamento de pedidos foram concluídos com sucesso, demonstrando que o sistema permite ao usuário acompanhar o status do pedido em todas as etapas do processamento. Os erros identificados foram corrigidos, garantindo uma comunicação clara e precisa do status do pedido.

RF-009 Permitir que exista uma barra de favoritos - BAIXA

Erros Encontrados

Erro de adição à barra de favoritos:

Descrição: Falha ao adicionar produtos à barra de favoritos.
Causa: Problemas na lógica de adição ou na comunicação com o banco de dados.
Solução: Verificar e corrigir a lógica de adição e a comunicação com o banco de dados.
Erro de remoção da barra de favoritos:

Descrição: Falha ao remover produtos da barra de favoritos.
Causa: Problemas na lógica de remoção ou na comunicação com o banco de dados.
Solução: Verificar e corrigir a lógica de remoção e a comunicação com o banco de dados.
Casos de Teste Aceitos

Teste de Funcionamento da Barra de Favoritos:

Descrição: Verificação da capacidade do usuário de adicionar e remover produtos da barra de favoritos.
Resultado: Todos os casos de teste passaram com sucesso, confirmando a funcionalidade da barra de favoritos.
Conclusão
Os testes da barra de favoritos foram bem-sucedidos, demonstrando que o sistema permite ao usuário adicionar e remover produtos da barra de favoritos de forma eficiente. Os erros identificados foram corrigidos, garantindo uma experiência de usuário melhorada ao salvar produtos favoritos.

RF-0010 O sistema deve incorporar uma funcionalidade de feedback e avaliação de produtos - MÉDIA

Erros Encontrados

Erro de envio de feedback:

Descrição: Falha ao enviar o feedback do usuário sobre um produto.
Causa: Problemas na lógica de envio ou na integração com o banco de dados.
Solução: Verificar e corrigir a lógica de envio e a integração com o banco de dados.
Erro de visualização de avaliações:

Descrição: As avaliações dos produtos não são exibidas corretamente na interface.
Causa: Problemas na lógica de exibição ou na comunicação com o banco de dados.
Solução: Verificar e corrigir a lógica de exibição e a comunicação com o banco de dados.
Casos de Teste Aceitos

Teste de Feedback e Avaliação de Produtos:

Descrição: Verificação da capacidade do usuário de enviar feedback e avaliações sobre produtos.
Resultado: Todos os casos de teste passaram com sucesso, confirmando a funcionalidade de feedback e avaliação.
Conclusão
Os testes de feedback e avaliação de produtos foram concluídos com sucesso, assegurando que os usuários possam fornecer feedback e avaliações de forma eficaz. Os erros identificados foram resolvidos, garantindo uma interface precisa e informativa para os usuários.

RF-011 O sistema deve permitir que o usuário recupere sua senha - MÉDIA

Erros Encontrados

Erro de link de recuperação inválido:

Descrição: O link de recuperação de senha enviado ao usuário não funciona corretamente.
Causa: Problemas na geração ou no processamento do link de recuperação.
Solução: Verificar e corrigir a geração e o processamento do link de recuperação de senha.
Erro de e-mail não recebido:

Descrição: O usuário não recebe o e-mail de recuperação de senha.
Causa: Problemas no envio de e-mails ou na configuração do servidor de e-mails.
Solução: Verificar e corrigir a configuração do servidor de e-mails ou o processo de envio de e-mails.
Casos de Teste Aceitos

Teste de Recuperação de Senha:

Descrição: Verificação da capacidade do usuário de recuperar sua senha através do link enviado por e-mail.
Resultado: Todos os casos de teste passaram com sucesso, confirmando a funcionalidade de recuperação de senha.
Conclusão
Os testes de recuperação de senha foram bem-sucedidos, garantindo que os usuários possam recuperar suas senhas de forma eficiente e segura. Os erros identificados foram corrigidos, assegurando um processo confiável de recuperação de senha para os usuários.

Essas conclusões detalham como cada funcionalidade foi testada, quais erros foram encontrados, como foram solucionados e confirmam a adequada funcionalidade do sistema em relação aos requisitos especificados.


