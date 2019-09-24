using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("part of the health that descreases")]
    private RectTransform m_HealthBar;

    [SerializeField]
    [Tooltip("UI that displays the score")]
    private Text m_Score;

    [SerializeField]
    [Tooltip("UI that displays the damage multiplier")]
    private Text m_Multiplier;
    #endregion

    #region Private Variables
    private float p_HealthBarOrigWidth;
    #endregion

    #region Initialization
    private void Awake()
    {
        p_HealthBarOrigWidth = m_HealthBar.sizeDelta.x;
        m_Multiplier.text = "Damage Multiplier : 1.0x";
        m_Score.text = "Score : 0";
    }
    #endregion

    #region Update Health Bar
    public void UpdateHealth(float percent)
    {
        m_HealthBar.sizeDelta = new Vector2(p_HealthBarOrigWidth * percent, m_HealthBar.sizeDelta.y);
    }
    #endregion

    #region Update Score Text 
    public void UpdateScore(int score)
    {
        m_Score.text = "Score : " + score.ToString();
    }
    #endregion

    #region Update Multiplier Text
    public void UpdateMultiplier(float multiplier)
    {
        m_Multiplier.text = "Damage Multiplier :" + multiplier.ToString() + "x";
    }
    #endregion

}
