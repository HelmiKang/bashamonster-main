namespace BashMonster;
public class Gubbe
{
    public float hp = 100;
    public float mass = 80;
    public string name;
    public float maxHp = 100;

    public Gubbe()
    {
        
    }
    public void Resethp()
    {
        hp = maxHp;
    }
}
