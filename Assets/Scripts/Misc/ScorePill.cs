using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePill : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("health the pill restores")]
    private int m_ScoreGain;
    public int ScoreGain
    {
        get
        {
            return m_ScoreGain;
        }
    }
    #endregion
}
