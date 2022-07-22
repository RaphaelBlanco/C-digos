#USE O PONTO NO LUGAR DA VIRGULA
altura = float(input("Digite sua altura: "))
peso = float(input("Digite seu peso: "))

imc = peso / (altura*altura)

if imc < 18.5:
    print(f"MAGREZA: {imc}")

elif imc >= 18.5 and imc < 25:
    print(f"NORMAL: {imc}")

elif imc >= 25 and imc < 30:
    print(f"SOBREPESO: {imc}")

elif imc >= 30 and imc < 40:
    print(f"OBESIDADE: {imc}")

else:
    print(f"OBESIDADE GRAVE: {imc}")
