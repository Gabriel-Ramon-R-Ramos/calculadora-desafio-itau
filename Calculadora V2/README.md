## ✅ Correções feitas
Este projeto contém tratamentos de erros e feedbacks para auxiliar o desenvolvedor durante o uso da aplicação.

### 🧮 Arquivo `Calculadora.cs`

**Alterações feitas:**

- A correção do processamento infinito da fila (Queue)
    - Alterado `Peek()` para `Dequeue()`
- Implementação da operação de divisão
- Tratamento de erro de divisão por 0
- Tratamento de erro por Overflow de dados
- Inclusão de mensagens de feedback ao desenvolvedor sobre erros potenciais

---
#### Explicação:
O loop infinito ocorria porque o código utilizava `Peek()` — que apenas **lê o primeiro elemento da fila sem removê-lo** — em vez de `Dequeue()`, que **remove e retorna** o primeiro elemento, permitindo avançar na fila.

A operação de divisão foi implementada com tratamento para divisão por zero.

A penúltima operação do desafio apresentava erro por estouro de valor (overflow). O tipo int em C# suporta até 2.147.483.647. Somar valores acima disso causa retorno ao valor negativo mínimo (-2.147.483.648).

### 🛠 Arquivo: `Utils.cs`
>  Este arquivo foi criado para **centralizar funções reutilizáveis**, melhorando a organização do código.

**Funções Implementadas**:

- `LerFilaOperacoes()` — faz a leitura de todos os itens da fila, sem consumi-los
- `LerPilhaResultados()` — faz a leitura e consumo de todos os itens da pilha (Stack)

### 💻 Arquivo `Program.cs`

**Alterações feitas:**

- Criação da pilha (Stack) para armazenar os resultados
- Uso das funções utilitárias para exibir fila e pilha

#### **Explicação:**
A pilha foi criada para armazenar os resultados das operações, conforme o desafio solicitava. Após cada cálculo, os resultados são empilhados e exibidos no final.

---

**🔍Nota importante:** Esta é uma versão alternativa do projeto, focada apenas no tratamento de erros.
Ela não representa a versão completa do desafio com todas as funcionalidades solicitadas. 

Para acessar a versão completa e recomendada, acesse este link: <br>
👉 [Versão completa do desafio](https://github.com/Gabriel-Ramon-R-Ramos/calculadora-desafio-itau/tree/main/Calculadora).
