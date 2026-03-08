namespace DTOs.Psi;


public class ReturnPsicologoDTO{
    public int Id {get; set;}
    public string Name {get; set;}
    public string Adress {get; set;}
    public string CPF {get; set;}
    public string CRP {get; set;}
    public int Age {get; set;}
    public string Espciacilization {get; set;}
    public string Email {get; set;}

    //isso ai eh o tipo do mtodo http que o controller vai receber, get so puxa dados, put atualiza, post cria e delet deleta 

}// mano tava vendo, o bgl q vai ter os metodos, nao é metodo, esqueci a palavra, ms tipo é get, put, post e delete