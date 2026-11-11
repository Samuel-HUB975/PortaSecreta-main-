using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public string nomeDoItem = "Coletavel";
    public float velocidadeGiro = 90f;

    void Start()
    {
        transform.Rotate(0, velocidadeGiro * Time.deltaTime, 0); 
    }

    private void OnTriggerEnter(Collider outro)
    {
        Inventario inventario = outro.GetComponent<Inventario>();
        if(inventario != null ) 
        {
            inventario.AdicionarItem(nomeDoItem);
           Destroy(gameObject);
        }
    }   
   
    void Update()
    {
        
    }
}
