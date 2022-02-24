using System;

namespace CadastroPessoasVsCode
{
    public class PessoaFisica : Pessoa
    {
        public string cpf { get; set; }

        public DateTime dataNascimento { get; set; }

        public  override float PagarImposto(float rendimento)
        {
            if (rendimento<=1500)
            {
                return 0;

            }else if (rendimento > 1500 && rendimento <= 3500)
            {
                return rendimento * .02f;

            }else if (rendimento > 3500 && rendimento <= 6000)

            {
                return rendimento * .035f;
            }else
            {
                return rendimento * .05f;
            }

        }

        public bool ValidarDataNascimento(DateTime dataNasc){
            
            DateTime dataAtual = Datetime.Today;
            
            double anos = (dataAtual - datanasc).TotalDays / 365;

            console.writeLine($"{anos}");

            if(anos>=18)
            {
                return true;   
            }

            return false;
        }
    }
}