nome = input("Digite seu nome: ")
peso = float(input("Digite seu peso: "))
altura = float(input("Digite sua altura: "))

imc = peso / (altura*altura)

if imc < 18.4:
    print("Abaixo do peso")
else:
    if imc >= 18.5 and imc < 24.9:
        print("Peso normal")
    else:
        print("Acima do peso") 

    