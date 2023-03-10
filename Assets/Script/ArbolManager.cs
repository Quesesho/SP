using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArbolManager : MonoBehaviour
{
    public static ArbolManager instantiate;

    public int      healtHojas = 100,
                    healtTallo = 100,
                    healtCorazon = 100,
                    healtRaiz1 = 100,
                    healtRaiz2 = 100;
    private void Awake()
    {
        instantiate = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DamageUpdate();
    }
    public void SetDamage(string name)
    {
        if (name.Equals("Tronco"))
        {
            healtTallo--;
        }
        if (name.Equals("Hojas"))
        {
            healtHojas--;
        }
        if (name.Equals("Corazon"))
        {
            healtCorazon--;
        }
        if (name.Equals("Raiz1"))
        {
            healtRaiz1--;
        }
        if (name.Equals("Raiz2"))
        {
            healtRaiz2--;
        }
    }
    public void Curando()
    {
        if (healtTallo < 100)
            healtTallo++;
        if (healtHojas < 100)
            healtHojas++;
        if (healtCorazon < 100)
            healtCorazon++;
        if (healtRaiz1 < 100)
            healtRaiz1++;
        if (healtRaiz2 < 100)
            healtRaiz2++;
    }
    private void DamageUpdate()
    {
        if (healtTallo <= 0)
        {
            healtTallo = 0;
            transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
        }
        else
        {
            transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
        }
        if (healtHojas <= 0)
        {
            healtHojas = 0;
            transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
        }
        else
        {
            transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
        }
        if (healtCorazon <= 0)
        {
            transform.GetChild(1).GetChild(0).gameObject.SetActive(false);
            PlayerManager.instantiate.isDead = true;
        }
        if (healtRaiz1 <= 0)
        {
            healtRaiz1 = 0;
            transform.GetChild(1).GetChild(1).gameObject.SetActive(false);
        }
        else
        {
            transform.GetChild(1).GetChild(1).gameObject.SetActive(true);
        }
        if (healtRaiz2 <= 0)
        {
            healtRaiz2 = 0;
            transform.GetChild(1).GetChild(2).gameObject.SetActive(false);
        }
        else
        {
            transform.GetChild(1).GetChild(2).gameObject.SetActive(true);
        }
    }
}
