namespace MyGame
{
    public class Enemy
    {
        private static int powerUpCounter;
        
        // Instance Variables
        private string name;
        private float health;
        private float shield;
        
        // Constructor
        public Enemy(string _name)
        {
            this.name = _name;
            health = 100f;
            shield = 0f;
        }

        static Enemy()
        {
            powerUpCounter = 0;
        }
        
        // Get Enemy name with properties
        public string Name => name;
        public float Health => health;
        public float Shield => shield;

        public static int PowerUpCounter => powerUpCounter;

        public void TakeDamage(float _damage)
        {
            shield -= _damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0)
                    health = 0;
            }
        }

        public void PickUpPowerUp(PowerUp _powerUp, float _amount)
        {
            if (_amount <= 100)
            {
                switch (_powerUp)
                {
                    case PowerUp.Health:
                        health += _amount;
                        break;
                    case PowerUp.Shield:
                        shield += _amount;
                        break;
                
                }
            }
            
        }
    }
}