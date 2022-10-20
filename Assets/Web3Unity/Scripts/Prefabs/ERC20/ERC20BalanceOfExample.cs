using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ERC20BalanceOfExample : MonoBehaviour
{
    public TextMeshProUGUI tokenBalance;
    public BigInteger tokenQuantity;

    async void Start()
    {
        string chain = "binance";
        string network = "testnet";
        string contract = "0x33816b4CD0E2d8A33D6281b297F839a66ad7a986";
        string account = PlayerPrefs.GetString("Account");

        BigInteger balanceOf = await ERC20.BalanceOf(chain, network, contract, account);
        print(balanceOf);
        tokenBalance.text = balanceOf.ToString();
        tokenQuantity = balanceOf;
    }

    void SendToken()
    {
        
    }
}
