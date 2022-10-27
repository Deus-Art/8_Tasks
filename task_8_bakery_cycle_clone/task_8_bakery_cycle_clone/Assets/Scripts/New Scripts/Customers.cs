using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Customers : MonoBehaviour
{
    public static Customers instance;
    [SerializeField] private List<GameObject> Musteriler = new List<GameObject>();
    [SerializeField] private GameObject musteriPrefab;
    [SerializeField] private Transform musteriPoint;
    public float timez = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void EkmekAl()
    {
        //Musteriler[0].SetActive(false);
        MusteriOlustur();
        //Destroy(Musteriler[Musteriler.Count - 1]);
        //Musteriler.RemoveAt(Musteriler.Count -1);
        //Musteriler.RemoveAt(0);
        //MusteriOlustur();
        //SiraIlerle();
    }

    public void DestroyHuman()
    {       
            if(Musteriler.Count -1 == 0)
            {
                Destroy(Musteriler[Musteriler.Count -1]);
                Musteriler.RemoveAt(Musteriler.Count -1);
            }

            if(Musteriler.Count -1 == 1)
            {
                Destroy(Musteriler[Musteriler.Count - 2]);
                Musteriler.RemoveAt(0);
            }
            
        
    }
    public void SiraIlerle()
    {
        for(int i = 0; i < Musteriler.Count ; i++)
        {
            //Walk animasyon true
            Animator anim = Musteriler[i].GetComponent<Animator>();
            anim.SetBool("Walking", true);
            Musteriler[i].transform.DOLocalMove(Musteriler[i].transform.localPosition + new Vector3(0, 0, 0.5f), 0.5f).OnComplete(()=>anim.SetBool("Walking",false));
        }
    }

    public void MusteriOlustur()
    {
        // GameObject Musteri = Instantiate(musteriPrefab, musteriPoint);
        // Musteriler.Add(Musteri);
        // Musteri.transform.parent = transform;
        // Vector3 newPos = new Vector3(2f, 0, 0);
        // Musteri.transform.localPosition = newPos;

        GameObject tempo = Instantiate(musteriPrefab, musteriPoint);
        Musteriler.Add(tempo);
        tempo.transform.localPosition = new Vector3(Musteriler.Count * 0.2f, 0f, 0f);
        tempo.transform.localScale = new Vector3(2f, 2f, 2f);
        
    }

    
}
