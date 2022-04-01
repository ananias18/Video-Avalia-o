namespace Aula15.Assistir
{
    
    public abstract class Pessoa
    {
        protected string name;
        protected int age;
        protected string sex;
        protected float experience;

        public Pessoa(string name, int age, string sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
            this.experience = 0;
        }

        public string getName()
        {
            return this.name;
        }
        public int getAge()
        {
            return this.age;
        }
        public string getSex()
        {
            return this.sex;
        }
        public float getExperience()
        {
            return this.experience;
        }
        public void setName(string n)
        {
            this.name = n;
        }
        public void setAge(int ag)
        {
            this.age = ag;
        }
        public void setSex(string s)
        {
            this.sex = s;
        }
        public void setExperience(float e)
        {
            this.experience = e;
        }
    }
}