int heroHealth = 10;
int monsterHealth = 10;
int heroAtack = 0;
int monsterAtack = 0;

Random damageHero = new Random();
Random damageMonster = new Random();

do
{
    heroAtack = damageHero.Next(1, 6);
    monsterHealth = monsterHealth - heroAtack;
    Console.WriteLine($"Monster was damaged and lost {heroAtack} and now has {monsterHealth} health.");
    if(monsterHealth > 0)
    {
        monsterAtack = damageMonster.Next(1, 6);
        heroHealth = heroHealth - monsterAtack;
        Console.WriteLine($"Hero was damaged and lost {monsterAtack} and now has {heroHealth} health.");

        if(heroHealth <= 0)
        {
            Console.WriteLine("Monster win");
            break;
        }

    }
    else
    {
        Console.WriteLine("Hero win");
        break;
    }
   
    
   
}while(heroHealth > 0 || monsterHealth > 0);
