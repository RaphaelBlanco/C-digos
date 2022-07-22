
package animal;

public class Mamifero extends Animal {
    String alimento;

    public String getAlimento() {
        return alimento;
    }

    public void setAlimento(String alimento) {
        this.alimento = alimento;
    }
    
    public Mamifero(String nome, float comprimento, int patas, String cor, String ambiente, float velmedia) {
        super(nome, comprimento, patas, cor, ambiente, velmedia);
        this.alimento = alimento;
    }
     public void dadosMamiferos (){
        System.out.println("O nome dele e: "+ nome + " possui um comprimento de " + comprimento + " de cor " + cor + " vive no ambiente "+ ambiente +
                "e tem a velocidade media de " + velmedia + "se alimenta de "+ alimento);
    
    }
}
