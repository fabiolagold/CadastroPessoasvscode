namespace CadastroPessoasVsCode
{
    public abstract class NewBaseType
    {
        public abstract float PagarImposto(float rendimento);
    }

    public abstract class Pessoa : NewBaseType
    {
        public string nome { get; set; } 

        public Endereco endereco { get; set; }

        public float rendimento { get; set;  }
    }
}