using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class accountAddress : MonoBehaviour
{
    public TextMeshProUGUI myAccount;

    private string account;
    
    // Start is called before the first frame update
    void Start()
    { 
        account = PlayerPrefs.GetString("Account");
        myAccount.text = account;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
