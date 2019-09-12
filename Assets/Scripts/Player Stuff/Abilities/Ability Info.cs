using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AbilityInfo
{
    #region Editor variables 
    [SerializeField]
    [Tooltip("how power the ability has")]
    private int m_Power;
    public int Power
    {
        get
        {
            return m_Power;
        }
    }

    [SerializeField]
    [Tooltip("how far you can shoot the abiliy")]
    private float m_Range;
    public float Range
    {
        get
        {
            return m_Range;
        }
    }
    #endregion

}
