using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KitsuneYuki{
    public class CardManager : MonoBehaviour
    {
        //卡片控制器
        [SerializeField] DefaultObserverEventHandler card_observer;
        private void Awake() {
            card_observer.OnTargetFound.AddListener(CardFound);
            card_observer.OnTargetLost.AddListener(CardLost);
        }
        //找到卡片的行為
        void CardFound(){
            print("Card found !");
        }
        //卡片不見的行為
        void CardLost(){
            print("Card lost !");
        }
    }
}
