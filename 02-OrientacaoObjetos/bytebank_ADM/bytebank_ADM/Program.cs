using bytebank_ADM.Funcionarios;
using bytebank_ADM.ParceriaComercial;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;

//CalcularBonificacao();
UsarSistema();

void CalcularBonificacao()
{
    Console.WriteLine("Boas vindas ao ByteBank Administração!\n");

    GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

    Designer pedro = new Designer("533.588.933-00");
    pedro.Nome = "Pedro";

    Desenvolvedor samya = new Desenvolvedor("665.999.875.99");
    samya.Nome = "Samya";

    Diretor paula = new Diretor("788.022.094-88");
    paula.Nome = "Paula";

    Auxiliar igor = new Auxiliar("233.544.366-66");
    igor.Nome = "Igor";

    GerenteContas camila = new GerenteContas("933.544.755-33");
    camila.Nome = "Camila";


    gerenciador.Registrar(pedro);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);

    Console.WriteLine("Total de Bonificação: " + gerenciador.GetTotalBonificacao());
}

void UsarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();

    Diretor paula = new Diretor("788.022.094-88");
    paula.Nome = "Paula";
    paula.Senha = "123";

    GerenteContas camila = new GerenteContas("933.544.755-33");
    camila.Nome = "Camila";
    camila.Senha = "1273";

    ParceiroComercial joao = new ParceiroComercial();
    joao.Senha = "1234";

    sistemaInterno.Logar(paula, "123");
    sistemaInterno.Logar(camila, "123");
    sistemaInterno.Logar(joao, "1234");
}


Console.ReadKey();