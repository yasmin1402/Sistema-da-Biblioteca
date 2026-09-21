namespace LêAí.Data
{
    public class LivroRepository
    {
        privade static List<Livro> _tabelaLivros = new list<Livros>();
        privade static int proximoID = 1; //Variável auxiliar

        public void Adicionar(Livro livro) //método adiciona
        {
            livro.Id = proximoid++;
            _tabelaLivros.Add(livro);
        }
        public list<Livros> ObterTodos()
        {
            return _tabelaLivros;
        }
    }
}