namespace RPGDio.src.Entities
{
    public class Wizard : Hero 
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;  
        }
     
        public override string Attack(){
            return this.Name + " Lançou mágia";
        }

        public string Attack(int Bonus){

            if(Bonus > 6){
                return this.Name + " Lançou mágia super efetiva com bônus de ataque de " + Bonus;
            }else{
                return this.Name + " Lançou mágia fraca com bônus de ataque de " + Bonus;
            }
            
        }
    }
}