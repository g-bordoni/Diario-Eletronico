using System;
using Diario_Eletronico.Estruturas;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Diario turmaA1 = new Diario("gabriel neves","A1");

            Aluno aluno1 = new Aluno("jose silva");
            Aluno aluno2 = new Aluno("ana cruz");
            Aluno aluno3 = new Aluno("joao pera");
            Aluno aluno4 = new Aluno("luciano bello");
            Aluno aluno5 = new Aluno("marco antonio");
            Aluno aluno6 = new Aluno("eduardo luz");

            float[] nota1 = {3.5F,6.9F,8.0F};
            aluno1.setNotas(nota1);
            float[] nota2 = {3.3F,6.4F,4.0F};
            aluno2.setNotas(nota2);
            float[] nota3 = {3.4F,6.9F,6.0F};
            aluno3.setNotas(nota3);
            float[] nota4 = {3.6F,6.1F,7.0F};
            aluno4.setNotas(nota4);
            float[] nota5 = {3.8F,6.4F,1.0F};
            aluno5.setNotas(nota5);
            float[] nota6 = {8.6F,4.5F};
            aluno6.setNotas(nota6);

            string[] presenca1 = {"P","A","A","A","P"};
            aluno1.setPresenca(presenca1);
            string[] presenca2 = {"P","A","P","A","P"};
            aluno2.setPresenca(presenca2);
            string[] presenca3 = {"P","A","A","A","P"};
            aluno3.setPresenca(presenca3);
            string[] presenca4 = {"P","P","P","P","P"};
            aluno4.setPresenca(presenca4);
            string[] presenca5 = {"P","P","A","A","P"};
            aluno5.setPresenca(presenca5);
            string[] presenca6 = {"P","P","P","A","P"};
            aluno6.setPresenca(presenca6);


            turmaA1.insertNode(aluno1);
            turmaA1.insertNode(aluno2);
            turmaA1.insertNode(aluno3);
            turmaA1.insertNode(aluno4);
            turmaA1.insertNode(aluno5);
            turmaA1.insertNode(aluno6);

            turmaA1.print();
            Console.WriteLine();

            aluno6.insertNovaAula("P");
            aluno4.insertNovaAula("P");
            aluno4.insertNovaAula("P");
            aluno5.insertNovaAula("A");

            aluno1.insertNovaAvalicao(8.8F);
            aluno2.insertNovaAvalicao(5.8F);

            turmaA1.print();
            Console.WriteLine();

            Aluno novato = new Aluno("daniel diniz");
            novato.setNotas(nota5);
            novato.setPresenca(presenca2);

            turmaA1.insertNode(novato);


            turmaA1.print();
            Console.WriteLine();


        }
    }
}
