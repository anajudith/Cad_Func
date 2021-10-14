class Funcionario {

    private string _Matricula;
    public string Matricula
    {
        get { return _Matricula; }
        set { _Matricula = value; }
    }
    
    // public string Matricula;
    public string Nome;
    public string Departamento;
    
    // public double Salario;

    private double _Salario;
    public double Salario
    {
        get { return _Salario; }
        set { 
                if(value <= 0)
            _Salario = 0;
            else 
                _Salario = value;
             }
    }
    
    public Data DataAdmissão;
}

class Data 
{
    public string Dia;
    public string Mes;
    public string Ano;

}