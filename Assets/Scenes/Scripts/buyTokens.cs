using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_WEBGL
public class buyTokens : MonoBehaviour
{
    async public void OnSendContract()
    {
        // smart contract method to call
        string method = "buyTokens";
        // abi in json format
        string abi = "[ 	{ 		\"inputs\": [], 		\"name\": \"buyTokens\", 		\"outputs\": [ 			{ 				\"internalType\": \"uint256\", 				\"name\": \"tokenAmount\", 				\"type\": \"uint256\" 			} 		], 		\"stateMutability\": \"payable\", 		\"type\": \"function\" 	}, 	{ 		\"inputs\": [ 			{ 				\"internalType\": \"address\", 				\"name\": \"tokenAddress\", 				\"type\": \"address\" 			} 		], 		\"stateMutability\": \"nonpayable\", 		\"type\": \"constructor\" 	}, 	{ 		\"anonymous\": false, 		\"inputs\": [ 			{ 				\"indexed\": false, 				\"internalType\": \"address\", 				\"name\": \"buyer\", 				\"type\": \"address\" 			}, 			{ 				\"indexed\": false, 				\"internalType\": \"uint256\", 				\"name\": \"amountOfBNB\", 				\"type\": \"uint256\" 			}, 			{ 				\"indexed\": false, 				\"internalType\": \"uint256\", 				\"name\": \"amountOfTokens\", 				\"type\": \"uint256\" 			} 		], 		\"name\": \"BuyTokens\", 		\"type\": \"event\" 	}, 	{ 		\"anonymous\": false, 		\"inputs\": [ 			{ 				\"indexed\": true, 				\"internalType\": \"address\", 				\"name\": \"previousOwner\", 				\"type\": \"address\" 			}, 			{ 				\"indexed\": true, 				\"internalType\": \"address\", 				\"name\": \"newOwner\", 				\"type\": \"address\" 			} 		], 		\"name\": \"OwnershipTransferred\", 		\"type\": \"event\" 	}, 	{ 		\"inputs\": [], 		\"name\": \"renounceOwnership\", 		\"outputs\": [], 		\"stateMutability\": \"nonpayable\", 		\"type\": \"function\" 	}, 	{ 		\"inputs\": [ 			{ 				\"internalType\": \"address\", 				\"name\": \"newOwner\", 				\"type\": \"address\" 			} 		], 		\"name\": \"transferOwnership\", 		\"outputs\": [], 		\"stateMutability\": \"nonpayable\", 		\"type\": \"function\" 	}, 	{ 		\"inputs\": [], 		\"name\": \"withdraw\", 		\"outputs\": [], 		\"stateMutability\": \"nonpayable\", 		\"type\": \"function\" 	}, 	{ 		\"inputs\": [], 		\"name\": \"owner\", 		\"outputs\": [ 			{ 				\"internalType\": \"address\", 				\"name\": \"\", 				\"type\": \"address\" 			} 		], 		\"stateMutability\": \"view\", 		\"type\": \"function\" 	}, 	{ 		\"inputs\": [], 		\"name\": \"tokensPerBnb\", 		\"outputs\": [ 			{ 				\"internalType\": \"uint256\", 				\"name\": \"\", 				\"type\": \"uint256\" 			} 		], 		\"stateMutability\": \"view\", 		\"type\": \"function\" 	} ]";
        // address of contract
        string contract = "0xA1977Cb63dDd67A361F647b644b80CdC7Fce110D";
        // array of arguments for contract 
        string args = "[]";
        // value in wei
        string value = "1000000000000000000";
        // gas limit OPTIONAL
        string gasLimit = "";
        // gas price OPTIONAL
        string gasPrice = "";
        // connects to user's browser wallet (metamask) to update contract state
        try
        {
            string response = await Web3GL.SendContract(method, abi, contract, args, value, gasLimit, gasPrice);
            Debug.Log(response);
        }
        catch (Exception e)
        {
            Debug.LogException(e, this);
        }
    }
}
#endif
