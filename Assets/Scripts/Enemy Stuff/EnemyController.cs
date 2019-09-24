using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    #region Editor Varibles
    [SerializeField]
    [Tooltip("how much health")]
    private int m_MaxHealth;

    [SerializeField]
    [Tooltip("how much health")]
    private  float m_Speed;

    [SerializeField]
    [Tooltip("amount of damage dealt")]
    private float m_Damage;

    [SerializeField]
    [Tooltip("explosion after enemy dies")]
    private ParticleSystem m_DeathExplosion;

    [SerializeField]
    [Tooltip("Prob of dropping a pill")]
    private float m_PillDropRate;

    [SerializeField]
    [Tooltip("the item the enemy drops")]
    private GameObject m_DropItem;

    [SerializeField]
    [Tooltip("ponits player gets")]
    private int m_Score;
    #endregion

    #region Private Variables
    private float p_currHealth;
    #endregion

    #region Cached Components
    private Rigidbody cc_Rb;
    #endregion

    #region Cached References
    private Transform cr_Player;
    #endregion

    #region Intitialization
    private void Awake()
    {
        p_currHealth = m_MaxHealth;

        cc_Rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        cr_Player = FindObjectOfType<PlayerController>().transform;
    }

    #endregion

    #region Main Updates
    private void FixedUpdate()
    {
        Vector3 dir = cr_Player.position - transform.position;
        dir.Normalize();
        cc_Rb.MovePosition(cc_Rb.position + dir * m_Speed * Time.fixedDeltaTime);
    }
    #endregion

    #region Collision Methods
    private void OnCollisionStay(Collision collision)
    {
        GameObject other = collision.collider.gameObject;
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerController>().DecreaseHealth(m_Damage);
        }
    }

    #endregion

    #region Health Methods
    public void DecreaseHealth(float amount)
    {
        p_currHealth -= amount;
        if (p_currHealth <= 0)
        {
            ScoreManager.singleton.IncreaseScore(m_Score);
            if (Random.value < m_PillDropRate)
            {
                Instantiate(m_DropItem, transform.position, Quaternion.identity);
            }
            Instantiate(m_DeathExplosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    #endregion
}
