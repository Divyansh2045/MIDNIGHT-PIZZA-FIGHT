class Enemy
{
    //variables
    private int health = 150;
    //private int attackDamage = 10;
    //private int healingCapacity = 10;
    private int maxHealth = 150;

    public int Health
    {
        get 
        {
            return health;
        }
        private set
        {
            if(value < 0)
            health = 0;
            else if (value > maxHealth)
            health = maxHealth;
            else
            value = health;
        }
    }
        public Enemy()
        {
            SpawnEnemy();

        }
    

        private void SpawnEnemy()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("🦹 CRUST BANDIT: NEMESIS OF ITALIAN CUISINE 🦹");
            Console.WriteLine("==================================================\n");
            Console.WriteLine("Crush Bandit : You'll never catch me, flour face!\n");
        }