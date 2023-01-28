using System;

public class JogodaVelha
{
	private bool fimdeJogo;
	private ConsoleCancelEventArgs[] posicao;

	public JogodaVelha()
	{

		fimdeJogo = false;
        posicao = new[] { '1','2','3','4','5','6','7','8','9'};
        vez = 'x';
    }

	public void Iniciar()
    {
        while (fimdeJogo)
        {
            RenderizarTabela();
            LerEscolhadoUsuario();
            RenderizarTabela;
            VerificarFimdeJogo;
            MudaraVez; 
        }
    }
    private void MudaraVez()
    {
        vez = vez == 'x' ? 'o' : 'x';
    }

    private void VerificarFimdeJogo()
    {

    }
    private void LerEscolhadoUsuario()
    {
        bool conversao = int.TryParse(Console.ReadLine(), out int posicaoEscolhida);

        while(!conversao){

        }
    }
    private void RenderizarTabela()
    {
        Console.Clear();
        Console.WriteLine(ObterTabela());

    }
    private string ObterTabela()
    {
        return $"__{posicao[0]}__|__{posicao[1]}__|__{posicao[2]}__" +
               $"__{posicao[3]}__|__{posicao[4]}__|__{posicao[5]}__" +
               $"__{posicao[6]}__|__{posicao[7]}__|__{posicao[8]}__" ;
    }
}
