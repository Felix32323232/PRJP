using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class ParticleController : MonoBehaviour
{
    [SerializeField] private int numPar;
    [SerializeField] private float GparSpeed;
    [SerializeField] private float Gangle;
    [SerializeField] private float Gtime;
    [SerializeField] private float Ggravedad;
    [SerializeField] public GameObject Particle;

    public void OnInteract(InputAction.CallbackContext context)
    {
       if (context.started)
        {
            CreateParticle();
        }

       
        
    }


    void Update()
    {
        
    }

    void CreateParticle()
    {
        for (int i = 0; i < numPar; i++)
        {
            GameObject par = Instantiate(Particle, transform.position, Quaternion.identity);
            Particle parScript = par.GetComponent<Particle>();
            parScript.velIn = GparSpeed * Random.Range(1, 3);
            parScript.angIn = Gangle * Random.Range(20, 60);
            parScript.angInZ = Random.Range(0, 361);
            parScript.tiempoMax = Gtime;
            parScript.gravedad = Ggravedad * Random.Range(1, 3);
        }
           
    }

 
}
