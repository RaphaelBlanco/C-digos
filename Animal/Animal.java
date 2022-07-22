
package animal;

public class Animal {
    
        String nome;
        float comprimento;
        int patas;
        String cor;
        String ambiente;
        float velmedia;

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public float getComprimento() {
        return comprimento;
    }

    public void setComprimento(float comprimento) {
        this.comprimento = comprimento;
    }

    public int getPatas() {
        return patas;
    }

    public void setPatas(int patas) {
        this.patas = patas;
    }

    public String getCor() {
        return cor;
    }

    public void setCor(String cor) {
        this.cor = cor;
    }

    public String getAmbiente() {
        return ambiente;
    }

    public void setAmbiente(String ambiente) {
        this.ambiente = ambiente;
    }

    public float getVelmedia() {
        return velmedia;
    }

    public void setVelmedia(float velmedia) {
        this.velmedia = velmedia;
    }

        
    public Animal(String nome, float comprimento, int patas, String cor, String ambiente, float velmedia){
        this.nome = nome;
        this.comprimento = comprimento;
        this.cor = cor;
        this.ambiente = ambiente;
        this.velmedia = velmedia;
         
    }
       public void imprimir (){
        System.out.println("O nome dele e: "+ nome + " possui um comprimento de " 
                + comprimento + " de cor " + cor + " vive no ambiente "+ ambiente + " e tem a velocidade media de " + velmedia);
    }
     
}
