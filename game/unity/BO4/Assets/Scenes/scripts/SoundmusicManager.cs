using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundmusicManager : MonoBehaviour
{
    public List<AudioSource> AudioItems;
    public List<float> timing1; 
    public List<float> timing2;
    public deSanityBar bar;
    public int need;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bar.slidei.value >= timing1[need] && bar.slidei.value <= timing2[need])
        {
            print("dit is een fout");
            if (AudioItems[need].isPlaying == false)
            {
                AudioItems[need].Play();
            }
        }
        else
        {
            AudioItems[need].Stop();
            if (need != AudioItems.Capacity - 1)
            {
                need += 1;
            }
            
        }
    }
}
