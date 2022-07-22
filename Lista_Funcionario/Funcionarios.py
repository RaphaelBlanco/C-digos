funcionarios = ["Ana", "Marcos", "Alice", "Pedro", "Sophia", "Bruno", "Melissa"]
turno_dia = ["Ana", "Marcos", "Alice", "Melissa"]
turno_noite = ["Pedro", "Sophia", "Bruno"]
tem_carro = ["Marcos", "Alice", "Bruno", "Melissa"]

set1 = set(funcionarios)
set2 = set(turno_dia)
set3 = set(turno_noite)
set4 = set(tem_carro)

print(f"Funcionarios que tem carro e trabalham a noite: {set1 & set3 & set4}")
print(f"Funcionarios que tem carro e trabalham de dia: {set1 & set2 & set4}")
print(f"Funcionarios que nao tem carro: {set1 - set4}")