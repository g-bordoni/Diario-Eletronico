namespace Diario_Eletronico.Estruturas{

//----------------------------------------------------------------
    public class Node{
        //Atributos
        private Aluno _aluno = null;
        private Node _ptrDir = null;
        private Node _ptrEsq = null;

        //Metodos SET
        public void setAluno( Aluno alunoNovo){
            this._aluno = alunoNovo;
        }
        public void setPtrDir(Node alunoNovo){
            this._ptrDir = alunoNovo;
        }
        public void setPtrEsq(Node alunoNovo){
            this._ptrEsq = alunoNovo;
        }
        //Metodos GET
        public Aluno getAluno(){
            return this._aluno;
        }
        public Node getPtrDir(){
            return this._ptrDir;
        }
        public Node getPtrEsq(){
            return this._ptrEsq;
        } 
    }

//----------------------------------------------------------------
    public class Diario{
        //Atributos
        private Node raiz = null;
        private string professor;
        private string turma;

        //Construtor
        public Diario(string professor, string turma){
            this.professor = professor.ToUpper();
            this.turma = turma;
        }
        //Demais Metodos
        public void insertNode(Aluno alunoNovo, Node endereco_caminho = null){
            if (this.raiz == null){
                Node novoNode = new Node();
                novoNode.setAluno(alunoNovo);
                this.raiz = novoNode;
            } else {
                endereco_caminho=(endereco_caminho==null)? this.raiz : endereco_caminho; 
                int sort = string.Compare(alunoNovo.getNome(),endereco_caminho.getAluno().getNome());
                
                if(sort == -1){
                    if(endereco_caminho.getPtrEsq() == null){
                        Node novoNode = new Node();
                        novoNode.setAluno(alunoNovo);
                        endereco_caminho.setPtrEsq(novoNode);
                    }else{
                        insertNode(alunoNovo, endereco_caminho.getPtrEsq());
                    }
                } else if(sort == 1){
                    if(endereco_caminho.getPtrDir() == null){
                        Node novoNode = new Node();
                        novoNode.setAluno(alunoNovo);
                        endereco_caminho.setPtrDir(novoNode);
                    }else{
                        insertNode(alunoNovo, endereco_caminho.getPtrDir());
                    }
                } else{
                    System.Console.WriteLine("Esse aluno já está cadastrado.");
                }
            }
        }

        public void print(Node endereco_caminho = null){
            if (this.raiz == null){
                System.Console.WriteLine("O diário está vazio.");
            }else{
                if (endereco_caminho==null){
                    System.Console.WriteLine("------------------------------------------------");
                    System.Console.WriteLine("DIÁRIO DE CLASSE");
                    System.Console.Write($"PROF.: {this.professor}\t\tTURMA: {this.turma}\n");
                    System.Console.WriteLine("------------------------------------------------\n");
                    System.Console.Write("ALUNO:\t\t\tASSIDUIDADE:\tNOTAS:\n");
                    

                    endereco_caminho = this.raiz;}
                 
                if(endereco_caminho.getPtrEsq() != null)
                    print(endereco_caminho.getPtrEsq());

                endereco_caminho.getAluno().print();

                if(endereco_caminho.getPtrDir() != null)
                    print(endereco_caminho.getPtrDir());   
            }

        }
    }
}