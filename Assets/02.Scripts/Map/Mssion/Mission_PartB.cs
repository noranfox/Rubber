using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Mission_PartB : MonoBehaviour
{
    
    public GameObject can;
    public GameObject gameCard;

    public TMP_Text loading;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // ���� - ���Ǳ�
        if(collision.gameObject.tag == "machine")
        {
            Destroy(collision.gameObject);
            can.SetActive(true);
            
            // can.GetComponent<Collider>().enabled = false; << ���� ������Ʈ ��ü�� ���°� �ƴ϶� �����ִ� �ٸ��� ���������� 
        }
        // ���� - ������
        else if(collision.gameObject.tag == "game")
        {
            Destroy(collision.gameObject);
            gameCard.SetActive(true);
        }
        // ����ī�� - ����������
        else if(collision.gameObject.tag == "water_management")
        {
            loading.gameObject.SetActive(true);
        }
    }

}