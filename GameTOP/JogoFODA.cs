using GameTOP.Interface;
using GameTOP.Lib;

namespace GameTOP
{
    class JogoFODA {
        
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;

        public JogoFODA(iJogador jogador1,iJogador jogador2) {
            _jogadorA = jogador1;
            _jogadorB = jogador2;
        }

        public void IniciarJogo(){
            System.Console.WriteLine(_jogadorA.Corre()+"\n"+_jogadorA.Chuta()+"\n"+_jogadorA.Passe());
            System.Console.WriteLine("\n PRÔXIMO JOGADOR \n");
            System.Console.WriteLine(_jogadorB.Corre()+"\n"+_jogadorB.Chuta()+"\n"+_jogadorB.Passe());
        }
    }
}