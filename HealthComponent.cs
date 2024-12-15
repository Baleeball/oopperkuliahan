class HealthComponent
{
    public bool isDead = false;

    public float fullHealthPoint;
    public float healthPoint;

    public HealthComponent(float fullHealth)
    {
        this.fullHealthPoint = fullHealth;
        healthPoint = this.fullHealthPoint;
    }

    public void Damage(float damage)
    {
        if (isDead)
            return;

        healthPoint = healthPoint - damage < 0f ? 0f : healthPoint - damage;
    }

    public void Damage(DamageComponent damager)
    {
        Damage(damager.damage);
    }

    public void Heal(float healValue)
    {
        healthPoint = healthPoint + healValue > fullHealthPoint ? fullHealthPoint : healthPoint + healValue;
    }

    public void FullHeal()
    {
        this.healthPoint = this.fullHealthPoint;
    }
}