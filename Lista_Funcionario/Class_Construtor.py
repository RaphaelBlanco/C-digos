from datetime import datetime

#criar classe
class Funcionarios:
    
    def __init__(self, nome, sobrenome, data_nasc):
        self.nome = nome
        self.sobrenome = sobrenome
        self.data_nasc = data_nasc
    
    def NomeCompleto(self):
        return self.nome + " " + self.sobrenome
    
    def Idade(self):
        ano_atual = datetime.now().year
        self.data_nasc = int(ano_atual - self.data_nasc)
        return self.data_nasc

#criar objeto
usuario1 = Funcionarios("Elena", "Cabral", 1999)
usuario2 = Funcionarios("Rafaella", "Amaral", 1998)

#print
print(usuario2.NomeCompleto())
#print(Funcionarios.NomeCompleto(usuario2))
print(usuario1.Idade())