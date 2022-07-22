
package animal;

public class TestarAnimal {
    
    public static void main(String[] args) {
        
        Mamifero c1 = new Mamifero("CAMELO" ,150 ,4,"AMARELO","TERRA",2 );
        c1.imprimir();
        
        Peixe p1 = new Peixe("BARBATANAS E CAUDAS","TUBARAO", 300, 0, "CINZENTO", "MAR", (float)1.5);
        p1.imprimir();
    }
    
}
