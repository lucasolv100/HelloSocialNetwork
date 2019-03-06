using HelloSocialNetwork.Domain.Enums;

namespace HelloSocialNetwork.Domain.Entities
{
    public class ProcurandoPor
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool NaoEspecificado { get { return Id == (int)ProcurandoEnum.NaoEspecificado;} }
        public bool Namoro { get { return Id == (int)ProcurandoEnum.Namoro;} }
        public bool Amizade { get { return Id == (int)ProcurandoEnum.Amizade;} }
        public bool VerNoQueDa { get { return Id == (int)ProcurandoEnum.VerNoQueDa;} }

    }
}