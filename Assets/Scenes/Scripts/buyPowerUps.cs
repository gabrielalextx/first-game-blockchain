using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEngine;

#if UNITY_WEBGL
public class buyPowerUps : MonoBehaviour
{
    private int tokenQuantity;
    private string tokenConvert;
    
    public int lifeValue = 10;
    public int tkQtd = 100;
    
    public GameObject player;

    //public TextMeshProUGUI tokenScreen;
    
    async void Start()
    {
        string chain = "binance";
        string network = "testnet";
        string contract = "0x33816b4CD0E2d8A33D6281b297F839a66ad7a986";
        string account = PlayerPrefs.GetString("Account");
        
        BigInteger balanceOf = await ERC20.BalanceOf(chain, network, contract, account);
        print(balanceOf);
        tokenConvert = balanceOf.ToString();
        ConvertStringToInt();
        //tokenScreen.text = balanceOf.ToString();
    }

    public void OnBuyPowerUps()
    {
        if (tkQtd > 0 && player != null)
        {
            tkQtd -= lifeValue;
            player.GetComponent<Character>().life++;
            
        }
    }

    private void ConvertStringToInt()
    {
        tokenConvert = tokenConvert.Remove(3);
        
        bool isParsable = Int32.TryParse(tokenConvert, out tokenQuantity);
        if (isParsable)
        {
            tokenQuantity = Convert.ToInt32(tokenConvert);
        }
        
    }

    private void Update()
    {
        player = GameObject.FindWithTag("Player");
    }
    
    
}
#endif