using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public readonly string _Nome;
        public Jogador2(string nome)
        {
            _Nome = nome;
        }
        string iJogador.Chuta()
        {
            return $"{_Nome} está chutando!";
        }

        string iJogador.Corre()
        {
            return $"{_Nome} está correndo!";
        }

        string iJogador.Passe()
        {
            return $"{_Nome} está passando!";
        }
    }
}