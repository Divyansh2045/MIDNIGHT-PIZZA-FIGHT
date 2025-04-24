using Sytem;

class Player()
{
       //variables
    private int health = 100;
    private int maxHealth = 100;
   // private int attackDamage = 20;
   // private int healingCapacity = 15;

       public int Health
    {
        get
        {
            return health;
        }

        private set
        {
            if (value < 0)
            health = 0;
            else if (value > maxHealth) 
            health = maxHealth; 
            else
            health = value;
        }
    }

    //default contructor
    public Player()
    {
        spawnPlayer();
    }

    private void spawnPlayer()
    {
        Console.WriteLine("\n==================================================");
        Console.WriteLine(" 🍕 DOUGH MASTER: GUARDIAN OF THE GOLDEN CRUST 🍕 ");
        Console.WriteLine("==================================================\\n");
        Console.WriteLine("\nDough Master: That scoundrel won't escape with my creation!");

    }
}