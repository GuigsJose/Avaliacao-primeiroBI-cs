//ex 8
public class Curso{

    public string Tipo{get;set;}
    public bool Concluido{get;set;}
    public double nota1, nota2, nota3;

    public Curso(){
        Concluido = false;
    }

    public double CalcularMedia(){
        return (nota1 + nota2 + nota3)/3;
    }

    public bool Certificado(){
        if(CalcularMedia() >= 6){
            return Concluido = true;
        }else{
            return Concluido = false;
        }
    }

}