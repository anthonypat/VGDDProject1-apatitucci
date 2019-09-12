using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerAttackInfo
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("the name of an attack")]
    private string m_Name;
    public string AttackName
    {
        get
        {
            return m_Name;
        }
    }

    [SerializeField]
    [Tooltip("button to press to do this attack")]
    private string m_Button;
    public string Button
    {
        get
        {
            return m_Button;
        }
    }

    [SerializeField]
    [Tooltip("the trigger string to activate this in the animator")]
    private string m_TriggerName;
    public string TriggerName
    {
        get
        {
            return m_TriggerName;
        }
    }

    [SerializeField]
    [Tooltip("prefab of the GameObject representing this ability")]
    private GameObject m_AbilityGO;
    public GameObject AbilityGo
    {
        get
        {
            return m_AbilityGO;
        }
    }

    [SerializeField]
    [Tooltip("where to spawn ability w.r.t the player")]
    private Vector3 m_offset;
    public Vector3 Offset
    {
        get
        {
            return m_offset;
        }
    }

    [SerializeField]
    [Tooltip("how long to wait before this attack is activated after button press")]
    private float m_WindUpTime;
    public float WindUpTime
    {
        get
        {
            return m_WindUpTime;
        }
    }

    [SerializeField]
    [Tooltip("how long to wait before player can move again")]
    private float m_FrozenTime;
    public float FrozenTime
    {
        get
        {
            return m_FrozenTime;
        }
    }

    [SerializeField]
    [Tooltip("how long to wait before this ability can be used again")]
    private float m_Cooldown;

    [SerializeField]
    [Tooltip("amount of health the ability costs")]
    private int m_HealthCost;
    public int HealthCost
    {
        get
        {
            return m_HealthCost;
        }
    }

    [SerializeField]
    [Tooltip("color to change to when using this ability")]
    private Color m_Color;
    public Color AbilityColor
    {
        get
        {
            return m_Color;
        }
    }
    #endregion

    #region Public Variables
    public float Cooldown
    {
        get;
        set;
    }
    #endregion

    #region Cooldown Methods
    public void ResetCooldown()
    {
        Cooldown = m_Cooldown;
    }

    public bool IsReady()
    {
        return Cooldown <= 0;
    }
    #endregion

}
