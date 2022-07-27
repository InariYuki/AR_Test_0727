using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

namespace KitsuneYuki{
    public class CardManager : MonoBehaviour
    {
        //卡片控制器
        [SerializeField] DefaultObserverEventHandler card_observer;
        [SerializeField] Animator card_object_animator;
        [SerializeField] Button attack_button;
        [SerializeField] VirtualButtonBehaviour virtual_jump_button;
        AudioSource BGM;
        private void Awake() {
            card_observer.OnTargetFound.AddListener(CardFound);
            card_observer.OnTargetLost.AddListener(CardLost);
            attack_button.onClick.AddListener(Attack);
            virtual_jump_button.RegisterOnButtonPressed(Jump);
            BGM = GameObject.Find("BGM").GetComponent<AudioSource>();
        }
        //找到卡片的行為
        void CardFound(){
            card_object_animator.SetTrigger("TriggerWin");
            BGM.Play();
        }
        //卡片不見的行為
        void CardLost(){
            print("Card lost !");
            BGM.Stop();
        }
        void Attack(){
            print("attack !");
        }
        void Jump(VirtualButtonBehaviour do_something){
            print("Jump !");
        }
    }
}
