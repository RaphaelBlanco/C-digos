
package heranca;

public class Conta {
    private String numero;
    public double saldo;
   
    public Conta(String numero, double saldo){
            this.numero = numero;
            this.saldo = saldo;
    }
    
    public void creditar (double valor){
            this.saldo += valor;
    }
    
    public boolean debitar (double valor){
        this.saldo -= valor;
        if(saldo > 0 && valor < saldo){
            this.saldo = saldo - valor;
            System.out.println("saldo atual: " + this.saldo);
        }else{
            System.out.println("Saldo insuficiente ");
        }
        return false;
    }
    
    public void getSaldo(){
        System.out.println("Saldo da conta: " + numero + " - " + saldo);
    }

    public String getNumero(){
        return numero;
    }

}

