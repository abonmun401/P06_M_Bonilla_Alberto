using UnityEngine;

public class Items : MonoBehaviour
{
     int contador = 10;
    public GameObject Puerta;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         Puerta.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)){
            Application.Quit();
        }
    }
     void OnTriggerEnter(Collider other){
        if (other.CompareTag("Key")){
            Destroy(other.gameObject);
            contador --;
        }

        if (contador == 0){
            Puerta.SetActive (false);
            
        }

       
     }
}
