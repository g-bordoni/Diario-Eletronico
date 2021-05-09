namespace Diario_Eletronico.Estruturas

{    public class Aluno{
        //Atributos:
        private string _nome;
        private float[] _notas =  new float[0];
        private string[] _presenca =  new string[0];

        // Construtor:
        public Aluno(string nome){
            this._nome = nome.ToUpper();
        }
        // Metodos GET:
        public string getNome(){
            return this._nome;
        }
        public float[] getNotas(){
            return this._notas;
        }
        public string[] getPresenca(){
            return this._presenca;
        }
        // Metodos SET:
        public void setNome(string novoNome){
            this._nome = novoNome;
        }
        public void setNotas(float[] novaNotas){
            this._notas = novaNotas;
        }
        public void setPresenca(string[] novaPresenca){
            this._presenca = novaPresenca;
        }
        //Metodos INSERT:
        public void insertNovaAvalicao(float nova_nota){
            float[] novasNotas = new float[this._notas.Length + 1];

            for(int i=0; i<this._notas.Length; i++)
                novasNotas[i] = this._notas[i];
            novasNotas[this._notas.Length] = nova_nota;

            this._notas = novasNotas;
        }
        public void insertNovaAula(string presenca){
            if((presenca.ToUpper()=="P") || (presenca.ToUpper()=="A")){
                string[] novaPresenca = new string[this._presenca.Length + 1];

                for(int i=0; i<this._presenca.Length; i++)
                    novaPresenca[i] = this._presenca[i];
                novaPresenca[this._presenca.Length] = presenca;

                this._presenca = novaPresenca;

            }else{
                System.Console.WriteLine("\nA presença do aluno deve ser dada por:");
                System.Console.WriteLine("\t(P)resente");
                System.Console.WriteLine("\t(A)usente\n");
            }
        }
        //Metodos OUTPUT
        public float assiduidade(){
            if(this._presenca.Length == 0){
                return 0;
            }else{
                int presente = 0;
                foreach(string dia in this._presenca){
                    if(dia == "P")
                        presente++;
                }
                return 100 * ((float)presente/(float)this._presenca.Length);
            }
        }
        public void print(){
            System.Console.Write(this._nome);
            System.Console.Write($"\t\t\t{assiduidade():0}%\t");
            foreach(float nota in this._notas)
                System.Console.Write($"\t{nota:0.00}");
            System.Console.WriteLine();
        }

}
}