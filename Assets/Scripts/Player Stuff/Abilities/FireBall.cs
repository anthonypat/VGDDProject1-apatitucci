using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : Ability 
{
    public override void Use(Vector3 spawnPos, float multiplier)
    {
        Collider[] hits = Physics.OverlapSphere(spawnPos, m_Info.Range);
        foreach (Collider hit in hits)
        {
            if (hit.GetComponent<Collider>().CompareTag("Enemy"))
            {
                hit.GetComponent<Collider>().GetComponent<EnemyController>().DecreaseHealth(m_Info.Power * multiplier);
            }
        }
        var emitterShape = cc_Ps.shape;
        emitterShape.length = m_Info.Range;
        cc_Ps.Play();
    }
}
