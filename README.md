# Calculadora de IMC (Índice de Massa Corporal)

Bem-vindo à Calculadora de IMC! Este é um programa Windows Forms que permite calcular o Índice de Massa Corporal (IMC) com base no peso e na altura inseridos pelo usuário. Siga as instruções abaixo para utilizar a aplicação corretamente.

## Requisitos do Sistema

- Computador com sistema operacional Windows.
- Ambiente de desenvolvimento compatível com Windows Forms (por exemplo, Visual Studio).
- Conhecimentos básicos em programação com C#.

<img width="266" alt="1" src="https://user-images.githubusercontent.com/90057261/189719132-f72dadeb-edee-46da-b12f-da57359efdf9.png">  <img width="268" alt="2" src="https://user-images.githubusercontent.com/90057261/189719185-161e1e4b-be28-4f3b-9010-fa10ea9baed3.png">

## Como Usar

1. Abra o ambiente de desenvolvimento e crie um novo projeto Windows Forms.

2. Na janela de design do formulário principal, adicione os seguintes componentes:
   - Rótulos para exibir instruções e resultados.
   - Caixas de texto para o usuário inserir o peso (em quilogramas) e a altura (em metros).
   - Um botão de cálculo.

3. No evento de clique do botão de cálculo, adicione a lógica para calcular o IMC com base nos valores digitados pelo usuário.

4. Utilize a fórmula do IMC para realizar o cálculo:
   
    
        public string CalcclassifiIMC(double P,double A)
        {

            double imc = P / (A * A);

            if (imc < 18.49)
            {
                return ("Peso abaixo do normal ");
            }
            else if (imc <= 24.99)
            {
                return ("Peso normal ");
            }
            else if (imc <= 29.99)

            {
                return ("Sobrepeso ");
            }
            else if (imc <= 34.99)
            {
                return ("Grau de Obesidade I ");
            }
            else if (imc <= 39.99)
            {
                return ("Grau de Obesidade II ");
            }
            else
            {
                return ("Obesidade Grau III ");
            }
        }
    

   Lembre-se de tratar possíveis erros de divisão por zero ou valores inválidos.

5. Utilize uma estrutura condicional (if/else, switch/case) para interpretar o valor do IMC calculado e exibir uma mensagem correspondente.

6. Por exemplo, você pode usar as seguintes faixas de IMC para gerar as mensagens:
   - IMC abaixo de 18,5: "Abaixo do peso"
   - IMC entre 18,5 e 24,9: "Peso normal"
   - IMC entre 25 e 29,9: "Sobrepeso"
   - IMC entre 30 e 34,9: "Obesidade grau 1"
   - IMC entre 35 e 39,9: "Obesidade grau 2"
   - IMC acima de 40: "Obesidade grau 3"

7. Exiba a mensagem correspondente ao resultado do IMC no rótulo apropriado.

8. Execute a aplicação e teste inserindo diferentes valores de peso e altura para calcular o IMC.

## Contribuição

Este projeto foi desenvolvido pela Pâmela Borges. Se você identificar algum problema ou desejar contribuir para o projeto, fique à vontade para abrir uma issue ou enviar um pull request no repositório do GitHub.

Esperamos que a Calculadora de IMC seja útil para você. Cuide da sua saúde!

![Visitors](https://api.visitorbadge.io/api/visitors?path=https%3A%2F%2Fgithub.com%2Fpblda13%2FCalculadora_IMC_Forms&label=Visitantes&countColor=%23f47373&style=flat-square)


