namespace Aula15.Assistir
{

    public class Gafanhoto : Pessoa
    {
        private string login;
        private int totAssistido;

        public Gafanhoto(string name, int age, string sex, string login) : base(name, age, sex)
        {
            this.login = login;
            this.totAssistido = 0;
        }
        public string getLogin()
        {
            return this.login;
        }
        public int getTotAssistido()
        {
            return this.totAssistido;
        }
        public void setLogin(string l)
        {
            this.login = l;
        }
        public void setTotAssistido(int t)
        {
            this.totAssistido = t;
        }

        public override String ToString()
        {
            return "Gafanhoto: " + this.getName() + "  " + this.getLogin() + "  " + this.getTotAssistido() + "  " + this.getSex() + "  " + this.getAge();
        }
    }
}