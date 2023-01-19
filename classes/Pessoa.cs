using Encontro_Remoto.interfaces;

namespace Encontro_Remoto.classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? nome { get; set; }

        public int rendimento { get; set; }

        public Endereco? end { get; set; }



        public abstract float calcularImposto(float rendimento);
    }
}