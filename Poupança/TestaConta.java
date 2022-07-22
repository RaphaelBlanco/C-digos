
package heranca;

public class TestaConta {
    
    public static void main(String[] args) {
        
        Conta c1 = new Conta ("123", 120.00);
        c1.getSaldo();
        c1.creditar(200);
        c1.debitar(100);
        
        Poupanca p1 = new Poupanca("345", 150.00);
        p1.getSaldo();
        p1.renderJuros(0.01);
        p1.getSaldo();
        
        Conta poupanca = new Poupanca("567", 200.00);
        poupanca.getSaldo();
           
    }
}
