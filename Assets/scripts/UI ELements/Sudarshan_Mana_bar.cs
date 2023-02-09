using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Sudarshan_Mana_bar : MonoBehaviour
{
    // Start is called before the first frame update
    public Image barImage;
    private Mana mana;
    void Start()
    {
        barImage = GetComponent<Image>();
        barImage.fillAmount = 0.3f;
        mana = new Mana();
    }

    // Update is called once per frame
    void Update()
    {
        mana.Update();
        barImage.fillAmount = mana.GetManaNormalized();

        if(Input.GetKeyDown(KeyCode.K)){
            mana.TrySpendMana(100);
        }
    }


}

public class Mana {
    private float ManaAmount;
    private float ManaRegenAmount;
    public const int MANA_MAX = 100;
    public Mana(){
        ManaAmount = 0;
        ManaRegenAmount = 30f;
    }
    public void Update(){
        ManaAmount += ManaRegenAmount * Time.deltaTime;
        Mathf.Clamp(ManaAmount, 0f, 100f);
    }
    public void TrySpendMana(int amount){
        if(ManaAmount >= amount){
            ManaAmount -= amount;
        }
    }
    public float GetManaNormalized(){
        return ManaAmount/MANA_MAX;
    }
}