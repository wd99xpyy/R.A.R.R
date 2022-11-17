using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//using UnityEngine.UI;

public class AnimalOnWorld : MonoBehaviour
{
    public Animal thisAnimal;
    public Specise animalInSpecise;
    public int animalHealth;
    public int animalMaxHealth = 100;
    public int animalHungry;
    public int animalMaxHungry = 100;

    public TextMeshProUGUI species;
    public TextMeshProUGUI sickness;

    public healthbar healthbar;
    public healthbar hungrybar;

    // Start is called before the first frame update
    void Start()
    {
        setAnimalInfo();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            takeDamage(5);
        }
    }

    public void refreshBar()
    {
        hungrybar.SetHealth(animalHungry);
        healthbar.SetHealth(animalHealth);
    }

    void takeDamage(int damage)
    {
        animalHealth -= damage;
        healthbar.SetHealth(animalHealth);
    }


    void setAnimalInfo()
    {
        healthbar.SetMaxHealth(animalMaxHealth);
        animalHealth = Random.Range(30, 70);
        healthbar.SetHealth(animalHealth);

        hungrybar.SetMaxHealth(animalMaxHungry);
        animalHungry = Random.Range(30, 70);
        hungrybar.SetHealth(animalHungry);

        species.text = "Specise: " + thisAnimal.anmalSpecise;
    }
}
