using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpPill : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("how much more damage")]
    private float m_DamageMultiplier;
    public float DamageMultiplier
    {
        get
        {
            return m_DamageMultiplier;
        }
    }
    #endregion
}
