using UnityEngine;
using UnityEngine.Rendering;

public class ParticleController : MonoBehaviour
{
    [SerializeField] private int numPar;
    [SerializeField] private float GparSpeed;
    [SerializeField] private float Gangle;
    [SerializeField] private float Gtime;
    [SerializeField] private float Ggravedad;
    [SerializeField] public GameObject Particle;
    [SerializeField] private GameObject[] particleArray;
    [SerializeField] private Particle[] particleScriptArray;
    float timer;

    void Start()
    {     
            CreateParticleExplotion();
    }

    void CreateParticleExplotion()
    {
        particleArray = new GameObject[numPar];
        particleScriptArray = new Particle[numPar];

        for (int i = 0; i < numPar; i++)
        {
            GameObject par = Instantiate(Particle, transform.position, Quaternion.identity);
            particleArray[i] = par;         
            particleScriptArray[i] = particleArray[i].GetComponent<Particle>();
            Particle parScript = par.GetComponent<Particle>();
            parScript.velIn = GparSpeed * Random.Range(1,4);
            parScript.angIn = Gangle * Random.Range(20, 60);
            parScript.tiempoMax = Gtime ;
            parScript.gravedad = Ggravedad * Random.Range(1, 3);
            if (timer == Gtime)
            {
                               Destroy(par);
            }
        }
    }

    void UpdateParticlePosition(Particle[] particle, float time)
    {
        for (int i = 0; i < numPar; i++)
        {
            float angleRad = particle[i].angIn * Mathf.Deg2Rad ;
            float x = particle[i].velIn * Mathf.Cos(angleRad) * time ;
            float y = particle[i].velIn * Mathf.Sin(angleRad) * time - 0.5f * particle[i].gravedad * time * time ;
            particle[i].transform.position = new Vector3(x, y, 0);
        }
           
    }

    void Update()
    {
        timer = timer + Time.deltaTime;
        UpdateParticlePosition(particleScriptArray, timer);
    }
}
