using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI14TVIN
{
    class ControlExercicios
    {
        //Ligar as duas classes
        ModelExercicios model;
        private int opcao;
        public double bas;
        public double altura;

        public ControlExercicios()
        {
            model = new ModelExercicios();//Chamando o construtor da classe Model Exercícios 
        }//fim do construtor

        public int ConsultarOpcao
        {
            get
            {
                return opcao;
            }
            set
            {
                this.opcao = value;
            }
        }

        public void Menu()
        {
            Console.WriteLine("---- Menu ----" +
                             "\n1.Exercíco 01" +
                             "\n1.Exercíco 02" +
                             "\n1.Exercíco 03");
            Console.WriteLine("Eacolha uma das opçóes acima: ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do meun

        public void Executar()
        {

        }
    }











    case 1: 
        Console.writeLine(ModelExercicios.Exercicio01());
        break;
    case 2:
        Console.writeLIne("informe um número"); 
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("O antecessor de " + num + é: " + model.exercicio02(num));
        break;
    case 3:
        Console.WriteLine(informe a base: ");
        double 
        //fim do switch
        //fim do executar 
