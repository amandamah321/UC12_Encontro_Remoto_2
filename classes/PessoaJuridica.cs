using System.Text.RegularExpressions;
using Encontro_Remoto.interfaces;

namespace Encontro_Remoto.classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj { get; set; }

        public string? razaoSocial { get; set; }

        public override float calcularImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return rendimento * .03f;
            }
            else if (rendimento <= 6000)
            {
                return rendimento * .05f;
            }
            else if (rendimento <= 10000)
            {
                return rendimento * .07f;
            }
            else
            {
                return rendimento * .09f;
            }

        }

        public bool ValidarCnpj(string cnpj)
        {
            bool retornoCnpjValido = Regex.IsMatch(cnpj, @"^(\d{14})|(\d {2}.\d{3}.\{3}./\d{4}-\d{2}.)$");

            if (retornoCnpjValido)
            {
                string subStringCnpj14 = cnpj.Substring(8, 4);

                if (subStringCnpj14 == "0001")
                {
                    return true;
                }
                // CONTINUAR EM 2:03:34 
            }



            string subStringCnpj18 = cnpj.Substring(11, 4);

            if (subStringCnpj18 == "0001")
            {
                return true;
            }

            return false;


        }
    }
}