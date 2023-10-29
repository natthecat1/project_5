using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "money")]
public class MoneyPickUp : PowerupEffect
{
    public float amount;
    public override void Apply(GameObject Player)
    {
        Player.GetComponent<Coin>().GetCoin(amount);
    }
}
