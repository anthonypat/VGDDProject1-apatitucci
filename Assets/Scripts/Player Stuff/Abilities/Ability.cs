using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : MonoBehaviour
{
    #region Editor variables 
    [SerializeField]
    [Tooltip("All of the main information abuot this particular ability")]
    protected AbilityInfo m_Info;
    #endregion

    #region Cache Components
    protected ParticleSystem cc_Ps;
    #endregion

    #region Intialization 
    private void Awake()
    {
        cc_Ps = GetComponent<ParticleSystem>();
    }
    #endregion

    #region Use Methods
    public abstract void Use(Vector3 spawnPos);
    #endregion 
}
