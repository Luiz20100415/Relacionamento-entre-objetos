using System;
using RelacionamentoEntreObjetos;

// Exercicio 1
// Veiculo veiculo = new Veiculo("Toyota", "Corolla");
// veiculo.ExibirInformacoes();

// Carro carro = new Carro(4);
// carro.Marca = "Honda";
// carro.Modelo = "Civic"; 
// carro.ExibirInformacoesCarro();

// Moto moto = new Moto(600);
// moto.Marca = "Yamaha";
// moto.Modelo = "R1";
// moto.ExibirInformacoesMoto();

// Exercicio 2
// ProdutoDigital produtoDigital = new ProdutoDigital("Curso de C#", 199.99m, 1);
// produtoDigital.ExibirInformacoesProdutoDigital();

// Ebook ebook = new Ebook("X-Men: A Guerra Fria", 89.99m, 350);
// ebook.ExibirInformacoesEbook();

// CursosOnline cursoOnline = new CursosOnline("Desenvolvimento de Sistemas", 199.99m, 1200);
// cursoOnline.ExibirInformacoesCursoOnline();


// Exercicio 3
// JogoDigital jogoDigital = new JogoDigital("The Last of Us", "PlayStation 4", 50.0);
// jogoDigital.ExibirInformacoesJogo();

// JogoFisico jogoFisico = new JogoFisico("FIFA 23", "PlayStation 5", "Discos");
// jogoFisico.ExibirInformacoesJogo();


// Exercicio 4
// Notificacao email= new NotificacaoEmail();
// email.Enviar();

// Notificacao sms = new NotificacaoSMS();
// sms.Enviar();

// Notificacao push = new NotificacaoPush();
// push.Enviar();


// Exercicio 5
// List<Entrega> entregas = new List<Entrega>
// {
//      new EntregaExpressa(50),
//      new EntregaEconomica(50),
//      new RetiradaLocal(50)
// };

// foreach (Entrega entrega in entregas)
// {
//      Console.WriteLine($"Tipo: {entrega.GetType().Name} | Distância: {entrega.Distancia} km | Frete: {entrega.CalcularFrete():C}");
// }

// Exercicio 6
// Relatorio relatorio = new Relatorio("Vendas Trimestrais");
// Contrato contrato = new Contrato("2026-089");
     
// relatorio.Imprimir();
// relatorio.Exportar();

// Console.WriteLine();
// contrato.Imprimir();

// Exercicio 7
// Notebook notebook = new Notebook("Dell Latitude 5440", "1234567", 16);
// Smartphone smartphone = new Smartphone("Samsung Galaxy S24", "12345678", 256);

// notebook.ExibirInformacoes();
// smartphone.ExibirInformacoes();

// Exercicio 8
// List<Animal> animais = new List<Animal>
// {
//     new Cachorro("Claudio"),
//     new Gato("luis Boquinha"),
//     new Passaro("Corinthians")
// };

// foreach (Animal animal in animais)
// {
// animal.Apresentar();
// animal.EmitirSom();
// }

// Exercicio 9
// IArmazenavel armazenamento;
        
// armazenamento = new ArquivoTexto();
// armazenamento.Salvar("Relatório financeiro de 2026.");
// armazenamento.Ler();
           
// armazenamento = new BancoDados();
// armazenamento.Salvar("ID: 101 | Cliente: Maria Silva");
// armazenamento.Ler();

// Exercicio 10
// IContratavel servicoContratavel;

// servicoContratavel = new Hospedagem("Plano Cloud Pro");
// servicoContratavel.Contratar();

// servicoContratavel = new Consultoria("Arquitetura de Software");
// servicoContratavel.Contratar();

// Console.WriteLine();


// ICancelavel servicoCancelavel = new Hospedagem("Plano Cloud Pro");
// servicoCancelavel.Cancelar();


        
