class DamageComponent
{
    public float damage;

    public DamageComponent(float damageValue)
    {
        this.damage = damageValue;
    }

    public void Damage(HealthComponent target, float multiplier = 1.0f)
    {
        target.Damage(this.damage * multiplier);
    }
}