using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class stackparent : MonoBehaviour
{
    public static stackparent instance;
    
    public List<GameObject> finishcubes = new List<GameObject>();
    [SerializeField] private float distanceBetweenObjects;
    [SerializeField] private Transform prevObject;
    [SerializeField] private GameObject prevGameObject;
    [SerializeField] private Transform parent;
    // public GameObject endPanel;
    // public int count;
    // public Text Score;
    // public GameObject score;
    // public GameObject particle;
    // public GameObject particle1;


    public int childObjectNum;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        distanceBetweenObjects = prevObject.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //public void StackCubeEnd(GameObject other, int index)
    //{
    //    other.transform.parent = transform;
    //    Vector3 newPoss = finishcubes[index].transform.localPosition;
    //    newPoss.y += 1;
    //    other.transform.localPosition = newPoss;
    //    finishcubes.Add(other);

       
    //}

    public void Collect(GameObject collectObject)
    {
        finishcubes.Add(collectObject);

        collectObject.transform.parent = parent;

        Vector3 desPos = prevObject.localPosition;
        desPos.y += distanceBetweenObjects;

        collectObject.transform.localPosition = desPos;
        prevObject = collectObject.transform;
        childObjectNum = finishcubes.Count;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("sphere"))
        {
            
            other.gameObject.GetComponent<Collider>().enabled = false;
            Collect(other.gameObject);
            
            //StartCoroutine(Finishx());
            

                



        }
        if (other.CompareTag("collected"))
        {
            
            other.gameObject.GetComponent<Collider>().enabled = false;
            Collect(other.gameObject);
            
            //StartCoroutine(Finishx());
            
                /*if (ShapeChanger.instance2.cubeB.enabled == true)
            {

                Debug.Log(count);

                count += 5;
                Score.text = "Score:" + count;
                score.SetActive(true);
            }*/
        }

    }
    // IEnumerator Finishx()
    // {
    //     yield return new WaitForSeconds(10f);
       
    //     Time.timeScale = 0;
        
    // }


}