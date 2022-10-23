using ConsoleApp2;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

//Classes dos animais

public class Animal 
{
    // Classe mãe com os principais atributos que todo animal tem;
     
    protected string _nome;
    public string Nome { get { return this._nome; } set{ this._nome = value; } }


    //Futuramente mudar int idade para uma lógica onde se tem uma ideia princial de data de nascimento
    //e criar uma função onde retorna a idade convertida quando no cadastro se colocar a data de nascimento do animal

    protected int _idade;
    public int Idade { get { return this._idade; } set { this._idade = value; } }

    protected string _genero;
    public string Genero { get { return this._genero; } set { this._genero = value; } }


    protected string _habitat;
    public string Habitat { get { return this._habitat; } set { this._habitat = value; } }


    protected string _alimento;
    public string Alimento { get { return this._alimento; } set { this._alimento = value; } }


    protected string _localidade;
    public string Localidade { get { return this._localidade; } set { this._localidade = value; } }
}


public class Mamiferos : Animal
{

    private string _familia;
    public string Familia 
    { get { return this._familia; } set { this._familia = value; } }

    private string _classes;
    public string Classes { get { return this._classes; } set { this._classes = value; } }



    public Mamiferos(string nome, int idade, string genero,string habitat,string familia, string localidade,string alimento, string classes)
    {
        
       
        _nome = nome;
        _idade = idade;
        _genero = genero;
        _habitat = habitat;
        _alimento = alimento;
        _localidade = localidade;
        _familia = familia;
        _classes = classes;
    }

    public Mamiferos()
    {
    }
}  


public class Repteis: Animal
    {

    private string _familia;
    public string Familia
    { get { return this._familia; } set { this._familia = value; } }


    private string _tipoEscama;
    public string TipoEscama { get { return this._tipoEscama; } set { this.TipoEscama = value; } }



    public Repteis(string nome, int idade, string genero, string habitat, string familia, string localidade, string alimento, string tipoEscama)
    {

        _nome = nome;
        _idade = idade;
        _genero = genero;
        _habitat = habitat;
        _localidade = localidade;
        _familia = familia;
        _alimento = alimento;
        _tipoEscama = tipoEscama;
    }

}


public class Aves: Animal
    {

    private string _familia;
    public string Familia
    {get { return this._familia; } set { this._familia = value; }}

    private string _tipoPlumagem;
    public string TipoPlumagem { get { return this._tipoPlumagem; } set { this._tipoPlumagem = value; } }

    public Aves(string nome, int idade, string genero, string habitat, string familia, string localidade, string alimento, string tipoPlumagem)
    {

        _nome = nome;
        _idade = idade;
        _genero = genero;
        _habitat = habitat;
        _localidade = localidade;
        _familia = familia;
        _alimento = alimento;
        _tipoPlumagem = tipoPlumagem;
    }
}


public class Anfibios : Animal
{

    private string _familia;
    public string Familia
    { get { return this._familia; } set { this._familia = value; } }


    public Anfibios(string nome, int idade, string genero, string habitat, string familia, string localidade, string alimento)
    {

        _nome = nome;
        _idade = idade;
        _genero = genero;
        _habitat = habitat;
        _localidade = localidade;
        _familia = familia;
        Alimento = alimento;
        
    }
}


public class Peixes: Animal
{
    private string _familia;
    public string Familia
    { get { return this._familia; } set { this._familia = value; } }

    public string TipoAgua;

    public Peixes(string nome, int idade, string genero, string habitat, string familia, string localidade, string alimento, string tipoAgua)
    {

        _nome = nome;
        _idade = idade;
        _genero = genero;
        _habitat = habitat;
        _localidade = localidade;
        _familia = familia;
        _alimento = alimento;
        TipoAgua = tipoAgua;

    }

}














class Zoologico
{


    static void Main()
    {
        Boolean rodando = true; //while looping

        //Animais já "Cadastrados" no zoologico\\
        cadastroMamiferos.Add(new Mamiferos("Chico", 10, "Macho", "Norte da Africa", "Chipanzé", "1", "Frutas", "Primata"));
        cadastroAnfibios.Add(new Anfibios("Cururu", 1, "Macho", "Austrália", "Sapo Cururu", "3", "Sapos Menores"));
        cadastroAves.Add(new Aves("Blu", 3, "Macho", "Floresta Amazonica", "Arara Azul", "5", "Frutas", "Azul"));
        cadastroPeixes.Add(new Peixes("Dory", 1, "Fêmea", "Oceano Pacífico", "Peixe azul", "Aquário", "Plânctons", "Salgada"));

        while (rodando)
        {

            

            Console.WriteLine("*********************");
            Console.WriteLine("      ZooGabriel");
            Console.WriteLine("*********************");
            Console.WriteLine("");
            Console.WriteLine("**********************************");
            Console.WriteLine("    O que você gostaria fazer?    ");
            Console.WriteLine("**********************************");
            Console.WriteLine("1- Ver Animais do zoologico");
            Console.WriteLine("2- Realizar cadastro de Animais");
            Console.WriteLine("3- notas sobre o Código");
            Console.WriteLine("4- sair");
            Console.WriteLine("**********************************");
            Console.Write("-> ");
            int resposta = Convert.ToInt32(Console.ReadLine());

            if (resposta == 1)
            {
                ///Futuramente adicionar todos os animais cadastrados em um banco de dados e criar função para fazer essa consulta///

                consultaCadastro();

            }
            else if (resposta == 2)
                cadastroAnimais();

           

            //CRIAR ELSE IF PARA CONSULTA DOS ANIMAIS POR BLOCO DO ZOOLOGICO
            //CRIAR ELSE IF PARA REMOVER ANIMAIS DO BANCO DE DADOS E CRIAR HISTORICO DE ANIMAIS


            else if (resposta == 3)
            {
                Console.WriteLine("");
                Console.WriteLine(
                "Essa é a primeira versão do mini sistema de zoologico, usei o que aprendi com logica" +
                "e orientação a objetos  para tentar aprender e aplicar mais os conceitos aprendidos " +
                "durante o processo. Futuramente pretendo fazer uma tela para o programa alem de"+
                "implementar conceitos de banco de dados.");
                Console.WriteLine("");
                Console.ReadKey();
                Console.WriteLine("");

            }

            else if (resposta == 4)
            {
                Console.WriteLine("Até a proxima!!!!!");
                Console.WriteLine("");
                rodando = false;

            }


        }






        
    }


    static List<Mamiferos> cadastroMamiferos = new List<Mamiferos>();
    static List<Anfibios> cadastroAnfibios = new List<Anfibios>();
    static List<Aves> cadastroAves = new List<Aves>();
    static List<Peixes> cadastroPeixes = new List<Peixes>();
    static List<Repteis> cadastroRepteis = new List<Repteis>();

    static void cadastroAnimais()
    {


        Boolean cadastro = true;

        while (cadastro)
        {

            Console.WriteLine("");
            Console.WriteLine("    Primeiro escolha o seu tipo:");
            Console.WriteLine("**********************************");
            Console.WriteLine("           1- Anfíbios");
            Console.WriteLine("           2- Aves");
            Console.WriteLine("           3- Mamiferos");
            Console.WriteLine("           4- Peixes");
            Console.WriteLine("           5- Répteis");
            Console.WriteLine("**********************************");
            Console.Write("-> ");
            int resposta1 = Convert.ToInt32(Console.ReadLine());


            if (resposta1 == 1) //Anfibios
            {
                //escrever os parametros do objeto
                Console.WriteLine("Nome:");
                Console.Write("> ");
                string nome = Console.ReadLine();

                Console.WriteLine("Idade");
                Console.Write("> ");
                int idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Genero:");
                Console.Write("> ");
                string genero = Console.ReadLine();

                Console.WriteLine("Habitat:");
                Console.Write("> ");
                string habitat = Console.ReadLine();

                Console.WriteLine("Espécie");
                Console.Write("> ");
                string especie = Console.ReadLine();

                Console.WriteLine("Local de origem");
                Console.Write("> ");
                string local = Console.ReadLine();

                Console.WriteLine("Alimento Principal");
                Console.Write("> ");
                string alimento = Console.ReadLine();

               
                cadastroAnfibios.Add(new Anfibios(nome, idade, genero, habitat, especie, local, alimento));

                                             //bloco que quebra o ciclo while\\
                //____________________________________________________________________________________________//

                Console.WriteLine("");
                Console.WriteLine("**********************************");
                Console.WriteLine("deseja cadastrar outro Animal? 1/0");
                Console.WriteLine("**********************************");
                Console.WriteLine("");
                Console.Write(">");
                int respostaContinuar = Convert.ToInt32(Console.ReadLine());

                if (respostaContinuar == 1)
                {
                    Console.WriteLine("");

                    foreach (Anfibios i in cadastroAnfibios)
                        Console.WriteLine(i.Nome + " Foi cadastrado com sucesso no sistema. ");
                        
                    Console.WriteLine("");
                }

                else{

                    foreach (Aves i in cadastroAves)
                        Console.WriteLine(i.Nome + " Foi cadastrado com sucesso no sistema. ");

                    Console.WriteLine("");


                    cadastro = false;
                }
                //____________________________________________________________________________________________//

            }//Anfibios

            else if (resposta1 == 2) //Aves
            {
                Console.WriteLine("Nome:");
                Console.Write("> ");
                string nome = Console.ReadLine();

                Console.WriteLine("Idade");
                Console.Write("> ");
                int idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Genero:");
                Console.Write("> ");
                string genero = Console.ReadLine();

                Console.WriteLine("Habitat:");
                Console.Write("> ");
                string habitat = Console.ReadLine();

                Console.WriteLine("Espécie");
                Console.Write("> ");
                string especie = Console.ReadLine();

                Console.WriteLine("Local de origem");
                Console.Write("> ");
                string local = Console.ReadLine();

                Console.WriteLine("Alimento Principal");
                Console.Write("> ");
                string alimento = Console.ReadLine();

                Console.WriteLine("Plumagem");
                Console.Write("> ");
                string plumagem = Console.ReadLine();


                cadastroAves.Add(new Aves(nome, idade, genero, habitat, especie, local, alimento, plumagem));

                                               //bloco que quebra o ciclo while\\
                //____________________________________________________________________________________________//

                Console.WriteLine("");
                Console.WriteLine("**********************************");
                Console.WriteLine("deseja cadastrar outro Animal? 1/0");
                Console.WriteLine("**********************************");
                Console.WriteLine("");
                Console.Write(">");
                int respostaContinuar = Convert.ToInt32(Console.ReadLine());

                if (respostaContinuar == 1)
                {
                    Console.WriteLine("");

                    foreach (Aves i in cadastroAves)//percorre a lista
                        Console.WriteLine(i.Nome + " Foi cadastrado com sucesso no sistema. ");
                    
                    Console.WriteLine("");
                }

                else{

                    foreach (Aves i in cadastroAves)//percorre a lista
                        Console.WriteLine(i.Nome+" Foi cadastrado com sucesso no sistema. ");

                    Console.WriteLine("");

                    cadastro = false;
                }
                //____________________________________________________________________________________________//


            }//Aves

            else if (resposta1 == 3) //Mamiferos
            {
                //escrever os parametros do objeto
                Console.WriteLine("Nome:");
                Console.Write("> ");
                string nome = Console.ReadLine();

                Console.WriteLine("Idade");
                Console.Write("> ");
                int idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Genero:");
                Console.Write("> ");
                string genero = Console.ReadLine();

                Console.WriteLine("Habitat:");
                Console.Write("> ");
                string habitat = Console.ReadLine();

                Console.WriteLine("Espécie");
                Console.Write("> ");
                string especie = Console.ReadLine();

                Console.WriteLine("Local de origem");
                Console.Write("> ");
                string local = Console.ReadLine();

                Console.WriteLine("Alimento Principal");
                Console.Write("> ");
                string alimento = Console.ReadLine();

                Console.WriteLine("Classe");
                Console.Write("> ");
                string classe = Console.ReadLine();
  
                cadastroMamiferos.Add(new Mamiferos(nome, idade, genero, habitat, especie, local, alimento, classe));

                                              //bloco que quebra o ciclo while\\
                //____________________________________________________________________________________________//

                Console.WriteLine("");
                Console.WriteLine("**********************************");
                Console.WriteLine("deseja cadastrar outro Animal? 1/0");
                Console.WriteLine("**********************************");
                Console.WriteLine("");
                Console.Write(">");
                int respostaContinuar = Convert.ToInt32(Console.ReadLine());

                if (respostaContinuar == 1)
                {
                    Console.WriteLine("");

                    foreach (Mamiferos i in cadastroMamiferos)//percorre a lista
                        Console.WriteLine(i.Nome + " Foi cadastrado com sucesso no sistema. ");

                    Console.WriteLine("");
                }

                else{
                    foreach (Mamiferos i in cadastroMamiferos)//percorre a lista
                        Console.WriteLine(i.Nome + " Foi cadastrado com sucesso no sistema. ");

                    Console.WriteLine("");

                    cadastro = false;
                }
                //____________________________________________________________________________________________//
            }//Mamiferos

            else if (resposta1 == 4)//Peixes
            {

                //escrever os parametros do objeto
                Console.WriteLine("Nome:");
                Console.Write("> ");
                string nome = Console.ReadLine();

                Console.WriteLine("Idade");
                Console.Write("> ");
                int idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Genero:");
                Console.Write("> ");
                string genero = Console.ReadLine();

                Console.WriteLine("Habitat:");
                Console.Write("> ");
                string habitat = Console.ReadLine();

                Console.WriteLine("Espécie");
                Console.Write("> ");
                string especie = Console.ReadLine();

                Console.WriteLine("Local de origem");
                Console.Write("> ");
                string local = Console.ReadLine();

                Console.WriteLine("Alimento Principal");
                Console.Write("> ");
                string alimento = Console.ReadLine();

                Console.WriteLine("Tipo de Agua");
                Console.Write("> ");
                string tipoAgua = Console.ReadLine();

                cadastroPeixes.Add(new Peixes(nome, idade, genero, habitat, especie, local, alimento, tipoAgua));


                                                 //bloco que quebra o ciclo while\\
                //____________________________________________________________________________________________//
                Console.WriteLine("");
                Console.WriteLine("**********************************");
                Console.WriteLine("deseja cadastrar outro Animal? 1/0");
                Console.WriteLine("**********************************");
                Console.WriteLine("");
                Console.Write(">");
                int respostaContinuar = Convert.ToInt32(Console.ReadLine());

                if (respostaContinuar == 1)
                {
                    Console.WriteLine("");

                    foreach (Peixes i in cadastroPeixes)//percorre a lista
                        Console.WriteLine(i.Nome + " Foi cadastrado com sucesso no sistema. ");

                    Console.WriteLine("");
                }

                else{
                    foreach (Peixes i in cadastroPeixes)//percorre a lista
                        Console.WriteLine(i.Nome + " Foi cadastrado com sucesso no sistema. ");

                    Console.WriteLine("");

                    cadastro = false;
                }
                //____________________________________________________________________________________________//

            }//Peixes

            else if (resposta1 == 5)//Répteis
            {
                //escrever os parametros do objeto
                Console.WriteLine("Nome:");
                Console.Write("> ");
                string nome = Console.ReadLine();

                Console.WriteLine("Idade");
                Console.Write("> ");
                int idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Genero:");
                Console.Write("> ");
                string genero = Console.ReadLine();

                Console.WriteLine("Habitat:");
                Console.Write("> ");
                string habitat = Console.ReadLine();

                Console.WriteLine("Espécie");
                Console.Write("> ");
                string especie = Console.ReadLine();

                Console.WriteLine("Local de origem");
                Console.Write("> ");
                string local = Console.ReadLine();

                Console.WriteLine("Alimento Principal");
                Console.Write("> ");
                string alimento = Console.ReadLine();

                Console.WriteLine("Tipo de Escama");
                Console.Write("> ");
                string tipoEscama = Console.ReadLine();



                cadastroRepteis.Add(new Repteis(nome, idade, genero, habitat, especie, local, alimento, tipoEscama));

                                             //bloco que quebra o ciclo while\\
                //____________________________________________________________________________________________//
                Console.WriteLine("");
                Console.WriteLine("**********************************");
                Console.WriteLine("deseja cadastrar outro Animal? 1/0");
                Console.WriteLine("**********************************");
                Console.WriteLine("");
                Console.Write(">");
                int respostaContinuar = Convert.ToInt32(Console.ReadLine());

                if (respostaContinuar == 1)
                {
                    Console.WriteLine("");

                    foreach (Repteis i in cadastroRepteis)
                        Console.WriteLine(i.Nome + " Foi cadastrado com sucesso no sistema. ");

                    Console.WriteLine("");
                }

                else
                {
                    foreach (Repteis i in cadastroRepteis)
                        Console.WriteLine(i.Nome + " Foi cadastrado com sucesso no sistema. ");

                    Console.WriteLine("");

                    cadastro = false;
                }


                //____________________________________________________________________________________________//


            }//Répteis
        }

    }

    static void consultaCadastro()
    {
        Console.WriteLine("" +
            "");
        if (cadastroAnfibios.Count>0){
            Console.WriteLine("_______________________");
            Console.WriteLine("Você tem um total de " + cadastroAnfibios.Count + " Anfibios cadastrados");

            foreach (Anfibios m in cadastroAnfibios)
            {
                Console.WriteLine(m.Nome + ", " + m.Familia + ", BLOCO:" + m.Localidade);
            }
            Console.WriteLine("_______________________");
            Console.WriteLine("");
        }

        if (cadastroAves.Count>0){
            Console.WriteLine("_______________________");
            Console.WriteLine("Você tem um total de " + cadastroAves.Count + " Aves cadastradas");

            foreach (Aves m in cadastroAves)
            {
                Console.WriteLine(m.Nome + ", " + m.Familia + ", BLOCO:" + m.Localidade);
            }
            Console.WriteLine("_______________________");
            Console.WriteLine("");
        }

        if (cadastroMamiferos.Count>0)
        {
            Console.WriteLine("_______________________");
            Console.WriteLine("Você tem um total de " + cadastroMamiferos.Count + " Mamiferos cadastrados");

            foreach (Mamiferos m in cadastroMamiferos)
            {
                Console.WriteLine(m.Nome + ", " + m.Familia + ", BLOCO:" + m.Localidade);
            }
            Console.WriteLine("_______________________");
            Console.WriteLine("");
        }

        if (cadastroRepteis.Count>0)
        {
            Console.WriteLine("_______________________");
            Console.WriteLine("Você tem um total de " + cadastroRepteis.Count + " Répteis cadastrados");

            foreach (Repteis m in cadastroRepteis)
            {
                Console.WriteLine(m.Nome + ", " + m.Familia + ", BLOCO:" + m.Localidade);
            }
            Console.WriteLine("_______________________");
            Console.WriteLine("");
        }

        if (cadastroPeixes.Count>0)
        {
            Console.WriteLine("_______________________");
            Console.WriteLine("Você tem um total de " + cadastroMamiferos.Count + " Peixes cadastrados");

            foreach (Peixes m in cadastroPeixes)
            {
                Console.WriteLine(m.Nome + ", " + m.Familia + ", BLOCO:" + m.Localidade);
            }
            Console.WriteLine("_______________________");
            Console.WriteLine("");
        }
        Console.WriteLine(""+
            "");

    }

}
