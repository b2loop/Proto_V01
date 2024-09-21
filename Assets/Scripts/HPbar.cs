using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{
    [SerializeField] Image redbar;
    [SerializeField] Image greybar;
    [SerializeField] Health health;

    float MaxHP;

    private void Start()
    {
        MaxHP = health.HP;
    }

    // Update is called once per frame
    void Update()
    {
        redbar.fillAmount = health.HP / MaxHP;
    }
}
