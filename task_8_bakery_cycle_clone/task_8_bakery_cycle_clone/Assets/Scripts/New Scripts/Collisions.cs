using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Collisions : MonoBehaviour
{
    public static Collisions instance;
    [SerializeField] private Image HamurYesilResim,FirinYesilResim,TezgahYesilResim;
    public float zaman;
    private bool inHamurArea,inHamurBirakma,inEkmekAlma,inEkmekBirakma;
    public bool hamurStackFull;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("HamurAlani"))
    //    {
    //        inHamurArea = true;
    //    }
    //    if (other.CompareTag("HamurBirakma"))
    //    {
    //        inHamurBirakma = true;
    //    }
    //    if (other.CompareTag("EkmekAlma"))
    //    {
    //        inEkmekAlma = true;
    //    }
    //    if (other.CompareTag("EkmekBirakma"))
    //    {
    //        inEkmekBirakma = true;
    //    }
    //}
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("HamurAlani"))
        {
            if (!hamurStackFull)
            {
                zaman += Time.deltaTime;
                HamurYesilResim.fillAmount = zaman;
                if (zaman > 1)
                {
                    Stacking.instance.StackHamurObjects();
                    zaman = 0;
                    HamurYesilResim.fillAmount = zaman;
                }
            }
        }
        if (other.CompareTag("HamurBirakma"))
        {
            if (Stacking.instance.ListHamurObjects.Count > 0)
            {
                zaman += Time.deltaTime;
                FirinYesilResim.fillAmount = zaman;
                if (zaman > 1)
                {
                    Stacking.instance.HamurBırak();
                    zaman = 0;
                    FirinYesilResim.fillAmount = zaman;
                }
            }
        }
        if (other.CompareTag("EkmekAlma"))
        {
            if (Stacking.instance.EkmekCikmaList.Count > 0)
            {
                Stacking.instance.EkmekleriAl();
            }
        }
        if (other.CompareTag("EkmekBirakma"))
        {
            if (Stacking.instance.TepsidekiEkmekler.Count > 0)
            {
                zaman += Time.deltaTime;
                TezgahYesilResim.fillAmount = zaman;
                if (zaman > 1)
                {
                    Stacking.instance.EkmekBirak();
                    zaman = 0;
                    TezgahYesilResim.fillAmount = 0;
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("HamurAlani"))
        {
            inHamurArea = false;
            zaman = 0;
            HamurYesilResim.fillAmount = 0;
        }
        if (other.CompareTag("HamurBirakma"))
        {
            inHamurBirakma = false;
            zaman = 0;
            FirinYesilResim.fillAmount = 0;
        }
        if (other.CompareTag("EkmekAlma"))
        {
            inEkmekAlma = false;
        }
        if (other.CompareTag("EkmekBirakma"))
        {
            inEkmekBirakma = false;
            zaman = 0;
            HamurYesilResim.fillAmount = 0;
        }
    }
    private void Update()
    {
        if (inHamurArea)
        {
            if (!hamurStackFull)
            {
                zaman += Time.deltaTime;
                HamurYesilResim.fillAmount = zaman;
                if (zaman > 1)
                {
                    Stacking.instance.StackHamurObjects();
                    zaman = 0;
                    HamurYesilResim.fillAmount = zaman;
                }
            }

        }
        if (inHamurBirakma)
        {
            if(Stacking.instance.ListHamurObjects.Count > 0)
            {
                zaman += Time.deltaTime;
                FirinYesilResim.fillAmount = zaman;
                if(zaman > 1)
                {
                    Stacking.instance.HamurBırak();
                    zaman = 0;
                    FirinYesilResim.fillAmount = zaman;
                }
            }

        }
        if (inEkmekAlma)
        {
            if(Stacking.instance.EkmekCikmaList.Count > 0)
            {
                Stacking.instance.EkmekleriAl();
            }
        }
        if (inEkmekBirakma)
        {
            if(Stacking.instance.TepsidekiEkmekler.Count > 0)
            {
                zaman += Time.deltaTime;
                TezgahYesilResim.fillAmount = zaman;
                if(zaman > 1)
                {
                    Stacking.instance.EkmekBirak();
                    zaman = 0;
                    TezgahYesilResim.fillAmount = 0;
                }
            }
        }
    }
}
