namespace heranca_polimorfismo;

class FuncionarioN2:Funcionario
{
    public override double Lucro(){
        return base.Lucro()*0.02;
    }
}