using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float startingHealth;
    [SerializeField] private AudioSource Hitsound;
    [SerializeField] private AudioSource Deathsound;
    public float currentHealth { get; private set; }
    public Image HPbar;
    
    
    private void Awake()
    {
        currentHealth = startingHealth;
        rb = GetComponent<Rigidbody2D>();

    }
    
     
    
    
    public void PlayerDamage(float _damage)
    { 
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
        Debug.Log(currentHealth);

        float Fill = currentHealth/startingHealth;

        HPbar.fillAmount = Fill;

        
        if (currentHealth > 0)
        {
            Hitsound.Play();
           
        }
        else if (currentHealth <= 0)
        {
            rb.bodyType = RigidbodyType2D.Static;
            if (rb.bodyType == RigidbodyType2D.Static)
            {
            RestartLevel();
            Deathsound.Play();
            }
           
        }
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
