namespace aula;
class Exemplo
{
    public string nome = "";
    public int idade = 0;
    public bool vacinado = false;

    //metodos
    public void mostramsg(){
        Console.WriteLine("Oi 2F!");

    }

    public void mostranome(string texto){
        Console.WriteLine("OI " + texto);
    }

    public string msg(){
        return "Ola tudo certo!";
    }

    public int somar(int a,int b){
         return a+b;
    }
}


