using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReactionController : MonoBehaviour
{
    public ChemicalElement elementData1;
    public ChemicalElement elementData2;

    public ChemicalElement resultData;
    public GameObject result;
    public string resultNameGO;

    public Mesh purticleMesh;

    public GameObject[] particles;
    public ParticleScript pscript;
    private float enterTime;
    private float deltaTime;

    // Start is called before the first frame update
    void Start()
    {
        enterTime = Time.time;

        var materials1 = elementData1.visualFlask.materials;
        materials1[1] = elementData1.material;
        elementData1.visualFlask.materials = materials1;
        elementData1.labelText.text = elementData1.name;

        var materials2 = elementData2.visualFlask.materials;
        materials2[1] = elementData2.material;
        elementData2.visualFlask.materials = materials2;
        elementData2.labelText.text = elementData2.name;

        foreach (var particle in elementData1.particles)
        {
            particle.material = elementData1.material;
            particle.mesh = purticleMesh;
        }

        foreach (var particle in elementData2.particles)
        {
            particle.material = elementData2.material;
            particle.mesh = purticleMesh;
        }
    }

    private void Update()
    {
        deltaTime = Time.time - enterTime;

        if (deltaTime > 12.0f)
        {
            this.ChangeResultMaterial();

            pscript.enabled = false;
            foreach (var particle in particles)
            {
                particle.SetActive(false);
            }
        }
    }

    public void ChangeResultMaterial()
    {
        Material[] materials2 = new Material[1];
        materials2[0] = elementData2.visualFlask.materials[0];
        elementData2.visualFlask.materials = materials2;

        var materials1 = elementData1.visualFlask.materials;
        materials1[1] = resultData.material;
        elementData1.visualFlask.materials = materials1;
        elementData1.labelText.text = resultData.name;
        result.name = resultNameGO;

        pscript.enabled = false;
        foreach (var particle in particles)
        {
            particle.SetActive(false);
        }
    }

    [System.Serializable]
    public struct ChemicalElement
    {
        public string name;
        public Material material;
        public MeshRenderer visualFlask;
        public ParticleSystemRenderer[] particles;
        public Text labelText;
    }
}
