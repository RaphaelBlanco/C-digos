temperatura = int(input("Qual a temperatura da carne: "))

if temperatura < 48:
    print("Precisa assar mais")

elif temperatura >= 48 and temperatura < 54:
    print("Rare (selada)")

elif temperatura >= 54 and temperatura < 60:
    print("Medium (ao ponto para o mal)")

elif temperatura >= 60 and temperatura < 65:
    print("Medium (ao ponto)")

elif temperatura >= 65 and temperatura < 71:
    print("Medium well (ao ponto para o bem)")

else:
    print("well done(bem passada)")