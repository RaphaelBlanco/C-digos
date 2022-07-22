    
package animal;

public class Peixe extends Animal{
    String caracteristica;

    public String getCaracteristica() {
        return caracteristica;
    }

    public void setCaracteristica(String caracteristica) {
        this.caracteristica = caracteristica;
    }
    
    public Peixe (String caracteristica, String nome, float comprimento, int patas, String cor, String ambiente, float velmedia){
        super(nome, comprimento, patas, cor, ambiente, velmedia);
        this.caracteristica = caracteristica;
    }
 
     public void imprimir (){
        System.out.println("O nome dele e: "+ nome + " possui um comprimento de " + comprimento + " de cor " + cor + " vive no ambiente "+ ambiente +
                "e tem a velocidade media de " + velmedia);
        
    }
}
