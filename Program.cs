using Sistema_de_Hospedagem.Models;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedesP = new List<Pessoa>();
List<Pessoa> hospedesD = []; //inicializando lista

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new(nome: "Hóspede 2");
Pessoa p3 = new(nome: "Hóspede 1");
Pessoa p4 = new(nome: "Hóspede 2");
Pessoa p5 = new(nome: "Hóspede 1");
Pessoa p6 = new(nome: "Hóspede 2");

hospedesP.Add(p1);
hospedesP.Add(p2);

hospedesD.Add(p3);
hospedesD.Add(p4);
hospedesD.Add(p5);
hospedesD.Add(p6);


// Cria a suíte
Suite parizi = new(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);
Suite petuni = new(tipoSuite: "Deluxe", capacidade: 4, valorDiaria: 150);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reservaP = new(diasReservados: 5);
reservaP.CadastrarSuite(parizi);
reservaP.CadastrarHospedes(hospedesP);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reservaD = new(diasReservados: 15);
reservaD.CadastrarSuite(petuni);
reservaD.CadastrarHospedes(hospedesD);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reservaP.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reservaP.CalcularValorDiaria()}\n");

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reservaD.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reservaD.CalcularValorDiaria()}\n");




