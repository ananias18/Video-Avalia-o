namespace Aula15.Assistir
{

    public class Video : AcoesVideo
    {
        private string titulo;
        private int avaliacao;
        private int views;
        private int curtidas;
        private bool reproduzindo;

        public Video(string titulo)
        {
            this.titulo = titulo;
            this.avaliacao = 1;
            this.views = 0;
            this.curtidas = 0;
            this.reproduzindo = false;
        }

        public string getTitulo()
        {
            return this.titulo;
        }
        public int getAvaliacao()
        {
            return this.avaliacao;
        }
        public int getViews()
        {
            return this.views;
        }
        public int getCurtidas()
        {
            return this.curtidas;
        }
        public bool getReproduzindo()
        {
            return this.reproduzindo;
        }
        public void setTitulo(string t)
        {
            this.titulo = t;
        }
        public void setAvaliacao(int a)
        {
            float nova;
            nova = (float)((this.avaliacao + avaliacao) / this.views);
            this.avaliacao = a;
        }
        public void setViews(int v)
        {
            this.views = v;
        }
        public void setCurtidas(int c)
        {
            this.curtidas = c;
        }
        public void setReproduzindo(bool r)
        {
            this.reproduzindo = r;
        }
        public void play()
        {
            this.reproduzindo = true;
        }
        public void pause()
        {
            this.reproduzindo = false;
        }
        public void like()
        {
            this.curtidas++;
        }
        public void dislike()
        {
            this.curtidas--;
        }
        

    }
}