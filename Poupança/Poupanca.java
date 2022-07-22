
package heranca;


public class Poupanca extends Conta {
    
    public Poupanca(String numero, double saldo) {
        super(numero, saldo);
    }
    
    public void getSaldo(){
      System.out.println("Saldo da Poupança " + getNumero() + " - " + saldo );
    }
   
    public void renderJuros (double taxa){
        saldo = saldo * (1+taxa);       
    }
    
}
