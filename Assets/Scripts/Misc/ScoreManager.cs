using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("HUD script")]
    private HUDController m_HUD;
    #endregion

    public static ScoreManager singleton;

    #region Private variebles
    private int m_CurScore;
    #endregion

    #region Initilization 
    private void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
        } else if (singleton != this)
        {
            Destroy(gameObject);
        }
        m_CurScore = 0;
    }
    #endregion

    #region Score Methods
    public void IncreaseScore(int amount)
    {
        m_CurScore += amount;
        UpdateScoreUI(m_CurScore);
    }


    public void UpdateHighScore()
    {
        if (!PlayerPrefs.HasKey("HS"))
        {
            PlayerPrefs.SetInt("HS", m_CurScore);
            return;
        }

        int hs = PlayerPrefs.GetInt("HS");
        if (hs < m_CurScore)
        {
            PlayerPrefs.SetInt("HS", m_CurScore);
        }
    }

    public void UpdateScoreUI(int amount)
    {
        m_HUD.UpdateScore(amount);
    }
    #endregion

    #region Desctruction
    private void OnDisable()
    {
        UpdateHighScore();
    }
    #endregion
}
